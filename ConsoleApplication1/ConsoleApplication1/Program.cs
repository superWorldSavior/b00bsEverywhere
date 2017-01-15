using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    { 
        static void Main()
        {
            int j;
            int m;
            int a;
            char validation;

            do
            {
                Console.WriteLine("Entrer le jour : __/__/__");
                j = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entrer le mois : " + j + "/__/__");
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entrer l'année : " + j + "/" + m + "/____");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("la date a vérifier est  : " + j + "/" + m + "/" + a + ")");
                Console.WriteLine("Est-ce la date que vous voulez vérifier ? O pour continuer, N pour revenir à l'écran de saisie");
                validation = Convert.ToChar(Console.ReadLine());
             } while (validation == 'N' || validation == 'n');  
             Console.WriteLine(verifdate(j, m, a));
            Console.ReadLine();
        }

        static bool bissextile(int annee)
        {
            if ((annee % 4) == 0)
            {
                if (((annee % 100) == 0 && ((annee % 400) != 0)))
                    return false;
                else
                    return true;
            }
            else
                return false;
        }
        static bool verifdate(int j, int m, int a)
        {
            int[] jours = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if(a<100)
                {
                if (a < 0)
                    return false;
                if (a < 50)
                    a += 2000;
                else
                    a += 1900;
                }
            if (m < 1 || m > 12 || j < 1)
                return false;
            if ((j > jours[m-1]))
                return false;
            if ((!bissextile(a)) && m == 2 && j > 28)
                return false;
            return true;       
        }
    }
}


