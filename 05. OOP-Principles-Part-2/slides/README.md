<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Object-Oriented Programming Fundamental Principles – Part 2
## Polymorphism, Class Hierarchies, Exceptions, Strong Cohesion and Loose Coupling
<img class="slide-image" src="\imgs\pic00.png" style="top:49.29%; left:74.86%; width:18.36%; z-index:-1" />
<img class="slide-image" src="\imgs\pic01.png" style="top:3.99%; left:82.24%; width:21.55%; z-index:-1" />
<img class="slide-image" src="\imgs\pic02.png" style="top:4.34%; left:59.88%; width:16.47%; z-index:-1" />
<div class="signature">
	<p class="signature-course"></p>
	<p class="signature-initiative"></p>
	<a href="" class="signature-link"></a>
</div>




<!-- section start -->
<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Contents
- Polymorphism
- Class Hierarchies: Real World _Example_
- Exception Handling and Exception Classes
- Cohesion and Coupling
<img class="slide-image" src="\imgs\pic03.png" style="top:46.76%; left:61.06%; width:37.56%; z-index:-1" />
<img class="slide-image" src="\imgs\pic04.png" style="top:46.52%; left:11.61%; width:38.43%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Polymorphism
<img class="slide-image" src="\imgs\pic05.png" style="top:35%; left:6.05%; width:43.67%; z-index:-1" />
<img class="slide-image" src="\imgs\pic06.png" style="top:5.29%; left:60.82%; width:41.62%; z-index:-1" />
<img class="slide-image" src="\imgs\pic07.png" style="top:48.38%; left:76.72%; width:22.92%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Polymorphism
- **Polymorphism** = ability to **take more than oneform**(objects have more than one type)
  - A class can be used through its parent interface
  - A child class may override some of the behaviors of the parent class
- Polymorphism allows **abstract operations**to be defined and invoked
  - Abstract operations are defined in the base class' interface and implemented in the child classes
    - Declared as **abstract** or **virtual**


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Polymorphism -->
- Why handle an object of given type as object of its base type?
  - To invoke **abstract operations**
  - To mix different related types in the same collection
    - E.g. **List&lt;object&gt;** can hold anything
  - To pass more specific object to a method that expects a parameter of a more generic type
  - To declare a more generic field which will be initialized and "specialized" later


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'font-size:40px;' } -->
# Virtual Methods
- **Virtual method** is
  - Defined in a base class and can be **changed** (overridden) in the descendant classes
  - Can be called through the base class' interface
- Virtual methods are declared through the keyword **virtual**

```cs
public virtual void Draw() { … }
```

- Methods declared as virtual in a base class can be overridden using the keyword **override**

```cs
public override void Draw() { … }
```



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Virtual Methods
## [Demo]()
<img class="slide-image" src="\imgs\pic08.png" style="top:4.41%; left:18.71%; width:70.52%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# More about Virtual Methods
- **Abstract methods**are purely virtual
  - If a method is **abstract** &rarr; it is **virtual** as well
  - Abstract methods are designed to be changed (overridden) later
- **Interface members** are also purely virtual
  - They have no default implementation and are designed to be overridden in a descendent class
- Virtual methods can be **hidden** through the new keyword:

```cs
public new double CalculateSurface() { return … }
```



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# The override Modifier
- Using **override** we can modify a method or property
  - An override method provides a **replacement implementation**of an inherited member
  - You cannot override a non-virtual or static method
- The overridden base method must be **virtual**, **abstract**, or **override**


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Polymorphism – How it Works?
- **Polymorphism** ensures that the appropriate method of the subclass is called through its base class' interface
- Polymorphism is implemented using a technique called **late method binding**
  - The exact method to be called is determined at **runtime**, just before performing the call
  - Applied for all **abstract** / **virtual** methods
- _Note_: Late binding is a bit slower than normal (early) binding


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Polymorphism – _Example_

<img class="slide-image" src="\imgs\polymorphism.png" style="top:15%; left:18.71%; width:70.52%; z-index:-1" />

<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Polymorphism – _Example_
```cs
public abstract class Figure {
  public abstract double CalcSurface();
}
public class Square : Figure {
  public override double CalcSurface() { return … }
}
public class Circle : Figure {
  public override double CalcSurface() { return … }
}
Figure f1 = new Square(...);
Figure f2 = new Circle(...);
// This will call Square.CalcSurface()
int surface = f1.CalcSurface();
// This will call Circle.CalcSurface()
int surface = f2.CalcSurface();
```

