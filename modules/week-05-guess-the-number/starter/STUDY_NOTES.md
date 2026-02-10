# Week 5: Guess the Number - Study Notes

**Name:** Mateo Minor

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A do-while loop runs once before checking the condition but the while loop checks the condition before it runs even once. Use do while if you need to it to run at least once before checkingl.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: I used do-while in the readintrange to ask the user for a number and keep asking until the answer was valid

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: I used it for the guessing segment so it keeps asking until they guess it correctly

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: I used for loop to reapat the game for the number of rounds the user enters at the start of the program.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: So that I could reuse the same code and not have to write it out multiple times.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: Using the do-while loop and using <>

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: using the readintinrange method so check if the number was between 1-3

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer: using parse to convert what the user enters into an integer and if it failed it ask again.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: using if/else if the answer was above or below the correct answer.

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: using the variable guesscount that increased by one per player guess.

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer: Random and next(min, max) to generate a random number between 1 and the max.

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer: so that the max number is possible becuase it stops at one less

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer: I tested numbers that were invalid.

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer: Getting the loops to work was kind of a pain but they made more sense the more I worked with them.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. How to use all the types of loops.
2. When each of the loops is best applicable.
3. How to randomly generate numbers.
4. How to make a game! this was the first game I made I guess.
5. How to use loops with other loops.

**Which loop felt most natural to use and why?**

Answer: For because it just repeats no condition.

## Time Spent

**Total time:** 6 hours

**Breakdown:**

- Planning the loops: [2 hours]
- Input validation: [1 hours]
- Guessing logic: [1 hours]
- Testing and debugging: [2 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: PLanning the loops because I wasnt sure how to implement them

## Reflection

**What would you do differently next time?**

Answer: I would research more about loops.

**How did using three different loop types improve your understanding of repetition?**

Answer: Because I got so much practice with them and implementing them
