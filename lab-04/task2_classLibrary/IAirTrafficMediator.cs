﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_classLibrary
{
    public interface IAirTrafficMediator
    {
        void RequestLanding(Aircraft aircraft);
        void NotifyTakeOff(Aircraft aircraft);
    }
}
