# 📂 Week Four — File Handling in C#

## 📌 Overview | Dulmarka

This folder contains my **Week Four C# practice** focused on working with text files in a Windows Forms Application.

Toddobaadkan waxaan ku tababaranayaa sida C# loogu akhriyo xogta text file, looga saaro item gaar ah, iyo sida loo tirtiro file dhan. Waxaan sidoo kale baranayaa sida file operations loogu xiro Windows Forms controls sida `Button`, `ListBox`, iyo `MessageBox`.

## 🎯 Learning Objectives | Ujeeddooyinka

- Understand basic file handling using the `System.IO` namespace.
- Read text files using different methods.
- Check whether a file exists before using it.
- Remove a selected item from a text file.
- Delete a complete file after user confirmation.
- Display file contents and messages in a Windows Forms interface.

## 🧰 Methods Practiced | Methods-ka La Tababartay

### 1. `StreamReader` and `File.OpenText()`

These are used to open and read a text file one line at a time.

Waxaa la adeegsadaa `ReadLine()` si line kasta loo akhriyo, halka `EndOfStream` lagu hubiyo in dhammaadka file-ka la gaaray.

### 2. `File.ReadAllLines()`

Reads all lines from a text file and returns them as a string array (`string[]`).

Method-kan wuxuu xogta oo dhan hal mar ugu soo qaadaa array, kadibna `ListBox.Items.AddRange()` ayaa lagu soo bandhigi karaa.

### 3. `File.ReadLines()`

Reads a file as a sequence of lines, which can be processed using `foreach`.

Habkani wuxuu kuu oggolaanayaa inaad line kasta si isdaba-joog ah u process-gareyso, wuxuuna ku habboonaan karaa files waaweyn marka aan loo baahnayn in dhammaan lines-ka hal mar memory-ga la geliyo.

### 4. `File.Exists()`

Checks whether a file exists at the specified path.

Waxaa la isticmaalaa ka hor reading ama deleting si loo hubiyo in file-ku jiro, loogana fogaado in operation lagu sameeyo file aan la helin.

### 5. Deleting a Selected Item

The program reads the file lines into a list, removes the selected item, and writes the remaining lines back to the file.

`ListBox.SelectedItem` wuxuu soo helayaa item-ka user-ku doortay. `Remove()` ayaa item-kaas ka saaraya list-ka, halka `File.WriteAllLines()` dib ugu kaydinayo xogta hadhay.

### 6. `File.Delete()`

Deletes the entire file from the specified location.

Ka hor inta aan file-ka la tirtirin, program-ku wuxuu user-ka weydiinayaa confirmation isagoo adeegsanaya `MessageBox.Show()` iyo `DialogResult`. Haddii user-ku doorto `Yes`, file-ka waa la tirtirayaa.

## 🖥️ Application Features | Waxyaabaha App-ku Qabanayo

- Read file contents using three different methods.
- Display text-file lines in a `ListBox`.
- Check file existence using `File.Exists()`.
- Delete a selected line/item from the file.
- Ask for confirmation before deleting the entire file.
- Show success and error messages through `MessageBox`.

## 🛠️ Technologies Used

- **Language:** C#
- **Application Type:** Windows Forms
- **IDE:** Microsoft Visual Studio
- **Namespace:** `System.IO`
- **File Format:** `.txt`

## ▶️ How to Run | Sida Loo Socodsiiyo

1. Open the project in **Microsoft Visual Studio**.
2. Make sure the text file exists at the path assigned to `filePath`.
3. Build and run the Windows Forms Application.
4. Use the reading buttons to display file contents.
5. Select an item in the `ListBox` before clicking **Delete Selected Item**.
6. Only click **Delete Entire File** when you really intend to delete the file.

## ⚠️ Important Notes | Qodobo Muhiim ah

- The `filePath` variable must point to a valid location on your computer.
- An absolute file path from one computer may not work on another computer.
- Deleting the entire file is a permanent action unless a backup exists.
- Use a `using` statement with `StreamReader` to ensure the file is closed properly, even if an error occurs.
- Clear the `ListBox` before loading the file again to avoid duplicate displayed items.

## 🎓 Learning Outcome | Waxa Aan Bartay

By practicing these methods, I am learning how to work with text files in C# and connect file operations to a graphical user interface.

Waxaan ku tababartay file reading, checking file existence, deleting individual items, deleting a complete file, iyo isticmaalka `ListBox` iyo `MessageBox` si application-ku ula falgalo user-ka.

---

**Course:** C# Programming I  
**Section:** Week Four — File Handling  
**Purpose:** Practice and learning
