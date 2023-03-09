using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vaz<string> vaz2101 = new Vaz<string>("vaz",80, 5, 400);
            Console.WriteLine("ВАЗ2101 " + vaz2101.info());
            Vaz<int> vaz2105 = new Vaz<int>(2605, 80, 5, 400);
            Console.WriteLine("ВАЗ2105 " + vaz2105.info());
            Console.WriteLine("----------------------------------");

            Airplane<string> mriya = new Airplane<string>("airplane",850, 250, 4000);
            Console.WriteLine("Ан-225 Мрия " + mriya.info());
            Airplane<int> an225 = new Airplane<int>(225, 850, 250, 4000);
            Console.WriteLine("Ан-225 Мрия " + an225.info());
            Console.WriteLine("----------------------------------");

            Titanic<string> titanic = new Titanic<string>("bul-bul",39,46238,1500);
            Console.WriteLine("Титаник " + titanic.info());
            Titanic<int> britanic = new Titanic<int>(3, 39, 46238, 1500);
            Console.WriteLine("Титаник " + britanic.info());
        }
    }
    abstract class Transport
    {
        public  abstract int speed{get; set;}
        public abstract int tonnage { get; set; }
        public abstract int powerReserve { get; set; }
       
        public Transport(int speed, int tonnage, int powerReserve)
        {
            this.speed = speed;
            this.tonnage = tonnage;
            this.powerReserve = powerReserve;
          
        }
        public abstract string info();     
        
    }
    abstract class Car : Transport
    {
        public string id;
        public Car( int speed, int tonnage, int powerReserve): base( speed, tonnage, powerReserve) 
        { 
            this.id = id;
        }
    }
    abstract class Ship : Transport
    {
        public string id;
        public Ship (int speed, int tonnage, int powerReserve) : base(speed, tonnage, powerReserve)
        {
            this.id = id;
        }
    }
    abstract class Plane : Transport
    {
        public string id;
        public Plane( int speed, int tonnage, int powerReserve) : base(speed, tonnage, powerReserve)
        {
            this.id = id;
        }
    }
    class Vaz<T> : Car
    {
        public T id { get; set; }
        public override int speed { get; set; }
        public override int tonnage { get; set; }
        public override int powerReserve { get; set; }
        public Vaz(T id, int speed, int tonnage, int powerReserve) : base( speed, tonnage, powerReserve) 
        {
            this.id = id;
        }

        public override string info()
        {
            return $"грузоподъёмностью в {tonnage}т. может преодолеть {powerReserve}км. со скоростью {speed}км/ч.   id = {id}";
        }
    }
    class Airplane<T> : Plane
    {
        public T id { get; set; }
        public override int speed { get; set; }
        public override int tonnage { get; set; }
        public override int powerReserve { get; set; }
        public Airplane(T id, int speed, int tonnage, int powerReserve) : base(speed, tonnage, powerReserve)
        {
            this.id = id;
        }

        public override string info()
        {
            return $"грузоподъёмностью в {tonnage}т. может преодолеть {powerReserve}км. со скоростью {speed}км/ч.  id = {id}";
        }
    }
    class Titanic<T> : Ship
    {
        public T id { get; set; }
        public override int speed { get; set; }
        public override int tonnage { get; set; }
        public override int powerReserve { get; set; }
        public Titanic(T id, int speed, int tonnage, int powerReserve) : base(speed, tonnage, powerReserve)
        {
            this.id = id;
        }

        public override string info()
        {
            return $"грузоподъёмностью в {tonnage}т. может преодолеть {powerReserve}км. со скоростью {speed}км/ч.  id = {id}";
        }
    }
}
