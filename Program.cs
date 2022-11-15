using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Övning_List_o_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country Sweden = new Country("Sweden", 46, "Stockholm");
            Country France = new Country("France", 33, "Paris");
            Country Italy = new Country("Italy", 39, "Rome");
            Country Spain = new Country("Spain", 34, "Madrid");
            Country Finland = new Country("Finland", 358, "Helsinki");

            List<Country> Countries = new List<Country>();
            Countries.Add(Sweden);
            Countries.Add(France);
            Countries.Add(Italy);
            Countries.Add(Spain);
            Countries.Add(Finland);

            //Console.WriteLine("Please enter country code: ");
            //int Answer = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter country code: ");
            //int Answer = int.Parse(Console.ReadLine());
            //Country CodeToFind = Countries.Find(x => x.Code == Answer);
            //string Answer2;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Please enter country code: ");
            //    int Answer = int.Parse(Console.ReadLine());
            //    Country CodeToFind = Countries.Find(x => x.Code == Answer);

            //    if (Countries.Any(x => x.Code == Answer))
            //    {
            //        Console.WriteLine(CodeToFind.ToString());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, could not find country");
            //    }
            //    do
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Do you want to continue? Yes or No.");
            //        Answer2 = Console.ReadLine().ToUpper();
            //        if (Answer2 != "YES" && Answer2 != "NO")
            //        {
            //            Console.WriteLine("I'm sorry, I don't understand");
            //        }
            //    } while (Answer2 != "YES" && Answer2 != "NO");
            //}
            //while (Answer2 == "YES");



            Dictionary<int, Country> CountryDic = new Dictionary<int, Country>();
            CountryDic.Add(46, Sweden);
            CountryDic.Add(33, France);
            CountryDic.Add(39, Italy);
            CountryDic.Add(34, Spain);
            CountryDic.Add(358, Finland);

            string Answer3;
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter country code: ");
                int Answer = int.Parse(Console.ReadLine());

                Country country;
                if (CountryDic.TryGetValue(Answer, out country))
                {
                    Console.WriteLine($"Name: {country.Name}\nCode: {country.Code}\nCapital: {country.Capital}");
                }
                else
                {
                    Console.WriteLine("Sorry, could not find country");
                }
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Do you want to continue? Yes or No.");
                    Answer3 = Console.ReadLine().ToUpper();
                    if (Answer3 != "YES" && Answer3 != "NO")
                    {
                        Console.WriteLine("I'm sorry, I don't understand");
                    }
                } while (Answer3 != "YES" && Answer3 != "NO");
            }
            while (Answer3 == "YES");
        }
    }
}
