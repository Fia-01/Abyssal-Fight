using Code_jeu_1;
using System;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace Code_jeu_1
{
    public class Personnage
    {
        public string Nom;
        public int Vie;
        public int Attaque;
        public int Defence;
        public int Effet;

        public void Attaquer(Personnage cible)
        {
            cible.Vie -= this.Attaque;
        }

        public void Sang(Personnage cible)
        {
            for (int i = 0; i < cible.Effet; i++)
            {
                cible.Vie -= 5;
            }
        }

        public void Soin()
        {
            Vie += 105;
        }

        public void Potion_Faiblesse(Personnage cible)
        {
            cible.Attaque -= 20;
        }

        public void Contre(Personnage cible)
        {
            cible.Attaque -= cible.Attaque;
        }
    }

    public class Arme
    {
        public string Nom;
        public int Attaque;
        public int VitesseAttaque;
        public int Competence;
    }

    public class Armure
    {
        public string Nom;
        public int Vie;
        public int Defence;
    }
}
