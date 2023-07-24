using System;
using System.Collections.Generic;
using System.Text;

namespace Igor_Chaikin_test_tasks_1_3.Entities
{
    class Truck : Vehicle
    {
        private int loadCapacity;

        public int LoadCapacity { get => loadCapacity; }

        public Truck() {
            manufacturerName = "CAT";
            wheelsCount = 6;
            productionYear = 2018;
            loadCapacity = 5000;
        }
    }
}
