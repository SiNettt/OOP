using System;
namespace MyCars
{
     class Program
    {


        class Car
        {


            public string Mark { get; set; }
            public double Engine { get; set; }
            public Color Color { get; set; }
            public int Weight { get; set; }



            public Car(string mark, double engine, Color color, int weight)
            {
                Mark = mark;
                Engine = engine;
                Color = color;
                Weight = weight;
            }


            public void AddWeight(int NewWeight)
            {
                Weight += NewWeight;
            }

            public void AddWeight(double NewWeight)
            {
                Weight += (int)NewWeight;
            }


            public override bool Equals(object? obj)
            {
                return obj is Car car &&
                       Mark == car.Mark &&
                       Engine == car.Engine &&
                       Color == car.Color &&
                       Weight == car.Weight;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Mark, Engine, Color, Weight);
            }

            public static bool operator ==(Car left, Car right)
            {
                return Equals(left, right);
            }

            public static bool operator !=(Car left, Car right)
            {
                return !Equals(left, right);
            }


            public override string ToString()
            {
                return ("Mark = " + Mark + ", Engine = " + Engine + ", Color = " + Color + ", Weight = " + Weight);
            }



        }


        enum Color
        {
            Black,
            Red,
            Grey
        }

        
        static void Main(string[] args)
        {

            Car mits = new Car("Mitsubishi", 2.2, Color.Black, 1000);
            Car ford = new Car("Ford", 1.4, Color.Grey, 1000);
            Car ford2 = new Car("Ford", 1.4, Color.Grey, 1000);

            mits.AddWeight(1000);
            ford.AddWeight(500);
            ford2.AddWeight(500);

            mits.AddWeight(10.10000);
            ford.AddWeight(20.2000);
            ford2.AddWeight(20.2000);

            Console.WriteLine(mits);
            Console.WriteLine(ford);

            Console.WriteLine(mits.Equals(ford));

            Console.WriteLine(ford == ford2);

        }
    }
}