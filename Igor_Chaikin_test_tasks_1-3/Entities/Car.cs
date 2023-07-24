using System;
using System.Collections.Generic;
using System.Text;

namespace Igor_Chaikin_test_tasks_1_3.Entities
{
    class Car : Vehicle
    {
        private int maxSpeed;
        private int doorsCount;

        public int MaxSpeed { get => maxSpeed; }
        public int DoorsCount { get => doorsCount; }

        public Car() {
            manufacturerName = "Ford";
            wheelsCount = 4;
            productionYear = 2023;
            maxSpeed = 150;
            doorsCount = 4;
        }
    }
}
