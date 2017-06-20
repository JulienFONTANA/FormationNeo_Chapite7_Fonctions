using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationNeo_Chapite7_Fonctions_Exo1
{
    class Exo1Ch7
    {
        static void Main(string[] args)
        {
            /* Avant tout il faut répondre à la question "Pourquoi faire une fonction?"
             * 
             * La première partie de ces exercices seront des fonctions sans retours
             * Le but est ici de comprendre comment on peut se simplifier la vie avec
             * les fonctions!
             * 
             * Cet exercice vous demandde d'utiliser des fonctions, mais pas encore d'en écrire
            */

            // Ecrivons les tables de multiplications
            // Ecrire la table des '1' et des '2' en utilisant le modèle fourni
            Console.WriteLine(Environment.NewLine + "Table des 1:");
            Console.WriteLine("1 * 1 = " + 1 * 1);
            Console.WriteLine("1 * 2 = " + 1 * 2);
            Console.WriteLine("1 * 3 = " + 1 * 3);
            Console.WriteLine("1 * 4 = " + 1 * 4);
            Console.WriteLine("1 * 5 = " + 1 * 5);
            Console.WriteLine("1 * 6 = " + 1 * 6);
            Console.WriteLine("1 * 7 = " + 1 * 7);
            Console.WriteLine("1 * 8 = " + 1 * 8);
            Console.WriteLine("1 * 9 = " + 1 * 9);
            Console.WriteLine("1 * 10 = " + 1 * 10);

            Console.WriteLine(Environment.NewLine + "Table des 2:");
            // Votre code ici



            // Laborieux, n'est-ce pas?
            // Simplifiez vous la tache avec une boucle pour la table des 3!
            Console.WriteLine(Environment.NewLine + "Table des 3:");






            // Pourtant ce n'est toujours pas pratique. Imaginez devoir faire ça pour les tables
            // des 4, des 5, des 6, des 7... Ou pour la tables des 140! Pas pratique...
            // Heureusement une fonction "TableMultiplication" est fournie en bas de ce fichier
            // Son prototype est le suivant: static void TableMultiplication(int a)
            // Cette fonction affiche une table de multiplication
            // Ecrivez donc la tables des 4, 5, 6, et 7 en quatres lignes!






            // Il est devenu bien plus facile d'écrire une table de multiplication n'est-ce-pas?
            // Observez qu'il est possible de reprendre notre boucle (utilisée lors de la création 
            // de la table des 3) et de l'inclure dans une fonction pour gagner encore plus de temps!
            // Utiliser la fonction "TableMultiplicationBoucle" pour la table des 8


            // Cette fonction permet à notre code d'être modulaire. Si on veut afficher la
            // tables des 9, 10 ou 24, on peut, et si on veux afficher la table jusqu'à 12
            // ou 15 et non plus jusqu'à 10, une simple modification dans le code de la fonction
            // modifiera l'intégralité du comportement de ce programme!!!
            // Il est possible d'utilisez une fonction dans une boucle aussi!
            // utilisez une boucle pour  afficher les tables de multiplication de 9 à 12!
            // Ne faites qu'un seul appel à la fonction de Multiplication de votre choix






            // Reflexion (ne codez pas):
            // Comment est il possible de simplifier tout cet exercice en quelques lignes?
            // C'est à dire comment afficher les tables de multiplication de 1 à 12 en
            // un minimum de lignes 
        }

        static void TableMultiplication(int a)
        {
            Console.WriteLine(Environment.NewLine + "Table des " + a + ":");
            Console.WriteLine(a + " * 1 = " + a * 1);
            Console.WriteLine(a + " * 2 = " + a * 2);
            Console.WriteLine(a + " * 3 = " + a * 3);
            Console.WriteLine(a + " * 4 = " + a * 4);
            Console.WriteLine(a + " * 5 = " + a * 5);
            Console.WriteLine(a + " * 6 = " + a * 6);
            Console.WriteLine(a + " * 7 = " + a * 7);
            Console.WriteLine(a + " * 8 = " + a * 8);
            Console.WriteLine(a + " * 9 = " + a * 9);
            Console.WriteLine(a + " * 10 = " + a * 10);
        }

        static void TableMultiplicationBoucle(int a)
        {
            Console.WriteLine(Environment.NewLine + "Table des " + a + ":");
            for (int index = 1; index <= 10; index++)
            {
                Console.WriteLine(a + " * " + index + " = " + a * index);
            }
        }
    }
}
