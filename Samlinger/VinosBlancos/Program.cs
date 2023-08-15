using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinosBlancos
{
    internal class Program
    {
        const int max = 175388;
        const byte maxStar = 100;
        
        static void Main(string[] args)
        {
            Console.Title = "Vinos Blancos";
            StartController();
        }

        #region View
        static void View()
        {
            
        }

        #endregion View

        #region Controller
        static void StartController()
        {
            string starSales = "";
            Model();
            for (int i = 0; i < Model().Length; i++)
            {
                int stars = maxStar * Model()[i] / max;
                for (int j = 0; j < stars; j++)
                {
                    starSales += stars
                }
            }
            
        }

        #endregion Controller

        #region Model
        static int[] Model()
        {
            int[] sales = new int[] { 175134, 175338, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };
            return sales;
        }

        #endregion Model
    }
}

