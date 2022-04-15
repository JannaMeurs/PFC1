using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFaceCountEnd.Classes
{
    public class Sensor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Location Location { get; set;}
        public BindingList<SensorMeasurement> Measurements { get; set; }

        public Sensor(int Id, string Name, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            Measurements = new BindingList<SensorMeasurement>();
        }

        public void AddLocation(Location location)
        {
            this.Location = location;
        }

        public void ConnectSensorMeasurementToSensor(SensorMeasurement Measurement)
        {
            Measurements.Add(Measurement);
            Measurement.AddSensor(this);
        }
    }
}
