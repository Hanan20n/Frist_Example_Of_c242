C# File Handling – OpenFileDialog and SaveFileDialog

Project Description

This project demonstrates file handling in C# Windows Forms using OpenFileDialog, SaveFileDialog, StreamReader, and StreamWriter.

Features

Open File: Reads data from an existing text file and displays it in a ListBox.

Save File: Saves user input into a text file.

Append Data: Adds new data without deleting previously saved data.

Clear: Clears the TextBox and ListBox without deleting the saved file.

Controls Used

TextBox

ListBox

OpenFileDialog

SaveFileDialog

Buttons

Important Methods

Method

Purpose

File.OpenText()

Reads a file

File.AppendText()

Adds new data to a file

ReadLine()

Reads one line

WriteLine()

Writes one line

Items.Add()

Adds data to ListBox

Items.Clear()

Clears ListBox

Answer to the Assignment Question

Can the user enter two or three inputs before clicking Save, and will all inputs be saved?

Yes. By setting Multiline = True in the TextBox, the user can enter multiple lines before clicking Save. All entered lines will be saved into the same text file.

If the user replaces the previous text instead of adding new lines, only the latest text will be saved.