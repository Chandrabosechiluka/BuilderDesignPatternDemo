using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternDemo.Models
{
    public class BikeDirector
    {
        private IBikeBuilder _bikeBuilder;

        public BikeDirector(IBikeBuilder bikeBuilder)
        {
            _bikeBuilder = bikeBuilder;
        }

        public void BuildBike()
        {
            _bikeBuilder.BuildFrame();
            _bikeBuilder.BuildEngine();
            _bikeBuilder.BuildWheels();
        }

        public Bike GetBike()
        {
            return _bikeBuilder.GetBike();
        }
    }

}
