using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProFaceCountEnd.Classes
{
    public class SensorMeasurement
    {
        public int EntryId { get; set; }
        public int PeopleIn{ get; set; }
        public int PeopleOut { get; set; }
        public DateTime TimeStamp { get; set; }
        public Sensor Sensor { get; set; }

        public SensorMeasurement(int EntryId, int PeopleIn, int PeopleOut, DateTime TimeStamp)
        {
            this.EntryId = EntryId;
            this.PeopleIn = PeopleIn;
            this.PeopleOut = PeopleOut;
            this.TimeStamp = TimeStamp;
            

        }

        public void AddSensor(Sensor sensor)
        {
            this.Sensor = sensor;
        }
    }
}
