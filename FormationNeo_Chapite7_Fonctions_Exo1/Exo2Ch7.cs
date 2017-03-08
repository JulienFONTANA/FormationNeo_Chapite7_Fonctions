
/* Nous allons essayer de nous simplifier la vie grâce aux fonctions!
 * Les notions dont vous avez besoin sont:
 *      --> Les variables
 *      --> Les structures conditionnelles
 *      --> La logique de Boole
 *      --> Les boucles
 * 
 * Commencer par choisir ce projet au démarrage. Pour ce faire, faites un clic droit sur "FormationNeo_Chapitre7_Fonction_Exo1",
 * et cliquer sur l'icone de roue dentée "Définir comme projet de démarrage"
 * 
 * Utiliser Ctrl + F5 pour compiler et lancer le projet
*/

using System;

namespace FormationNeo_Chapite7_Fonctions_Exo2
{
    class Exo2Ch7
    {
        static void Main(string[] args)
        {
            string nom = "";
            string age = "";

            // Ecrivez une fonction qui affiche "J'aime les poney tout doux." à l'écran
            // qui ne renvoie rien et ne prends pas de paramètres
            // Appelez votre fonction ILovePoney()!


            // Ecrivez une fonction qui affiche votre nom et votre age (vous pouvez mentir)
            // sous la forme "Je m'appel {prénom} et j'ai {age} ans!"
            // On utilisera un age sous la forme d'un string ici pour se simplifier la vie...
            Console.WriteLine("Quel est votre nom ?");
            nom = Console.ReadLine();
            Console.WriteLine("Quel est votre age ?");
            age = Console.ReadLine();


            // Ecriver une fonction ayant le même nom que la fonction précédante mais 
            // qui n'affiche que votre nom (surcharger votre fonction)


            // Ecrivez une fonction qui soustrait 2 double et qui renvoie le résultat
            // Astuce: pour initialiser un double, utiliser des chiffres à virgules
            //         exemple -> double a = 9.4;
            // Ne mettez pas le "Console.WriteLine(...)" dans votre fonction!


            // Ecrivez une fonction qui multiplie 2 int et qui renvoie le résultat
            // Appellez cette fonction "Multiplication" 


            // En utilisant votre fonction "Multiplication", écriver une fonction qui
            // ne prend qu'un int en paramètre mais qui renvoie le carré de celui-çi!


            // Afficher toutes les valeurs des carrés des nombres entre 1 et 'n'


            // Ecrivez une fonction qui prends un age en paramètre et détermine si vous êtes majeur
            // et qui renvoie cette information sous forme de booleen
            // Utiliser la variable ageInt (un int) et pas la variable age (un string)
            int ageInt = 21;

        }
    }
}
