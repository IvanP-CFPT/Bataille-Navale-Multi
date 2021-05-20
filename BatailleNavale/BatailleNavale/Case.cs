using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    public class Case
    {
        private bool _boat;

        private bool _hit;

        private string _color;

        public bool Boat
        {
            get { return this._boat; }
            set { this._boat = value; }
        }

        public bool Hit
        {
            get { return this._hit; }
            set { this._hit = value; }
        }

        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        public Case() : this(false, false, "white") { }

        public Case(bool boat, bool hit, string color)
        {
            this.Boat = boat;
            this.Hit = hit;
            this.Color = color;
        }

        public void ChangeColor(string newColor)
        {
            this.Color = newColor;
        }

        public void ToggleBoat()
        {
            this.Boat = !this.Boat;
        }

        public void ToggleHit()
        {
            this.Hit = !this.Hit;
        }
    }
}
