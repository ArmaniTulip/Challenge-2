using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace Challenge_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the file names
            string originalFileName = "mytest.txt";
            string copiedFileName = "mytest_copy.txt";

            // Define the content to write to the file
            string[] content = 
            {
                "Hello and Welcome",
                "It is the first content",
                "of the text file mytest.txt"
            };

            try
            {
                // Create and write content to the original file
                File.WriteAllLines(originalFileName, content);
                Console.WriteLine( originalFileName);

                // Copy the original file to a new file
                File.Copy(originalFileName, copiedFileName, true);
                Console.WriteLine(copiedFileName);

                // Read and display the content of the copied file
                string[] copiedFileContent = File.ReadAllLines(copiedFileName);
                Console.WriteLine( copiedFileName);

                foreach (string line in copiedFileContent)
                {
                    Console.WriteLine(line);
                }
            
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);






            }
        }
    }
}
