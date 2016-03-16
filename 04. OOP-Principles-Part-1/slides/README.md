<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Object-Oriented Programming Fundamental Principles – Part 1
## Inheritance, Abstraction, Encapsulation
<img class="slide-image" src="\imgs\pic00.png" style="top:53.77%; left:64.56%; width:37.78%; z-index:-1" />
<img class="slide-image" src="\imgs\pic01.png" style="top:49.26%; left:83.81%; width:17.40%; z-index:-1" />
<img class="slide-image" src="\imgs\pic03.png" style="top:51.38%; left:65.50%; width:17.63%; z-index:-1" />
<img class="slide-image" src="\imgs\pic04.png" style="top:59.77%; left:3.74%; width:47.33%; z-index:-1" />
<img class="slide-image" src="\imgs\pic05.png" style="top:48.99%; left:91.69%; width:17.08%; z-index:-1" />
<div class="signature">
	<p class="signature-course"></p>
	<p class="signature-initiative"></p>
	<a href="" class="signature-link"></a>
</div>




<!-- section start -->
<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Table of Contents
- Fundamental Principles of OOP
- Inheritance
  - Class Hierarchies
  - Inheritance and Access Levels
- Abstraction
  - Abstract Classes
  - Interfaces
- Encapsulation
<img class="slide-image" src="\imgs\pic06.png" style="top:43.20%; left:56.14%; width:45.51%; z-index:-1" />
<img class="slide-image" src="\imgs\pic07.png" style="top:12.34%; left:77.66%; width:24.21%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Fundamental Principles of OOP
<img class="slide-image" src="\imgs\pic08.png" style="top:42%; left:53.88%; width:45.32%; z-index:-1" />
<img class="slide-image" src="\imgs\pic09.png" style="top:42%; left:8.04%; width:45.17%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Fundamental Principles of OOP
- **Inheritance**
  - Inherit members from parent class
- **Abstraction**
  - Define and execute abstract actions
- **Encapsulation**
  - Hide the internals of a class
- **Polymorphism**
    - Access a class through its parent interface

<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Inheritance


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Classes and Interfaces
- **Classes** define attributes and behavior
  - Fields, properties, methods, etc.
  - Methods contain code for execution

```cs
public class Labyrinth { public int Size { get; set; } }
```

- **Interfaces** define a set of operations
  - Empty methods and properties, left to be implemented later


```cs
public interface IFigure { void Draw(); }
```

<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Inheritance
- **Inheritance**allows**child** classes to **inherit** the characteristics of an existing **parent** (**base**) class
  - Attributes (fields and properties)
  - Operations (methods)
- Child class can extend the parent class
  - Add new fields and methods
  - Redefine methods (modify existing behavior)
- A class can **implement** an interface by providing implementation for all its methods


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Types of Inheritance
- Inheritance terminology

<img class="slide-image" src="\imgs\inheritance-type.png" style="top:20%; left:8.04%; width:75%; z-index:-1" />



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Inheritance – Benefits
- Inheritance has a lot of benefits
  - Extensibility
  - Reusability (**code reuse**)
  - Provides abstraction
  - Eliminates redundant code
- Use inheritance for buidling **is-a** relationships
  - E.g. dog **is-a** animal (dogs are kind of animals)
- Don't use it to build **has-a** relationship
  - E.g. dog **has-a** name (dog is not kind of name)
<img class="slide-image" src="\imgs\pic12.png" style="top:18.38%; left:76.72%; width:20.28%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Inheritance
- **Inheritance** implicitly gains **all members**from another class
  - All fields, methods, properties, events, …
  - Some members could be inaccessible (hidden)
- The class whose methods are inherited is called **base** (parent) class
- The class that gains new functionality is called **derived** (child) class


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Inheritance – _Example_

<img class="slide-image" src="\imgs\inheritance-example.png" style="top:20%; left:8.04%; width:75%; z-index:-1" />



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Class Hierarchies
- **Inheritance** leads to a **hierarchiesof classes** and / or interfaces in an application:

<img class="slide-image" src="\imgs\hierarchies.png" style="top:30%; left:8.04%; width:75%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Inheritance in .NET
- A class can inherit only one base class
  - E.g. **IOException** derives from **SystemException** and it derives from **Exception**
