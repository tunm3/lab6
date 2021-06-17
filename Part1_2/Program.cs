using System;

namespace Part1_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            thermostat.OnTemperatureChange += heater.OnTemperaturechanged;
            Heater heaterCuong = new Heater(100);
            thermostat.OnTemperatureChange += heaterCuong.OnTemperaturechanged;
            Cooler cooler = new Cooler(80);
            thermostat.OnTemperatureChange += cooler.OnTemperatureChanged;
            string temperature;
            Console.WriteLine("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
            Console.ReadLine();
        }
    }
}