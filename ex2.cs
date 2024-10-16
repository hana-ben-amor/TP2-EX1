using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class ex2
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Nous allons faire une division avec des nombres positifs :");

            try
            {
                Console.Write("\nEntrez un premier nombre : ");
                uint a = uint.Parse(Console.ReadLine());

                Console.Write("Entrez un deuxieme nombre : ");
                uint b = uint.Parse(Console.ReadLine());

                // Check for division by zero
                if (b == 0)
                {
                    throw new DivideByZeroException(); // Manually throw exception for division by zero
                }

                uint c = a / b;
                Console.WriteLine("Le résultat de la division est " + c);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erreur : Vous devez entrer un nombre entier positif !");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Erreur : Le nombre entré est trop grand ou trop petit.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Erreur : Division par zéro n'est pas autorisée.");
            }
            catch (Exception ex)
            {
                // This will catch any other exceptions that were not handled above
                Console.WriteLine("Une erreur inattendue est survenue : " + ex.Message);
            }
            finally
            {
                // Code that will always run, regardless of exceptions
                Console.WriteLine("Merci d'avoir utilisé notre programme.");
            }

            Console.ReadLine();
        }
    

}
}
