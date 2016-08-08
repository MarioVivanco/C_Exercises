using System;

namespace ExerciseWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of feet: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var myUnitConvertor = new UnitConvertor(12);
            var result = myUnitConvertor.Convert(input, 12);
            Console.WriteLine("{0} feet = {1} inches", input, result);

            Panda[] Pandas = new Panda[] { new Panda("A", 1), new Panda("B", 2), new Panda("C", 3), new Panda("D", 4), new Panda("E", 5) };
            for (int i = 0; i < Pandas.Length; i++)
            {
                Console.WriteLine("Panda{0}: Name - {1} Age - {2}", i + 1, Pandas[i].name, Pandas[i].age);
            }

            Point A = new Point();
            Point B = new Point();
            Console.WriteLine("{0},{1}", A.x, A.y);
            Console.WriteLine("{0},{1}", B.x, B.y);

            int dX = A.x - B.x;
            int dY = A.y - B.y;
            int multi = dX * dX + dY * dY;
            double distance = Math.Round(Math.Sqrt(multi), 3);

            Console.WriteLine("Distance: {0} units", distance);

            Console.Read();
        }
    }

    class UnitConvertor
    {
        public int ratio;
        public int output;

        public UnitConvertor(int m)
        {
            ratio = m;
        }

        public int Convert(int input, int ratio)
        {
            output = input * ratio;
            return output;
        }
    }

    class Panda
    {
        public string name;
        public int age;

        public Panda(string n, int a)
        {
            this.name = n;
            this.age = a;
        }
    }

    class Point
    {
        public int x;
        public int y;

        public Point()
        {
            this.x = getNumber();
            this.y = getNumber();
    
        }

        private static Random r = new Random();

        private int getNumber()
        {
            int number = r.Next(-10, 11);
            return number;
        }
    }
}