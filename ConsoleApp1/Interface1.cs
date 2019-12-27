using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface ICar
    {
        int Abc { get;  }
        void slowDown();
        void speedUp();
        void turnRight();
        void turnLeft();
        void stop();
        void corn();
        void turnLightOn();
        void turnLightOff();

    }
}
