using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Location
    {
        public  string Address { get; set; }
        public  string Phone { get; set; }
        public  double Latitude { get; set; }
        public  double Longitude { get; set; }
        public  City City { get; set; }
        public  int Id { get; set; }
        public  bool IsDeleted { get; set; }
        /*
         "locations": [
      {
        "address": "Trg mladenaca 4",
        "phone": "+38121425699",
        "latitude": 45.252658,
        "longitude": 19.842318,
        "city": {
          "name": "Novi Sad",
          "id": 1,
          "isDeleted": false
        },
        "id": 11,
        "isDeleted": false
      }
    ],*/
    }
}
