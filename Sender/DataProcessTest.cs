using System.Collections.Generic;
using System.Diagnostics;

namespace Sender
{
    public class DataProcessTest
    {
        public void TestTemperatureValues()
        {
            DataProcess sensorData = new DataProcess();
            List<float> sensorValues = sensorData.GenerateTemperatureData(1, 100);
            foreach (float reading in sensorValues)
            {
                Debug.Assert(reading <= 100 && reading > 0);
            }
        }

        public void TestSocValues()
        {
            DataProcess sensorData = new DataProcess();
            List<float> sensorValues = sensorData.GenerateSocData(10, 50);
            foreach (float reading in sensorValues)
            {
                Debug.Assert(reading <= 50 && reading > 10);
            }
        }
    }
}