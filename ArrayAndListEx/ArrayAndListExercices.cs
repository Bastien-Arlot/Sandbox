using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListEx
{
    public class ExercicesList
    {
        public void Exercice1()
        {
            var names = new List<string>();

            while(true)
            {
                Console.WriteLine("What is your name?");
                var input  = Console.ReadLine();  
                if(String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                names.Add(input);
                
            }
            if(names.Count == 0)
            {

                return;
            }else if(names.Count == 1)
            {
                Console.WriteLine($"{names[0]} likes your post");
            }else if(names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} like your post");
            }else if(names.Count > 2)
            {
                Console.WriteLine($"{names[0]} and ${ names[1]} and { names.Count - 2 } other people like your post");
            }
        }

        public void Exercice2()
        {
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();

            char[] array = input.ToCharArray();
            Array.Reverse(array);

            Console.WriteLine(string.Join("", array));
        }

        public void Exercice3()
        {
            var numbers = new List<int>();
            Console.WriteLine("Enter a total of 5 non-identical number");


            while (true)
            {
                Console.WriteLine("Select your number");
                var input = Console.ReadLine();
                int number = int.Parse(input);

                if(!numbers.Contains(number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("This number was already picked, retry");
                }

                if(numbers.Count == 5)
                {
                    numbers.Sort();
                    string result = string.Join("", numbers);
                    Console.WriteLine($"Here is your result: {result}");
                    break;
                }
            }   
        }

        public void Exercice4()
        {
            var numbers = new List<int>();
          

            while (true)
            {
                Console.WriteLine("Enter a number or type Quit to exit");
                string input = Console.ReadLine();

                if(input == "Quit")
                {
                    List<int> distinctNumbers = numbers.Distinct().ToList();
                    string result = string.Join("", distinctNumbers);
                    Console.WriteLine($"The list of distinctNumbers is {result}");

                    break;
                }

                int number = int.Parse(input);
                numbers.Add(number);

                
            }
        }

        public void Exercice5()
        {
            var numbers = new List<int>();

            Console.WriteLine("Enter a list of numbers separated by commas, should contain at least 5 numbers");

            while(true)
            {
                Console.WriteLine("Select your list");
                string input = Console.ReadLine();

                var list = input.Split(",");

                foreach(var value in list)
                {
                    numbers.Add(int.Parse(value));
                }

                if(numbers.Count < 5)
                {
                    Console.WriteLine("Invalid list, retry");
                }
                else
                {
                    numbers.Sort();
                    List<int> result = new List<int>();
                    for(int i = 0; i < (3); i++)
                    {
                        
                        result.Add(numbers[i]);
                    }
                    string finalResult = string.Join("", result);
                    Console.WriteLine($"You 3 smallest numbers inside your list are {finalResult}"); 
                    break;
                }

                
            }
        }

    }
}