- A class can implement several interfaces
  - This is .NET’s form of **multiple inheritance**
  - E.g. **List&lt;T&gt;** implements **IList&lt;T&gt;**, **ICollection&lt;T&gt;**, **IEnumerable&lt;T&gt;**
- An interface can implement several interfaces
  - E.g. **IList&lt;T&gt;** implements **ICollection&lt;T&gt;** and **IEnumerable&lt;T&gt;**


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# How to Define Inheritance?
- Specify the name of the base class after the name of the derived (with colon)

```cs
public class Shape
{ … }
public class Circle : Shape
{ … }
```

- Use the keyword **base** to invoke the parent constructor




```cs
public Circle (int x, int y) : base(x)
{ … }
```

<img class="slide-image" src="\imgs\pic13.png" style="top:23.32%; left:83.27%; width:18.51%; z-index:0" />
<img class="slide-image" src="\imgs\pic14.png" style="top:59.94%; left:89.28%; width:13.12%; z-index:0" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Simple Inheritance _Example_

```cs
public class Mammal
{
  public int Age { get; set; }

  public Mammal(int age)
  {
    this.Age = age;
  }

  public void Sleep()
  {
    Console.WriteLine("Shhh! I'm sleeping!");
  }
}
```

<img class="slide-image" src="\imgs\pic15.png" style="top:13.22%; left:74.50%; width:28.54%; z-index:0" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
<!-- # Simple Inheritance _Example_ -->

```cs
public class Dog : Mammal
{
  public string Breed { get; set; }

  public Dog(int age, string breed)
    : base(age)
  {
    this.Breed = breed;
  }

  public void WagTail()
  {
    Console.WriteLine("Tail wagging...");
  }
}
```

<img class="slide-image" src="\imgs\pic16.png" style="top:11.46%; left:81.40%; width:22.04%; z-index:0" />


<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Simple Inheritance
## [Demo]()
<img class="slide-image" src="\imgs\pic17.png" style="top:42.97%; left:63.94%; width:39.38%; z-index:-1" />
<img class="slide-image" src="\imgs\pic18.png" style="top:52%; left:5.82%; width:44.13%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Access Levels
- Access modifiers in C#
  - **public** – access is not restricted
  - **private** – access is restricted to the containing type
  - **protected** – access is limited to the containing type and types derived from it
  - **internal** – access is limited to the current assembly
  - **protected** **internal** – access is limited to the current assembly or types derived from the containing class


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Inheritance and Accessibility

```cs
class Creature {
   protected string Name { get; private set; }
   protected void Walk()
   {
      Console.WriteLine("Walking ...");
   }
   private void Talk()
   {
      Console.WriteLine("I am creature ...");
   }

}
class Mammal : Creature
{
   // base.Walk() can be invoked here
   // base.Talk() cannot be invoked here
   // this.Name can be read but cannot be modified here
}
```



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Inheritance and Accessibility -->

```cs
class Dog : Mammal
{
  public string Breed { get; private set; }
  // base.Talk() cannot be invoked here (it is private)
}

class InheritanceAndAccessibility
{
  static void Main()
  {
    Dog joe = new Dog(6, "Labrador");
    Console.WriteLine(joe.Breed);
    // joe.Walk() is protected and can not be invoked
    // joe.Talk() is private and can not be invoked
    // joe.Name = "Rex"; // Name cannot be accessed here
    // joe.Breed = "Shih Tzu"; // Can't modify Breed
  }
}
```



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Inheritance and Accessibility
## [Demo]()
<img class="slide-image" src="\imgs\pic19.png" style="top:52%; left:30%; width:40%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Inheritance: Important Aspects
- **Structures** cannot be inherited
- In C# there is no **multiple** inheritance
  - Only multiple interfaces can be implemented
- Static members are also inherited
- Constructors are not inherited
- Inheritance is **transitive** relation
  - If C is derived from B, and B is derived from A, then C inherits A as well


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Inheritance: Important Features
- When a derived class extends its base class
  - It can freely add new members
  - Cannot remove derived ones
