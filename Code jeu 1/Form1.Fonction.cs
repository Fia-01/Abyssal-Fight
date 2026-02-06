using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_jeu_1
{
    // Important : il faut garder "partial" et le même nom "Form1"
    public partial class Form1
    {
        public void ActuVie()
        {
            // valeur pas sous 0 sinon plantage
            if (joueur1.Vie >= 0)
            {
                VieHeros.Value = joueur1.Vie;
                HPHeros.Text = $"HP :{joueur1.Vie} / {VieHeros.Maximum}";
            }
            else
                VieHeros.Value = 0;

            // Barre du Gobelin
            if (joueur2.Vie >= 0) 
            { 
                HPGobelin.Text = $"HP :{joueur2.Vie} / {VieGobelin.Maximum}";
                VieGobelin.Value = joueur2.Vie;
            }
            else { 
                VieGobelin.Value = 0;
                 }
            if (joueur3.Vie >= 0)
            { 
            HPSquellette.Text = $"HP :{joueur3.Vie} / {VieSquellette.Maximum}";
            VieSquellette.Value = joueur3.Vie;
            }
            else { 
                VieSquellette.Value = 0;
                 }
        }

        public void ActuLabel()
        {
            labelActu.Text = ($"Actuellement : \nHP : {joueur1.Vie} \nDEF : {joueur1.Defence}\nDMG : {joueur1.Attaque}");

        }
        public async void TourMonstres()
        {
            LabelTour.ForeColor = Color.DarkRed;
            LabelTour.Text = "Tours Des Monstres !";
            await Task.Delay(800);
            if (joueur2.Vie > 0)
            {
                PicGobelin.Image = GobelinAttaque;
                joueur2.Attaquer(joueur1);
                if(joueur1.Nom == "Achille")
                    await FlashImage(PicAchille);
                else
                    await FlashImage(PicHeros);
                LabelDegats1.Visible = true;
                LabelDegats1.Text = ($"- {joueur2.Attaque}HP");
                await Task.Delay(500);
                LabelDegats1.Visible = false;
                ActuVie();
                await Task.Delay(500);
                PicGobelin.Image = imgNormale;
            }
            await Task.Delay(600);
            if (joueur3.Vie > 0)
            {
                PicSquellette.Image = SquellAttaque;
                joueur3.Attaquer(joueur1);
                if (joueur1.Nom == "Achille")
                    await FlashImage(PicAchille);
                else{ 
                    await FlashImage(PicHeros);}
                LabelDegats1.Visible = true;
                LabelDegats1.Text = $"- {joueur3.Attaque}HP";
                await Task.Delay(500);
                LabelDegats1.Visible = false;
                ActuVie();
                await Task.Delay(500);
                PicSquellette.Image = imgSquell;
            }
            LabelTour.Text = "Tours du Héros !";
                LabelTour.ForeColor = Color.Blue;
            
            if(joueur1.Vie <= 0)
            {
                PicAchille.Visible = false;
                PicHeros.Visible = false;
                HPHeros.Visible = false;
                VieHeros.Visible = false;
                btnSoins.Visible = false;
                btnFaiblesse.Visible = false;
                MessageBox.Show("Vous avez perdu !");
            }
            TourJoueur = true;
        }
        private async Task FlashImage(PictureBox pic)
        {
            for (int i = 0; i < 2; i++)
            {
                pic.Visible = false;
                await Task.Delay(50);
                pic.Visible = true;
                await Task.Delay(50);
            }
        }

        private async void AnimationHeros()
        {
            if (joueur1.Nom == "Achille")
            {
                PicAchille.Image = achilleAttaque;
                await Task.Delay(700);
                PicAchille.Image = achilleNormal;
            }
            else
            {
                PicHeros.Image = herosAttaque;
                await Task.Delay(700);
                PicHeros.Image = herosNormal;
            }
        }
        private async Task ShowDMG1()
        {
            LabelDegats2.Visible = true;
            LabelDegats2.Text = ($"- {joueur1.Attaque}HP");
            await Task.Delay(500);
            LabelDegats2.Visible = false;
        }
        private async Task ShowDMG2()
        {
            LabelDegats3.Visible = true;
            LabelDegats3.Text = ($"- {joueur1.Attaque}HP");
            await Task.Delay(500);
            LabelDegats3.Visible = false;
        }
        public void HideHeros()
        {
            btnAchille.Visible = false;
            btnHeros.Visible = false;
            btnArmureDemon.Visible = true;
            btnArmurePaladin.Visible = true;
            ChoixPerso.Visible = false;
            ChoixArmure.Visible = true;
        }
        public void HideArmure()
        {
            btnArmureDemon.Visible = false;
            btnArmurePaladin.Visible = false;
            ChoixArmure.Visible = false;
            btnEpee.Visible = true;
            btnMace.Visible = true;
            btnMarteau.Visible = true;
            ChoixArme.Visible = true;
        }
        public void HideRound()
        {
            SquellettePresentation.Visible = false;
            GobelinPresentation.Visible = false;
            labelRound.Visible = false;
            btnStart.Visible = false;
            labelGobelinInfo.Visible = false;
            labelInfoSquellette.Visible = false;
            btnModeFacile.Visible = false;

            labelActu.Visible = true;
            ChoixPerso.Visible = true;
            btnAchille.Visible= true;
            btnHeros.Visible= true;
        }
        public void HideMonstre()
        {
            if (joueur2.Vie < 0)
                joueur2.Vie = 0;

            if (joueur2.Vie == 0)
            {
                PicGobelin.Visible = false;
                VieGobelin.Visible = false;
                HPGobelin.Visible = false;
            }

            if(joueur3.Vie < 0)
                joueur3.Vie = 0;

            if (joueur3.Vie == 0)
            { 
                PicSquellette.Visible = false;
                HPSquellette.Visible = false;
                VieSquellette.Visible = false;
            }
            if(joueur3.Vie == 0 && joueur2.Vie == 0)
            {
                MessageBox.Show("Vous avez Gagnez !");
            }

        }
        public async void DemarrerCombat()
        {
            MessageBox.Show($"Vous entre en combat avec\n HP:{joueur1.Vie} \nDMG : {joueur1.Attaque} \nPotion Soins : {potion}");
            labelActu.Visible = false;
            btnEpee.Visible = false;
            btnMace.Visible = false;
            btnMarteau.Visible = false;
            ChoixArme.Visible = false;
            TitreRound.Visible = true;
            btnSoins.Text = ($"Soins (+105HP) [ {potion} soins ]");
            await Task.Delay(200);
            //TEXTE AUTRE
            LabelTour.Visible = true;
            //HEROS
            HPHeros.Visible = true;
            if (joueur1.Nom == "Achille")
            {
                PicAchille.Visible = true;
            }
            else
            {
                PicHeros.Visible = true;
            }
            VieHeros.Visible = true;
            VieHeros.Maximum = joueur1.Vie;
            VieHeros.Value = joueur1.Vie;
            btnFaiblesse.Visible = true;
            btnSoins.Visible = true;

            await Task.Delay(200);
            //GOBELIN
            HPGobelin.Visible = true;
            VieGobelin.Visible = true;
            PicGobelin.Visible = true;
            VieGobelin.Maximum = joueur2.Vie;
            VieGobelin.Value = joueur2.Vie;

            //SQUELLETTE
            HPSquellette.Visible = true;
            VieSquellette.Visible = true;
            PicSquellette.Visible = true;
            VieSquellette.Maximum = joueur3.Vie;
            VieSquellette.Value = joueur3.Vie;
            ActuVie();        }
    }
}