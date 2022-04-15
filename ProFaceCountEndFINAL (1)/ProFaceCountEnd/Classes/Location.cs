using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProFaceCountEnd.Classes
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxPersons { get; set; }
        public BindingList<Sensor> Sensors { get; set; }
        

        

        public Location(int Id, string Name, int MaxPersons)
        {
            this.Id = Id;
            this.Name = Name;
            this.MaxPersons = MaxPersons;
            Sensors = new BindingList<Sensor>();
            
            
        }

        public void ConnectSensorToLocation(Sensor sensor)
        {
            Sensors.Add(sensor);
            sensor.AddLocation(this);
        }


        
    }
}
