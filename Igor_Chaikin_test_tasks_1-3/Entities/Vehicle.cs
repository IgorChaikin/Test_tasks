using System;
using System.Collections.Generic;
using System.Text;

namespace Igor_Chaikin_test_tasks_1_3.Entities
{
    abstract class Vehicle
    {
        protected string manufacturerName;
        protected int wheelsCount;
        protected int productionYear;

        public string ManufacturerName { get => manufacturerName; }
        public int WheelsCount { get => wheelsCount; }
        public int ProductionYear { get => productionYear; }
    }
}
