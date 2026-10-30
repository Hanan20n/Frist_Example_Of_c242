# 🔁 Week Four — Loops in C#

## 📘 Overview | Dulmarka

This week focuses on **loops** in C#, which allow a program to repeat instructions while a condition is true or for a planned number of repetitions.

Toddobaadkan waxaan baranayaa **loops**: sida amarro (statements) marar badan loo fuliyo anigoon isla code-ka mar kasta dib u qorin. Chapter-ka PowerPoint-ku wuxuu daboolayaa `while`, `++` iyo `--`, `for`, iyo `do-while`.

## 🎯 Learning Objectives | Ujeeddooyinka

- Explain what a loop is and why it is useful.
- Use a `while` loop and understand its condition.
- Identify and prevent infinite loops.
- Increment and decrement variables using `++` and `--`.
- Explain prefix and postfix notation.
- Use `for` loops with initialization, test, and update expressions.
- Use a `do-while` loop and compare it with `while`.

## 1. What Is a Loop? | Waa maxay Loop?

A **loop** repeats a statement or a group of statements. Instead of writing the same instruction several times, we write it once inside a loop.

Tusaale ahaan, haddii aan rabo inaan “Hello” soo bandhigo shan jeer, loop ayaa iga caawinaya inaan hal mar qoro code-ka oo uu program-ku ku celiyo.

## 2. The `while` Loop

A `while` loop repeats its body as long as its Boolean condition is `true`. It is a **pretest loop** because it checks the condition before executing the body.

```csharp
int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
    count++;
}
```

**Step-by-step | Tallaabo-tallaabo**

1. `int count = 0;` creates a counter variable and starts it at zero.
2. `count < 5` checks whether the counter is less than five.
3. If the condition is true, the message appears.
4. `count++` increases the counter by one.
5. The condition is checked again. When `count` becomes 5, the condition is false and the loop stops.

This loop displays the message five times.

### When the condition starts as false

```csharp
int count = 5;

while (count < 5)
{
    MessageBox.Show("Hello");
    count++;
}
```

The body does not execute even once because `5 < 5` is false at the beginning.

### Infinite loops | Loop aan dhammaanayn

An **infinite loop** continues indefinitely because its stopping condition never becomes false. A common mistake is forgetting to update the counter.

```csharp
int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
    // Mistake: count is never increased.
}
```

**Important:** Always check that something inside the loop changes the condition, or make sure the loop has a clear exit.

## 3. Increment and Decrement Operators

- `count++` increases the value by 1.
- `count--` decreases the value by 1.
- `count += 1` is another way to add 1.
- `count -= 1` is another way to subtract 1.
- `count = count + 1` and `count = count - 1` express the same basic changes.

Example:

```csharp
int count = 3;
count++; // count is now 4
count--; // count is now 3 again
```

### Prefix versus postfix

- **Postfix:** `count++` — the current value is used first in an expression, then incremented.
- **Prefix:** `++count` — the value is incremented first, then used in the expression.

When these operators are used alone on a line, both increase the variable by one. The difference matters when the operator is part of a larger expression.

## 4. The `for` Loop

A `for` loop is useful when a counter controls how many times a loop repeats. Its header contains three parts:

```csharp
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
```

- **Initialization:** `int count = 0` runs once at the start.
- **Test:** `count < 5` is checked before each iteration.
- **Update:** `count++` increases the counter after the body runs.

The example displays “Hello” five times, with counter values 0, 1, 2, 3, and 4.

### Other update expressions

Count by tens:

```csharp
for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}
```

Count backwards:

```csharp
for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}
```

`ToString()` converts the number into text so it can be passed to `MessageBox.Show()`.

## 5. The `do-while` Loop

A `do-while` loop is a **posttest loop**: it executes the body first, then checks the condition. Therefore, its body always executes at least once.

```csharp
int number = 1;

do
{
    MessageBox.Show(number.ToString());
} while (number < 0);
```

The message appears once even though `number < 0` is false, because the condition is checked after the body.

Compare it with:

```csharp
int number = 1;

while (number < 0)
{
    MessageBox.Show(number.ToString());
}
```

This `while` loop displays nothing because it checks the false condition before entering the body.

**Syntax note:** A `do-while` statement ends with a semicolon after the condition: `} while (condition);`

## 6. Choosing the Right Loop

| Loop | Condition checked | Runs at least once? | Common use |
|---|---|---|---|
| `while` | Before the body | No | Repeat while a condition remains true |
| `for` | Before the body | No | Repeat using a counter |
| `do-while` | After the body | Yes | Run once before deciding whether to repeat |

## 🧪 Practice Exercises

1. Write a `while` loop that displays numbers 1 through 5.
2. Write a `for` loop that displays even numbers from 2 through 20.
3. Write a `for` loop that counts down from 10 to 0.
4. Predict whether a `while` loop with condition `count < 0` runs when `count = 0`.
5. Explain why the `do-while` example executes once but the similar `while` example does not.
6. Find and fix the error in an infinite loop where the counter is never updated.

## ⚠️ Common Mistakes

- Forgetting to increment or decrement the counter.
- Using the wrong comparison operator, such as `<` instead of `<=`.
- Updating a counter in a way that can never make the condition false.
- Forgetting the semicolon at the end of a `do-while` statement.
- Assuming a `while` loop always runs at least once.

## 🎓 Learning Outcome | Natiijada

By the end of this week, I should be able to choose between `while`, `for`, and `do-while`, trace loop execution, use counter operators, and recognize infinite-loop mistakes.

Toddobaadkan waxaan ku tababartay sida loops-ku u shaqeeyaan, sida counter loo isticmaalo, iyo farqiga u dhexeeya **pretest** iyo **posttest** loops.

---

**Course:** C# Programming I  
**Section:** Week Four — Loops  
**Source:** Chapter 4 PowerPoint, *Starting Out with Visual C#*, Sixth Edition  
**Purpose:** Study notes and practice
