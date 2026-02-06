namespace Code_jeu_1
{
    class Combat
    {
        public static void LancerCombat(
            Personnage joueur1,
            Personnage joueur2,
            Personnage joueur3,
            Arme Marteau,
            Random rand)
        {
            int tour = 0;
            int potion = 2;
            int soin = 2;
            while (joueur1.Vie > 0 && (joueur2.Vie > 0 || joueur3.Vie > 0))
            {
                int aleatoire = rand.Next(0, 100);

                if (joueur1.Attaque != Marteau.Attaque && tour == 0)

                    Console.WriteLine("\n=== Votre tour ===\n");
                Console.WriteLine($"1 - Attaquer ({joueur1.Attaque} dégâts)");
                if (soin > 0)
                    Console.WriteLine($"2 - Se soigner +80 HP [{soin}]");
                if (potion > 0)
                    Console.WriteLine($"3 - Potion de faiblesse (-20 DMG) [{potion}]");

                int choix = int.Parse(Console.ReadLine());

                //ATTAQUE
                if (choix == 1)
                {
                    Program.wait("Choisis ta cible\n");

                    if (joueur2.Vie > 0)
                        Console.WriteLine($"1 - {joueur2.Nom} {joueur2.Vie} HP");

                    if (joueur3.Vie > 0)
                        Console.WriteLine($"2 - {joueur3.Nom} {joueur3.Vie} HP");

                    int cible = int.Parse(Console.ReadLine());

                     if(cible == 1)
                    {
                        joueur1.Attaquer(joueur2);
                        Program.wait($"Vous avez infligez {joueur1.Attaque} DMG");
                        if (joueur2.Vie <= 0)
                            Console.WriteLine("\nLe Gobelin est mort");
                    }
                    if (cible == 2)
                    {
                        joueur1.Attaquer(joueur3);
                        Program.wait($"Vous avez infligez {joueur1.Attaque} DMG");
                        if (joueur3.Vie <= 0)
                            Console.WriteLine("\nLe Squellette est mort");
                    }

                }

                else if (choix == 2)
                {
                    joueur1.Soin();
                    Console.WriteLine($"Vous avez maintenant {joueur1.Vie} HP");
                    soin--;
                }

                else if (choix == 3 && potion > 0)
                {
                    Console.WriteLine("1 - Gobelin");
                    Console.WriteLine("2 - Squelette");
                    int cible = int.Parse(Console.ReadLine());

                    if (cible == 1) joueur1.Potion_Faiblesse(joueur2);
                    if (cible == 2) joueur1.Potion_Faiblesse(joueur3);

                    potion--;
                }

                if (joueur2.Vie > 0)
                {
                    Console.WriteLine("\n=== Tour du Gobelin ===\n");
                    joueur2.Attaquer(joueur1);
                    Console.WriteLine($"{joueur2.Nom} attaque de {joueur2.Attaque} DMG");
                    Console.WriteLine($"Il vous reste {joueur1.Vie} HP");
                    Thread.Sleep(800);
                }

                if (joueur3.Vie > 0)
                {
                    Console.WriteLine("\n=== Tour du Squelette ===\n");
                    joueur3.Attaquer(joueur1);
                    Console.WriteLine($"{joueur3.Nom} attaque de {joueur3.Attaque} DMG");
                    Console.WriteLine($"Il vous reste {joueur1.Vie} HP\n\n");
                    Thread.Sleep(800);
                }

                tour++;
            }
        }
    }
}
