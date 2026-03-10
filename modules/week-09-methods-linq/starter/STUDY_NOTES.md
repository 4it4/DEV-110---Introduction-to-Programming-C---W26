# Week 9: Score Stats (Methods + LINQ) - Study Notes

**Name:** Mateo Minor

## Methods and Decomposition

**Why is it helpful to break a program into small methods?**
[Think about readability, testing, and debugging]

Answer: Each method does one job, making code easier to read. Bugs are easier to find when logic is isolated. Small methods can be tested and reused independently.

## LINQ (Stats + Method Chaining)

**Which LINQ methods did you use for basic statistics?**
[Examples: Min, Max, Average, Count with predicates]

Answer: `Min()`, `Max()`, `Average()`, and `Count(predicate)` to get passing and failing totals.

**Which LINQ methods did you chain together for reports?**
[Examples: Where + OrderByDescending, OrderByDescending + Take]

Answer: `Where + OrderByDescending` for passing/failing scores. `OrderByDescending + Take` for top scores.

**Why is it helpful to put score logic in a class (ScoreReport) instead of keeping everything in Program?**
[Think about organization, reuse, and readability]

Answer: It keeps `Program` clean. The report logic is reusable and easy to find. Related methods stay grouped together.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. LINQ methods
2. Count()
3. Orchestrator methods
4. CultureInfo.InvariantCulture
5. Encapsulating logic in a class

**Which concept felt easiest (methods or LINQ) and why?**

Answer: Methods felt easiest. Breaking code into named steps is intuitive. LINQ chaining required more practice to read fluently.

## Time Spent

**Total time:** 7 hours

**Breakdown:**

- Understanding the starter code: 1 hours
- Implementing the print methods: 3 hour
- LINQ method chaining: 1 hours
- Testing and debugging: 1 hours
- Writing documentation: 1 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Implementing the print methods took the longest. Getting the output format exactly right required careful attention to spacing and labels.

## Reflection

**What would you improve next time?**

Answer: Read the expected output more carefully before coding. Small formatting details caused most of my re-runs.

**How did methods make this program easier to work on?**

Answer: Each method was a small, focused task. I could implement and test one at a time without touching the rest of the program.
