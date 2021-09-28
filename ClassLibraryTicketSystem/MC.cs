﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC : Vehicle
    {



        public MC(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            licensePlate = LicensePlate;
            date = Date;
        }


        public override double Price()
        {
            if (Brobiz==true)
            {
                return 125 - (125 * 0.05);
            }
            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}