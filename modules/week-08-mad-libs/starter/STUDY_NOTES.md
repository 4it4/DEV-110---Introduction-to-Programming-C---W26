# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Mateo Minor

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer: ChooseTemplate displays the two options and returns the selected StoryTemplate. CollectWords loops through each prompt and returns the user's answers as an array. ReadYesNo keeps asking until the user enters "y" or "n". ReadIntInRange keeps asking until the user enters a valid integer within the given range. ReadNonEmptyString keeps asking until the user enters a non-empty string.

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: It keeps Main short and easy to follow — you can see the overall flow at a glance without wading through details. Each method has one job, so if something breaks, you know exactly where to look.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: It holds the title, the list of prompts, and the template text for a story. Grouping these three things together means the rest of the program only needs to know about one object instead of three separate variables.

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: Both stories go through the exact same CollectWords and GenerateStory logic — only the data inside the template is different. Adding a third story would just mean creating another StoryTemplate object, with no changes to the core logic.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer: Inside GenerateStory, at the string.Format call in FormatStory. That's the point where the user's words get combined with the template text, so it's the most useful place to inspect what's going in and what's coming out.

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer: It made the execution order obvious — I could see exactly when each method was called and what values the variables held at each step. It removed a lot of guesswork about why the output looked a certain way.

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer: I initially forgot to cast string[] to object[] before passing it to string.Format, which caused a runtime error. Stepping through FormatStory in the debugger showed the issue immediately, and the fix was a one-line cast: object[] objects = words;.

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1. Splitting code into small, focused methods makes both reading and debugging much easier.
2. Classes let you bundle related data and behavior so the rest of your program stays simple.
3. Input validation loops are essential — users will always enter something unexpected.

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer: Writing the input helper methods (ReadIntInRange, ReadNonEmptyString, ReadYesNo) made it click. Once those existed, CollectWords and ChooseTemplate became very clean because all the messy validation logic was already handled elsewhere.

## Time Spent

**Total time:** 6

**Breakdown:**

- Planning structure (methods/classes): 1
- Input validation: 1
- Story templates + formatting: 1
- Testing and debugging: 2
- Writing documentation: 1

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: testing because getting the string.Format placeholders lined up correctly with the right prompts required careful counting and testing.

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: I'd add more templates and let the user pick from a longer menu. I'd also add a Logger.Debug call inside FormatStory to print the formatted story before returning it, which would make debugging easier in future assignments.

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: When a test failed, I could isolate which method was responsible right away. For example, if the story output was wrong, I knew to look at GenerateStory and FormatStory — not at the input or loop logic. Smaller methods mean smaller places to search.
