using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given names and phone numbers, assemble a phone book that maps friends'
//    names to their respective phone numbers.
//    You will then be given an unknown number of names to query 
//        your phone book for. For each name queried,
//        print the associated entry from your phone book
//        on a new line in the form name=phoneNumber;
//    if an entry for name is not found, print Not found instead.

//Sample Input

//3
//sam 99912222
//tom 11122222
//harry 12299933
//sam
//edward
//harry

//Sample Output

//sam=99912222
//Not found
//harry=12299933


namespace Day_8_Dictionaries
{
    class Solution

    {
        static Hashtable phonebook = new Hashtable();
        
        static void Main(string[] args)
        {

            //create phonebook
           
            //read input

            int numEntries = Int32.Parse(Console.ReadLine());

          for (int i = 1; i <= numEntries; i++)
          {
                //split input string by space
                
                string[] arr_temp = Console.ReadLine().Split(' ');
                //add to phonebook
                phonebook.Add(arr_temp[0], arr_temp[1]);
                
                
          }
            //Console.WriteLine("Eneter query");
            ////take in queries
            //try infinite loop until empty string then break
            while(true)
            {
                string input = Console.ReadLine();
                if(!String.IsNullOrEmpty(input))
                {
                    Lookup(input);

                }
                else
                {
                    break;
                }
            }

            //while (!String.IsNullOrEmpty(Console.ReadLine()))
            //{
            //    string query = Console.ReadLine();
            //    Lookup(query);
               
                
            //}
           // Console.ReadLine();



            //foreach (DictionaryEntry var in phonebook)
            //{
            //    Console.WriteLine("" + var.Key + " " + var.Value);

            //}
            //Console.ReadLine();


            //create lookup method
            //lookup 

        }

        static void Lookup(string query)
        {
            //On a new line for each query,
            //    print Not found if the name has no corresponding entry 
            //    in the phone book; otherwise, print the full name and  number
            //    in the format name = phoneNumber.

            //Console.ReadLine();
            if (!phonebook.ContainsKey(query))
            {
                Console.WriteLine("Not found");
            }
            else
                Console.WriteLine(query + " = " + phonebook[query]);
            //Console.ReadLine();
        }

        static void PrintArray(string[] str)
        {
            foreach(var v in str)
            { 
                Console.WriteLine(v);
            }
        }
    }
}
