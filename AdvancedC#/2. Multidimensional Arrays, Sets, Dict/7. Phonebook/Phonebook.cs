//Write a program that receives some info from the console about people and their phone numbers.
//You are free to choose the manner in which the data is entered; each entry should have just one name and one number (both of them strings). 
//After filling this simple phonebook, upon receiving the command "search", your program should be able to perform a search of a contact by name and print her details in format "{name} -> {number}". In case the contact isn't found, print "Contact {name} does not exist." Examples:
//Input	Output
//Nakov-0888080808
//search
//Mariika
//Nakov	Contact Mariika does not exist.
//Nakov -> 0888080808
//Nakov-+359888001122
//RoYaL(Ivan)-666
//Gero-5559393
//Simo-02/987665544
//search
//Simo
//simo
//RoYaL
//RoYaL(Ivan)	Simo -> 02/987665544
//Contact simo does not exist.
//Contact RoYaL does not exist.
//RoYaL(Ivan) -> 666
//* Bonus: What happens if the user enters the same name twice in the phonebook? Modify your program to keep multiple phone numbers per contact.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('-').ToArray();
            Dictionary<string,string> phonebook=new Dictionary<string,string>();

            while (input[0]!="search")
            {
                phonebook.Add(input[0], input[1]);
                input = Console.ReadLine().Split('-').ToArray();
            }

            while (true)
            {
                string nameSearched = Console.ReadLine();
                if (phonebook.ContainsKey(nameSearched))
                {
                        Console.WriteLine("{0} --> {1}", nameSearched, phonebook[nameSearched]);
                }  
                else
                    {
                        Console.WriteLine("Contact {0} doesn't exist", nameSearched);
                    }
            }
        }
    }
}
