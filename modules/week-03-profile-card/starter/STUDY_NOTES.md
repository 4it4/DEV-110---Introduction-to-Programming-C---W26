# Week 3: Personal Profile Card - Study Notes

**Name:** Mateo Minor

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer: Strings, Integers, doubles, and booleans. Strings store a string of characters, Integers store whole no decimal numbers, doubles store decimal numbers, and bool stores true or false.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: Double was used for GPA because GPA requires decimal precision.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: I was able to convert the users yes no input into a boolean by making "yes" equal to true.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: I followed the example as they were already grouped up logically. I did move favorite number into personal because they made more sense as it is not a calculation.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: I calculated their birthyear, Years until graduation, and their age in months.

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: Because we want the user to do as little work as neccesary. We can easily have the program calculate that information for them.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: I would say that the hardest part of this assignment was figuring out how do calculations with different data types.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: I had to convert the double of their height in inches into an integer but I am think the method I chose converts it into an integer after the calculation.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: I would say that the most confusing part is getting booleans to do anything for me. I have to do a lot of research to figure out how to do anything with them.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: Parse methods like int.Parse() and double.Parse() converts the string it recieves from the user input into the desired data type.

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: The one that was listed in the program file. feet = inches / 12, remaining = inches % 12.

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: The boolean is checking if the gpa is above 3.5 and if it is it becomes true.

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: by putting :F2 in the line that writes it to the user in the console. That limits the double to only display 2 decimal places.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: I used an if else statement because I felt like that was a good solution.

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I used empty Console.Writelines(); to add "padding" underneatht he categories.

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: I am not sure how many calculations you can make with the given user information. You could give them semesters left?

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: It is important because of how it interacts with the calculations.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: You have to sign up for a lot of things and sign ups usually ask for stuff like this.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. Really getting down that syntax.
2. Converting data types for equations.
3. Making sure I know how to limit how many decimals are displayed when reading a double.
4. How to format information presented in console.
5. How to trouble shoot more effectively.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: Bool is so hard to get to write to console with something specifically or parse from the users input. They can type anything and I have to figure out how to make it true or false.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: Understanding data types helps writing better programs because you can create cleaner code and run into less errors if you are able to perform operations better. Instead of having to jump through hoops to get isfulltimegrad to cooperate as a string I can just use a bool.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: I tried decimals and negatives and nothing breaks the program.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: There were some bugs caused by syntax errors and forgetting how to properly use if else statements.

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: While I was coding I had them output to the console until I was able to get everything to print correctly before packaging it nicely for the user.

## Time Spent

**Total time:** 8 hours

**Breakdown:**

-   Understanding data types and planning variables: [1 hours]
-   Collecting user input with correct types: [3 hours]
-   Implementing calculations: [1 hours]
-   Formatting output: [1 hours]
-   Testing and debugging: [1 hours]
-   Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Collecting user input because I had to figure out how to parse everything and how to prepare it for the calculations.

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: I wouldn't do anything differently. Maybe study more on booleans.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: The program is very scalable there is a lot of things you can add without running into annoying roadblocks or bottlenecks.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: I would like to model a shopping cart that sounds interesting.
