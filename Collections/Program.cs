using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new List<string>()
            {
                "asdf",
                "blreg",
                "steve",
                "appple",
                "antelope"
            };

            strings.Add("abc");
            var results = strings.Contains("blreg");


            // just like a filter in JS
            var wordsBegginningWithA = strings.
                Where(currentString => currentString.StartsWith("a"));

            var firstWord = strings.FirstOrDefault(currentString => currentString.StartsWith("a"));
            var secondWord = strings.Skip(1).First();
            var secondUsingTake = strings.Skip(1).Take(1);

            var anyWordsWithX = strings.Any(currentWord => currentWord.StartsWith("x"));

            var allWordsWithX = strings.All(currentWord => currentWord.StartsWith("x"));

            var transformed = strings.Select(item => $"{item} - transformed");

            var transformedAnimal = strings.Select(item => new Animal { Name = item });

            Console.WriteLine("here");
            Console.WriteLine(transformed);
            foreach (var i in transformed)
            {
                Console.WriteLine($"{i}, this is I");
            }
            Console.WriteLine(transformedAnimal);

            Console.WriteLine("end");


            strings.OrderBy(currentString => currentString.Last());
            strings.OrderByDescending(currentString => currentString.Last());


            var letterAnimal = strings
                .Where(currentString => currentString.StartsWith("a"))
                .Select(item => new Animal { Name = item });



            var groupedByStrings = strings
                .GroupBy(currentString => currentString.First());

            foreach(var grouping in groupedByStrings)
            {
                Console.WriteLine($"I'm looping over groupBy {grouping.Key}");
                foreach(var currentString in grouping)
                {
                    Console.WriteLine($"current string in grouping {currentString}, other one {grouping.Key}");
                }
            }


            foreach (var currentString in strings)
            {
                Console.WriteLine($"Current string is {currentString}");
            }

            var alphabetWords = new Dictionary<char, string>();
            alphabetWords.Add('a', "apple");
            alphabetWords.Add('b', "baby");
            alphabetWords.Add('c', "catastrophe");

            var seven = alphabetWords['b']; // use this to get the value.
            alphabetWords['b'] = "dogastrophen"; // Use this to change the value.


            // var keyValues = new List<KeyValuePair<char, string>>();

            foreach (var word in alphabetWords)
            {
                Console.WriteLine($"Th current key is {word.Key} and the value is {word.Value}");
            }

            var hashset = new HashSet<Animal>();
            var animal = new Animal { Age = 12, Color = "Golden", Name = "tom", Type = "dog" };
            var tom = new Animal { Age = 12, Color = "Golden", Name = "tom", Type = "mouse" };
            var jerry = new Animal { Age = 12, Color = "Golden", Name = "jerry", Type = "cat" };


            // hashset.Add(new Animal { Age = 12, Color = "Golden", Name = "tom", Type = "dog" });

            hashset.Add(animal);
            hashset.Add(tom);
            hashset.Add(jerry);




        }
    }
    class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
    }
}