- Declaring new members with the same name or signature **hides** the inherited ones
- A class can declare **virtual** methods and properties
  - Derived classes can **override** the implementation of these members
  - E.g. **Object.ToString()** is virtual method




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Abstraction
<img class="slide-image" src="\imgs\pic20.png" style="top:47.60%; left:12.58%; width:27.43%; z-index:-1" />
<img class="slide-image" src="\imgs\pic21.png" style="top:26.33%; left:59.30%; width:44.63%; z-index:-1" />
<img class="slide-image" src="\imgs\pic22.png" style="top:4.57%; left:34.38%; width:19.35%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Abstraction
- **Abstraction** means ignoring irrelevant features, properties, or functions and emphasizing the relevant ones ...
- ... relevant to the given project
  - With an eye to future reuse in similar projects
- Abstraction helps **managing complexity**
- "Relevant" to what?


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Abstraction -->
- Abstraction is something we do every day
  - Looking at an object, we see those things about it that have meaning to us
  - We abstract the properties of the object, and keep only what we need
  - E.g. students get "name" but not "color of eyes"
- Allows us to represent a complex reality in terms of a simplified model
- Abstraction highlights the properties of an entity that we need and hides the others


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Abstraction in .NET
- In .NET object-oriented programming abstraction is achieved in several ways:
  - Abstract classes
  - Interfaces
  - Inheritance
<img class="slide-image" src="\imgs\pic24.png" style="top:55.22%; left:10.29%; width:27.60%; z-index:-1" />
<img class="slide-image" src="\imgs\abstraction.png" style="top:35.22%; left:40%; width:40%; z-index:-1" />



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Abstraction in .NET – _Example_
<img class="slide-image" src="\imgs\abstraction-example.png" style="top:10%; left:25%; width:60%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Interfaces
- An **interface** defines a set of operations (methods) that given object should perform
  - Also called "**contract**" for providing a set of operations
  - Defines abstract behavior
- Interfaces provide abstractions
  - You invoke the abstract actions
  - Without worrying how it is internally implemented


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Interfaces -->
- **Interfaces** describe a prototype of group of methods (operations), properties and events
  - Can be implemented by a given class or structure
  - Define only the prototypes of the operations
    - No concrete implementation is provided
  - Can be used to define abstract data types
  - Can be inherited (extended) by other interfaces
  - Can not be instantiated


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Interfaces – _Example_

```cs
public interface IShape
{
    void SetPosition(int x, int y);
    int CalculateSurface();
}
public interface IMovable
{
    void Move(int deltaX, int deltaY);
}
public interface IResizable
{
    void Resize(int weight);
    void Resize(int weightX, int weightY);
    void ResizeByX(int weightX);
    void ResizeByY(int weightY);
}
```



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Interfaces – _Example_ -->

```cs
public interface IPerson
{
    DateTime DateOfBirth  // Property DateOfBirth
    {
        get;
        set;
    }

    int Age  // Property Age (read-only)
    {
        get;
    }

    void Print(); // Method for printing
}
```



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Interface Implementation
- Classes and structures can implement (support) one or several interfaces

```cs
class Rectangle : IShape
{
  public void SetPosition(int x, int y) { … }
  public int CalculateSurface() { … }
}
```

- Implementer classes must **implement all**interface methods
  - Or should be declared **abstract**





<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Interface Implementation -->

```cs
class Rectangle : IShape, IMovable
{
   private int x, y, width, height;
   public void SetPosition(int x, int y) // IShape
   {
        this.x = x;
        this.y = y;
   }
   public int CalculateSurface() // IShape
   {
        return this.width * this.height;
   }
   public void Move(int deltaX, int deltaY) // IMovable
   {
        this.x += deltaX;
        this.y += deltaY;
   }
}
```



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Interfaces andImplementation
## [Demo]()


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Abstract Classes
- **Abstract classes**are special classes defined with the keyword **abstract**
  - Mix between class and interface
  - Partially implemented or fully unimplemented
  - Not implemented methods are declared **abstract** and are left empty
  - Cannot be instantiated directly
- Child classes should implement all abstract  methods or be declared as **abstract** too


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Abstract Classes -->
- **Abstract** **methods** are empty methods without implementation
  - The implementation is **intentionally left**for the descendent classes
- When a class contains **at least one abstract method**, it is called **abstract class**
- Abstract classes model abstract concepts
  - E.g. person, object, item, movable object


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Abstract Class – _Example_

