using Moq;
using System;
using TDDMicroExercises.TirePressureMonitoringSystem;
using Xunit;

namespace TirePressureMonitoringSystemTest
{
    public class AlarmTest
    {
        ISensor _sensor;
        [Fact]
        public void Test()
        {
            Assert.True(true);
        }
        [Fact]
        public void AlarmIsOff_WhenPressure_16()
        {
            // Arrange  
            var sensorMock = new Mock<ISensor>();
            sensorMock.Setup(s => s.PopNextPressurePsiValue()).Returns(16);
            _sensor = sensorMock.Object;

            Alarm alarm = new Alarm(_sensor);

            // Act 

            alarm.CheckPressure();

            //Assert  
            Assert.True(alarm.AlarmOn);
        }
        [Fact]
        public void AlarmIsOff_WhenPressure_17()
        {
            // Arrange  
            var sensorMock = new Mock<ISensor>();
            sensorMock.Setup(s => s.PopNextPressurePsiValue()).Returns(17);
            _sensor = sensorMock.Object;

            Alarm alarm = new Alarm(_sensor);

            // Act 

            alarm.CheckPressure();

            //Assert  
            Assert.False(alarm.AlarmOn);
        }
        [Fact]
        public void AlarmIsOn_WhenPressure_25()
        {
            // Arrange  
            var sensorMock = new Mock<ISensor>();
            sensorMock.Setup(s => s.PopNextPressurePsiValue()).Returns(25);
            _sensor = sensorMock.Object;

            Alarm alarm = new Alarm(_sensor);

            // Act 

            alarm.CheckPressure();

            //Assert  
            Assert.True(alarm.AlarmOn);
        }
    }
}
