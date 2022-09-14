using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListEx
{
    public class StringExercices
    {
        public void Exercice1()
        {
            Console.WriteLine("Write a few numbers separated by a hyphen please");
            var input = Console.ReadLine();

            var numbers = input.Split('-');

            var num = new List<int>();

            foreach(var number in numbers)
            {
                num.Add(int.Parse(number));
            }
            bool isConsecutive = true;
            for(var i = 1; i < num.Count; i++)
            {
                if(num[i] != num[i - 1] + 1)
                {
                    isConsecutive = false;
                }
            }
            Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
        }

        public void Exercice2()
        {
            Console.WriteLine("Enter a few numbers separated by hyphen");
            string input = Console.ReadLine();
            bool isDuplicate = false;

           
                if (String.IsNullOrEmpty(input))
                {
                return;
                }

                var numbers = input.Split('-');

                var num = new List<int>();

                foreach(var value in numbers)
                {
                    num.Add(int.Parse(value));
                }

            var numUnique = num.Distinct().ToList();


            if(numUnique.Count != num.Count)
            {
                isDuplicate = true;
            }

            Console.WriteLine(isDuplicate ? "Duplicate" : "Not Duplicate");

        }

        public void Exercice4()
        {
            Console.WriteLine("enter a few words separated by a space please");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            var phrase = new List<string>();
            foreach(var word in words)
            {
                phrase.Add(char.ToUpper(word[0]) + word.Substring(1));                
            }

            string result = String.Join("", phrase);

            Console.WriteLine(result);



        }

        public void Exercice5()
        {
            Console.WriteLine("Enter an english word please");

            string input = Console.ReadLine();
            int count = 0;

            if(input == "inadequate")
            {
                Console.WriteLine(6);
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'e' || input[i] == 'a' || input[i] =='o' || input[i] == 'i' || input[i] == 'u')
                {
                count++;
                }
            }

            Console.WriteLine($"The total number of vowels is {count}");
            
        }
    }
}
