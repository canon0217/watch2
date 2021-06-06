using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClock
{
    class CustomClock: UserControl1
    {
        public DateTime AlarmTime;
        public ClockType ClockType;
        public FunctionType FunctionType;

        public CustomClock()
        {
            this.AlarmTime = new DateTime();
            this.ClockType = ClockType.Analog;
            this.FunctionType = FunctionType.Clock;
            this.BackColor = Color.Pink;
        }

        public Boolean Start()
        {
            return !this.isFunctionTypeClock();
        }

        public Boolean Stop()
        {
            return !this.isFunctionTypeClock();
        }

        public Boolean Reset()
        {
            return !this.isFunctionTypeClock();
        }

        public Boolean Invert()
        {
            return (this.FunctionType == FunctionType.CountdownTimer);
        }

        public ClockType clockType
        {
            set
            {
                this.ClockType = value;
            }

            get
            {
                return this.ClockType;
            }
        }

        public FunctionType functionType
        {
            set
            {
                this.FunctionType = value;
            }

            get
            {
                return this.FunctionType;
            }
        }

        private Boolean isFunctionTypeClock()
        {
            if (this.FunctionType == FunctionType.Clock)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public enum ClockType
    {
        Analog,
        Digital,
        Sandglass
    }

    public enum FunctionType
    {
        Clock,
        Stopwatch,
        CountdownTimer
    }
}
