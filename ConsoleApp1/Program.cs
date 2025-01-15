using System;
using System.IO;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // File path to save the text file
        string filePath = @"C:\Users\Abdallah Hesham\source\repos\ConsoleApp1\DateTimeOutput.txt";

        Console.WriteLine($"The application is writing the current date and time to {filePath} every second...");
        Console.WriteLine("Press Ctrl+C to stop the application.");

        while (true)
        {
            try
            {
                // Get the current date and time
                string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Append the date and time to the text file
                File.AppendAllText(filePath, $"Current Date and Time: {currentDateTime}\n");
                Console.WriteLine(currentDateTime );
                // Wait for 1 second
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                break;
            }
        }
    }
}
