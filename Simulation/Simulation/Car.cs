using System;
using System.Collections.Generic;
using System.Text;

namespace Simulation
{
    class Car
    {
        private string brand;
        private string color;
        private int maxspeed;
        private int fuelConsumption; 
        private int volumeoftank; 
        public int  CurrentFuel { get; set; }


        public Car(string Brand,string Color,int Maxspeed,int FuelConsumption,int Volumeoftank)
        {
            brand = Brand;
            color = Color;
            maxspeed = Maxspeed;
            fuelConsumption = FuelConsumption;
            volumeoftank = Volumeoftank;

        }
        public Car()
        {

        }
        #region
        public void Run()
        {
            if (CurrentFuel>0)
            {
                CurrentFuel--;
                volumeoftank--;
                
            }
        }
        #endregion

        #region
        public void GasStation()
        {
            if (CurrentFuel<fuelConsumption)
            {
                CurrentFuel++;
            }
        }
        #endregion

        #region
        public double QunatityofKilometr() //polnu bak benzin ne qeder bes edecek 
        {
            double  quantity = 100 * volumeoftank / fuelConsumption;
            return quantity;
        }
        #endregion

        #region
        public double howManyFuelareEnough(int volume) //benzin nece km bes edecek
        {
            double quantity = 100 * volume / fuelConsumption;
            return quantity;
        }
        #endregion

    }

}
