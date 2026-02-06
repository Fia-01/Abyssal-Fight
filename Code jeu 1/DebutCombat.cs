namespace Code_jeu_1

{
    public class DebutCombat
    {
        public static void Lancer(Personnage joueur1, Personnage joueur2,Personnage joueur3, Arme sword, Arme mace, Arme Marteau)
        {
            Program.wait("===== Choisir votre Perso =====");
            Console.WriteLine("1 - Achille ( 120 HP , +10 DEG )");
            Console.WriteLine("2 - Heros ( 170HP -10 DEG ) \n");
            int perso = int.Parse(Console.ReadLine());

            if (perso == 1)
            {
                Program.wait("Vous avez choisi 'Achille'");
                joueur1.Vie += 120;
                joueur1.Attaque += 10;
                joueur1.Nom = "Achille";
            }
            else if (perso == 2)
            {
                Program.wait("Vous avez choisi 'Heros'");
                joueur1.Vie += 170;
                joueur1.Attaque -= 10;
            }

            //CHOIX ARMURE
            Program.wait("===== Choisir votre armure =====");
            Console.WriteLine("1 - Armure Paladin ( 30 def , 150 HP )");
            Console.WriteLine("2 - Armure Demon ( 10 def 200 HP ) \n");

            int armure = int.Parse(Console.ReadLine());

            if (armure == 1)
            {
                joueur1.Vie += 150;
                joueur1.Defence += 30;
                Program.wait("Vous avez équipée - Armure Paladin -\n");
            }
            else if (armure == 2)
            {
                joueur1.Vie += 200;
                joueur1.Defence += 10;
                Program.wait("Vous avez équipée - Armure Demon -\n");
            }

            //CHOIX ARME
            Program.wait("===== Choisir l'arme =====");
            Console.WriteLine("1 - Épée ( 40 dégâts)");
            Console.WriteLine("2 - Mace ( 60 dégâts)");
            Console.WriteLine("3 - Marteau ( 80 dégâts mais le Gobelin attaque en premier )");


            int arme = int.Parse(Console.ReadLine());

            if (arme == 1)
            {
                joueur1.Attaque += sword.Attaque;
                Program.wait("Vous avez équipée - Epée -");
            }

            else if (arme == 2)
            {
                joueur1.Attaque += mace.Attaque;
                Program.wait("Vous avez équipée - Mace -");
            }

            else if (arme == 3)
            {
                joueur1.Attaque += Marteau.Attaque;
                Program.wait("Vous avez équipée - Marteau -");
                Console.WriteLine("");
                Program.wait("\n--- Malus du marteau ---");
                joueur2.Attaquer(joueur1);
                Console.WriteLine("Le Gobelin attaque de 40DMG ");
                Console.WriteLine("Il vous reste " + joueur1.Vie + " HP");
                Thread.Sleep(500);
            }

            Program.wait("\n== ROUND 1 ===\n");
            Program.wait("Gobelin 150HP 40DMG");
            Program.wait("Squellette 120HP 60DMG\n");
            Thread.Sleep(500);

            Program.wait($"{joueur1.Nom} entre en combat avec {joueur1.Vie} HP ");  
            Thread.Sleep(500);

            Console.WriteLine("\n============================");
            Console.WriteLine("      DEBUT DU COMBAT");
            Console.WriteLine("============================\n");
        }

    }
}
