namespace G_NET_88_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //List<int> grades = new List<int>();
            //grades = [85, 92, 78, 95, 88, 70, 100, 65];

            //Console.WriteLine(grades.Count());
            //Console.WriteLine(grades[7]);
            //Console.WriteLine(grades[1]);
            //Console.WriteLine(grades.Last());
            //Console.WriteLine(grades.First());

            //grades.Sort();

            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}


            //Console.WriteLine(grades.Find(x => x >90));



            //List<int> number = grades.FindAll(x => x > 75);

            //foreach (int grade in number)
            //{
            //    Console.WriteLine(grade);
            //}


            //int number = grades.RemoveAll(x => x < 75);

            //bool has100 = grades.Any(x => x == 100);

            //List<string> gradeStrings = grades.Select(x => $"Grade: {x}").ToList(); 
            #endregion
            #region Question2
            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");


            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine($"Score: {player.Key}, Player: {player.Value}");
            //}

            //int firstKey = leaderboard.First().Key;
            //string firstValue = leaderboard.First().Value;

            //Console.WriteLine( firstKey);
            //Console.WriteLine(firstValue);

            //bool scoreExists = leaderboard.ContainsKey(500);

            //Console.WriteLine(scoreExists);



            //if (leaderboard.TryGetValue(500, out string playerName))
            //{
            //    Console.WriteLine($"Player with score 999: {playerName}");
            //}
            //else
            //{
            //    Console.WriteLine("No player with score 999");
            //}

            //leaderboard.Remove(200);


            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine($"Score: {player.Key}, Player: {player.Value}");
            //}
            #endregion
            #region Question3
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>
            //      {
            //             { "Ahmed", "01012345678" },
            //             { "Sara", "01123456789" },
            //             { "Ali", "01234567890" },
            //             { "Mona", "01512345678" }
            //      };

            //phoneBook["Omar"] = "01098765432";


            //try
            //{
            //    phoneBook.Add("Ahmed", "01111111111");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //bool added = phoneBook.TryAdd("Ahmed", "01111111111");

            //Console.WriteLine(added);

            //string searchName = "Hassan";

            //if (phoneBook.ContainsKey(searchName))
            //{
            //    Console.WriteLine(searchName + " exists");
            //}
            //else
            //{
            //    Console.WriteLine(searchName + " doesn't exist");
            //}

            //string name = "Hassan";

            //if (phoneBook.TryGetValue(name, out string phone))
            //{
            //    Console.WriteLine("Phone: " + phone);
            //}
            //else
            //{
            //    Console.WriteLine("Phone: Not Found");
            //}


            //Console.WriteLine(string.Join(", ", phoneBook.Keys));
            //Console.WriteLine(string.Join(", ",phoneBook.Values));



            #endregion
            #region Question4
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");


            //Console.WriteLine(emails.Count);

            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            //HashSet<int> union = new HashSet<int>(setA);
            //union.UnionWith(setB);

            //Console.WriteLine(string.Join(", ", union));

            //HashSet<int> intersection = new HashSet<int>(setA);
            //intersection.IntersectWith(setB);
            //Console.WriteLine(string.Join(", ", intersection));


            //HashSet<int> except = new HashSet<int>(setA);
            //except.ExceptWith(setB);

            //Console.WriteLine(string.Join(", ", except));

            //HashSet<int> subset = new HashSet<int> { 1, 2 };

            //bool isSubset = subset.IsSubsetOf(setA);

            //Console.WriteLine(isSubset);

            #endregion

        }

    }
}