<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Class Hierarchies:<br /> Real World _Example_
<img class="slide-image" src="\imgs\pic10.png" style="top:37.91%; left:7.49%; width:45.07%; z-index:-1" />
<img class="slide-image" src="\imgs\pic11.png" style="top:44.08%; left:58.95%; width:44.08%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Real World _Example_: Calculator
- Creating an application like the Windows Calculator
  - Typical scenario for applying the object-oriented approach
<img class="slide-image" src="\imgs\pic12.png" style="top:37.02%; left:30.82%; width:47.71%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Real World _Example_: Calculator -->
- The calculator consists of controls:
  - Buttons, panels, text boxes, menus, check boxes, radio buttons, etc.
- Class **Control** – the root of our OO hierarchy
  - All controls can be painted on the screen
    - Should implement an interface **IPaintable** with a method **Paint()**
  - Common properties: location, size, text, face color, font, background color, etc.


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Real World _Example_: Calculator -->
- Some controls could contain other (nested) controls inside (e. g. panels and toolbars)
  - We should have class **Container** that extends **Control** holding a collection of child controls
- The **Calculator** itself is a **Form**
  - **Form** is a special kind of **Container**
  - Contains also border, title (**text** derived from **Control**), icon and system buttons
- How the **Calculator** paints itself?
  - Invokes **Paint()** for all child controls inside it


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Real World _Example_: Calculator -->
- How a **Container** paints itself?
  - Invokes **Paint()** for all controls inside it
  - Each control knows how to visualize itself
- What is the common between buttons, check boxes and radio buttons?
  - Can be pressed
  - Can be selected
- We can define class **AbstractButton** and all buttons can derive from it

<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Calculator Classes -->
<img class="slide-image" src="\imgs\calc-classes.png" style="top:15%; left:10.71%; width:85%; z-index:-1" />



<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Exception Classes
## User-Defined Exception Classes
<img class="slide-image" src="\imgs\pic13.png" style="top:52%; left:32%; width:35%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Exception Handling in OOP
- In OOP **exception handling** is the main paradigm for error handling
  - **Exceptions** are special classes that hold information about an error or unusual situation
- Exceptions are thrown (raised) through the **throw** keyword

```cs
throw new InvalidCalculationException(
  "Cannot calculate the size of the specified object");
```

- Exceptions are handled though the **try-catch-finally** and **using(…)** constructs


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Exception Hierarchy
- Exceptions in .NET Framework are organized in a object-oriented **class hierarchy**
<img class="slide-image" src="\imgs\pic14.png" style="top:27.84%; left:6.49%; width:93.50%; z-index:-1; background-color: #DADADA;" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Defining an Exception Class
- To define an exception class, inherit from **ApplicationException** and define constructors

```cs
using System;

public class InvalidCalculationException
  : ApplicationException
{
  public InvalidCalculationException(string msg)
    : base(msg)
  { }

  public InvalidCalculationException(string msg,
    Exception innerEx) : base(msg, innerEx)
  { }
}
```

<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Defining Exception Classes
## [Demo]()
<img class="slide-image" src="\imgs\pic15.png" style="top:52%; left:28%; width:45%; z-index:-1" />


<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Cohesion and Coupling
<img class="slide-image" src="\imgs\pic16.png" style="top:42%; left:20.88%; width:62.55%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Cohesion
- **Cohesion** describes
  - How closely the routines in a class or the code in a routine support a **central purpose**
- Cohesion must be **strong**
  - Well-defined abstractions keep cohesion strong
- Classes must contain **strongly related functionality** and aim for single purpose
- Cohesion is a powerful tool for managing complexity


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Good and Bad Cohesion
- **Good cohesion**: HDD, CR-ROM, remote control
<br />
<br />
<br />
<br />
<br />
- **Bad cohesion**: spaghetti code, single-board computer
<img class="slide-image" src="\imgs\pic17.png" style="top:65.66%; left:7.49%; width:20.79%; z-index:-1" />
<img class="slide-image" src="\imgs\pic18.png" style="top:60.02%; left:35.56%; width:27.48%; z-index:-1" />
<img class="slide-image" src="\imgs\pic19.png" style="top:19.39%; left:10.98%; width:20.28%; z-index:-1" />
<img class="slide-image" src="\imgs\pic20.png" style="top:15.87%; left:40.18%; width:27.38%; z-index:-1" />
<img class="slide-image" src="\imgs\pic21.png" style="top:14.99%; left:75.79%; width:28.21%; z-index:-1" />
<img class="slide-image" src="\imgs\pic22.png" style="top:60.02%; left:72.05%; width:29.97%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Strong Cohesion
- **Strong cohesion**(good cohesion) example
  - Class **Math** that has methods:
    - **Sin()**, **Cos()**, **Asin()**
    - **Sqrt()**, **Pow()**, **Exp()**
    - **Math.PI**, **Math.E**

