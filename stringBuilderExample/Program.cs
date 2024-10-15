using System;
using System.Text;

namespace stringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] words = new string[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };
            string sentence = "";
            foreach (string word in words)
            {
                sentence = sentence + " " + word;//Problem new object will be created for each iteration
            }
            Console.WriteLine(sentence);

            StringBuilder builder = new StringBuilder();
            foreach (string word in words)
            {
                builder.Append(word);
                builder.Append(" ");
                Console.WriteLine(builder.ToString()+","+builder.Length+","+builder.Capacity);
            }

            builder[0] = 'v';
            Console.WriteLine(builder.ToString());
            Console.WriteLine(builder.MaxCapacity);

            Console.WriteLine(builder.Insert(5,"updated"));
            Console.WriteLine(builder.Remove(builder.ToString().IndexOf("q"), 5));
            Console.WriteLine(builder.Replace("a", "r"));
            
            Console.ReadKey();
            
        }
    }
}
