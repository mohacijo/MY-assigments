Introduction to Visual C#

📚 Chapter 1 – Introduction to Visual C#

This chapter introduces the basics of Visual C# programming and Windows Forms applications using Visual Studio.

📝 Topics Covered

* Objects and Classes
* Properties and Methods
* Controls
* .NET Framework
* Visual Studio IDE
* Toolbox
* Solution Explorer
* Projects and Solutions
* Windows Forms
* Properties Window
* Naming Controls
* C# Source Code
* Event-Driven Programming
* Event Handlers
* MessageBox
* Label Controls
* IntelliSense
* PictureBox Controls
* Comments and Indentation
* Closing a Form
* Syntax Errors

🔹 Objects

An object is a program component that contains data and performs operations.

* Properties – store data or settings of an object.
* Methods – perform operations on an object.

🔹 Controls

Controls are objects that are visible in a program’s GUI.

Common controls include:

* Label
* Button
* TextBox
* PictureBox

Controls can be added from the Toolbox and their properties can be changed using the Properties Window.

🔹 Visual Studio

Visual Studio is an Integrated Development Environment (IDE) used to create applications.

Important parts include:

* Designer Window
* Solution Explorer
* Properties Window
* Toolbox
* Code Editor

🔹 Windows Forms

When creating a new Windows Forms application, Visual Studio creates a form such as Form1.

The form can be customized by changing its properties, adding controls, moving controls, and resizing them.

🔹 C# Code Structure

C# code is mainly organized into:

1. Namespace – contains classes.
2. Class – contains methods.
3. Method – contains statements that perform operations.

Example:

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}

🔹 Event-Driven Programming

Windows Forms applications are event-driven.

The program waits for an event such as:

* Button click
* Key press
* Mouse movement

An event handler is a method that executes when an event occurs.

Example:

private void messageButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}

🔹 Label Control

A Label displays text on a form or displays program output.

Important properties include:

* Text
* Name
* Font
* BorderStyle
* AutoSize
* TextAlign

Example:

answerLabel.Text = "";

The = symbol is the assignment operator.

🔹 IntelliSense

IntelliSense provides automatic code completion while writing C# code. It suggests keywords, variables, methods, classes, and properties.

🔹 PictureBox

A PictureBox displays an image on a form.

Common properties:

* Image
* SizeMode
* Visible

Example:

cardBackPictureBox.Visible = true;
cardFacePictureBox.Visible = false;

The order of statements is important because C# executes statements sequentially.

🔹 Comments

Comments explain parts of the source code.

Single-line comment

// Close the form.

Multi-line comment

/*
   This is a block comment.
   It can contain multiple lines.
*/

🔹 Closing a Form

To close the current form:

this.Close();

To close the entire application:

Application.Exit();

🔹 Syntax Errors

Visual Studio detects syntax errors while writing code. Errors are usually shown with a red jagged underline.

Correct syntax is important before compiling and running the application.

🎯 Summary

This chapter provides the foundation for creating Windows Forms applications with C#. It explains how to use Visual Studio, create forms, add controls, change properties, write event-driven code, display messages, work with labels and images, and identify syntax errors.

🛠️ Tools

* C#
* Visual Studio
* Windows Forms
* .NET

⸻

Course: Visual C#
Chapter: Introduction to Visual C#
Language: C#