```cs
double sideA = 40, sideB = 69;
double angleAB = Math.PI / 3;

double sideC =
    Math.Pow(sideA, 2) + Math.Pow(sideB, 2)
    - 2 * sideA * sideB * Math.Cos(angleAB);

double sidesSqrtSum = Math.Sqrt(sideA) + Math.Sqrt(sideB) + Math.Sqrt(sideC);
```

<img class="slide-image" src="\imgs\pic23.png" style="top:18.51%; left:73.52%; width:28.59%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Weak Cohesion
- **Weak cohesion**(bad cohesion) example
  -  Class **Magic** that has these methods:

```cs
public void PrintDocument(Document d);
public void SendEmail(
string recipient, string subject, string text);
public void CalculateDistanceBetweenPoints(
int x1, int y1, int x2, int y2)
```

- Another example:

```cs
MagicClass.MakePizza("Fat Pepperoni");
MagicClass.WithdrawMoney("999e6");
MagicClass.OpenDBConnection();
```



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Coupling
- **Coupling** describes how tightly a class or routine is related to other classes or routines
- Coupling must be kept **loose**
  - Modules must depend little on each other
    - Or be entirely independent (**loosely coupled**)
  - All classes / routines must have small, direct, visible, and flexible relationships to other classes / routines
  - One module must be easily used by other modules


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Loose and Tight Coupling
- Loose Coupling:
  - Easily replace old HDD
  - Easily place this HDD to another motherboard
<br />
<br />
<br />
- Tight Coupling:
  - Where is the video adapter?
  - Can you change the video controller?
<img class="slide-image" src="\imgs\pic24.png" style="top:13.85%; left:75%; width:25%; z-index:-1" />
<img class="slide-image" src="\imgs\pic25.png" style="top:44.08%; left:75%; width:25%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Loose Coupling – _Example_

```cs
class Report
{
    public bool LoadFromFile(string fileName) {…}
    public bool SaveToFile(string fileName) {…}
}
class Printer
{
    public static int Print(Report report) {…}
}
class Program
{    
    static void Main()
    {
        Report myReport = new Report();          
        myReport.LoadFromFile("C:\\DailyReport.rep");
        Printer.Print(myReport);
    }
}
```



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'font-size: 40px;' } -->
# Tight Coupling – _Example_

```cs
class MathParams
{
    public static double operand;
    public static double result;
}
class MathUtil
{
    public static void Sqrt()
    {
      MathParams.result = CalcSqrt(MathParams.operand);
    }
}   
class MainClass
{
    static void Main()
    {
        MathParams.operand = 64;
        MathUtil.Sqrt();
        Console.WriteLine(MathParams.result);
    }
}
```



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Spaghetti Code
- Combination of bad cohesion and tight coupling:

```cs
class Report
{
  public void Print() {…}
  public void InitPrinter() {…}
  public void LoadPrinterDriver(string fileName) {…}
  public bool SaveReport(string fileName) {…}
  public void SetPrinter(string printer) {…}
}
class Printer
{
  public void SetFileName() {…}
  public static bool LoadReport() {…}
  public static bool CheckReport() {…}
}
```



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'font-size: 40px;' } -->
# Summary
- OOP fundamental principals are: **inheritance**, **encapsulation**, **abstraction**, **polymorphism**
  - Inheritance allows inheriting members from another class
  - Abstraction and encapsulation hide internal data and allow working through abstract interface
  - Polymorphism allows working with objects through their parent interface and invoke abstract actions
- Exception classes are natural to OOP
- **Strong cohesion**and **loose coupling** avoid spaghetti code


<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Object-Oriented Programming Fundamental Principles – Part 2
## Questions?



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - [csharpfundamentals.telerik.com](csharpfundamentals.telerik.com)
  - Telerik Software Academy
    - [academy.telerik.com](academy.telerik.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Software Academy Forums
    - [forums.academy.telerik.com](forums.academy.telerik.com)
<img class="slide-image" src="\imgs\pic26.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1" />
<img class="slide-image" src="\imgs\pic27.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1" />
<img class="slide-image" src="\imgs\pic28.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1" />
<img class="slide-image" src="\imgs\pic29.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1" />
