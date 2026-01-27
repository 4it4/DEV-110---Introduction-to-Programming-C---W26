# Week 2: Calculator Lite - Study Notes

**Name:** Mateo Minor

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer: Strings store characters, bools store true or false, integers store numbers without decimals, and doubles store numbers with decimals.

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: Integers cannot store decimals while doubles can, so doubles allow more accurate calculations with decimal numbers.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: I compared the user's input to "yes"; if it matches, I set the boolean to true, otherwise false.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: The hardest part was converting the yes/no input into a boolean and switching the calculations based on the choice.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I watched the lecture, read documentation, and tested different approaches until I got the calculator working correctly.

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: Understanding how to switch calculations depending on whether the user chose decimal precision or not.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: Division (/) gives the quotient of a division, while modulus (%) gives the remainder. For example, 5 / 2 = 2, 5 % 2 = 1.

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: Add the two numbers together and divide the sum by 2.

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: Subtract the second number from the first, divide by the first number, and multiply by 100.

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: Console.ReadLine() allows the user to type input, which is returned as a string.

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: I used int.Parse() and double.Parse() to convert the input string into a number for calculations.

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: I did not use string interpolation in my calculator.

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: :F2 formats the number to 2 decimal places, :F0 rounds to a whole number.

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: Dividing by zero causes an error, so I check if the second number is zero and skip the calculation if it is.

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: I used if/else to select either integer or double calculations and formatting depending on whether the user wanted decimals.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. Syntax
2. Data types
3. Parsing input
4. Conditional logic (if/else)
5. Debugging

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: Integers were interesting because they represent whole numbers, but booleans were also interesting for controlling logic.

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: Users may only want whole numbers in some cases, and decimal precision can make the output more accurate when needed.

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: I tested positive numbers, negative numbers, zero, and decimals.

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: Many syntax errors and type errors. I fixed them by debugging and reading documentation carefully.

## Time Spent

**Total time:** 17 hours

**Breakdown:**

- Understanding data types: 1 hour
- Reading and parsing user input: 4 hours
- Implementing arithmetic operations: 2 hours
- Adding conditional formatting: 4 hours
- Handling division by zero: 1 hour
- Testing and debugging: 4 hours
- Writing documentation: 1 hour

**Most time-consuming part:** Debugging, because it took time to find and fix errors.

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: I would start planning the conditional logic earlier to avoid confusion later.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: It teaches debugging, problem solving, and working with different data types and user input, which are essential for larger programs.
