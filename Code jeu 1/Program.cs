using System;
using System.Windows.Forms;

namespace Code_jeu_1
{
    public class Program    
    {
        //wait sert a rien en WinForms mais jlaisse belek
        public static void wait(string texte)
        {
            foreach (char lettre in texte)
            {
                Console.Write(lettre);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }

        [STAThread] // POUR TOUT GERER DANS UNE SEULE PAGE ET EVITER LES CRASH
        public static void Main(string[] args)
        {
            //Initialisation de la configuration Windows
            //Application.EnableVisualStyles(); //POUR LE STYLE MODERN
            Application.SetCompatibleTextRenderingDefault(true);//POUR LA NETETER DU TEXTE
            Application.Run(new Form1());//crée Form1 et bloque dessus, ne lis rien tant que form1 est pas fermé
        }
    }
}