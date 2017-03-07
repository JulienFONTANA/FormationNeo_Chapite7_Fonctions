
/* Bonjour dans le troisième tutoriel de la formation Néo!
 * Les variables n'ont plus aucun secret pour vous?
 * Les structures de controles sont devenu une seconde nature? Très bien!
 * 
 * Si les variables sont les briques élémentaires d'un programme, et si les
 * boucles et tests conditionnels permettent d'effectuer des traitement sur celles-çi,
 * nous restons quand même limité. Que faire si je doit incrémenter puis décrémenter 
 * une variable 100 fois? Que faire pour rendre mon code lisible? Comment gagner
 * du temps pour éviter de réécrire encore et toujours le même bout de code?
 * 
 * Il est temps de voir les fonctions... Et c'est un gros morceau!!!
 * 
*/

using System;

namespace FormationNeo_Chapite7_Fonctions
{
    class Program
    {
        /* Nous allons découvrir ensemble les fonctions, en commençant par la plus importante, le "Main"
         * C'est le point d'entrée de tout vos programmes. Prennons le temps de l'observer ensemble:
         * 
         *          static void Main(string[] args)
         *          
         * static           : Ne vous en occupez pas, c'est... compliqué. Nous verrons pourquoi il est la au chapitre 8!
         * void             : C'est un type de variable qui ne contient rien. Il sert juste à préciser que la fonction n'as pas de retour
         * Main             : C'est le nom de la fonction, il doit être unique. N'appellez pas une de vos fonction Main!
         * (string[] args)  : Ce sont les paramètres de la fonction Main. Nous verrons les paramètres dans ce cours!
         * 
         * Ceci est le "prototype" de la fonction Main, c'est à dire son type de retour, son nom, ces paramètres, mais pas son contenu.
         * Le contenu d'une fonction est son "corps". Jusqu'à présent, nous ne travaillons que dans le corps de la fonction Main.
         * 
         * Et c'est tout ce qu'il faut savoir pour le Main! Mais ce qui nous intéresse, c'est de pouvoir écrire nos propres fonction!
         * Allons-y!
        */
        static void Main(string[] args)
        {
            /* Nous allons commencer par des fonctions qui écrivent "Bonjour ..." à l'écran.
             * Ou se situe le code de ces fonctions? Tout en bas de ce tutorial, sous la fonction Main
             * Pour y accéder facilement, cliquer sur la petite case - à gauche de la fonction Main
             * 
             * Une autre solution est de cliquer sur le nom de la fonction qui vous intéresse, et
             * de presser la touche F12 pour en atteindre la définition... A vous de voir!
            */

            // 1 - Fonction sans paramètres et sans retour
            //     Notez les parentèses à la fin de la fonction, juste appelée par son nom
            //     Le programme "s'arrète" ici, et ne va pas lire plus bas, mais execute
            //     à la place ce qui se trouve dans la fonction "Bonjour()"
            Bonjour();

            // 2 - Fonction avec un paramètre
            //     Passez votre souris sur le nom de la fonction.
            //     Vous devriez lire ceci : "void Program.DireBonjour(string nom)"
            //     C'est le prototype de la fonction DireBonjour! On voit que cette fonction ne
            //     retourne rien mais nécessite un string pour fonctionner correctement
            //     Passez un type de donnée incorrect, et le ompilateur vous le ferra savoir!
            string nom = "Frank";
            DireBonjour(nom);

            // 3 - Cette fonction ressemble à la première, mais prends en compte un paramètre!
            //     De plus, elle se comporte comme la seconde! (Plus de détails dans la fonction)
            //     Ce comportement est normal, il s'agit d'une "surcharge" de fonction
            //     Il est possible en C# d'avoir plusieurs fonctions avec le même nom et le 
            //     même type de retour si la liste de leurs paramètres changent! C'est pratique
            //     pour ne pas avoir a réécrire le code d'une fonction quand on veux juste lui passer
            //     des paramètres différents.
            //     Et pour les fonctions qui demandes des types de variables simples, il est possible 
            //     de passer les paramètres tel quel! Pratique...
            Bonjour("Elise");


            /* Les fonctions précédantes n'ont aucun retour. Si certaines prennent un paramètre,
             * leur utilité reste limitée. Il est intéressant d'utiliser une fonction pour
             * effectuer un traitement puis de récupérer le résultat, surtout si cette opération
             * est récurente (un calcul, une lecture/ecriture dans un fichier...)
             * Les fonctions peuvent aussi simplifier les opérations complexes, par exemple
             * an appelant elles-même d'autres fonctions...
            */

            // Cette fonction additionne 3 int et renvoie le résultat (sous forme d'un int)
            // qui a son tour est affecté à la variable résultat (aussi un int)
            int resultat = 0;
            resultat = AdditionEnPlusieursEtapes(3, 7, 32);
            Console.WriteLine("Le resultat est égal à " + resultat);

            // Addition et AdditionEnPlusieursEtapes ont un comportement similaire
            // La différence ce fait au niveau du code (voir ces fonction en bas)
            resultat = Addition(16, 30, 27);
            Console.WriteLine("Le resultat est égal à " + resultat);

            // De la même manière qu'il est possible d'affecter le retour d'une fonction à une
            // variable, ce retour peut être utilisé tel quel!
            Console.WriteLine("Hé hop, tout en une seule ligne! -> " + Addition(101, -50, 78));

            // Il est possible de passer des valeurs en dur, des variables ou des résultats de fonctions
            // à d'autres fonction, mais c'est déconseillé, comme le montre cet exemple!
            int monInt = 36;
            resultat = Addition(3, monInt, Addition(12, 16, 20));
            Console.WriteLine("Le resultat de ce méli mélo est égal à " + resultat);

            // Les fonctions peuvent être contenu dans des structures de controles,
            // ou en contenir!
            resultat = 0;
            for (int i = 0; i <= 10; i = i + 5)
            {
                resultat = Addition(i, i, i);
                Console.WriteLine(resultat);
            }

            // Cette fonction met la valeur 'p' à la puissance 'n'
            Console.WriteLine("Pow -> " + Pow(2, 10));
        }

