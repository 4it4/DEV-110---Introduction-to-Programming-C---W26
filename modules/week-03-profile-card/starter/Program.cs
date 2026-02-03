using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Transactions;

namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        string name, hometown, color, dreamjob, major;
        int gradyear, age, favnumber, birthyear, yearstilgrad, months;
        double gpa, heightinches, feet, inches;
        bool isfulltime, ishonorstudent;

        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CREATOR            ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        Console.WriteLine("Enter your name:");
        name = Console.ReadLine();
        // - Hometown (city, state)
        Console.WriteLine("Enter your hometown:");
        hometown = Console.ReadLine();
        // - Favorite color
        Console.WriteLine("Enter your favorite color:");
        color = Console.ReadLine();
        // - Dream job
        Console.WriteLine("Enter your dream job:");
        dreamjob = Console.ReadLine();
        // Hint: string variableName = Console.ReadLine();


        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        Console.WriteLine("Enter your major");
        major = Console.ReadLine();
        // - GPA (double, 0.0-4.0)
        Console.WriteLine("Enter your GPA:");
        gpa = double.Parse(Console.ReadLine());
        // - Graduation year (int)
        Console.WriteLine("Enter your graduation year");
        gradyear = int.Parse(Console.ReadLine());
        // - Is full-time student? (bool from yes/no)
        Console.WriteLine("Are you a fulltime student? (yes/no)");
        isfulltime = Console.ReadLine().ToLower() == "yes";
        // Hint: double gpa = double.Parse(Console.ReadLine());
        // Hint: bool isFullTime = answer.ToLower() == "yes";

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        Console.WriteLine("Enter your age:");
        age = int.Parse(Console.ReadLine());
        // - Height in inches (double)
        Console.WriteLine("Enter your height (in inches)");
        heightinches = double.Parse(Console.ReadLine());
        // - Favorite number (int)
        Console.WriteLine("Enter your favorite number");
        favnumber = int.Parse(Console.ReadLine());

        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        birthyear = 2026 - age;
        // - Years to graduation = graduationYear - 2026
        yearstilgrad = gradyear - 2026;
        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        feet = (int)(heightinches / 12);
        inches = (int)(heightinches % 12);
        // - Is honor student? = gpa >= 3.5
        ishonorstudent = gpa >= 3.5;
        // - Age in months = age * 12
        months = age * 12;

        // TODO: DISPLAY formatted profile card
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");
        // Use sections with headers:
        // - PERSONAL INFORMATION
        Console.WriteLine("PERSONAL INFORMATION");
        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Hometown: {0}", hometown);
        Console.WriteLine("Favorite Color: {0}", color);
        Console.WriteLine("Favorite Number: {0}", favnumber);
        Console.WriteLine("Dream Job: {0}", dreamjob);
        Console.WriteLine("Height: {0} feet {1} inches ({2})", feet, inches, heightinches);
        Console.WriteLine();

        // - ACADEMIC DETAILS
        Console.WriteLine("ACADEMIC DETAILS");
        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
        Console.WriteLine("Major: {0}", major);
        Console.WriteLine("GPA: {0:F2}", gpa);
        Console.WriteLine("Expected Graduation: {0}", gradyear);

        if (isfulltime)
        {
            Console.WriteLine("Status: Full-Time Student");
        }
        else
        {
            Console.WriteLine("Part-Time Student");
        }

        if (ishonorstudent)
        {
            Console.WriteLine("Honor Student: Yes");
        }
        else
        {
            Console.WriteLine("Honor Student: No");
        }
        Console.WriteLine();

        // - CALCULATED STATISTICS
        // Use proper alignment and formatting
        Console.WriteLine("CALCULATED STATISTICS");
        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
        Console.WriteLine("Birth year: {0}", birthyear);
        Console.WriteLine("Years to Graduation: {0} years", yearstilgrad);
        Console.WriteLine("Age in Months: {0} months", months);
        Console.WriteLine();

        Console.WriteLine("═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
