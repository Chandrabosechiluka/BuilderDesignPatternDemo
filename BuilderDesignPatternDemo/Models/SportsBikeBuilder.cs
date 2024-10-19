using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternDemo.Models
{
    public class SportsBikeBuilder : IBikeBuilder
    {
        private Bike _bike = new Bike();

        public void BuildFrame()
        {
            _bike.Frame = "Sports Bike Frame";
        }

        public void BuildEngine()
        {
            _bike.Engine = "1300cc Engine";
        }

        public void BuildWheels()
        {
            _bike.Wheels = 2;
        }


        public Bike GetBike()
        {
            return _bike;
        }
    }

}
