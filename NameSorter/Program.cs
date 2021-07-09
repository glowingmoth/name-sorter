using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "unsorted-names-list.txt");
            var destPath = Path.Combine(Directory.GetCurrentDirectory(), "sorted-names-list.txt");
 
            //string filePath = @"C:\******YOUR FILE PATH*******\unsorted-names-list.txt"; // Exact path to .txt file
            //string destPath = @"C:\*****YOUR FILE PATH*******\sorted-names-list.txt";

            List<string> names = new List<string>();
            names = File.ReadAllLines(filePath).ToList();                           // chaining ToList() needed here becasue needs to convert to a List

            for (int i = 0; i <= names.Count - 2; i++)
            {

                for (int j = 0; j <= names.Count - 2; j++)
                {
                    int firstLetterSurname1 = names[j].LastIndexOf(" ") + 1;        // Index for the first character of surname
                    char letter1 = names[j][firstLetterSurname1];                   // Assigns the first character of surname to letter1
                    int surnameValue1 = (int)letter1;                               // Convert first character of surname to ascii value

                    int firstLetterSurname2 = names[j + 1].LastIndexOf(" ") + 1;    // These are the same as above and all 6 lines could
                    char letter2 = names[j + 1][firstLetterSurname2];               // be made into a function that returns both values needed																
                    int surnameValue2 = (int)letter2;

                    if (surnameValue1 > surnameValue2)								// Conditonal swap based on surname first letter values						
                    {
                        string temp;
                        temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }

            }

            File.WriteAllLines(destPath, names);                                   // Here the file will be saved to the same file path
                                                                                        // but with the name 'sorted-names-list.txt'
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
