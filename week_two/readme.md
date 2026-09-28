Chapter 2: Processing DataTopics
3.1 Reading Input with TextBox Controls   
3.2 A First Look at Variables   
3.3 Numeric Data Types and Variables 
3.4 Performing Calculations   
3.5 Inputting and Outputting Numeric Values   
3.6 Formatting Numbers with the ToString Method   
3.7 Simple Exception Handling   
3.8 Using Named Constants   
3.9 Declaring Variables as Fields   
3.10 Using the Math Class   
3.11 More GUI Details  
 3.12 Using the Debugger to Locate Logic Errors   
 3.1 Reading Input with TextBox ControlsTextBox Control: A rectangular GUI area that accepts user keyboard input.   Text Property: Stores text entered by the user as a string.   Clearing input programmatically:   C#textBox1.Text = "";
// or
textBox1.Clear();
// or
textBox1.Text = string.Empty;
3.2 A First Look at VariablesVariable: A named storage location in memory.   Syntax: DataType VariableName;   Primitive Data Types: Basic built-in data types provided by C#.   Integral Types: int, byte, short, long   Floating-Point Types: float, double, decimal   Other Basic Types: char, bool, string   String Concatenation: Combining strings using the + operator:   C#string fullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;
Scope & Lifetime: Local variables only exist inside the method where they are declared. Once the method finishes executing, local variables are destroyed.   3.3 Numeric Data Types and VariablesCommon Types:int: Whole numbers (e.g., 40).   double: Floating-point real numbers (e.g., 87.6).   decimal: High-precision numbers used for monetary/financial values (suffix with m, e.g., 28.75m).   Explicit Type Casting: Converting types using cast operators:   C#decimal moneyNumber = 4500m;
int wholeNumber = (int)moneyNumber;
var Keyword: Allows implicit type inference for local variables:   C#var interestRate = 12.0; // Inferred as double
3.4 Performing CalculationsBasic arithmetic operators: +, -, *, /, % (modulus).   Integer Division: Dividing two integers produces an integer result (fractional parts are truncated).   Cast to double to preserve decimals:   C#int x = 7, y = 3;
double result = (double)x / y;
3.5 Inputting and Outputting Numeric ValuesConversion from string to numeric types using Parse:   C#int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
Converting numbers back to string for output using .ToString():   C#decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();
3.6 Formatting Numbers with the ToString MethodFormat StringDescriptionExample CodeResult"N" or "n"Number format   12.3.ToString("n3")   12.300   "F" or "f"Fixed-point   123456.0.ToString("f2")   123456.00   "C" or "c"Currency   1234.5.ToString("c")$1,234.50"P" or "p"Percentage   0.234.ToString("p")   23.40%   3.7 Simple Exception HandlingException: A runtime error that occurs while the application is running.   try-catch Block: Prevents application crashes by catching errors gracefully:   C#try
{
    double miles = double.Parse(milesTextBox.Text);
    double gallons = double.Parse(gallonsTextBox.Text);
    double mpg = miles / gallons;
    mpgLabel.Text = mpg.ToString("n1");
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message); // Displays error message
}
3.8 Using Named ConstantsDeclared using the const keyword; values cannot be changed during program execution:   C#const double INTEREST_RATE = 0.129;
3.9 Declaring Variables as FieldsField: A class-level variable declared inside a class but outside any method.   Accessible to all methods within that class:   C#namespace FieldDemo
{
    public partial class Form1 : Form
    {
        private string name = "Charles"; // Field

        private void showNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name);
        }
    }
}
3.10 Using the Math ClassStandard static mathematical operations provided by .NET:   Math.Sqrt(x): Square root   Math.Pow(x, y): Power ($x^y$)   Math.Max(x, y) / Math.Min(x, y)   Math.Round(x)   Constants: Math.PI, Math.E   3.11 More GUI DetailsTab Order & Focus: Determines which control receives focus when pressing the Tab key (configured via TabIndex property).   Setting focus programmatically:   C#nameTextBox.Focus();
Access Keys (Mnemonics): Use an ampersand (&) in the Text property to create keyboard shortcuts (e.g., E&xit creates Alt+X).   Colors & Backgrounds: Set control foreground and background colors using Color values:   C#messageLabel.BackColor = Color.Black;
messageLabel.ForeColor = Color.Yellow;
3.12 Using the Debugger to Locate Logic ErrorsLogic Error: An error causing incorrect output without halting execution.   Breakpoints: Lines selected in code that pause execution and enter Break Mode to inspect variable values.   Single-Stepping: Executing statements one line at a time (e.g., using F11 or Step Into) to trace behavior.   Locals & Watch Windows: Inspection windows displaying current variable values during break mode.  