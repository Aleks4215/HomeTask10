using Microsoft.VisualBasic.CompilerServices;
using System;

namespace HomeTask10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }

    public class Car
    {
        public double Volume { get; set; }
        public string Vendor { get; set; }

        public string FuelConsumption { get; set; }

        public Car(double volume, string vendor, string fuelConsumption)
        {
            this.Volume = volume;
            this.Vendor = vendor;
            this.FuelConsumption = fuelConsumption;
        }

        public virtual double GetVolume(double volume)
        {
            return volume;
        }

        public static double operator -(Car a, Car b)
        {
            return a.Volume - b.Volume;
        }
        public static Car operator ++(Car car)
        {
            car.Volume++;
            return car;
        }


    }
    public class BMW : Car
    {
        public BMW(double volume, string vendor, string fuelConsumption) : base(volume, vendor, fuelConsumption)
        {
            this.Volume = volume;
            this.Vendor = vendor;
            this.FuelConsumption = fuelConsumption;
        }
    }
}
