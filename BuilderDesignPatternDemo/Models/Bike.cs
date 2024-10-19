using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternDemo.Models
{
    public class Bike
    {
        public string Frame { get; set; }
        public string Engine { get; set; }
        public int Wheels { get; set; }
        public override string ToString()
        {
            return $"The Frame of the Bike is: {Frame}, Engine: {Engine}, Wheels: {Wheels}";
        }
    }

}
