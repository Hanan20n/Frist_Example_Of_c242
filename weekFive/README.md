# 📁 Week Five — Files, Dialogs, Random Numbers, and Load Event in C#

## 📘 Overview | Dulmarka

This week continues the chapter **Loops, Files, and Random Numbers** from *Starting Out with Visual C#*, Sixth Edition. It covers saving and reading text-file data, choosing files through Windows dialog controls, generating random numbers, and using a form's `Load` event.

Toddobaadkan waxaan baranayaa sida program-ku xog ugu kaydiyo text file, dib uga akhriyo, user-kuna u doorto file-ka uu furayo ama meesha uu ku kaydinayo. Waxa kale oo aan baranayaa random numbers iyo `Form Load` event.

## 🎯 Learning Objectives | Ujeeddooyinka

- Explain why applications save data to files.
- Distinguish text files from binary files.
- Use `StreamWriter` to write to a text file.
- Understand `CreateText()` versus `AppendText()`.
- Use `StreamReader` to read text-file data.
- Read a file line by line until `EndOfStream`.
- Use `OpenFileDialog` and `SaveFileDialog`.
- Check whether a user selected OK or Cancel.
- Generate random values with `Random`.
- Describe when the Windows Forms `Load` event occurs.

## 1. Using Files for Data Storage

A program can write data to a file so it can be used later, even after the application closes. The three general steps are:

1. **Open** — establish a connection to the file.
2. **Process** — read data from the file or write data to it.
3. **Close** — finish working with the file and release the connection.

### Text files and binary files

- **Text file:** stores information encoded as text, such as a `.txt` file. Its contents can usually be viewed with a text editor.
- **Binary file:** stores data in a non-text representation that is not normally readable as plain text in a text editor.

This week's chapter material focuses on text files.

## 2. Writing Data with `StreamWriter`

The .NET `StreamWriter` class writes text to a file. The chapter introduces the `File.CreateText()` and `File.AppendText()` methods for creating a writer.

### Using `WriteLine()`

```csharp
StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");

outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");

outputFile.Close();
```

**Explanation | Sharaxaad**

- `StreamWriter outputFile;` declares a variable that can refer to a text writer.
- `File.CreateText("courses.txt")` creates or opens the named file for writing and returns a `StreamWriter`.
- `WriteLine()` writes the text and then adds a new line.
- `Close()` closes the writer connection.

### `Write()` versus `WriteLine()`

- `Write()` writes text without automatically adding a new line.
- `WriteLine()` writes text and then adds a line break.

### `CreateText()` versus `AppendText()`

- `File.CreateText(path)` creates the file if needed. If the file already exists, its existing contents are overwritten.
- `File.AppendText(path)` opens a writer that adds new text to the end of the file rather than erasing existing content.

Example:

```csharp
StreamWriter outputFile = File.AppendText("Names.txt");
outputFile.WriteLine("Lynn");
outputFile.WriteLine("Jamal");
outputFile.WriteLine("Alex");
outputFile.Close();
```

**Important:** Be careful with `CreateText()` because it can erase the existing contents of a file.

### File paths

A path tells the program where the file is located. For example:

```csharp
StreamWriter outputFile = File.AppendText(@"C:\Data\Names.txt");
```

The `@` before the string makes it a verbatim string, which is convenient for Windows paths because backslashes can be written directly. The directory must exist and the application must have permission to write there.

## 3. Reading Data with `StreamReader`

The `StreamReader` class reads text from a file. The chapter introduces `File.OpenText()` as a way to open a text file for reading.

```csharp
StreamReader inputFile;
inputFile = File.OpenText("students.txt");

string line = inputFile.ReadLine();
MessageBox.Show(line);

inputFile.Close();
```

### Reading methods

- `ReadLine()` reads the next line and returns it as a string.
- `Read()` reads the next character (or character value) from the stream.
- `ReadToEnd()` reads the remaining contents of the stream as text.
- `File.ReadAllText(path)` reads the entire file's contents into a string.

### Reading a file line by line

The `EndOfStream` property indicates whether the end of the file has been reached.

```csharp
using (StreamReader inputFile = File.OpenText("students.txt"))
{
    while (!inputFile.EndOfStream)
    {
        string line = inputFile.ReadLine();
        // Process or display the line here.
    }
}
```

**Why use `using`?** It ensures the reader is disposed and the file connection is closed when the block ends, including when an exception occurs. This is a recommended practice for file operations.

