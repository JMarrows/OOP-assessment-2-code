using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToBeReviewed
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] git_1a = System.IO.File.ReadAllLines(@"GitRepositories_1a.txt");
            string[] git_1b = System.IO.File.ReadAllLines(@"GitRepositories_1b.txt");
            string[] git_2a = System.IO.File.ReadAllLines(@"GitRepositories_2a.txt");
            string[] git_2b = System.IO.File.ReadAllLines(@"GitRepositories_2b.txt");
            string[] git_3a = System.IO.File.ReadAllLines(@"GitRepositories_3a.txt"); 
            string[] git_3b = System.IO.File.ReadAllLines(@"GitRepositories_3b.txt");
            Console.WriteLine("Whic files would you like to compare? Set 1,2 or 3 ");
            string UserInput = Console.ReadLine();
            if (UserInput == "1"){
                Console.WriteLine("You have chosen set 1 ");
                if(git_1a == git_1b)
                {
                 Console.WriteLine("These files are the same");   
                }
                else
                {
                    Console.WriteLine("These files are different");
                }
            }
            if (UserInput == "2"){
                 Console.WriteLine("You have chosen set 2 ");
                 if(git_2a == git_2b)
                {
                 Console.WriteLine("These files are the same");   
                }
                 else
                {
                 Console.WriteLine("These files are different");
                }
            }
            if (UserInput == "3"){
                Console.WriteLine("You have chosen set 3 ");
                if(git_3a == git_3b)
                {
                 Console.WriteLine("These files are the same");   
                }
                else
                {
                    Console.WriteLine("These files are different");
                }
            }
        }
    }
}
