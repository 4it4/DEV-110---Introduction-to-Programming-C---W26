/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

namespace MadLibs;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Mad Libs: Structure + Debugging ===");
        Console.WriteLine();

        bool playAgain;
        do
        {
            StoryTemplate template = ChooseTemplate();
            Console.WriteLine();

            string[] words = CollectWords(template);

            string story = template.GenerateStory(words);
            Console.WriteLine(story);
            Console.WriteLine();

            playAgain = ReadYesNo("Play again? (y/n): ");
            Console.WriteLine();
        }
        while (playAgain);
    }

    // TODO 2: Implement ChooseTemplate
    private static StoryTemplate ChooseTemplate()
    {
        Console.WriteLine("1) Debugging at the Zoo");
        Console.WriteLine("2) The Standup Meeting");

        int choice = ReadIntInRange("Choose a template (1-2): ", 1, 2);

        if (choice == 1)
        {
            return new StoryTemplate(
                "Debugging at the Zoo",
                new string[]
                {
                    "Enter an adjective: ",
                    "Enter a type of animal (plural): ",
                    "Enter a verb ending in -ing: ",
                    "Enter a programming language: ",
                    "Enter a debugging tool: ",
                    "Enter a number: ",
                    "Enter an emotion: ",
                    "Enter an exclamation: "
                },
                "Today at the zoo, a group of {1} were acting very {0}.\n" +
                "They kept {2} near the {3} exhibit, which was very confusing.\n" +
                "A zookeeper used a {4} to investigate and found {5} errors.\n" +
                "Everyone felt {6} about it. \"{7}!\" said the head zookeeper."
            );
        }
        else
        {
            return new StoryTemplate(
                "The Standup Meeting",
                new string[]
                {
                    "Enter a coworker's name: ",
                    "Enter an adjective: ",
                    "Enter a project or feature name: ",
                    "Enter a past-tense verb: ",
                    "Enter a number: ",
                    "Enter a plural noun (work-related): ",
                    "Enter a technical error or bug: ",
                    "Enter a snack food: "
                },
                "At today's standup, {0} gave a very {1} update.\n" +
                "Apparently, the {2} feature was {3} overnight.\n" +
                "There are now {4} open {5}, mostly caused by a {6}.\n" +
                "The team decided to fix it after eating {7}."
            );
        }
    }

    // TODO 3: Implement CollectWords
    private static string[] CollectWords(StoryTemplate template)
    {
        Logger.Info("Collecting words for the story...");

        string[] words = new string[template.Prompts.Length];

        for (int i = 0; i < template.Prompts.Length; i++)
        {
            words[i] = ReadNonEmptyString(template.Prompts[i]);
        }

        Console.WriteLine();
        return words;
    }

    // TODO 4: Implement ReadYesNo
    private static bool ReadYesNo(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim().ToLower();

            if (input == "y") return true;
            if (input == "n") return false;
        }
    }

    // TODO 5: Implement ReadIntInRange
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int result;
        bool valid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            valid = int.TryParse(input, out result) && result >= min && result <= max;
        }
        while (!valid);

        return result;
    }

    // TODO 6: Implement ReadNonEmptyString
    private static string ReadNonEmptyString(string prompt)
    {
        string input;

        do
        {
            Console.Write(prompt);
            input = (Console.ReadLine() ?? string.Empty).Trim();
        }
        while (string.IsNullOrWhiteSpace(input));

        return input;
    }
}
