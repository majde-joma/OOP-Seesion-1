using Proiect;
using System;
namespace Proiect
{

    class Grades
    {
        private int[] _studentGrades = new int[5];

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < 5)
                {
                    return _studentGrades[index];
                }
                return -1;
            }
            set
            {
                if (index >= 0 && index < 5)
                {
                    if (value >= 0 && value <= 100)
                    {
                        _studentGrades[index] = value;
                    }
                }
            }
        }
    }

}

internal class Program
{
    static void Main(string[] args)
    {
        Grades grades = new Grades();

        grades[0] = 95;
        grades[1] = 88;
        grades[2] = 105;
        Console.WriteLine(grades[0]);
        Console.WriteLine(grades[1]);
        Console.WriteLine(grades[2]);


    }
}
