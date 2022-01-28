using System;
using Microsoft.AspNetCore.Mvc;

namespace formando_devs_api.Domain
{
    public class EletricDevice
    {
        public EletricDevice(double Current, double Voltage)
        {
            this.Current = Current;
            this.Voltage = Voltage;
        }

        public double Current { get; set; }
        public double Voltage { get; set; }

        public double GetPower() 
        {
            return Voltage * Current;
        }

        public double GetResistence() 
        {
            return Voltage / Current;
        }

    }
}
