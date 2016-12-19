<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true } -->
# Extension Methods, Lambda Expressions and LINQ
## Extension Methods, Anonymous Types, Delegates, Lambda Expressions, LINQ, Dynamic

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic00.png" style="top:67%; left:76%; width:25%; z-index:-1; border-radius:10px;" /> -->
<div class="signature">
	<p class="signature-course">C# OOP</p>
	<p class="signature-initiative">Telerik Software Academy</p>
	<a href="https://telerikacademy.com" class="signature-link">https://telerikacademy.com</a>
</div>




<!-- section start -->
<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Table of Contents
- [Extension Methods](#extension)
- [Anonymous Types](#anonymous)
- [Delegates](#delegate)
- [Events](#event)
- [Lambda Expressions](#lambdas)
- [LINQ Queries](#linq)
- [Dynamic Type](#dynamics)

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic02.png" style="top:12.34%; left:58.01%; width:40%; z-index:-1; border-radius:10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Extension Methods

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic03.png" style="top:45%; left:40%; width:20%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'extension', showInPresentation:true, hasScriptWrapper:true } -->
# <a id="extension"></a>Extension Methods
- Once a type is defined and compiled into an assembly its definition is, more or less, final
  - The only way to update, remove or add new members is to recode and recompile the code
- **Extension methods** allow existing compiled types to gain new functionality
  - Without recompilation
  - Without touching the original assembly


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Defining Extension Methods
- Extension methods
  - Defined in a static class
  - Defined as `static`
  - Use `this` keyword before its first argument to specify the class to be extended
- Extension methods are "attached" to the extended class
  - Can also be called **statically** through the defining static class


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Extension Methods – _Examples_

```cs
public static class Extensions
{
  public static int WordCount(this string str)
  {
    return str.Split(new char[] { ' ', '.', '?' },
    StringSplitOptions.RemoveEmptyEntries).Length;
  }
}
...
static void Main()
{
  string s = "Hello Extension Methods";
  int i = s.WordCount();
  Console.WriteLine(i);
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
<!-- # Extension Methods – _Examples_ -->

```cs
public static void IncreaseWith(
    this IList<int> list, int amount)
{
    for (int i = 0; i < list.Count; i++)
    {
        list[i] += amount;
    }
}
// ...
static void Main()
{
    List<int> ints =
        new List<int> { 1, 2, 3, 4, 5 };
    ints.IncreaseWith(5); // 6, 7, 8, 9, 10
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Extension Methods
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/03.%20Extension-Methods-Delegates-Lambda-LINQ/demos/Extension-Methods) -->





<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Anonymous Types -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic06.png" style="top:45%; left:37%; width:30%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'anonymous', showInPresentation:true, hasScriptWrapper:false } -->
# <a id="anonymous"></a>Anonymous Types
- **Anonymous types**
  - Encapsulate a set of read-only properties and their value into a single object
  - No need to explicitly define a type first
- To define an anonymous type
  - Use of the new `var` keyword in conjunction with the object initialization syntax

```cs
var point = new { X = 3, Y = 5 };
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Anonymous Types – _Example_

```cs
// Use an anonymous type representing a car
var myCar =
  new { Color = "Red", Brand = "BMW", Speed = 180 };
Console.WriteLine("My car is a {0} {1}.",
  myCar.Color, myCar.Brand);
```

- At compile time, the C# compiler will autogenerate an uniquely named class
- The class name is not visible from C#
  - Using implicit typing (**var** keyword) is mandatory


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Anonymous Types – Properties
- Anonymous types are reference types directly derived from `System.Object`
- Have overridden version of `Equals()`, `GetHashCode()`, and `ToString()`
  - Do not have `==` and `!=` operators overloaded

```cs
var p = new { X = 3, Y = 5 };
var q = new { X = 3, Y = 5 };
Console.WriteLine(p == q); // false
Console.WriteLine(p.Equals(q)); // true
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Arrays of Anonymous Types
- You can define and use arrays of anonymous types through the following syntax:

```cs
var arr = new[]
{
    new { X = 3, Y = 5 },
    new { X = 1, Y = 2 },
    new { X = 0, Y = 7 }
};

foreach (var item in arr)
{
    Console.WriteLine("({0}, {1})", item.X, item.Y);
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Anonymous Types
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/03.%20Extension-Methods-Delegates-Lambda-LINQ/demos/Annonymous-Types) -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic07.png" style="top:55%; left:35%; width:30%; z-index:-1; border-radius:10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Delegates in .NET Framework -->


<!-- attr: { id:'delegate', showInPresentation:true, hasScriptWrapper:false } -->
# <a id="delegate"></a>What are Delegates?
- **Delegates** are special .NET types that **hold a method reference**
- Describe the **signature** of given method
  - Number and types of the parameters
  - The return type
- Their "values" are methods
  - These methods match their signature (parameters and return types)
  - Delegates are reference types


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
<!-- # What are Delegates? -->
- Delegates are roughly similar to function pointers in C and C++
  - Strongly-typed pointer (reference) to a method
  - Pointer (address) to a callback function
- Can point to static and instance methods
- Can point to a sequence of multiple methods
  - Known as multicast delegates
- Used to perform **callback** invocations
- Implement the "publish-subscribe" model


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Delegates – _Example_

```cs
// Declaration of a delegate
public delegate void SimpleDelegate(string param);
public class Delegates_Example_
{
  static void TestMethod(string param)
  {
    Console.WriteLine("I was called by a delegate.");
    Console.WriteLine("I got parameter: {0}.", param);
  }
  static void Main()
  {
    // Instantiate the delegate
    SimpleDelegate d = new SimpleDelegate(TestMethod);
    // Invocation of the method, pointed by delegate
    d("test");
  }
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Simple Delegate
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/03.%20Extension-Methods-Delegates-Lambda-LINQ/demos/Delegates-Example) -->



<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 40px;' } -->
# Generic and Multicast Delegates
- A delegate can be generic:

```cs
public delegate void SomeDelegate&lt;T&gt;(T item);
```

- Using a generic delegate:

```cs
public static void Notify(int i) { … }
SomeDelegate<int> d = new SomeDelegate<int>(Notify);
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 40px;' } -->
<!-- # Generic and Multicast Delegates -->

  - The above can simplified as follows:

```cs
SomeDelegate<int> d = Notify;
```

  - Delegates are **multicast** (can hold multiple methods), assigned through the `+=` operator:

```cs
d += Notify;
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 40px;' } -->
# Anonymous Methods
- **Anonymous methods** are methods without name
  - Can take parameters and return values
  - Declared through the `delegate` keyword

```cs
class SomeClass
{
  delegate void SomeDelegate(string str);
  static void Main()
  {
    SomeDelegate d = delegate(string str)
    {
      MessageBox.Show(str);
    };
    d("Hello");
  }
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 40px;' } -->
# Multicast Delegates – _Example_

```cs
delegate int StringDelegate&lt;T&gt;(T value);
public class MultiDelegates
{
  static int PrintString(string str)
  {
    Console.WriteLine("Str: {0}", str);
    return 1;
  }
  int PrintStringLength(string value)
  {
    Console.WriteLine("Length: {0}", value.Length);
    return 2;
  }
  public static void Main()
  {
    StringDelegate<string> d = MultiDelegates.PrintString;
    d += new MultiDelegates().PrintStringLength;
    int result = d("some string value");
    Console.WriteLine("Returned result: {0}", result);
  }
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Predefined Delegates
- Predefined delegates in .NET:
  - <code>Action&lt;T1,T2,T3&gt;</code> - generic predefined void delegate with parameters of types  `T1`, `T2` and `T3`
  - <code>Func&lt;T1,T2,TResult&gt;</code> - generic predefined delegate with return value of type TResult
  - Both have quite a lot of overloads

```cs
Func<string, int> predefinedIntParse = int.Parse;
int number = predefinedIntParse("50");

Action<object> predefinedAction = Console.WriteLine;
predefinedAction(1000);
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Multicast Generic Delegate
## [Demo]() -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic11.png" style="top:55%; left:35%; width:30%; z-index:-1; border-radius:10px;" /> -->




<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Events -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic12.png" style="top:42.79%; left:42.40%; width:38.90%; z-index:-1; border-radius:10px;" /> -->
<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic13.png" style="top:40.55%; left:8.10%; width:64.63%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'event', showInPresentation:true, hasScriptWrapper:false, style:'font-size: 40px;' } -->
# <a id="event"></a>Events
- A message sent by an object to signal the occurrence of an action
- Enable a class or object to notify other classes or objects when something of interest occurs
  - **Publisher**/**event sender** – the class that **sends**/**raises** the event
    - Doesn’t know which object/method will handle the event
  - **Subscribers** – the classes that **receive**/**handle** the event
- In the .NET events are based on the `EventHandler` delegate and the `EventArgs` base class


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 40px;' } -->
# Define Events
- Use `event` keyword
- Specify type of delegate for the event – `EventHandler`
- Add a `protected virtual` method
  - Name the method `On[EventName]`

```cs
class Counter {
  public event EventHandler ThresholdReached;
  protected virtual void OnThresholdReached(EventArgs e) {
    if (this.ThresholdReached != null) {
        this.ThresholdReached(this, e);
    }
  }
  // provide remaining implementation for the class
}
```


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Event Data
- Data that is associated with an event can be provided through an event data class
- `EventArgs` class is the base type for all event data classes
  - Also used when an event does not have any data associated with it
  - Naming of the data class – `[Name]EventArgs`

```cs
public class ThresholdReachedEventArgs : EventArgs
{
  public int Threshold { get; set; }
  public DateTime TimeReached { get; set; }
}
```


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Event Handlers
- To respond to an event, you define an **event handler** method
  - Must match the signature of the delegate

```cs
class Program {
  static void Main() {
    Counter counter = new Counter();
    counter.ThresholdReached += CounterThresholdReached;
    // provide remaining implementation for the class
  }
  static void CounterThresholdReached(
    object sender, EventArgs e) {
    Console.WriteLine("The threshold was reached.");
  }
}
```


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Events
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/03.%20Extension-Methods-Delegates-Lambda-LINQ/demos/Events) -->





<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Lambda Expressions -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic15.png" style="top:42%; left:23%; width:53.33%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'lambdas',showInPresentation:true, hasScriptWrapper:false } -->
# <a id="lambdas"></a>Lambda Expressions
- A lambda expression is an **anonymous function** containing expressions and statements
  - Used to create delegates or expression tree types
- Lambda expressions
  - Use the lambda operator `=>`
    - Read as "`goes to`"
  - The left side specifies the input parameters
  - The right side holds the expression or statement
- Link: [Lambda notation vs delegate keyword](http://stackoverflow.com/q/299703/1862812)


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Lambda Expressions –
## _Examples_
- Usually used with collection extension methods like `FindAll()` and `RemoveAll()`

```cs
List<int> list = new List<int>() { 1, 2, 3, 4 };
List<int> evenNumbers =
  list.FindAll(x => (x % 2) == 0);
foreach (var num in evenNumbers)
{
    Console.Write("{0} ", num);
}
Console.WriteLine();
// 2 4

list.RemoveAll(x => x > 3); // 1 2 3
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Sorting with Lambda Expression

```cs
var pets = new Pet[]
{
  new Pet { Name="Sharo", Age=8 },
  new Pet { Name="Rex", Age=4 },
  new Pet { Name="Strela", Age=1 },
  new Pet { Name="Bora", Age=3 }
};
var sortedPets = pets.OrderBy(pet => pet.Age);
foreach (Pet pet in sortedPets)
{
  Console.WriteLine("{0} -> {1}",
    pet.Name, pet.Age);
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Lambda Code Expressions
- Lambda code expressions:

```cs
List<int> list = new List<int>()
    { 20, 1, 4, 8, 9, 44 };

// Process each argument with code statements
List<int> evenNumbers = list.FindAll((i) =>
    {
    	Console.WriteLine("value of i is: {0}", i);
    	return (i % 2) == 0;
    });

Console.WriteLine("Here are your even numbers:");
foreach (int even in evenNumbers)
    Console.Write("{0}\t", even);
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Delegates HoldingLambda Functions
- Lambda functions can be stored in variables of type `delegate`
  - Delegates are typed references to functions
- Standard function delegates in .NET:
  - <code>Func&lt;TResult&gt;, Func&lt;T,TResult&gt;, Func&lt;T1,T2,TResult&gt;</code>, …

```cs
Func<bool> boolFunc = () => true;
Func<int, bool> intFunc = (x) => x < 10;
if (boolFunc() && intFunc(5))
  Console.WriteLine("5 < 10");
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'font-size:0.9em' } -->
# Predicates
- Predicates are predefined delegates with the following signature

```cs
public delegate bool Predicate&lt;T&gt;(T obj)
```

  - Define a way to check if an object meets some Boolean criteria
  - Similar to <code>Func&lt;T,bool&gt;</code>
- Used by many methods of `Array` and <code>List&lt;T&gt;</code> to search for an element
  - For example <code>List&lt;T&gt;.FindAll(…)</code> retrieves all elements meeting the criteria


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Predicates – _Example_

```cs
List<string> towns = new List<string>()
{
  "Sofia", "Plovdiv", "Varna", "Sopot", "Silistra"
};

List<string> townsWithS =
  towns.FindAll(delegate(string town)
  {
    return town.StartsWith("S");
  });

// A short form of the above (with lambda expression)
List<string> townsWithS =
  towns.FindAll((town) => town.StartsWith("S"));

foreach (string town in townsWithS)
{
  Console.WriteLine(town);
}
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Lambda Expressions
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/03.%20Extension-Methods-Delegates-Lambda-LINQ/demos/LambdaExpressions) -->

<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic16.png" style="top:55%; left:37%; width:25%; z-index:-1; border-radius:10px; background-color: white;" /> -->


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Action&lt;T&gt; and Func&lt;T&gt;
- <code>Action&lt;T&gt;</code> - void delegate with parameter `T`
- <code>Func&lt;T, Result&gt;</code> - result delegate returning `T`

```cs
Action<int> act = (number) =>
{
   Console.WrileLine(number);}
act(10); // logs 10

Func<string, int, string> greet = (name, age) =>
{
   return "Name: " + name + "Age: " + age;
}
Console.WriteLine(greet("Ivaylo", 10));
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Action&lt;T&gt; and Func&lt;T&gt;
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/03.%20Extension-Methods-Delegates-Lambda-LINQ/demos/Action-And-Func) -->



<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # LINQ and Query Keywords -->

<!-- <img showInPresentation="false" class="slide-image" src="imgs/pic19.png" style="top:38.53%; left:20.58%; width:49.04%; z-index:-1; border-radius:10px;" /> -->
<!-- <img showInPresentation="false" class="slide-image" src="imgs/pic20.png" style="top:37.86%; left:63.65%; width:37.00%; z-index:-1; border-radius:10px;" /> -->
<!-- <img showInPresentation="true" class="slide-image" src="imgs/pic21.png" style="top:45%; left:25%; width:53.27%; z-index:-1; border-radius:10px;" /> -->


<!-- attr: { id:'linq', showInPresentation:true, hasScriptWrapper:false } -->
# <a id="linq"></a>LINQ Building Blocks
- `LINQ` is a set of extensions to .NET Framework
  - Encompasses language-integrated query, set, and transform operations
  - Consistent manner to obtain and manipulate "data" in the broad sense of the term
- `Query expressions` can be defined directly within the C# programming language
  - Used to interact with numerous data types
  - Converted to **expression trees** at compile time and evaluated at runtime


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # LINQ to * -->


<!-- <img showInPresentation="true" class="slide-image" src="imgs/linqto.png" style="top:10%; left:7.84%; width:90%; z-index:-1; border-radius:10px;" /> -->



<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# LINQ and Query Keywords
- Language Integrated Query (`LINQ`) query keywords
  - `from` – specifies data source and range variable
  - `where` – filters source elements
  - `select` – specifies the type and shape that the elements in the returned sequence
  - `group` – groups query results according to a specified key value
  - `orderby` – sorts query results in ascending or descending order


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Query Keywords
##_Examples_
- `select`, `from` and `where` clauses:

```cs
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var querySmallNums =
    from num in numbers
    where num < 5
    select num;

foreach (var num in querySmallNums)
{
   Console.Write(num.ToString() + " ");
}
// The result is 4 1 3 2 0
```




<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Query Keywords
## _Examples_ -->
- Nested queries:

```cs
string[] towns =
  { "Sofia", "Varna", "Pleven", "Ruse", "Bourgas" };

var townPairs =
  from t1 in towns
    from t2 in towns
    select new { T1 = t1, T2 = t2 };

foreach (var townPair in townPairs)
{
  Console.WriteLine("({0}, {1})",
    townPair.T1, townPair.T2);
}
```




<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Query Keywords
## _Examples_ -->
- Sorting with `оrderby`:

```cs
string[] fruits =
  { "cherry", "apple", "blueberry", "banana" };

// Sort in ascending sort
var fruitsAscending =
    from fruit in fruits
    orderby fruit
    select fruit;

foreach (string fruit in fruitsAscending)
{
   Console.WriteLine(fruit);
}
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 40px;' } -->
# Standard Query Operators
## _Example_

```cs
string[] games = {"Morrowind", "BioShock", "Half Life",
  "The Darkness", "Daxter", "System Shock 2"};

// Build a query expression using extension methods
// granted to the Array via the Enumerable type

var subset = games
            .Where(game => game.Length > 6)
            .OrderBy(game => game)
            .Select(game => game);

foreach (var game in subset)
   Console.WriteLine(game);
```

```cs
var subset =
  from g in games
  where g.Length > 6
  orderby g
  select g;
```


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 40px;' } -->
# Counting the Occurrences
## of a Word in a String – _Example_

```cs
string text = "Historically, the world of data ...";
// …
string searchTerm = "data";
string[] source = text.Split(
   new char[] { '.', '?', '!', ' ', ';', ':', ',' },
   StringSplitOptions.RemoveEmptyEntries);

// Use ToLower() to match both "data" and "Data"
var matchQuery =
   from word in source
   where word.ToLower() == searchTerm.ToLower()
   select word;
int wordCount =
   matchQuery.Count();
```

```cs
int wordCount = source.Select(
  w => w.toLower() ==
  searchTerm.ToLower()).Count();
```


<!-- attr: { showInPresentation:true, hasScriptWrapper:false, style:'font-size: 40px;' } -->
# Querying Arrays
- Any kind of arrays can be used with LINQ
  - Can be even an untyped array of objects
  - Queries can be applied to arrays of custom objects
  - _Example_:

```cs
Book[] books = {
   new Book { Title="LINQ in Action" },
   new Book { Title="LINQ for Fun" },
   new Book { Title="Extreme LINQ" } };
var titles = books
   .Where(book => book.Title.Contains("Action"))
   .Select(book => book.Title);
```

```cs
var titles =
   from b in books
   where b.Title.Contains("Action")
   select b.Title;
```


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Querying Generic Lists
- The previous example can be adapted to work with a generic list
  - <code>List&lt;T&gt;, LinkedList&lt;T&gt;, Queue&lt;T&gt;, Stack&lt;T&gt;, HashSet&lt;T&gt;</code>, etc.

```cs
List<Book> books = new List<Book>() {
   new Book { Title="LINQ in Action" },
   new Book { Title="LINQ for Fun" },
   new Book { Title="Extreme LINQ" } };
var titles = books
   .Where(book => book.Title.Contains("Action"))
   .Select(book => book.Title);
```



<!-- attr: { showInPresentation:true, hasScriptWrapper:true} -->
# Querying Strings
- Although `System.String` may not be perceived as a collection at first sight
  - It actually is a collection, because it implements <code>IEnumerable&lt;char&gt;</code>
- String objects can be queried with LINQ to Objects, like any other collection

<!-- attr: { showInPresentation:true, hasScriptWrapper:true} -->
<!-- # Querying Strings -->
```cs
var count = "Non-letter characters in this string: 8"
  .Where(c => !Char.IsLetter(c))
  .Count();
Console.WriteLine(count);
// The result is: 8
```

```cs
var count =
  (from c in "Non-letter…"
  where !Char.IsLetter(c)
  select c).Count();
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Operations
- `Where()`
  - Searches by given condition
- `First()/FirstOrDefault()`
  - Gets the first matched element
- `Last()/LastOrDefault()`
  - Gets the last matched element
- `Select()/Cast()`
  - Makes projection (conversion) to another type
- `OrderBy()/ThenBy()/OrderByDescending()`
    - Orders a collection


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Operations
- `Any()`
  - Checks if any element matches a condition
- `All()`
  - Checks if all element matches a condition
- `ToArray()/ToList()/AsEnumerable()`
  - Converts the collection type
- `Reverse()`
    - Reverses a collection


<!-- attr: { showInPresentation:true, hasScriptWrapper:false } -->
# Aggregation Methods
- `Average()`
  - Calculates the average value of a collection
- `Count()`
  - Counts the elements in a collection
- `Max()`
  - Determines the maximum value in a collection
- `Sum()`
    - Sums the values in a collection


<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Aggregation Methods – _Examples_
- <code>Count(&lt;condition&gt;)</code>

```cs
double[] temperatures =
   { 28.0, 19.5, 32.3, 33.6, 26.5, 29.7 };
int highTempCount = temperatures.Count(p => p > 30);
Console.WriteLine(highTempCount);
// The result is: 2
```

```cs
var highTempCount =
  (from p in temperatures
   where p > 30
   select p).Count();
```
<!-- attr: { showInPresentation:true, hasScriptWrapper:true } -->
# Aggregation Methods – _Examples_
- `Max()`

```cs
double[] temperatures =
   { 28.0, 19.5, 32.3, 33.6, 26.5, 29.7 };
double maxTemp = temperatures.Max();
Console.WriteLine(maxTemp);
// The result is: 33.6
```

```cs
var maxTemp =
  (from p in temperatures
   select p).Max();
```


<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # LINQ Query Keywords
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/03.%20Extension-Methods-Delegates-Lambda-LINQ/demos/LINQ-Queries) -->





<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Dynamic Type -->



<!-- attr: { id:'dynamics', showInPresentation:true, hasScriptWrapper:false } -->
# <a id="dynamics"></a>Dynamic Type
- The Dynamic type is
  - Defined with the `dynamic` keyword
  - Can hold everything (different from object)
  - Evaluated at runtime
  - _Example_:

```cs
dynamic dyn = 5;
dyn = "Some text";
dyn = new Student();
dyn.Name = "Ivan";
dyn = new[] { 5, 8, 10 };
```



<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true } -->
<!-- # Dynamic Type
## [Demo](https://github.com/TelerikAcademy/Object-Oriented-Programming/tree/master/Topics/03.%20Extension-Methods-Delegates-Lambda-LINQ/demos/DynamicType) -->


<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:false } -->
<!-- # Extension Methods, Lambda Expressions and LINQ
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

<!-- <img showInPresentation="false" class="slide-image" src="imgs/pic40.png" style="top:60.37%; left:92.39%; width:13.45%; z-index:-1; border-radius:10px;" /> -->
<!-- <img showInPresentation="false" class="slide-image" src="imgs/pic41.png" style="top:30.85%; left:68.14%; width:36.30%; z-index:-1; border-radius:10px;" /> -->
<!-- <img showInPresentation="false" class="slide-image" src="imgs/pic42.png" style="top:46.32%; left:95.14%; width:10.85%; z-index:-1; border-radius:10px;" /> -->
<!-- <img showInPresentation="false" class="slide-image" src="imgs/pic43.png" style="top:13.00%; left:92.85%; width:13.01%; z-index:-1; border-radius:10px;" /> -->
