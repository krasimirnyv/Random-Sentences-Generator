namespace RandomSentencesGenerator;

class RandomSentencesGenerator
{
    static void Main(string[] args)
    {
        string[] names = { "Peter", "Michell", "Jane", "Steve" };
        string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas" };
        string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
        string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
        string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
        string[] details = { "near the river", "at home", "in the park" };

        Console.WriteLine("Welcome to Random sentences generator!\n\n" +
                          "This is your first random generated sentence: ");
        while (true)
        {
            string randomName = GetRandomWord(names);
            string randomPlace = GetRandomWord(places);
            string randomAdverb = GetRandomWord(adverbs);
            string randomVerb = GetRandomWord(verbs);
            string randomNoun = GetRandomWord(nouns);
            string randomDetail = GetRandomWord(details);

            string whoFromWhere = $"{randomName} from {randomPlace}";
            string action = $"{randomAdverb} {randomVerb} {randomNoun}";
            string sentence = $"{whoFromWhere} {action} {randomDetail}.";
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{sentence}");
            Console.ResetColor();
            Console.WriteLine("Press ENTER/RETURN to generate a new random sentence.");
            Console.ReadLine();
        }
    }

    public static string GetRandomWord(string[] words)
    {
        Random random = new Random();
        int randomIndex = random.Next(words.Length);
        string word = words[randomIndex];
        return word;
    }
}