using Code_jeu_1; 
using System;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace Code_jeu_1
{
    public partial class Form1 : Form
    {   //INI PERSO
        Personnage joueur1 = new Personnage { Nom = "heros", Vie = 0, Attaque = 0 };
        Personnage joueur2 = new Personnage { Nom = "Gobelin", Vie = 350, Attaque = 80 };
        Personnage joueur3 = new Personnage { Nom = "Squelette", Vie = 300, Attaque = 50 };

        Image herosAttaque = Properties.Resources.herosAttaque;
        Image herosNormal = Properties.Resources.heros;

        Image achilleAttaque = Properties.Resources.achilleAttaque;
        Image achilleNormal = Properties.Resources.achille;

        Image imgNormale = Properties.Resources.gobelin;
        Image imgHover = Properties.Resources.GobelinHover;
        Image GobelinAttaque = Properties.Resources.GobelinAttaque;

        Image imgHoverSquell = Properties.Resources.squelletteHover;
        Image imgSquell = Properties.Resources.squellette;
        Image SquellAttaque = Properties.Resources.SquelletteAttaque;


        bool TourJoueur = true; // defaut : joueur qui commence
        int potion = 3;
        int potionFaiblesse = 1;
        public Form1()
        {
            InitializeComponent();
            //HEROS
            VieHeros.Style = ProgressBarStyle.Continuous;
            VieHeros.ForeColor = Color.Green; // Couleur de la barre
            VieHeros.BackColor = Color.Black; // Couleur du fond
            //GOBELIN
            VieGobelin.Style = ProgressBarStyle.Continuous;
            VieGobelin.ForeColor = Color.Red; // Couleur de la barre
            VieGobelin.BackColor = Color.Black; // Couleur du fond
            //SQUELLETTE
            VieSquellette.Style = ProgressBarStyle.Continuous;
            VieSquellette.ForeColor = Color.Red; // Couleur de la barre
            VieSquellette.BackColor = Color.Black; // Couleur du fond
            this.DoubleBuffered = true;
        }

        //CHOIX HEROS
        private void btnHeros_Click(object sender, EventArgs e)
        {
            // On définit les stats du Héros
            joueur1.Nom = "Héros";
            joueur1.Vie += 360;
            joueur1.Attaque += 50;
            HideHeros();
            ActuLabel();
        }
        private void btnAchille_Click(object sender, EventArgs e)
        {
            joueur1.Nom = "Achille";
            joueur1.Vie += 280;
            joueur1.Attaque += 70;
            HideHeros();
            ActuLabel();
        }

        //CHOIX ARMURE
        private void btnArmureDemon_Click(object sender, EventArgs e)
        {
            joueur1.Attaque += 10;
            joueur2.Attaque -= 5;
            joueur3.Attaque -= 5;
            joueur1.Defence = 5;
            HideArmure();
            ActuLabel();
        }

        private void btnArmurePaladin_Click(object sender, EventArgs e)
        {
            joueur2.Attaque -= 15;
            joueur3.Attaque -= 15;
            joueur1.Defence = 15;
            HideArmure();
            ActuLabel();
        }

        //CHOIX ARME
        private void btnEpee_Click(object sender, EventArgs e)
        {
            joueur1.Attaque += 20;
            potion += 1;
            ActuLabel();
            DemarrerCombat();
        }
        private void btnMace_Click(object sender, EventArgs e)
        {
            joueur1.Attaque += 30;
            ActuLabel();
            DemarrerCombat();
        }
        private void btnMarteau_Click(object sender, EventArgs e)
        {
            joueur1.Attaque += 40;
            joueur1.Vie -= 20;
            ActuLabel();
            DemarrerCombat();
        }
        //
        //
        private async void PicGobelin_Click(object sender, EventArgs e)
        {
            if (!TourJoueur) return;
            TourJoueur = false;
            joueur1.Attaquer(joueur2);
            AnimationHeros();
            await FlashImage(PicGobelin);
            await ShowDMG1();
            ActuVie();
            HideMonstre();
            TourMonstres();
        }

        private async void PicSquellette_Click(object sender, EventArgs e)
        {
            if (!TourJoueur) return;
            TourJoueur = false;
            joueur1.Attaquer(joueur3);
            AnimationHeros();
            await FlashImage(PicSquellette);
            await ShowDMG2();
            ActuVie();
            HideMonstre();
            TourMonstres();
        }

        private async void btnSoins_Click(object sender, EventArgs e)
        {
            if (!TourJoueur) return;
            if (potion > 0)
            {
                VieHeros.Maximum += 105;
                joueur1.Soin();
                TourJoueur = false;
                ActuVie();
                LabelDegats1.Visible = true;
                LabelDegats1.ForeColor = Color.Green;
                LabelDegats1.Text = ("+105 HP");

                await Task.Delay(800);
                LabelDegats1.Visible = false;
                LabelDegats1.ForeColor = Color.Red;
                potion -= 1;
                btnSoins.Text = ($"Soins (+105HP) [ {potion} soins ]");

                TourMonstres();
            }
            if (potion == 0)
                btnSoins.BackColor = Color.Gray;
        }

        private async void btnFaiblesse_Click(object sender, EventArgs e)
        {
            if (!TourJoueur) return;
            if (potionFaiblesse > 0)
            {
                joueur1.Potion_Faiblesse(joueur2);
                TourJoueur = false;
                PicGobelin.Image = imgHover;

                LabelDegats2.Visible = true;
                LabelDegats2.ForeColor = Color.Black;
                LabelDegats2.Text = ("-20 TOTAL DMG");potionFaiblesse -= 1;
                btnFaiblesse.Text = ($"Potion Faiblesse (-20 MDG) [{potionFaiblesse} potion]");

                await Task.Delay(800);
                PicGobelin.Image = imgNormale;
                
                await Task.Delay(1200);
                LabelDegats2.Visible = false;
                LabelDegats2.ForeColor = Color.Red;

                TourMonstres();


            }
        }

        private void PicGobelin_MouseEnter(object sender, EventArgs e)
        {
            if (!TourJoueur) return;
            PicGobelin.Image = imgHover;
        }

        private void PicGobelin_MouseLeave(object sender, EventArgs e)
        {
            PicGobelin.Image = imgNormale;
        }
        private void PicSquellette_MouseEnter(object sender, EventArgs e)
        {
            if (!TourJoueur) return;
            PicSquellette.Image = imgHoverSquell;
        }
        private void PicSquellette_MouseLeave(object sender, EventArgs e)
        {
            PicSquellette.Image = imgSquell;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            HideRound();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            joueur1.Attaque = 100000;
        }

        private void btnModeFacile_Click(object sender, EventArgs e)
        {
            joueur2.Vie -= 100;
            joueur2.Attaque -= 20;

            joueur3.Vie -= 80;
            joueur3.Attaque -= 10;

            MessageBox.Show("Mode facile activé (Tu es vraiment nul)");
            HideRound();

        }
    }
}