## 4. The `OpenFileDialog` Control

`OpenFileDialog` displays the standard Windows **Open** dialog box so the user can choose a file. It is a nonvisual component: it appears in the component tray in the Windows Forms Designer rather than as a visible control on the form.

```csharp
if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    string selectedPath = openFileDialog.FileName;
    // Use selectedPath to open the selected file.
}
```

- `ShowDialog()` displays the dialog and returns a `DialogResult`.
- `DialogResult.OK` means the user confirmed a selection.
- `DialogResult.Cancel` means the user cancelled.
- `FileName` contains the selected file's full path.
- `InitialDirectory` can specify the folder shown when the dialog opens.

Example:

```csharp
openFileDialog.InitialDirectory = @"C:\Data";

if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    using (StreamReader inputFile =
           File.OpenText(openFileDialog.FileName))
    {
        string contents = inputFile.ReadToEnd();
        MessageBox.Show(contents);
    }
}
```

The selected path is used only after the user clicks OK.

## 5. The `SaveFileDialog` Control

`SaveFileDialog` displays a standard Windows **Save As** dialog box. It lets the user choose a filename and location instead of hard-coding a path.

```csharp
if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
    using (StreamWriter outputFile =
           File.CreateText(saveFileDialog.FileName))
    {
        outputFile.WriteLine("My saved text");
    }
}
```

- Call `ShowDialog()` to display the dialog.
- Check for `DialogResult.OK` before saving.
- Use `FileName` to get the chosen path.
- Use `File.CreateText()` when creating/replacing a file is intended; use an append method if the goal is to add to existing text.

## 6. Random Numbers with the `Random` Class

C# provides the `Random` class to generate pseudo-random values.

```csharp
Random rand = new Random();

int number1 = rand.Next();
double number2 = rand.NextDouble();
```

- `Next()` returns a non-negative integer.
- `NextDouble()` returns a floating-point value greater than or equal to 0.0 and less than 1.0.

### Choosing a range with `Next()`

```csharp
Random rand = new Random();
int number = rand.Next(100);
```

`rand.Next(100)` returns an integer from **0 through 99**, because the upper bound is excluded.

For a range such as 1 through 10 inclusive:

```csharp
int number = rand.Next(1, 11);
```

The lower bound is included and the upper bound is excluded, so this produces values 1–10.

## 7. The Windows Forms `Load` Event

When a form is being loaded into memory, its `Load` event occurs. Code in the form's Load event handler runs as the form loads, before the form is first displayed.

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}
```

You can create a Load event handler by double-clicking the form's background in the Windows Forms Designer, then writing initialization code inside the generated method.

Common uses include setting initial values, loading file data, or preparing controls before the user starts interacting with the form.

## 🧪 Practice Exercises

1. Create a text file named `courses.txt` and write three course names using `WriteLine()`.
2. Explain what happens if `CreateText()` is used when the file already exists.
3. Change the example to use `AppendText()`. Explain the difference in the result.
4. Read and display each line in `students.txt` using `StreamReader` and `EndOfStream`.
5. Add an `OpenFileDialog` and show the selected file's contents only when the result is `DialogResult.OK`.
6. Use `SaveFileDialog` to let the user choose where to save a text file.
7. Generate a random integer from 1 through 6, like a dice roll.
8. Give one example of code that belongs in a form's `Load` event.

## ⚠️ Common Mistakes

- Forgetting to close or dispose a reader/writer.
- Using `CreateText()` unintentionally and overwriting a file.
- Reading a file path that does not exist.
- Accessing the selected filename without checking the dialog result.
- Assuming `Next(100)` can return 100; it cannot.
- Placing code in an event handler that is never connected to the form's Load event.

## 🎓 Learning Outcome | Natiijada

By the end of this week, I should be able to save and read text data, let a user choose a file, generate random numbers within a specified range, and initialize a Windows Forms application in its Load event.

Toddobaadkan waxaan ku tababartay file storage, `StreamWriter`, `StreamReader`, file dialogs, random numbers, iyo `Load` event.

---

**Course:** C# Programming I  
**Section:** Week Five — Files, Dialogs, Random Numbers, and Load Event  
**Source:** Chapter 4 PowerPoint, *Starting Out with Visual C#*, Sixth Edition  
**Purpose:** Study notes and practice
