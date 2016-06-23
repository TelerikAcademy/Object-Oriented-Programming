<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Common Type System
## .NET Types Hierarchy, Cloning, Comparing, Value and Reference Types, Parameters Passing

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic09.png" style="top:70%; left:90%; width:13.05%; z-index:-1; border-radius: 10px;" /> -->
<div class="signature">
	<p class="signature-course">C# OOP</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="https://telerikacademy.com" class="signature-link">https://telerikacademy.com</a>
</div>




<!-- section start -->
<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [What is Common Type System (CTS)?](#cts)
  - Types Hierarchy
- [The System.Object type](#object)
  - [Overriding the Virtual Methods in **System.Object**](#virtual)
- [Operators **is** and **as**](#isas)
- [Object Cloning](#cloning)
  - **ICloneable** Interface
- [The <code>IComparable&lt;T&gt;</code> Interface](#icomparable)

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic10.png" style="top:43.20%; left:75.79%; width:30.33%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Table of Contents -->
- [The <code>IEnumerable&lt;T&gt;</code> interface](#ienumerable)
- [Value Types and Reference Types](#types)
  - [Boxing and Unboxing](#boxing)
- [Passing Parameters](#params)
  - Input, Output and Reference Passing

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic11.png" style="top:55%; left:75%; width:25%; z-index:-1; border-radius: 10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # What is Common Type System (CTS)? -->



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Inside .NET Framework
- Building blocks of .NET Framework

<img class="slide-image" src="imgs/net-framework.png" style="top:20.13%; left:10.47%; width:95%; z-index:-1; border-radius: 10px;" />


<!-- attr: { id:'cts',showInPresentation:true, hasScriptWrapper:true } -->
# <a id="cts"></a>What is CTS?
- .NET Common Type System (CTS)
- Defines CLR supported
  - Data types
  - Operations performed on them
- Extends the compatibility between different .NET languages
- Supports two types of data
  - Value types
  - Reference types
- All data types are inheritors of `System.Object`


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # .NET CTS Types Hierarchy -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic21.png" style="top:15.29%; left:6.08%; width:95.03%; z-index:-1; border-radius: 10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # The System.Object Type -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic23.png" style="top:45%; left:35%; width:25%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { id:'object',showInPresentation:true, hasScriptWrapper:true } -->
# <a id="object"></a>System.Object Type
- Base class for each .NET type
  - Inherited by default when a new type is defined
- Important virtual methods:
  - `Equals()` – comparison with other object
  - `ToString()` – represents the object as a string
  - `GetHashCode()` – evaluates the hash code (used with hash-tables)
  - `Finalize()` – used for clean up purposes when an object is disposed

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic25.png" style="top:72%; left:79.30%; width:15%; z-index:-1; border-radius: 10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Overriding the Virtual Methods in System.Object -->


<!-- attr: { id:'virtual', showInPresentation:true, hasScriptWrapper:false } -->
# <a id="virtual"></a> Overriding System.Object's Virtual Methods
- By default the operator `==` calls the `ReferenceEquals()` method
  - Compares the addresses for reference types
  - Or the binary representation for value types
- The methods `Equals()`, `GetHashCode()` should be defined at the same time
  - The same applies for the operators `==` and `!=`
  - You can override `Equals()` and use its implementation for `==` and `!=`


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size:40px;' } -->
# Overriding System.Object Methods

```cs
public class Student
{
  public string Name { get; set; }
  public int Age { get; set; }
  public override bool Equals(object param)
  {
    // If the cast is invalid, the result will be null
    Student student = param as Student;
    // Check if we have valid not null Student object
    if (student == null)
      return false;
    // Compare the reference type member fields
    if (! Object.Equals(this.Name, student.Name))
      return false;
    // Compare the value type member fields
    if (this.Age != student.Age)
      return false;
    return true;
  }
```
_the example continues_



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
<!-- # Overriding System.Object Methods – _Example_ -->

```cs
   public static bool operator == (Student student1,
                                  Student student2)
   {
       return Student.Equals(student1, student2);
   }
   public static bool operator !=(Student student1,
   					  Student student2)
   {
       return !(Student.Equals(student1, student2));
   }
   public override int GetHashCode()
   {
       return Name.GetHashCode() ^ Age.GetHashCode();
   }
}						
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Overriding the Virtual Methods in System.Object
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/06.%20Common-Type-System/demos/System.Object-Overloading) -->



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# More About System.Object
- The `System.Object` type has some other methods, which are inherited by all .NET types:
  - `GetType()`
    - Returns type's metadata as a `System.Type`
  - `MemberwiseClone()`
    - Copies the binary representation of the variable into a new variable (shallow clone)
  - `ReferenceEquals()`
    - Compares if two object have the same reference




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # `is` and `as` operators -->



<!-- attr: { id:'isas', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="isas"></a>Type Operators in C&#35;
- The `is` operator
  - Checks if an object an is instance of some type
  - Polymorphic operation
    - `5 is Int32`
    - `5 is object`
    - <code>5 is IComparable&lt;int&gt;</code>
- The `as` operator
  - Casts a reference type to another reference type
  - Returns `null` value if it fails
    - E.g. if the types are incompatible


<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic30.png" style="top:28.82%; left:72.82%; width:28.36%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Operators is and as – _Example_

```cs
class Base { }
class Derived : Base { }
class TestOperatorsIsAndAs
{
   static void Main()
   {
      Object objBase = new Base();
      if (objBase is Base)
          Console.WriteLine("objBase is Base");
      // Result: objBase is Base
      if (! (objBase is Derived))
          Console.WriteLine("objBase is not Derived");
      // Result : objBase is not Derived
      if (objBase is System.Object)
          Console.WriteLine("objBase is System.Object");
      // Result : objBase is System.Object
```

_the example continues_



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
<!-- # Operators is and as – _Example_ -->

```cs
 	 Base b = objBase as Base;
        Console.WriteLine("b = {0}", b);
        // Result: b = Base
        Derived d = objBase as Derived;
        if (d == null)
            Console.WriteLine("d is null");
        // Result: d is null
        Object o = objBase as Object;
        Console.WriteLine("o = {0}", o);
        // Result: o = Base
        Derived der = new Derived();
        Base bas = der as Base;
        Console.WriteLine("bas = {0}", bas);
        // Result: bas = Derived
    }
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Operators is and as
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/06.%20Common-Type-System/demos/Is-and-as-Operators) -->


<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Object Cloning -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic32.png" style="top:42%; left:20%; width:60%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { id:'cloning', showInPresentation:true, hasScriptWrapper:false } -->
# <a id="cloning"></a>Object Cloning
- In programming `cloning` an object means to create an identical copy of certain object
- `Shallow cloning`(shallow copy)
  - Uses the protected `MemberwiseClone()` method
  - Copies the value types bit by bit (binary)
  - Copies only the addresses of the reference types
- `Deepcloning`(deep copy)
  - Recursively copies all member data
  - Implemented manually by the programmer


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
<!-- # Object Cloning -->
- Types which allow cloning implement the `ICloneable` interface
- The `Clone()` method of the `ICloneable`
  - The only method of the interface
  - Returns an identical copy of the object
    - Returns `object` &rarr; must be casted later
  - You decide whether to create a **deep** or **shallow** copy or **something between**


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Object Cloning – _Example_

```cs
class LinkedList<T>: ICloneable
{
  public T Value { get; set; }
  public LinkedList<T> NextNode { get; private set; }

  public LinkedList(T value,
    LinkedList<T> nextNode = null)
  {
    this.Value = value;
    this.NextNode = nextNode;
  }

  object ICloneable.Clone()  // Implicit implementation
  {
    return this.Clone();
  }
}
```

_the example continues_



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Object Cloning – _Example_ -->

```cs
public LinkedList<T> Clone() // our method Clone()
{
  // Copy the first element
  LinkedList<T> original = this;
  T valueOriginal = original.Value;
  LinkedList<T> result = new LinkedList<T>(valueOriginal);
  LinkedList<T> copy = result;
  original = original.NextNode;
  // Copy the rest of the elements
  while (original != null)
  {
    valueOriginal = original.Value;
    copy.NextNode = new LinkedList<T>(valueOriginal);
    original = original.NextNode;
    copy = copy.NextNode;
  }
  return result;
}
```


<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic33.png" style="top:39.26%; left:70%; width:23.74%; z-index:0" /> -->


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Deep and Shallow Object Cloning
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/06.%20Common-Type-System/demos/ObjectCloning) -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # The Interface IComparable&lt;T&gt; -->


<!-- attr: { id:'icomparable',showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.9em' } -->
# <a id="icomparable"></a>IComparable&lt;T&gt; Interface
- The <code>System.IComparable&lt;T&gt;</code> interface
  - Implemented by the types, which can be compared (ordered in increasing order)
- The `CompareTo(T)` method defines the comparison. It returns:
  - Number `< 0`– if the passed object is bigger than the `this` instance
  - Number `= 0` – if the passed object is equal to the `this` instance
  - Number `> 0`– if the passed object is smaller than the `this` instance



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# IComparable&lt;T&gt; – _Example_

```cs
class Point : IComparable<Point>
{
  public int X { get; set; }
  public int Y { get; set; }
  public int CompareTo(Point otherPoint)
  {
    if (this.X != otherPoint.X)
    {
      return (this.X - otherPoint.X);
    }
    if (this.Y != otherPoint.Y)
    {
      return (this.Y - otherPoint);
    }
    return 0;
  }
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Implementing IComparable&lt;T&gt;
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/06.%20Common-Type-System/demos/Implementing-IComparable) -->


<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # The IEnumerable&lt;T&gt; Interface -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic39.png" style="top:55%; left:3.17%; width:98.93%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { id:'ienumerable', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="ienumerable"></a>IEnumerable&lt;T&gt;
- The <code>IEnumerable&lt;T&gt;</code> interface provides collection classes with `foreach` traversal
  - It consists of 4 interfaces: <code>IEnumerable<T></code>, `IEnumerable`, <code>IEnumerator&lt;T&gt;</code>, `IEnumerator`

```cs
public interface IEnumerable<T> : IEnumerable
{
  IEnumerator<T> GetEnumerator();
}

// Non-generic version (compatible with .NET 1.1)
public interface IEnumerable : IEnumerable
{
  IEnumerator GetEnumerator();
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# IEnumerator&lt;T&gt;
- The <code>IEnumerator&lt;T&gt;</code> interface provides sequential read-only, forward-only iterator

```cs
public interface IEnumerator<T> : IEnumerator
{
  bool MoveNext();
  void Reset();
  T Current { get; }
}

public interface IEnumerator
{
  bool MoveNext();
  void Reset();
  object Current { get; }
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Yield Return in C&#35;
- The `yield return` construct in C# simplifies the <code>IEnumerator&lt;T&gt;</code> implementations
  - When a yield return statement is reached
    - The expression is returned, and the current location in code is retained (for later use)

```cs
public IEnumerator<int> GetEnumerator()
{
  for (int i=100; i<200; i++)
  {
    yield return i;
  }
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Implementing IEnumerable<T>
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/06.%20Common-Type-System/demos/ImplementingIEnumerable) -->


<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Value Types -->

<!-- attr: { id:'types', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="types"></a>Value Types
- Store their values in the stack
- Can not hold `null` value
- Destroyed when the given variable goes out of scope
- When a method is called they are:
  - Passed by value
  - Stored in the stack (copied)

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic42.png" style="top:51.13%; left:78.14%; width:25.49%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Value Types -->
- Inherit `System.ValueType`
- Value types are:
  - Primitive types
    - `int`, `char`
    - `float`, `bool`
    - Others
  - Structures
  - Enumerations (enumerable types)

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic43.png" style="top:24.68%; left:65.03%; width:33.19%; z-index:-1; border-radius: 10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Reference Types -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic44.png" style="top:42%; left:30.27%; width:41.10%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Reference Types
- Implemented as type-safe pointers to objects
- Stored in the dynamic memory
- When a method is called they are passed by reference (by their address)
- Automatically destroyed by the CLR Garbage Collector, when they are out of scope or they are not in use
- Can hold `null` value


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Reference Types -->
- It is possible for many variables to point to one and the same reference type object
- Referent objects are:
  - `System.Object`, `System.String`
  - Classes and interfaces
  - Arrays
  - Delegates
  - Pointers

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic45.png" style="top:50%; left:70%; width:30%; z-index:-1; border-radius: 10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Value vs. Reference Types
## Assigning, Memory Location and Values -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic46.png" style="top:55%; left:35%; width:35%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Assigning Values
- **Value Types**
  - When assigning value types, their value is copied to the variable
- **Reference Types**
  - When assigning referent type, only the reference (address) is copied and the objects stays the same


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Memory Location
- The memory location for value types is the program execution stack
- The memory location for reference types is the dynamic memory
  - Also called **managed** **heap**



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Values
- Value types can not take `null` as a value, because they are not pointers
- Value types inherit `System.ValueType`
- Reference types inherit `System.Object`
- Value type variables can be stored in reference types with the boxing technique


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 40px;' } -->
# Value and Reference Types - _Example_

```cs
class RefClass { public int value; }  // Reference type
struct ValStruct { public int value; }  // Value type
class TestValueAndReferenceTypes
{
    static void Main()
    {
        RefClass ref_Example_ = new RefClass();
        ref_Example_.value = 100;
        RefClass ref_Example_2 = ref_Example_;
        ref_Example_2.value = 200;
        Console.WriteLine(ref_Example_.value); // Prints 200

        ValStruct val_Example_ = new ValStruct();
        val_Example_.value = 100;
        ValStruct val_Example_2 = val_Example_;
        val_Example_2.value = 200;
        Console.WriteLine(val_Example_.value); // Prints 100
    }
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Types, Variables <br/> and Memory -->


<!-- <img showInPresentation="true" class="slide-image" src="imgs/memory.png" style="top:20%; left:10%; width:80%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Value and Reference Types
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/06.%20Common-Type-System/demos/Value-And-Reference-Types) -->



<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Boxing and Unboxing -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic50.png" style="top:45%; left:25%; width:20%; z-index:-1; border-radius: 10px;" /> -->
<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic51.png" style="top:45%; left:55%; width:25.73%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { id:'boxing', showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.9em' } -->
# <a id="boxing"></a>Boxing and Unboxing
- Value types can be stored in reference types
- If needed CLR boxes and unboxes value types
- Boxing is operation, that converts a value type to a reference one

```cs
int i = 123;
// The following line boxes i.
object o = i;  
```
- Unboxing is the opposite operation
  - Converts boxed value to ordinary value type

```cs
o = 123;
i = (int)o;  // unboxing
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Boxing
1. Allocates dynamic memory for the creation of the object
1. Copies the contents of the variable from the stack to the allocated dynamic memory
1. Returns a reference to the created object in the dynamic memory
1. The original type is memorized
1. The dynamic memory contains information, that the object reference holds boxed object



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Unboxing
1. If the reference is `null` a `NullReferenceException` is thrown
1. If the reference does not point to a valid boxed value an `InvalidCastException` is thrown
1. The value is pulled from the heap and is stored into the stack



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Boxing Value Types -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/boxing.png" style="top:17.32%; left:10.08%; width:85%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Boxing and Unboxing – _Example_

```cs
using System;
class TestBoxingUnboxing
{
    static void Main()
    {
        int value1 = 1;
        object obj = value1; // boxing performed

        value1 = 12345; // only stack value is changed

        int value2 = (int)obj;  // unboxing performed
        Console.WriteLine(value2); // prints 1

        long value3 = (long) (int) obj; // unboxing
        long value4 = (long) obj; // InvalidCastException
    }
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Boxing and Unboxing Primitive Types
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/06.%20Common-Type-System/demos/BoxingUnboxingPrimitiveTypes) -->



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Boxing and Unboxing – _Example_

```cs
interface IMovable
{
    void Move(int x, int y);
}
// Very bad practice! Structures should
// contain no logic, but only data!
struct Point : IMovable
{
    public int x, y;
    public void Move(int x, int y)
    {
       this.x += x;
       this.y += y;
    }
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Boxing and Unboxing Custom Types
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/06.%20Common-Type-System/demos/Boxing-and-Unboxing) -->


<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Passing Parameters
## `ref` and `out` Keywords -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic59.png" style="top:52%; left:30.10%; width:40%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { id:'params', showInPresentation:true, hasScriptWrapper:false } -->
# <a id="params"></a>Passing Parameters
- Parameters can be passed in several ways to the methods:
  - `in` (default)
    - Passing value for value types
    - Passing heap address for reference types
  - `out`
    - Passed by stack address for both value types and reference types
    - The initialization can be done by the called method


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Passing Parameters
- Parameters can be passed in several ways to the methods:
  - `ref`
    - Passed by stack address for both value types and reference types
    - Initialization can't be done by the called method – access is for read and write

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic60.png" style="top:60%; left:75%; width:22.04%; z-index:-1; border-radius: 10px;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 40px;' } -->
# ref Parameters – _Example_

```cs
public class Student
{
  public string name;
  static void IncorrectModifyStudent(Student student)
  {
     student = new Student("Changed: " + student.name);
  }
  static void ModifyStudent(ref Student student)
  {
     student = new Student("Changed: " + student.name);
  }
  static void Main()
  {
     Student s = new Student("Ivaylo");
     Console.WriteLine(s.name); // Ivaylo
     IncorrectModifyStudent(s);
     Console.WriteLine(s.name); // Ivaylo
     ModifyStudent(ref s);
     Console.WriteLine(s.name); // Changed: Ivaylo
  }
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # `ref` Parameters
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/06.%20Common-Type-System/demos/PassingRefParameters) -->



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# out Parameters – _Example_

```cs
class TestOutParameters
{
  static void Main()
  {
    Rectangle rect = new Rectangle(5, 10, 12, 8);
    Point location;
    Dimensions dimensions;

    // Location and dimension are not pre-initialized!
    rect.GetLocationAndDimensions(
        out location, out dimensions);

    Console.WriteLine("({0}, {1}, {2}, {3})",
        location.x, location.y,
        dimensions.width, dimensions.height);
    // Result: (5, 10, 12, 8)
  }
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # `out` Parameters
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/06.%20Common-Type-System/demos/PassingOutParameters) -->



<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:false } -->
<!-- # Common Type System
## Questions? -->

<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
    - [C# OOP Course](http://academy.telerik.com/student-courses/programming/object-oriented-programming/about)
  - Telerik Software Academy
    - [telerikacademy.com](https://telerikacademy.com)
  - Telerik Academy @ Facebook
    - [facebook.com/TelerikAcademy](facebook.com/TelerikAcademy)
  - Telerik Software Academy Forums
    - [forums.academy.telerik.com](forums.academy.telerik.com)

<!-- <img showInPresentation="false" class="slide-image" src="imgs/pic26.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1; border-radius: 10px;" /> -->
<!-- <img showInPresentation="false" class="slide-image" src="imgs/pic27.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1; border-radius: 10px;" /> -->
<!-- <img showInPresentation="false" class="slide-image" src="imgs/pic28.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1; border-radius: 10px;" /> -->
<!-- <img showInPresentation="false" class="slide-image" src="imgs/pic29.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1; border-radius: 10px;" /> -->
