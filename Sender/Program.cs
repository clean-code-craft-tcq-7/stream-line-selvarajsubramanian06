using System;
using System.Collections.Generic;

namespace Sender
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataProcess sensorDataProcess = new DataProcess();

            List<BatteryParameters> bmsParameterData = new List<BatteryParameters>();
            List<float> temperatureData = sensorDataProcess.GenerateTemperatureData(1, 100);
            List<float> socData = sensorDataProcess.GenerateSocData(10, 50);

            for (int i = 0; i < temperatureData.Count; i++)
            {
                BatteryParameters bmsParameter = new BatteryParameters();
                bmsParameter.temperature = temperatureData[i];
                bmsParameter.soc = socData[i];

                bmsParameterData.Add(bmsParameter);
            }

            sensorDataProcess.PrintParameterValues(bmsParameterData);
                       
        }
    }
}