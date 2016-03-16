<!-- section start -->
<!-- attr: { id:'', class:'slide-title', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Common Type System
## .NET Types Hierarchy, Cloning, Comparing,Value and Reference Types, Parameters Passing
<img class="slide-image" src="\imgs\pic00.png" style="top:52.11%; left:62.69%; width:39.67%; z-index:-1" />
<img class="slide-image" src="\imgs\pic01.png" style="top:10.95%; left:4.29%; width:17.81%; z-index:-1" />
<img class="slide-image" src="\imgs\pic04.png" style="top:55.07%; left:65.07%; width:13.75%; z-index:-1" />
<img class="slide-image" src="\imgs\pic05.png" style="top:57.66%; left:75.75%; width:10.40%; z-index:-1" />
<img class="slide-image" src="\imgs\pic06.png" style="top:53.37%; left:90.61%; width:12.39%; z-index:-1" />
<img class="slide-image" src="\imgs\pic07.png" style="top:58.04%; left:85.22%; width:8.59%; z-index:-1" />
<img class="slide-image" src="\imgs\pic08.png" style="top:53.12%; left:82.89%; width:7.01%; z-index:-1" />
<img class="slide-image" src="\imgs\pic09.png" style="top:45.73%; left:31.43%; width:13.05%; z-index:-1" />
<div class="signature">
	<p class="signature-course"></p>
	<p class="signature-initiative"></p>
	<a href="" class="signature-link"></a>
</div>




<!-- section start -->
<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Table of Contents
- What is Common Type System (CTS)?
  - Types Hierarchy
- The System.Object type
  - Overriding the Virtual Methodsin **System.Object**
- Operators **is** and **as**
- Object Cloning
  - **ICloneable** Interface
- The **IComparable<T>** Interface
<img class="slide-image" src="\imgs\pic10.png" style="top:43.20%; left:75.79%; width:30.33%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
<!-- # Table of Contents -->
- The **IEnumerable<T>** interface
- Value Types and Reference Types
  - Boxing and Unboxing
- Passing Parameters
  - Input, Output and Reference Passing
<img class="slide-image" src="\imgs\pic11.png" style="top:51.29%; left:62.35%; width:26.76%; z-index:-1" />
<img class="slide-image" src="\imgs\pic12.png" style="top:52.04%; left:18.82%; width:23.53%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# What is Common Type System (CTS)?
<img class="slide-image" src="\imgs\pic14.png" style="top:50.25%; left:17.78%; width:21.32%; z-index:-1" />
<img class="slide-image" src="\imgs\pic15.png" style="top:59.68%; left:76.72%; width:10.40%; z-index:-1" />
<img class="slide-image" src="\imgs\pic16.png" style="top:58.77%; left:85.22%; width:8.59%; z-index:-1" />
<img class="slide-image" src="\imgs\pic17.png" style="top:55.13%; left:81.47%; width:7.01%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Inside .NET Framework
- Building blocks of .NET Framework
<img class="slide-image" src="\imgs\net-framework.png" style="top:20.13%; left:10.47%; width:95%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# What is CTS?
- .NET Common Type System (CTS)
- Defines CLR supported
  - Data types
  - Operations performed on them
- Extends the compatibility between different .NET languages
- Supports two types of data
  - Value types
  - Reference types
- All data types are inheritors of **System.Object**
<img class="slide-image" src="\imgs\pic18.png" style="top:20.28%; left:80.47%; width:13.81%; z-index:-1" />
<img class="slide-image" src="\imgs\pic19.png" style="top:19.37%; left:90.71%; width:11.40%; z-index:-1" />
<img class="slide-image" src="\imgs\pic20.png" style="top:14.10%; left:86.39%; width:9.30%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# .NET CTS Types Hierarchy
<img class="slide-image" src="\imgs\pic21.png" style="top:15.29%; left:6.08%; width:95.03%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# The  System.Object Type
<img class="slide-image" src="\imgs\pic22.png" style="top:42%; left:38.60%; width:35.04%; z-index:-1" />
<img class="slide-image" src="\imgs\pic23.png" style="top:38.94%; left:69.24%; width:27.33%; z-index:-1" />
<img class="slide-image" src="\imgs\pic24.png" style="top:35.30%; left:8.87%; width:34.06%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# System.Object Type
- Base class for each .NET type
  - Inherited by default whena new type is defined
- Important virtual methods:
  - **Equals()** – comparison with other object
  - **ToString()** – represents the object as a string
  - **GetHashCode()** – evaluates the hash code (used with hash-tables)
  - **Finalize()** – used for clean up purposes when an object is disposed
<img class="slide-image" src="\imgs\pic25.png" style="top:12.41%; left:79.30%; width:21.98%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Overriding the Virtual Methods in System.Object
<img class="slide-image" src="\imgs\pic26.png" style="top:52%; left:25.26%; width:43.21%; z-index:-1" />
<img class="slide-image" src="\imgs\pic27.png" style="top:52%; left:61.27%; width:27.33%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Overriding System.Object's Virtual Methods
- By default the operator **==** calls the **ReferenceEquals()** method
  - Compares the addresses for reference types
  - Or the binary representation for value types
- The methods **Equals()**, **GetHashCode()** should be defined at the same time
  - The same applies for the operators **==** and **!=**
  - You can override **Equals()** and use its implementation for **==** and **!=**


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'font-size:40px;' } -->
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



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
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



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Overriding the Virtual Methods in System.Object
## [Demo]()



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# More About System.Object
- The **System.Object** type has some other methods, which are inherited by all .NET types:
  - **GetType()**
    - Returns type's metadata as a **System.Type**
  - **MemberwiseClone()**
    - Copies the binary representation of the variable into a new variable (shallow clone)
  - **ReferenceEquals()**
    - Compares if two object have the same reference




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# is and as operators
<img class="slide-image" src="\imgs\pic29.png" style="top:42%; left:28.98%; width:51.15%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Type Operators in C#
- The **is** operator
  - Checks if an object an is instance of some type
  - Polymorphic operation
    - 5 is Int32
    - 5 is object
    - 5 is IComparable<int>
