namespace RefactoringHomework
{
    public interface IGradeManager
    {
        double calculateFinalGrade(double bonus, double average);
        void processGrades(string studentName, double[] grades);
    }
}