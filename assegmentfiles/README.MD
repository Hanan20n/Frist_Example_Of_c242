# 📂 Research Other Methods Using Files in C#

## 📌 Project Overview | Dulmarka Mashruuca

This project is a **C# Windows Forms Application** created to practice different file-handling methods in C#.

Mashruucan waxaa loo sameeyay in lagu barto sida loo akhriyo, loo maamulo, loona tirtiro xogta ku jirta text file iyadoo la adeegsanayo `System.IO` namespace iyo Windows Forms controls.

The application demonstrates different approaches to reading files, deleting individual items, and deleting an entire file.

## 🎯 Project Objectives | Ujeeddooyinka Mashruuca

Mashruucan ujeeddooyinkiisu waa in la barto:

- Sida loo akhriyo xogta ku jirta text file.
- Sida loo isticmaalo `StreamReader`, `ReadAllLines()`, iyo `ReadLines()`.
- Sida loo hubiyo in file-ku jiro iyadoo la adeegsanayo `File.Exists()`.
- Sida loo tirtiro item gaar ah oo ku jira file.
- Sida loo tirtiro file dhan iyadoo la adeegsanayo `File.Delete()`.
- Sida loo isticmaalo `ListBox` si xogta file-ka loogu soo bandhigo GUI.
- Sida loo isticmaalo `MessageBox` si user-ka loo siiyo fariimo iyo confirmation dialogs.

## 🛠️ Technologies Used | Teknoolojiyada La Adeegsaday

- **Programming Language:** C#
- **Framework:** Windows Forms
- **IDE:** Microsoft Visual Studio
- **Namespace:** `System.IO`
- **File Type:** `.txt`

## 📖 Methods Explained | Sharaxaadda Methods-ka

### 1. `StreamReader`

This method reads a text file one line at a time.

Method-kan wuxuu file-ka u akhriyaa line kasta si gooni ah. Waxaa la adeegsaday `ReadLine()` si loo akhriyo line-ka, iyo `EndOfStream` si loo hubiyo in dhammaadka file-ka la gaaray iyo in kale.

**Code concepts:** `File.OpenText()`, `ReadLine()`, `EndOfStream`, and `Close()`.

### 2. `ReadAllLines()`

This method reads all lines from a file and stores them in a string array.

Method-kan wuxuu hal mar akhriyaa dhammaan lines-ka file-ka, kadibna wuxuu ku kaydiyaa `string[]` array. Waxaa loo adeegsaday `AddRange()` si dhammaan lines-ka loogu daro `ListBox`.

**Code concepts:** `File.ReadAllLines()`, `string[]`, and `Items.AddRange()`.

### 3. `ReadLines()`

This method reads the file as a sequence of lines.

`ReadLines()` wuxuu kuu oggolaanayaa inaad lines-ka mid-mid u process-gareyso adigoo adeegsanaya `foreach`. Habkani wuxuu faa'iido u yeelan karaa files waaweyn, sababtoo ah uma baahna in dhammaan lines-ka hal mar lagu kaydiyo array.

**Code concepts:** `File.ReadLines()` and `foreach`.

### 4. Delete Selected Item

This method deletes a specific item selected by the user from the file.

Marka user-ku item ka doorto `ListBox`, program-ku wuxuu xogta file-ka ku akhriyaa `List<string>`, kadibna wuxuu isticmaalaa `Remove()` si uu uga saaro item-ka la doortay.

Haddii item-ka la helo, xogta hadhay waxaa dib loogu qoraa file-ka iyadoo la adeegsanayo `File.WriteAllLines()`.

**Code concepts:** `SelectedItem`, `File.ReadAllLines()`, `ToList()`, `Remove()`, and `File.WriteAllLines()`.

### 5. Delete Entire File

This method deletes the complete text file after user confirmation.

Program-ku wuxuu marka hore hubiyaa in file-ku jiro. Kadib wuxuu soo bandhigayaa `MessageBox` leh `Yes` iyo `No`, si user-ku u xaqiijiyo ficilka.

Haddii user-ku doorto `Yes`, waxaa la adeegsadaa `File.Delete()` si file-ka oo dhan loo tirtiro, waxaana la nadiifiyaa `ListBox`.

**Code concepts:** `File.Exists()`, `MessageBox.Show()`, `DialogResult`, `File.Delete()`, and `Items.Clear()`.

## 🖥️ Application Features | Waxyaabaha uu App-ku Qabanayo

- 📄 Read file contents using different methods.
- 📋 Display file contents inside a `ListBox`.
- 🔎 Check whether a file exists before performing operations.
- 🗑️ Delete a selected item from the file.
- ⚠️ Ask for confirmation before deleting the entire file.
- 💬 Display success, error, and confirmation messages.

## 📁 Project Structure | Qaab-dhismeedka Mashruuca

```text
Research_other_methods_using_files/
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── Home Practice.txt
└── README.md
```

**Note:** `Home Practice.txt` waa file-ka xogta lagu kaydiyo. Waa inuu ku yaallaa path-ka uu program-ku isticmaalayo, ama waa in `filePath` loo beddelaa path sax ah oo kombiyuutarkaaga ku habboon.

## ▶️ How to Run the Project | Sida Loo Socodsiiyo

1. Open Microsoft Visual Studio.
2. Open the C# Windows Forms project.
3. Ensure that the text file exists at the specified `filePath`.
4. Build the project using **Build Solution**.
5. Run the application using **Start**.
6. Click the buttons to test the different file-handling methods.

Raac tallaabooyinkan si aad u tijaabiso sida file loo akhriyo, item gaar ah loo tirtiro, iyo sida file dhan loo tirtiro.

## ⚠️ Important Notes | Qodobo Muhiim ah

- The `filePath` variable must point to a valid file location.
- The application should check whether a file exists before reading or deleting it.
- Deleting an item rewrites the file with the remaining lines.
- Deleting the entire file is a permanent operation unless you have a backup.
- For better resource management, use `using` statements when working with `StreamReader`.

**Important:** The current implementation uses an absolute file path. Haddii qof kale kombiyuutarkiisa ku furo project-ka, waxaa laga yaabaa inuusan shaqayn ilaa `filePath` la waafajiyo meesha file-ku yaallo.

## 🎓 Learning Outcomes | Waxa Aan Ka Bartay

Through this project, I practiced different file-handling techniques in C# and learned how to connect file operations with Windows Forms controls.

Mashruucan waxaan ku bartay farqiga u dhexeeya file-reading methods-ka, sida xog gaar ah looga saaro file, sida file dhan loo tirtiro, iyo sida loo isticmaalo `ListBox` iyo `MessageBox` si user-ku ula falgalo application-ka.

## 👩‍💻 Author

**Student Project — C# Programming**

Created for practical learning and experimentation with file-handling methods in C#.
