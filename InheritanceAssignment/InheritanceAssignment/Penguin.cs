﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Penguin : Bird
    {
        public Penguin() : this("n/a", false, false, false, false, false, false, false) { }

        public Penguin(string aName, bool itHasTalons, bool itHasWebbedFeet, bool itHasWings, bool itHasFeathers, bool itCanFly, bool itCanHover, bool itCanSwim)
        {
            this.Name = aName;
            this.HasTalons = itHasTalons;
            this.HasWebbedFeet = itHasWebbedFeet;
            this.HasWings = itHasWings;
            this.HasFeathers = itHasFeathers;
            this.CanFly = itCanFly;
            this.CanHover = itCanHover;
            this.CanSwim = itCanSwim;
        }
    }
}
