using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinosBlancos
{
    internal class Program
    {
        const int MAX = 175388;
        const byte MAX_STARS = 100;
        
        static void Main(string[] args)
        {
            Console.Title = "Vinos Blancos";
            StartController();
        }

        #region View
        static void View(string sales)
        {
            Console.Write(sales);
            Console.ReadKey();
        }

        #endregion View

        #region Controller
        static void StartController()
        {
            string starSales = "";
            Model();
            for (int i = 0; i < Model().Length; i++)
            {
                int stars = MAX_STARS * Model()[i] / MAX;
                for (int j = 0; j < stars; j++)
                {
                    starSales += "*";
                }
                starSales += "\n";
            }
            View(starSales);
            
        }

        #endregion Controller

        #region Model
        static int[] Model()
        {
            int[] sales = new int[] { 175134, 175338, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };
            Array.Sort(sales);
            Array.Reverse(sales);
            return sales;
        }

        #endregion Model
    }
}

