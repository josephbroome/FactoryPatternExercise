using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    static class VehicleFactory
    {
        public static Ivehicle GetIvehicle(int tires)

        {
            switch(tires)
            {
                case 2:
                    return new Motorcycle();
                case 3:
                    return new ThreeWheeler();
                case 4:
                    return new Car();
                case 18:
                    return new BigRig();
                default:
                    return new Car();

            }

        }
        
    
    }
}
