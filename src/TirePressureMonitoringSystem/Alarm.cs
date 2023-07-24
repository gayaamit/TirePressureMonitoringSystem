namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {        
        private const double LowPressureThreshold = 17;
        private const double HighPressureThreshold = 21;
        public Alarm()
        {
        }
        public Alarm(ISensor sensor)
        {
            _sensor = sensor;
        }

        readonly ISensor _sensor = new Sensor();

        bool _alarmOn = false;

        public void Check()
        {
            double psiPressureValue = _sensor.PopNextPressurePsiValue();

            if (psiPressureValue < LowPressureThreshold || HighPressureThreshold < psiPressureValue)
            {
                _alarmOn = true;
            }
        }
        public void CheckPressure()
        {
            double psiPressureValue = _sensor.PopNextPressurePsiValue();

            if (psiPressureValue < LowPressureThreshold || HighPressureThreshold < psiPressureValue)
            {
                _alarmOn = true;
            }
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }

    }
}
