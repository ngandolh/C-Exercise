using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Low-level module
    public class Light
    {
        public void TurnOn()
        {
            //Code
        }

        public void TurnOff() { }
    }

    //High-level module
    public class Switch
    {
        private Light light;
        public Switch()
        {
            light = new Light();// High-level module depends on abstraction (interface)
        }

        public void FlipUp()
        {
            light.TurnOn();
        }

        public void FlipDown()
        {
            light.TurnOff();
        }

    }
    ////////////////////////////////////////////////////////////////////////
    
    //Abstraction(interface)
    public interface ISwithchable
    {
        void TurnOn();
        void TurnOff();
    }

    public class Switch2
    {
        private ISwithchable device;
        public Switch2(ISwithchable swithchableDevice)
        {
            this.device = swithchableDevice;// High-level module depends on abstraction (interface)
        }

        public void FlipUp()
        {
            device.TurnOn();
        }

        public void FlipDown()
        {
            device.TurnOff();
        }
    }
}
