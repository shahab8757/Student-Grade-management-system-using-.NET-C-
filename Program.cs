using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> studentNames = new List<string>(); // List to store student names
        List<double> studentGrades = new List<double>(); // List to store student grades
        string studentName;
        double studentGrade;
        int numberOfStudents;

        // Get the number of students
        Console.Write("Enter the number of students: ");
        numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Loop to get student names and grades
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nStudent #{i + 1}:");

            // Get student name
            Console.Write("Enter the student's name: ");
            studentName = Console.ReadLine();
            studentNames.Add(studentName);

            // Get student grade
            Console.Write("Enter the student's grade: ");
            studentGrade = Convert.ToDouble(Console.ReadLine());
            studentGrades.Add(studentGrade);
        }

        // Calculate and display results
        double totalGrades = 0;
        Console.WriteLine("\nStudent Grades Summary:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            // Print student name and grade
            Console.WriteLine($"{studentNames[i]} - Grade: {studentGrades[i]} - " +
                (studentGrades[i] >= 60 ? "Pass" : "Fail"));

            // Calculate total for average grade calculation
            totalGrades += studentGrades[i];
        }

        // Calculate and display average grade
        double averageGrade = totalGrades / numberOfStudents;
        Console.WriteLine($"\nThe average grade of all students is: {averageGrade:F2}");
    }
}
