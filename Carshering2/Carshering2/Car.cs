using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carshering2
{
    /*public interface ICar
    {
        string Number { get; }
        string Name { get; }
        string Specifications { get; }
        string RentTime { get; }
        decimal Price { get; }
        CarClass CarClass { get; }
    }*/

    public interface ICarClass
    {
        string Class { get; }
    }

    public class CarClass : ICarClass
    {
        public string Class { get; }

        public CarClass(string class_)
        {
            this.Class = class_;
        }

        public override string ToString()
        {
            return Class;
        }
    }

    public class Car
    {
        public string Number { get; }
        public string Name { get; }
        public string Specifications { get; }
        public string RentTime = "1мин";
        public decimal Price { get; }
        public CarClass CarClass { get; }

        public Car(string name, string specifications, string number, decimal price, CarClass carClass)
        {
            this.Name = name;
            this.Specifications = specifications;
            this.Number = number;
            this.Price = price;
            this.CarClass = carClass;
        }

        public override string ToString()
        {
            return $"{Name} {Specifications} {Price} {CarClass}";
        }
    }
}
