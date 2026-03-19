# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:** Mateo Minor

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: It rreturns a string. I looped through it to parse each of the habits.

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: it can cause errors.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: It takes a file path and a string and writes each element as its own line in the file.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: Select turns each habit into a CSV string and creates an Ienumberable. ToArray takes that and turns it into a string for WriteAllLines.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: It is an error you get when the program tries to read a file that doesnt exist.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: it catches any unexpected errors that are important for us to know.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. How to work with CSV files.
2. How to use LINQ's Count.
3. How to catch specific things

**What was the trickiest part of this assignment and how did you work through it?**

Answer: Was the loadhabits method it was hard to keep track of everything and get it to work properly.

## Time Spent

**Total time:** 7 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 0.5 hours
- Implementing LoadHabits: 2 hours
- Implementing PrintHabits / PrintSummary: 1 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 2 hours
- Testing and debugging: 1 hours
- Writing study notes: 0.5 hours

**Most time-consuming part:**

Answer:Loadhabits definitely.
