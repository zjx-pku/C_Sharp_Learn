using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicles
    {

    }

    public abstract class Car : Vehicles
    {

    }

    public abstract class Train : Vehicles
    {

    }

    public class Compact : Car, IPassengerCarrier
    {

    }

    public class SUV : Car, IPassengerCarrier
    {

    }

    public class Pickup : Car, IHeavyLoadCarrier, IPassengerCarrier
    {

    }

    public class PassengerTrain : Train, IPassengerCarrier
    {

    }

    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }

    public class DoubleBogey : Train
    {

    }

    public interface IPassengerCarrier
    {

    }

    public interface IHeavyLoadCarrier
    {

    }

}
