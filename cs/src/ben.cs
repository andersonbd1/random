// Fig. 10.25: Delegates.cs
// Using delegates to pass functions as arguments.
using System;
using System.Collections.Generic;

class Delegates
{
   // delegate for a function that receives an int and returns a bool
   public delegate bool NumberPredicate( int number );               

   static void Main( string[] args )
   {
      int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

      // create an instance of the NumberPredicate delegate type
      NumberPredicate evenPredicate = IsEven;                   

      // call IsEven using a delegate variable
      Console.WriteLine( "Call IsEven using a delegate variable: {0}",
         evenPredicate( 4 ) );

      // filter the even numbers using method IsEven                  
      List< int > evenNumbers = FilterArray( numbers, evenPredicate );

      // display the result
      DisplayList( "Use IsEven to filter even numbers: ", evenNumbers );

      // filter the odd numbers using method IsOdd           
      List< int > oddNumbers = FilterArray( numbers, IsOdd );

      // display the result
      DisplayList( "Use IsOdd to filter odd numbers: ", oddNumbers );

      // filter numbers greater than 5 using method IsOver5      
      List< int > numbersOver5 = FilterArray( numbers, IsOver5 );

      // display the result
      DisplayList( "Use IsOver5 to filter numbers over 5: ",
         numbersOver5 );
   } // end Main

   // select an array's elements that satisfy the predicate
   private static List< int > FilterArray( int[] intArray,
      NumberPredicate predicate )
   {
      // hold the selected elements
      List< int > result = new List< int >();

      // iterate over each element in the array
      foreach ( int item in intArray )
      {
         // if the element satisfies the predicate
         if ( predicate( item ) )
            result.Add( item ); // add the element to the result
      } // end foreach

      return result; // return the result
   } // end method FilterArray

   // determine whether an int is even
   private static bool IsEven( int number )
   {
      return ( number % 2 == 0 );
   } // end method IsEven

   // determine whether an int is odd
   private static bool IsOdd( int number )
   {
      return ( number % 2 == 1 );
   } // end method IsOdd

   // determine whether an int is positive
   private static bool IsOver5( int number )
   {
      return ( number > 5 );
   } // end method IsOver5

   // display the elements of a List
   private static void DisplayList( string description, List< int > list )
   {
      Console.Write( description ); // display the output's description

      // iterate over each element in the List
      foreach ( int item in list )
         Console.Write( "{0} ", item ); // print item followed by a space

      Console.WriteLine(); // add a new line
   } // end method DisplayList
} // end class Delegates

