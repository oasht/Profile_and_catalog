using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_profile__catalog
{
    [Serializable]
    public class Good
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public double Price { get; set; }
        public override string ToString() { return $"{Name} - {Price} руб."; }
    }
}
