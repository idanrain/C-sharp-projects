using System;
using System.Security.Cryptography.X509Certificates;

// initialize variables - graded assignments 


int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94,90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 90, 85, 87, 98, 100, 89, 89 };
int[] chrisScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] davidScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };


// student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "David" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

    
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

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "David")
        studentScores = davidScores;
    else
continue;

int assignmentSum = 0;

    decimal currentStudentgrade = 0;

    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
            
        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            assignmentSum += score;
       
       else
       
        assignmentSum+= score / 10;
       }
    
    currentStudentgrade = (decimal)assignmentSum / examAssignments;

    if (currentStudentgrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentgrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentgrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentgrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentgrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentgrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentgrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentgrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentgrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentgrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentgrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentgrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t {currentStudentgrade} \t {currentStudentLetterGrade} ");
}

