using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpTutorial.FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a text document
            string file_name = "Text.txt";
            string file_path = @"c:\~projects";
            string target_path = System.IO.Path.Combine(file_path, file_name);

            if(System.IO.File.Exists(target_path))
            {
                Console.Write("File available\r\n");
            }
            else
            {
                System.IO.File.Create(target_path);
            }
            Console.ReadKey(); 

            //reading text document
            string file_path2 = @"c:\~projects\CSharp\~documents\CSharpTutorial.txt";
            string text = System.IO.File.ReadAllText(file_path2);
            Console.Write(text);
            Console.ReadKey();

            //We read the text in lines
            string[] lines = System.IO.File.ReadAllLines(file_path2);
            foreach(string l in lines) 
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();

            //We print the array elements into the text file as lines
            string[] lines2 = { "Student Number: 636", "Name: Enes", "Surname: Soğukpınar" };
            System.IO.File.WriteAllLines(@"c:\~projects\Text.txt",lines2);

            //We write the string variable to the text file
            string resume = "I was born in 2001 in Bakırköy district of Istanbul.\r\n";
            System.IO.File.WriteAllText(@"c:\~projects\Text.txt",resume);

            //We print only the desired elements in the array to the text file
            string[] employee = {"Employee=Alptuğ","Employee=Göktuğ","Employee=Serhat","Manager=Elif" };
            using (System.IO.StreamWriter file=new System.IO.StreamWriter(@"c:\~projects\Text.txt"))
            {
                foreach(string line3 in employee)
                {
                    if (line3.Contains("Manager"))
                    {
                        file.WriteLine(line3);
                    }
                }
            }

            //We add data to an existing text file
            using (System.IO.StreamWriter file1 = new System.IO.StreamWriter(@"c:\~projects\Text.txt", true))
                file1.WriteLine("added data\r\n");


        }
    }
}