```cs
abstract class MovableShape : IShape, IMovable
{
    private int x, y;
    public void Move(int deltaX, int deltaY)
    {
        this.x += deltaX;
        this.y += deltaY;
    }
    public void SetPosition(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public abstract int CalculateSurface();
}
```



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Interfaces vs. Abstract Classes
- C# **interfaces** are like **abstract classes**, but in contrast interfaces:
  - Can not contain methods with implementation
    - All interface methods are abstract
  - Members do not have scope modifiers
    - Their scope is assumed public
    - But this is not specified explicitly
  - Can not define fields, constants, inner types and constructors


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Abstract Classes – _Example_

```cs
public abstract class Animal : IComparable<Animal>
{
  // Abstract methods
  public abstract string GetName();
  public abstract int Speed { get; }
  // Non-abstract method
  public override string ToString()
  {
    return "I am " + this.GetName();
  }
  // Interface method
  public int CompareTo(Animal other)
  {
    return this.Speed.CompareTo(other.Speed);
  }
}
```



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Abstract Classes – _Example_ -->

```cs
public class Turtle : Animal
{
  public override int Speed { get { return 1; } }

  public override string GetName()
  { return "turtle"; }
}

public class Cheetah : Animal
{
  public override int Speed { get { return 100; } }

  public override string GetName()
  { return "cheetah"; }
}
```



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Abstract Classes
## [Demo]()


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Abstract Data Types
- Abstract Data Types (ADT) are data types defined by a set of operations (interface)
- _Example_: **IList&lt;T&gt;** in .NET Framework
<img class="slide-image" src="\imgs\pic28.png" style="top:38.79%; left:10.29%; width:26.45%; z-index:-1" />
<img class="slide-image" src="\imgs\data-types.png" style="top:38.79%; left:50%; width:35%; z-index:-1" />



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Inheritance Hierarchies
- Using inheritance we can create inheritance hierarchies
  - Easily represented by UML class diagrams
- UML class diagrams
  - Classes are represented by rectangles containing their methods and data
  - Relations between classes are shown as arrows
    - Closed triangle arrow means inheritance
    - Other arrows mean some kind of associations


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# UML Class Diagrams - Example
<img class="slide-image" src="\imgs\uml.png" style="top:12.34%; left:30%; width:47.60%; z-index:-1" />


<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Class Diagrams in Visual Studio
## [Demo]()




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Encapsulation
<img class="slide-image" src="\imgs\pic30.png" style="top:32.62%; left:20.36%; width:40.55%; z-index:-1" />
<img class="slide-image" src="\imgs\pic31.png" style="top:11.73%; left:70.54%; width:30.04%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Encapsulation
- Encapsulation hides the implementation details
- Class announces some operations (methods) available for its clients – its **public interface**
- All data members (fields) of a class should be hidden
  - Accessed via properties (read-only and read-write)
- No interface members should be hidden


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Encapsulation – _Example_
- Data fields are private
- Constructors and accessors are defined (getters and setters)
<img class="slide-image" src="\imgs\encapsulation.png" style="top:35%; left:20%; width:60%; z-index:-1" />




<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Encapsulation in .NET
- Fields are always declared **private**
  - Accessed through **properties** in read-only or read-write mode
- Constructors are almost always declared **public**
- Interface methods are always **public**
  - Not explicitly declared with **public**
- Non-interface methods are declared **private** / **protected**


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Encapsulation – Benefits
- Ensures that structural changes remain local:
  - Changing the class internals does not affect any code outside of the class
  - Changing methods' implementation does not reflect the clients using them
- Encapsulation allows adding some logic when accessing client's data
  - E.g. **validation** on modifying a property value
- Hiding implementation details reduces complexity &rarr; easier maintenance


<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Encapsulation
## [Demo]()


<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Object-Oriented Programming Fundamental Principles – Part 1
## Questions?


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - [csharpfundamentals.telerik.com](csharpfundamentals.telerik.com)
  - Telerik Software Academy
    - [academy.telerik.com](csharpfundamentals.telerik.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Software Academy Forums
    - [forums.academy.telerik.com](forums.academy.telerik.com)
<img class="slide-image" src="\imgs\pic33.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1" />
<img class="slide-image" src="\imgs\pic34.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1" />
<img class="slide-image" src="\imgs\pic35.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1" />
<img class="slide-image" src="\imgs\pic36.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1" />
