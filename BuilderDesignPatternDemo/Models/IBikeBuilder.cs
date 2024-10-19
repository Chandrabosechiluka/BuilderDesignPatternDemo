using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternDemo.Models
{
    public interface IBikeBuilder
    {
        void BuildWheels();
        void BuildEngine();
        void BuildFrame();
        Bike GetBike();
    }

}
