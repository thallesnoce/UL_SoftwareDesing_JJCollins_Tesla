﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SoftwareDesign.ControllerLayer.Business
{
    public class ConcreteObserver : Observer
    {
        public void updateState(int state)
        {
            //please add a reminder / alert here to show the effect in View Layer.
            //Console.writeline("You are viewing the package"+state);
        }


    }
}
