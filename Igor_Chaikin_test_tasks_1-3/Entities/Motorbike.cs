using System;
using System.Collections.Generic;
using System.Text;

namespace Igor_Chaikin_test_tasks_1_3.Entities
{
    class Motorbike : Vehicle
    {
        private bool hasSidecar;

        public bool HasSidecar { get => hasSidecar; }

        public Motorbike() {
            manufacturerName = "Harley-Davidson";
            wheelsCount = 2;
            productionYear = 1980;
            hasSidecar = false;
        }
    }
}
