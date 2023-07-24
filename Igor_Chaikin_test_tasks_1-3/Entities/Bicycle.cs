using System;
using System.Collections.Generic;
using System.Text;

namespace Igor_Chaikin_test_tasks_1_3.Entities
{
    class Bicycle : Vehicle
    {
        private int bicyclistsCount;

        public int BicyclistsCount { get => bicyclistsCount; }

        public Bicycle()
        {
            manufacturerName = "AIST";
            wheelsCount = 2;
            productionYear = 1999;
            bicyclistsCount = 1;
        }
    }
}
