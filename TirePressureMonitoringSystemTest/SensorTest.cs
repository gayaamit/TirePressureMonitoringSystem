using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDMicroExercises.TirePressureMonitoringSystem;
using Xunit;

namespace TirePressureMonitoringSystemTest
{
    public class SensorTest
    {
        [Theory]
        [InlineData(16)]
        public void DetectSensor(double value)
        {
            var sensorMock = new Mock<ISensor>();
            sensorMock.Setup(s => s.PopNextPressurePsiValue()).Returns(value);
            ISensor _sensor = sensorMock.Object;
            Assert.Equal(16, value);
        }
    }
}
