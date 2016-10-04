using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ShakespearHW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creat an instance of StreamReader to read from Shakespear file
            StreamReader read = new StreamReader("Shakespear.txt");
            
            int lineNumber = 0;
            Console.WriteLine();


            //Read first line from the text file
            string line = read.ReadLine();

            //Read the other lines from the text file
            while (line != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}:{1}", lineNumber, line);
                line = read.ReadLine();
            }

            read.Close();




        }
    }
}
