using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Partner
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string ShortInfo { get; set; }
        public string hqPhone { get; set; }
        public List<Location> Locations { get; set; }
        public List<Discount> Discounts { get; set; }
        public Category Category { get; set; }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        /*
         "name": "Apetit bar",
    "url": "https://www.facebook.com/Apetit-bar/",
    "shortInfo": "15%",
    "hqPhone": "",
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
    ],
    
    "category": {
      "name": "restorani",
      "id": 1,
      "isDeleted": false
    },
    "id": 11,
    "isDeleted": false
  },*/
    }
}
