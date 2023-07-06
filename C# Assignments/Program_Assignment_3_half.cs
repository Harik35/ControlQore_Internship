using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program_1
            Console.WriteLine("Enter the String: ");
            string word = Console.ReadLine();
            int lenOfString = word.Length;
            Console.WriteLine(lenOfString);

            //Program_2
            Console.WriteLine("Enter the String: ");
            word = Console.ReadLine();
            Console.WriteLine("Enter the letter which you want to find index: ");
            char.TryParse(Console.ReadLine(), out char letter);
            int position = word.IndexOf(letter);
            Console.WriteLine(position);


            //Program_3
            Console.WriteLine("Enter the String: ");
            word = Console.ReadLine();

            string rev = reverseString(word);
            Console.WriteLine(rev);


            //Program_4
            Console.WriteLine("Enter the String: ");
            word = Console.ReadLine();
            word = "Hai" + word;
            Console.WriteLine(word);


            //Program_5
            Console.WriteLine("Enter the String: ");
            word = Console.ReadLine();
            int leng = word.Length;
            Console.WriteLine(word[leng - 1]);


            //Program_6
            Console.WriteLine("Enter the String: ");
            word = Console.ReadLine();

            rev = replacing(word);
            Console.WriteLine(rev);


            //Program_7
            Console.WriteLine("Enter the String: ");
            word = Console.ReadLine();
            Console.WriteLine("Enter the letter want to count: ");
            char.TryParse(Console.ReadLine(), out letter);

            int count = 0;
            count = Counter(word, letter);
            Console.WriteLine(count);
            Console.ReadLine();

            //Program_8















            //Program_9
            string adate = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(adate);
            adate = DateTime.Now.ToString("hh:mm:ss");
            Console.WriteLine(adate);
            adate = DateTime.Now.ToString("dddd, dd, MMMMM, YYYY hh:mm:ss");
            Console.WriteLine(adate);
            Console.ReadLine();





        }

        //Program_3_Function
        static string reverseString(string word)
        {
            string rev = ""; 
            int leng = word.Length;
            for (int i = leng-1; i >= 0; i--)
            {
                rev = rev + word[i];
            }
            return rev;
        }

        //Program_6_Function
        static string replacing(string word)
        {
            string NewString = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    NewString = NewString + '_';
                }
                else
                {
                    NewString += word[i];
                }
                
            }
            return NewString;
        }

        //Program_7_Function
        static int Counter(string word, char letter) 
        {
            int count = 0;
            for (int i = 0;i < word.Length;i++)
            {
                if (word[i] == letter)
                {
                    count++;
                }
            }
            return count;   
        }

        

    }
}
