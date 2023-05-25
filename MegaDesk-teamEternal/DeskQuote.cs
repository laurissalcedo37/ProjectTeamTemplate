using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MegaDesk_JimDeMordaunt
{
    public class DeskQuote
    {
        public double quote { get; set; }
        public DateTime quoteDate { get; set; }
        public Desk newDesk { get; set; }
        public string fullName { get; set; }
        public string rushDays { get; set; }
        public DeskQuote newQuote;
        private int deskArea;
        private double rushCost;
        private double quotePrice;
        private double desktopCost;
        private const double BASEPRICE = 200;
        private const double DRAWER = 50;
        private const double SMALL_DESK = 1000;
        private const double LARGE_DESK = 2000;
    public DeskQuote(Desk inDesk, string inFullName, string inRushDays, DateTime inDate)
    {
        newDesk = inDesk;
        fullName = inFullName;
        rushDays = inRushDays;
        quoteDate = inDate;
        quote = CalculatePrice(newDesk, rushDays);
    }

    private double CalculatePrice(Desk newDesk, string rushDays)
        {
            double extraSurfaceCost;

            double drawCost = newDesk.numDrawers * DRAWER;
            deskArea = newDesk.width * newDesk.depth;

            if (deskArea > 1000)
            {
                extraSurfaceCost = deskArea - 1000;
            }
            else
            {
                extraSurfaceCost = 0;
            }

            rushCost = DetermineRushCost(rushDays, deskArea);
            desktopCost = (float)newDesk.desktop;
            quotePrice = BASEPRICE + drawCost + extraSurfaceCost + desktopCost + rushCost;
            return quotePrice;
        }
    private double DetermineRushCost(string rushDays, int deskArea)
    {
            string[,] rushPricesChart = GetRushOrder();
            string rushPrice;
        if (rushDays == "3 day")
        {
            if (deskArea < SMALL_DESK)
            {
                rushPrice = rushPricesChart[0,0]; //60;
            }
            else if (deskArea >= SMALL_DESK && deskArea <= LARGE_DESK)
            {
                rushPrice = rushPricesChart[0, 1]; //70;
            }
            else
            {
                    rushPrice = rushPricesChart[0, 2]; // 80;
            }
        }
        else if (rushDays == "5 day")
        {
            if (deskArea < SMALL_DESK)
            {
                rushPrice = rushPricesChart[1,0];
            }
            else if (deskArea >= SMALL_DESK && deskArea <= LARGE_DESK)
            {
                rushPrice = rushPricesChart[1,1]; //50;
                }
            else
            {
                rushPrice = rushPricesChart[1, 2]; // 60;
                }
        }
        else if (rushDays == "7 day")
        {
            if (deskArea < SMALL_DESK)
            {
                rushPrice = rushPricesChart[2, 0]; // 30;
                }
            else if (deskArea >= SMALL_DESK && deskArea <= LARGE_DESK)
            {
                rushPrice = rushPricesChart[2, 1]; // 35;
                }
            else
            {
                rushPrice = rushPricesChart[2, 2]; //40;
                }
        }
        else
        {
            rushDays = "14 day regular";
            rushPrice = "0";
        }
        rushCost = Convert.ToDouble(rushPrice);
        return rushCost;
    }
        public string[,] GetRushOrder()
        {
            int counter = 0;
            string[] rushPrices = new string[19];
            string[,] rushPricesChart = new string[3,3];
            try
            {
                StreamReader read = new StreamReader("rushOrderPrices.txt");
                for (int i =0; read.EndOfStream == false; i++)
                {
                    rushPrices[i] = read.ReadLine();
                }
                for (int m = 0; m<3; m++)
                {
                    for (int n = 0; n < 3; n++)
                    {
                        rushPricesChart[m, n] = rushPrices[counter]; counter++;
                    }
                }
            } catch (Exception e)
            {
               // System.IO.FileNotFoundException
                throw e;
            }
            return rushPricesChart;
        }
    }

}

