using System;

// initialize variables - graded assignments 
int examAssignments = 5;
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

int[] studentScores = new int[5];
string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (var student in studentNames)
{
    string studentName = student;

    if (studentName == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (studentName == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (studentName == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (studentName == "Logan")
    {
        studentScores = loganScores;
    }
    else if (studentName == "Becky")
    {
        studentScores = beckyScores;
    }
    else if (studentName == "Chris")
    {
        studentScores = chrisScores;
    }
    else if (studentName == "Eric")
    {
        studentScores = ericScores;
    }
    else if (studentName == "Gregor")
    {
        studentScores = gregorScores;
    }
    else
        continue;

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;

    foreach (var item in studentScores)
    {
        gradedAssignments++;

        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += item;
        }
        else
            sumAssignmentScores += item / 10;
    }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{studentName}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

