    namespace Code_jeu_1
    {
        class FinCombat
        {
            public static void AfficherResultat(Personnage joueur)
            {
                Console.WriteLine("\n============================");
                if (joueur.Vie <= 0)
                    Console.WriteLine("        VOUS AVEZ PERDU");
                else
                    Console.WriteLine("        VOUS AVEZ GAGNE");
                Console.WriteLine("============================");
            }
        }
    }
