using System;

// initialize variables - graded assignments 
int examAssignments = 5;

//Student score arrays
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

//Student Scores array
int [] studentScores = new int[10];

string currentStudentLetterGrade = "";

//Output header to the console
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames){
    
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

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
        
    else
        continue;

    //Initialize/reset the sume of scored assignments
    int sumAssignmentScores = 0;

    //Initialize/reset the calculated average of exam + extra credit scores
    decimal overallStudentGrade = 0;

        //Initialize/reset the number of graded assignments
        int gradedAssignments = 0;

        // Variable to store exam scores only
        decimal examScores = 0;

        // Variable to store extra credit points
        decimal extraCreditPts = 0;

        //Loop through the scores array and complete calculations for the currentstudent
        foreach (int score in studentScores)
        {
            //Increment the assignment counter
            gradedAssignments++;

            //Add the exam score to the sum.
            if (gradedAssignments <= examAssignments){
            sumAssignmentScores += score;
            examScores += score;
            }
            else {
                //Add the extra credit points to the sum - bonus points equals 10% of exam score
                sumAssignmentScores += score / 10;
                extraCreditPts += score / 10;
            }
        }
        extraCreditPts = extraCreditPts / (decimal)examAssignments;
        examScores = examScores / (decimal)examAssignments;
        overallStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

        if (overallStudentGrade >= 97){
            currentStudentLetterGrade = "A+";
        }
        else if(overallStudentGrade >= 93){
            currentStudentLetterGrade = "A";
        }
        else if(overallStudentGrade >= 90){
            currentStudentLetterGrade = "A-";
        }
        else if (overallStudentGrade >= 87){
            currentStudentLetterGrade = "B+";
        }
        else if (overallStudentGrade >= 83){
            currentStudentLetterGrade = "B";
        }
        else if (overallStudentGrade >= 80){
            currentStudentLetterGrade = "B-";
        }
        else if (overallStudentGrade >= 77){
            currentStudentLetterGrade = "C+";
        }
        else if (overallStudentGrade >= 73){
            currentStudentLetterGrade = "C";
        }
        else if (overallStudentGrade >= 70){
            currentStudentLetterGrade = "C-";
        }
        else if (overallStudentGrade >= 67){
            currentStudentLetterGrade = "D+";
        }
        else if (overallStudentGrade >= 63){
            currentStudentLetterGrade = "D";
        }
        else if (overallStudentGrade >= 60){
            currentStudentLetterGrade = "D-";
        }
        else{
            currentStudentLetterGrade = "F";
        }
        Console.WriteLine($"{currentStudent}\t\t{examScores}\t\t{overallStudentGrade}\t{currentStudentLetterGrade}\t{(int)examScores} ({extraCreditPts} pts)");
}



Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

