namespace Overview;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

//Starting with .NET 6
//Console.WriteLine("Hello, World!");


//-------------------
//   Key Features  
//-------------------

/* 
 * - Strongly Typed
 * - Garbage Collected, but w/ Access to Pointers
 * - C style
 * - More strict type saftey than C++
 * - Variety of Metaprogramming options
 * - Generics (similar to C++ templates, but very different underlying implementation and performance)
 * - Designed as an Object Oriented language
 * - Typically uses a JIT compiler that targets Microsoft's .NET Common Language Runtime (CLR)
 *      - Converts source code to cpu independent common intermediate language (CIL), then converts CIL to native code.
 * - Now has access to AOT compilation with some limitations
 * - Intended to be general purpose, and has a diverse array of available libraries.
 * 
 */