        // Cette fonction est unt fonction sans retour, sans paramètres,
        // dont le fonctionnement est immuable.
        static void Bonjour()
        {
            Console.WriteLine("Bonjour sans paramètres!");
        }

        // Cette fonction prends un paramètre, ici un nom sous forme de string
        // et ce paramètre change le fonctionnement de la fonction
        static void DireBonjour(string nom)
        {
            Console.WriteLine("Bonjour " + nom + "!");
        }

        // Cette fonction est une "surcharge" de la première fonction que nous avons vu
        // En effet, elle possède le même type de retour, le même nom, mais son
        // comportement change grâce à l'introduction d'un paramètre
        static void Bonjour(string nom)
        {
            Console.WriteLine("Bonjour " + nom + "!");
        }

        // Une addition en plusieurs étapes, ici dans le seul but de vous montrer le fonctionnement
        // du retour d'une fonction. On déclare puis affecte la somme de a, b et c à résultat qui
        // est du même type (int) puis on utilise le mot clé "return" pour renvoyer le retour de 
        // cette fonction.
        static int AdditionEnPlusieursEtapes(int a, int b, int c)
        {
            int result;
            result = a + b + c;
            return result;
        }

        // La même fonction que précédement, mais avec un retour en une ligne
        static int Addition(int a, int b, int c)
        {
            return a + b + c;
        }

        // Cette fonction est un peu complexe, et élève le nombre 'p' à la puissance 'n'
        static int Pow(int p, int n)
        {
            int result = p;
            for (int i = 1; i < n; i++)
            {
                result *= p;
            }
            return result;
        }
    }
}
