using System;
using System.Collections.Generic;

namespace Sender
{
    public class DataProcess
    {
        public List<float> GenerateTemperatureData(float min, float max)
        {
            Random randData = new Random();
            List<float> temperatureData = new List<float>();

            for (int i = 0; i < 50; i++)
            {
                temperatureData.Add((float)(randData.NextDouble() * (max - min)) + min);
            }
            return temperatureData;
        }

        public List<float> GenerateSocData(float min, float max)
        {
            Random randData = new Random();
            List<float> socData = new List<float>();
            for (int i = 0; i < 50; i++)
            {
                socData.Add((float)(randData.NextDouble() * (max - min)) + min);
            }
            return socData;
        }
        public void PrintParameterValues(List<BatteryParameters> bmsParameterData)
        {
            Console.WriteLine("Temperature Data (parameter 1)");
            
            foreach (BatteryParameters bmsParameter in bmsParameterData)
            {
                Console.WriteLine(bmsParameter.temperature);
            }
            
            Console.WriteLine("SOC Data (parameter 2)");

            foreach (BatteryParameters bmsParameter in bmsParameterData)
            {
                Console.WriteLine(bmsParameter.soc);
            }
        }
    }
}