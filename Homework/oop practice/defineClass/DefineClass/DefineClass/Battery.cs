using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class Battery
    {
        //model, hours idle and hours talk
        private string batteryModel;
        private int hoursIdle;
        private uint hoursTalk;
        private BatteryType batteryType;
        public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ApplicationException("Battery model can NOT be null or empty!");
                }
                this.batteryModel = value;
            }
        }
    }
}
