using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp.Models
{
    class Vehicles
    {
        private string registrationNo;
        private string type;
        private string colour;

        public string RegistrationNo
        {
            get { return registrationNo; }
            set { registrationNo = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
