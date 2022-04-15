using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProFaceCountEnd.Classes
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string HouseNumber { get; set; }
        public List<Location> Locations { get; set; }

        
    }
    
}
