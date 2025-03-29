using System.Text.Json;

namespace RandomSentencesGenerator;

class RandomSentencesGenerator
{
    static void Main(string[] args)
    {
        string json = File.ReadAllText("data.json");
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        SentenceData data = JsonSerializer.Deserialize<SentenceData>(json, options);
        
        string[] names = data.Names?.ToArray() ?? Array.Empty<string>();
        string[] places = data.Places?.ToArray() ?? Array.Empty<string>();
        string[] adverbs = data.Adverbs?.ToArray() ?? Array.Empty<string>();
        string[] verbs = data.Verbs?.ToArray() ?? Array.Empty<string>();
        string[] nouns = data.Nouns?.ToArray() ?? Array.Empty<string>();
        string[] details = data.Details?.ToArray() ?? Array.Empty<string>();
        
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

class SentenceData
{
    public List<string> Names { get; set; }
    public List<string> Places { get; set; }
    public List<string> Adverbs { get; set; }
    public List<string> Verbs { get; set; }
    public List<string> Nouns { get; set; }
    public List<string> Details { get; set; }
}