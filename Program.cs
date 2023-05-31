// // Wish List

// using System;

// class Program
// {
//     static void Main()
//     {
//         string[] iWishFor = new string[]
//         {
//             "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
//             "The ability to think of interesting wishes on short notice",
//             "A washtub of Skittles",
//             "World peace, but not the kind of world peace where all the humans are removed from existence",
//             "A TV that is NOT internet-capable",
//             "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
//         };

//         Console.WriteLine("My wishes...");
//         foreach (string wish in iWishFor)
//         {
//             Console.WriteLine(wish);
//         }
//     }
// }

// Insulter

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         string[] insults = new string[]
//         {
//             "You look like what morning breath smells like.",
//             "If you tried to give me CPR I would probably throw myself back underwater.",
//             "I am not a fan of you.",
//             "You think you're so special...and you are. The fact of your existence is nearly impossible to believe.",
//             "I'd rather walk than be on the same plane as you.",
//             "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy.",
//             "Do you have to be so...like that?"
//         };

//         List<int> indexes = new List<int>();
//         Random random = new Random();

//         while (indexes.Count < 3)
//         {
//             int candidate = getRandomInt(0, insults.Length - 1, random);
//             if (!indexes.Contains(candidate))
//             {
//                 indexes.Add(candidate);
//             }
//         }

//         for (int i = 0; i < indexes.Count; i++)
//         {
//             int index = indexes[i];
//             Console.WriteLine(insults[index]);
//         }
//     }

//     static int getRandomInt(int min, int max, Random random)
//     {
//         return random.Next(min, max + 1);
//     }
// }

// FizzBuzz

// using System;

// class Program
// {
//     static void Main()
//     {
//         for (int n = 1; n <= 100; n++)
//         {
//             if (n % 15 == 0)
//             {
//                 Console.WriteLine("fizzbuzz");
//             }
//             else if (n % 3 == 0)
//             {
//                 Console.WriteLine("fizz");
//             }
//             else if (n % 5 == 0)
//             {
//                 Console.WriteLine("buzz");
//             }
//             else
//             {
//                 Console.WriteLine(n);
//             }
//         }
//     }
// }
