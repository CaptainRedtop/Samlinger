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
            int y2009 = 175134;
            int y2010 = 175338;
            int y2011 = 172818;
            int y2012 = 142709;
            int y2013 = 151437;
            int y2014 = 152620 + 35432;
            int y2015 = 150979;
            int y2016 = 152210;
            int y2017 = 149450;
            int y2018 = 154398;
            int y2019 = 150160;

            int[] sales = new int[] { y2009, y2010, y2011, y2012, y2013, y2014, y2015, y2016, y2017, y2018, y2019 };
            Array.Sort(sales);
            Array.Reverse(sales);
            return sales;
        }

        #endregion Model
    }
}

