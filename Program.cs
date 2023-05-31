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

// Dinner party

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Guest> guests = GetGuests();
        Dictionary<string, List<Guest>> tables = new Dictionary<string, List<Guest>>
        {
            { "Table 1", new List<Guest>() },
            { "Table 2", new List<Guest>() }
        };

        foreach (Guest guest in guests)
        {
            List<string> table1Occupations = tables["Table 1"].ConvertAll(g => g.Occupation);
            if (table1Occupations.Contains(guest.Occupation))
            {
                tables["Table 2"].Add(guest);
            }
            else
            {
                tables["Table 1"].Add(guest);
            }
        }

        foreach (string tableName in tables.Keys)
        {
            List<Guest> tableGuests = tables[tableName];
            Console.WriteLine(tableName);
            foreach (Guest guest in tableGuests)
            {
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }
        }
    }

    static List<Guest> GetGuests()
    {
        return new List<Guest>
        {
            new Guest
            {
                Name = "Marilyn Monroe",
                Occupation = "entertainer",
                Bio = "(1926 - 1962) American actress, singer, model"
            },
            new Guest
            {
                Name = "Abraham Lincoln",
                Occupation = "politician",
                Bio = "(1809 - 1865) US President during American civil war"
            },
            new Guest
            {
                Name = "Martin Luther King",
                Occupation = "activist",
                Bio = "(1929 - 1968)  American civil rights campaigner"
            },
            new Guest
            {
                Name = "Rosa Parks",
                Occupation = "activist",
                Bio = "(1913 - 2005)  American civil rights activist"
            },
            new Guest
            {
                Name = "Peter Sellers",
                Occupation = "entertainer",
                Bio = "(1925 - 1980) British actor and comedian"
            },
            new Guest
            {
                Name = "Alan Turing",
                Occupation = "computer scientist",
                Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
            },
            new Guest
            {
                Name = "Admiral Grace Hopper",
                Occupation = "computer scientist",
                Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
            },
            new Guest
            {
                Name = "Indira Gandhi",
                Occupation = "politician",
                Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"
            }
        };
    }
}

class Guest
{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public string Bio { get; set; }
}
