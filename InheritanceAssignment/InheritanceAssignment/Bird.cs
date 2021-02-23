using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    abstract public class Bird
    {

        // Variables

        string name = "n/a";
        bool hasTalons = false;
        bool hasWebbedFeet = false;
        bool hasWings = false;
        bool hasFeathers = false;
        bool canFly = false;
        bool canHover = false;
        bool canSwim = false;

        // Gets & Sets

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public bool HasTalons
        {
            get
            {
                return this.hasTalons;
            }
            set
            {
                this.hasTalons = value;
            }
        }

        public bool HasWebbedFeet
        {
            get
            {
                return this.hasWebbedFeet;
            }
            set
            {
                this.hasWebbedFeet = value;
            }
        }

        public bool HasWings
        {
            get
            {
                return this.hasWings;
            }
            set
            {
                this.hasWings = value;
            }
        }

        public bool HasFeathers
        {
            get
            {
                return this.hasFeathers;
            }
            set
            {
                this.hasFeathers = value;
            }
        }

        public bool CanFly
        {
            get
            {
                return this.canFly;
            }
            set
            {
                this.canFly = value;
            }
        }

        public bool CanHover
        {
            get
            {
                return this.canHover;
            }
            set
            {
                this.canHover = value;
            }
        }

        public bool CanSwim
        {
            get
            {
                return this.canSwim;
            }
            set
            {
                this.canSwim = value;
            }
        }


        // Methods

        public override string ToString()
        {
            string message = "";

            message += $"Name: {this.Name}\n";
            message += $"Talons: {this.HasTalons}\n";
            message += $"Webbed Feet: {this.HasWebbedFeet}\n";
            message += $"Wings: {this.HasWings}\n";
            message += $"Feathers: {this.HasFeathers}\n";
            message += $"Flight: {this.CanFly}\n";
            message += $"Hover: {this.CanHover}\n";
            message += $"Swim: {this.CanSwim}\n";

            return message;
        }
    }
}
