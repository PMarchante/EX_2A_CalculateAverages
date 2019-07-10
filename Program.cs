using System;

namespace EX_2A_CalculateAverages
{
    class Program
    {
        public int sum(int one, int two, int three, int four, int five, int six, int seven, int eight, int nine, int ten)
        {


            if ((one | two | three | four | five | six | seven | eight | nine | ten) < 0 || (one | two | three | four | five | six | seven | eight | nine | ten) > 100)
                return 0;

            else
            {
                int sum = one + two + three + four + five + six + seven + eight + nine + ten;
                return sum;
            }

        }

        public char grade(int one, int two, int three, int four, int five, int six, int seven, int eight, int nine, int ten)
        {

            if ((one | two | three | four | five | six | seven | eight | nine | ten) < 0 || (one | two | three | four | five | six | seven | eight | nine | ten) > 100)
                return 'Z';


            int avg = (one + two + three + four + five + six + seven + eight + nine + ten) / 10;

            if (avg >= 90)
                return 'A';

            else if (avg < 90 && avg >= 80)
                return 'B';

            else if (avg < 80 && avg >= 70)
                return 'C';

            else if (avg < 70 && avg >= 60)
                return 'D';

            else
                return 'F';
        }

        public char gradeTakeAvg(int avg)
        {
            if (avg >= 90)
                return 'A';

            else if (avg < 90 && avg >= 80)
                return 'B';

            else if (avg < 80 && avg >= 70)
                return 'C';

            else if (avg < 70 && avg >= 60)
                return 'D';

            else
                return 'F';
        }

        public void grader()
        {
            Console.WriteLine("How many test grades will be entered?");
            String input = Console.ReadLine();
            int totalTests = Convert.ToInt32(input);
            int totalTestResult = 0;

            for (int x = 0; totalTests > x; x++)
            {
                Console.WriteLine("What is the grade for test " + (x + 1));
                String tmp = Console.ReadLine();

                if (Int32.Parse(tmp) < 0 || (Int32.Parse(tmp) > 100))
                {
                    while (Int32.Parse(tmp) < 0 || (Int32.Parse(tmp) > 100))
                    {
                        Console.WriteLine("Enter a number between 0 and 100");
                        tmp = Console.ReadLine();
                    }
                    totalTestResult += Convert.ToInt32(tmp);
                }

                else
                {
                    totalTestResult += Convert.ToInt32(tmp);

                }

            }
            int avg = totalTestResult / totalTests;
            char ltrGrade = gradeTakeAvg(avg);
            Console.WriteLine($"avg is {avg} and letter grade is {ltrGrade}");
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            //Console.WriteLine(test.grade(1100, 70, 80, 75, 80, 90, 100, 100, 80, 85));
            test.grader();
        }
    }
}
