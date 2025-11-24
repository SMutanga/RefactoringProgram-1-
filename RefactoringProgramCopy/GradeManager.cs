using System;

namespace RefactoringHomework
{
    public class GradeManager
    {
        private double passingGrade = 50.0;

        public double PassingGrade { get => passingGrade; set => passingGrade = value; }

        public void LogGradeProcessingManager()
        {
            Console.WriteLine("Working on grades...");
        }

        public void processGrades(string studentName, double[] grades)
        {
            Console.WriteLine("Processing grades for " + studentName);

            double total = CalculateTotal(grades);

            double average = CalculateAverage(grades, total);
            Console.WriteLine("Average: " + average);



            if (average >= PassingGrade)
            {
                Console.WriteLine("Status: Pass");
            }
            else
            {
                Console.WriteLine("Status: Fail");
            }
        }

        private static double CalculateAverage(double[] grades, double total)
        {
            return total / grades.Length;
        }

        private static double CalculateTotal(double[] grades)
        {
            double total = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                total += grades[i];
            }

            return total;
        }

        public double calculateFinalGrade(double bonus, double average)
        {
            return average + bonus;
        }
    }
}
