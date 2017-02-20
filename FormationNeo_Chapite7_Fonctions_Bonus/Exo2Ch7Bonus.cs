using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Il est temps de créer un système de localisation pour les héros.
 * L'idée est de localiser un héros ou qu'il soit, sur terre ou dans la mer!
*/

namespace FormationNeo_Chapite7_Fonctions_Bonus
{
    class Exo2Ch7Bonus
    {
        static void Main(string[] args)
        {
            // Solution au Bonus de l'exercice 2 du chapitre 7
            //
            // Bonus : Modifier le code pour créer une grille de 100 par 100 (et modifier les
            // co-ordonnées iniiales en conséquences), puis rajouter des indices pour aider
            // l'utilisateur!
            //
            // Le but ici est d'observer l'efficacité des fonctions!
            // Par exemple, l'ajout d'indices est très simple grâce à la fonction Radar,
            // utilisée à plusieurs reprises et qui évite l'écriture de trop de code!

            var rnd = new Random();
            int heroCoordX = rnd.Next(0, 99); // nombre aléatoire entre 0 et 99
            int heroCoordY = rnd.Next(0, 99);

            // Ligne pour tester les co-ordonnées
            //Console.WriteLine("Debug en (" + heroCoordX + ", " + heroCoordY + ")");

            int userCoordX = 0;
            int userCoordY = 0;
            bool enRecherche = true;

            Console.WriteLine("En recherche d'un héro... [LOADING]...");
            while (enRecherche)
            {
                Console.WriteLine('\n' + "Coordonnée en X: ");
                int.TryParse(Console.ReadLine(), out userCoordX);
                Console.WriteLine("Coordonnée en Y: ");
                int.TryParse(Console.ReadLine(), out userCoordY);

                Console.WriteLine("Recherche en (" + userCoordX + ", " + userCoordY + ")");

                if ((userCoordX == heroCoordX) && (userCoordY == heroCoordY)) // Coordonnées exactes
                {
                    enRecherche = false; // On arrète la recherche, on a trouvé
                    Console.WriteLine('\n' + "Héro correctement localisé.");
                }
                else
                {
                    // Tests sur la première valeur (X)
                    TestXCoord(userCoordX, heroCoordX);

                    // Tests sur la seconde valeur (Y)
                    TestYCoord(userCoordY, heroCoordY);
                }
            }
        }

        static void TestXCoord(int userX, int heroX)
        {
            if (userX == heroX)
                Console.WriteLine("Coordonnée Nord-Sud correcte");
            else if (userX > heroX)
            {
                Console.Write("Plus au Nord! ");
                Radar(userX, heroX); // Valeur la plus grande en premier
            }
            else // (userX < heroX)
            {
                Console.Write("Plus au Sud! ");
                Radar(heroX, userX); // Valeur la plus grande en premier
            }
        }

        static void TestYCoord(int userY, int heroY)
        {
            if (userY == heroY)
                Console.WriteLine("Coordonnée Est-Ouest correcte");
            else if (userY > heroY)
            {
                Console.Write("Plus a l'Est! ");
                Radar(userY, heroY); // Valeur la plus grande en premier
            }
            else // (userY < heroY)
            {
                Console.Write("Plus a l'Ouest! ");
                Radar(heroY, userY); // Valeur la plus grande en premier
            }
        }

        static void Radar(int val1, int val2)
        {
            int ecart = val1 - val2; // valeur positive comprise entre 0 (valeurs identiques) et 99
            if (ecart > 30)
            {
                Console.WriteLine("Le héro est sur un autre continent!");
            }
            else if (10 < ecart && ecart <= 30)
            {
                Console.WriteLine("Le héro est dans un autre pays!");
            }
            else
            {
                Console.WriteLine("Le héro est proche!");
            }
        }
    }
}
