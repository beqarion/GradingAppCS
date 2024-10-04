using System;


namespace MyGradingApp
{
  class Program
  {
    public static void Main(string[] args)
    {

      int examAssignments = 5;

      string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

      int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
      int[] andrewScores = [92, 89, 81, 96, 90, 89];
      int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
      int[] loganScores = [90, 95, 87, 88, 96, 96];

      int[] studentScores = new int[10];

      string currentStudentLetterGrade = "";

      // display the header row for scores/grades
      Console.Clear();
      Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

      foreach (string name in studentNames)
      {
        string currentStudent = name;

        if (currentStudent == "Sophia")
          studentScores = sophiaScores;

        else if (currentStudent == "Andrew")
          studentScores = andrewScores;

        else if (currentStudent == "Emma")
          studentScores = emmaScores;

        else if (currentStudent == "Logan")
          studentScores = loganScores;

        int sumExamScore = 0;
        int sumExtraScore = 0;


        decimal currentOverallGrade = 0;
        decimal currentExamGrade = 0;
        decimal extraCreditPoints = 0;
        int avgExtraScore = 0;


        int gradedAssignments = 0;
        int extraAssignment = 0;

        foreach (int score in studentScores)
        {
          gradedAssignments += 1;

          if (gradedAssignments <= examAssignments)
            sumExamScore += score;

          else
          {
            extraAssignment++;
            sumExtraScore += score;
          }
        }

        // Calculation printed values
        currentOverallGrade = (decimal)(sumExamScore + (decimal)sumExtraScore / 10) / examAssignments;
        currentExamGrade = (decimal)sumExamScore / examAssignments;
        if (extraAssignment > 0)
          avgExtraScore = sumExtraScore / extraAssignment;
        extraCreditPoints = (decimal)sumExtraScore / 10 / examAssignments;

        // Letter grade assignement block
        if (currentOverallGrade >= 97)
          currentStudentLetterGrade = "A+";

        else if (currentOverallGrade >= 93)
          currentStudentLetterGrade = "A";

        else if (currentOverallGrade >= 90)
          currentStudentLetterGrade = "A-";

        else if (currentOverallGrade >= 87)
          currentStudentLetterGrade = "B+";

        else if (currentOverallGrade >= 83)
          currentStudentLetterGrade = "B";

        else if (currentOverallGrade >= 80)
          currentStudentLetterGrade = "B-";

        else if (currentOverallGrade >= 77)
          currentStudentLetterGrade = "C+";

        else if (currentOverallGrade >= 73)
          currentStudentLetterGrade = "C";

        else if (currentOverallGrade >= 70)
          currentStudentLetterGrade = "C-";

        else if (currentOverallGrade >= 67)
          currentStudentLetterGrade = "D+";

        else if (currentOverallGrade >= 63)
          currentStudentLetterGrade = "D";

        else if (currentOverallGrade >= 60)
          currentStudentLetterGrade = "D-";

        else
          currentStudentLetterGrade = "F";


        Console.WriteLine($"{currentStudent}\t\t{currentExamGrade}\t\t{currentOverallGrade}\t{currentStudentLetterGrade}\t{avgExtraScore} ({extraCreditPoints} pts)");
      }

      Console.WriteLine("\n\rPress thse Enter key to continue");
      Console.ReadLine();

    }
  }
}



