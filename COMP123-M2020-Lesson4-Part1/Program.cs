using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_Lesson4_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person("Tom", 40);

            tom.SaysHello();

            string tomString = tom.ToString();

            Console.WriteLine(tomString);
            Console.WriteLine();


            Person jacky = new Person("Jacky",  22);

            jacky.SaysHello();

            Console.WriteLine(jacky.ToString());
            Console.WriteLine();

            Student joss = new Student("Joss", 22, "A1234567890");

            joss.SaysHello();
            joss.Studies();

            Console.WriteLine(joss.ToString());


            // wait for user to enter anything
            Console.ReadLine();
        }
    }
}