- The **as** operator
  - Casts a reference type to another reference type
  - Returns **null** value if it fails
    - E.g. if the types are incompatible
<img class="slide-image" src="\imgs\pic30.png" style="top:28.82%; left:72.82%; width:28.36%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
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



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
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



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Operators is and as
## [Demo]()
<img class="slide-image" src="\imgs\pic31.png" style="top:52%; left:29.59%; width:40%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Object Cloning
<img class="slide-image" src="\imgs\pic32.png" style="top:42%; left:20%; width:60%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Object Cloning
- In programming **cloning** an object means to create an identical copy of certain object
- **Shallow cloning**(shallow copy)
  - Uses the protected **MemberwiseClone()** method
  - Copies the value types bit by bit (binary)
  - Copies only the addresses of the reference types
- **Deepcloning**(deep copy)
  - Recursively copies all member data
  - Implemented manually by the programmer


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
<!-- # Object Cloning -->
- Types which allow cloning implement the **ICloneable** interface
- The **Clone()** method of the **ICloneable**
  - The only method of the interface
  - Returns an identical copy of the object
    - Returns **object** &rarr; must be casted later
  - You decide whether to create a **deep**or **shallow**copy or **something between**


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
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
```

_the example continues_



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
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

<img class="slide-image" src="\imgs\pic33.png" style="top:39.26%; left:74.85%; width:23.74%; z-index:0" />


<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Deep and Shallow Object Cloning
## [Demo]()




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# The Interface IComparable<T>
<img class="slide-image" src="\imgs\pic35.png" style="top:36.44%; left:28.13%; width:52.83%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# IComparable<T> Interface
- The **System.IComparable<T**> interface
  - Implemented by the types, which can be compared (ordered in increasing order)
- The **CompareTo(T)** method defines the comparison. It returns:
  - Number **< 0**– if the passed object isbigger than the **this** instance
  - Number **= 0** – if the passed object isequal to the **this** instance
  - Number **> 0**– if the passed object issmaller than the **this** instance
<img class="slide-image" src="\imgs\pic36.png" style="top:59.94%; left:84.58%; width:21.69%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# IComparable<T> – _Example_

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



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Implementing IComparable<T>
## [Demo]()


<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# The IEnumerable<T> Interface
<img class="slide-image" src="\imgs\pic39.png" style="top:42%; left:3.17%; width:98.93%; z-index:-1;" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# IEnumerable<T>
- The **IEnumerable<T>** interface provides collection classes with **foreach** traversal
  - It consists of 4 interfaces: **IEnumerable<T>**, **IEnumerable**, **IEnumerator<T>**, **IEnumerator**

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



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# IEnumerator<T>
- The **IEnumerator<T>** interface provides sequential read-only, forward-only iterator

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



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Yield Return in _C#_
- The **yield** **return** construct in C# simplifies the **IEnumerator<T>** implementations
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



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Implementing IEnumerable<T>
## [Demo]()
<img class="slide-image" src="\imgs\pic40.png" style="top:52%; left:3.17%; width:98.93%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Value Types
<img class="slide-image" src="\imgs\pic41.png" style="top:42%; left:23%; width:53.20%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Value Types
- Store their values in the stack
- Can not hold **null** value
- Destroyed when the given variable goes out of scope
- When a method is called they are:
  - Passed by value
  - Stored in the stack (copied)
<img class="slide-image" src="\imgs\pic42.png" style="top:51.13%; left:78.14%; width:25.49%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
<!-- # Value Types -->
- Inherit **System.ValueType**
- Value types are:
  - Primitive types
    - **int**, **char**
    - **float**, **bool**
    - Others
  - Structures
  - Enumerations (enumerable types)
<img class="slide-image" src="\imgs\pic43.png" style="top:24.68%; left:65.03%; width:33.19%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Reference Types
<img class="slide-image" src="\imgs\pic44.png" style="top:42%; left:30.27%; width:41.10%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Reference Types
- Implemented as type-safe pointers to objects
- Stored in the dynamic memory
- When a method is called they are passed by reference (by their address)
- Automatically destroyed by the CLR Garbage Collector, when they are out of scope or they are not in use
- Can hold **null** value


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
<!-- # Reference Types -->
- It is possible for many variables to point to one and the same reference type object
- Referent objects are:
  - **System.Object**, **System.String**
  - Classes and interfaces
  - Arrays
  - Delegates
  - Pointers
<img class="slide-image" src="\imgs\pic45.png" style="top:42.83%; left:59.88%; width:42.44%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Value vs. Reference Types
## Assigning, Memory Location and Values
<img class="slide-image" src="\imgs\pic46.png" style="top:34.16%; left:28.07%; width:52.89%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Assigning Values
- **Value Types**
  - When assigning value types, their value is copied to the variable
- **Reference Types**
  - When assigning referent type, only the reference (address) is copied and the objects stays the same


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Memory Location
- The memory location for value types is the program execution stack
- The memory location for reference types is the dynamic memory
  - Also called **managed** **heap**
<img class="slide-image" src="\imgs\pic47.png" style="top:53.77%; left:42.10%; width:19.72%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Values
- Value types can not take **null** as a value, because they are not pointers
- Value types inherit **System.ValueType**
- Reference types inherit **System.Object**
- Value type variables can be stored in reference types with the boxing technique


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'font-size: 40px;' } -->
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



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Types, Variables and Memory

<img class="slide-image" src="\imgs\memory.png" style="top:20%; left:10%; width:80%; z-index:-1" />


<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Value and Reference Types
## [Demo]()
<img class="slide-image" src="\imgs\pic48.png" style="top:31.74%; left:33.68%; width:42.31%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Boxing and Unboxing
<img class="slide-image" src="\imgs\pic49.png" style="top:15.87%; left:31.81%; width:47.16%; z-index:-1" />
<img class="slide-image" src="\imgs\pic50.png" style="top:5.60%; left:73.92%; width:25.56%; z-index:-1" />
<img class="slide-image" src="\imgs\pic51.png" style="top:32.62%; left:8.42%; width:25.73%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Boxing and Unboxing
- Value types can be stored in reference types
- If needed CLR boxes and unboxes value types
- Boxing is operation, that converts a value type to a reference one
- Unboxing is the opposite operation
  - Converts boxed value to ordinary value type
<img class="slide-image" src="\imgs\pic52.png" style="top:60%; left:26.20%; width:19.87%; z-index:-1" />
<img class="slide-image" src="\imgs\pic53.png" style="top:60%; left:68.21%; width:25.73%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Boxing
- Allocates dynamic memory for the creation of the object
- Copies the contents of the variable from the stack to the allocated dynamic memory
- Returns a reference to the created object in the dynamic memory
- The original type is memorized
- The dynamic memory contains information, that the object reference holds boxed object
<img class="slide-image" src="\imgs\pic54.png" style="top:44.08%; left:94.50%; width:11.46%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Unboxing
- If the reference is **null** a **NullReferenceException** is thrown
- If the reference does not point to a valid boxed value an **InvalidCastException** is thrown
- The value is pulled from the heap and is stored into the stack
<img class="slide-image" src="\imgs\pic55.png" style="top:17.32%; left:86.08%; width:19.06%; z-index:-1" />
<img class="slide-image" src="\imgs\pic56.png" style="top:57.30%; left:86.08%; width:19.01%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Boxing Value Types
<img class="slide-image" src="\imgs\boxing.png" style="top:17.32%; left:10.08%; width:85%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
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



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Boxing and Unboxing Primitive Types
## [Demo]()



<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Boxing and Unboxing – _Example_

```cs
interface IMovable
{
    void Move(int x, int y)
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



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Boxing and Unboxing Custom Types
## [Demo]()
<img class="slide-image" src="\imgs\pic58.png" style="top:11.46%; left:55.20%; width:47.60%; z-index:-1" />




<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Passing Parameters
## **ref** and **out** Keywords
<img class="slide-image" src="\imgs\pic59.png" style="top:52%; left:30.10%; width:40%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Passing Parameters
- Parameters can be passed in several ways to the methods:
  - **in** (default)
    - Passing value for value types
    - Passing heap address for reference types
  - **out**
    - Passed by stack address for both value types and reference types
    - The initialization can be done by the called method


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# Passing Parameters
- Parameters can be passed in several ways to the methods:
  - **ref**
    - Passed by stack address for both value types and reference types
    - Initialization can't be done by the called method – access is for read and write
<img class="slide-image" src="\imgs\pic60.png" style="top:55.54%; left:83.27%; width:22.04%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'font-size: 40px;' } -->
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



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# ref Parameters
## [Demo]()
<img class="slide-image" src="\imgs\pic61.png" style="top:45.84%; left:7.49%; width:41.96%; z-index:-1" />


<!-- attr: { id:'', class:'', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
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



<!-- attr: { id:'', class:'slide-section demo', showInPresentation:'True', hasScriptWrapper:'True', style:'' } -->
# out Parameters
## [Demo]()
<img class="slide-image" src="\imgs\pic62.png" style="top:8.82%; left:72.05%; width:24.68%; z-index:-1" />


<!-- attr: { id:'', class:'slide-section', showInPresentation:'True', hasScriptWrapper:'False', style:'' } -->
# Common Type System
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
