# C-Sharp-Guide
Repository for learning or checking useful C# code and techniques. As you can tell, it's quite the work in progress.
It's important to note that these examples are using [.NET Core, not .NET Framework](https://stackify.com/net-core-vs-net-framework/).

## Section 1 - Basics
### [HelloWorld](https://github.com/majze/C-Sharp-Guide/tree/master/HelloWorld)
Just the basics in this one. Simple variable types, string concatenation, and writing to console.

### [Methods](https://github.com/majze/C-Sharp-Guide/tree/master/Methods)
Covers methods outside Main() and passing variables between them. If statements as well as for and while loops are mentioned. Briefly shows different exceptions for the try catch block.

### [TicTacToe](https://github.com/majze/C-Sharp-Guide/tree/master/TicTacToe)
Console game where 2 players compete to win. Uses 2D arrays to keep track of variables as well as some sloppy logic to check them.

## Section 2 - Classes
### [Classes](https://github.com/majze/C-Sharp-Guide/tree/master/classes)
Example person class goes over methods, properties, constructors, and destructors. **Program.cs** runs example problems to the output stream while **Person.cs** is responsible for the structure and details of the objects created in **Program.cs**.

### [Inheritance](https://github.com/majze/C-Sharp-Guide/tree/master/Inheritance)
Creates children of children objects from inheritence and uses methods to store or retireve data for manipulation. **Program.cs** uses an ArrayList to store different objects, then uses their methods to interact with each other. **Posts.cs** covers inheritance and timer functions. **Container.cs** showcases how simple objects can start small and get more complicated as they evolve into their children classes.

### [Data](https://github.com/majze/C-Sharp-Guide/tree/master/Data)
More on inheritance inclusing virtual functions and override functions. **Audi.cs** and **BMW.cs** are derived from **Car.cs**, which has the basic variables and functions. **M3.cs** is derived from **BMW.cs**, but would not work if it was derived from **Audi.cs** as the Audi class is sealed. Finally, **CarIDInfo.cs** is an example of how to use a "has a" relationship, which allows a class to own its own protected class.

### [Files]()

## Section 3 - UI Stuff
### Title
Text

## Section 4 - Game Stuff
### Title
Text
