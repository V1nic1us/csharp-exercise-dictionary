namespace csharp_exercise_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new dictionary
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\viniv\\source\\repos\\csharp-exercise-dictionary\\csharp-exercise-dictionary\\votes.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] parts = line.Split(' ');
                        string name = parts[0];
                        int votes = int.Parse(parts[1]);
                        if (myDictionary.ContainsKey(name))
                        {
                            int vote = myDictionary[name];
                            myDictionary[name] = votes + vote;
                        }
                        else
                        {
                            myDictionary.Add(name, votes);
                        }
                    }
                }
                int n = 0;
                foreach (var item in myDictionary)
                {
                    n += item.Value;
                    Console.WriteLine($"{item.Key} {item.Value}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}