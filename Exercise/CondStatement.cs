/*
1.Write a C# Sharp program to accept two integers and check whether they are equal or not.
Test Data :
Input 1st number: 5
Input 2nd number: 5
Expected Output :
5 and 5 are equal
*/
public class Exercise1
{
    public static void Main( )
    {
        int x = System.Convert.ToInt32(System.Console.ReadLine());
        int y = System.Convert.ToInt32(System.Console.ReadLine());
       
        if (x==y)
        {
            System.Console.WriteLine(x +" and "+ y +" are equal");
           
        }
        else
        {
            System.Console.WriteLine(x +" and "+ y +" are not equal");
        }
    }
}
/*
3. Write a C# Sharp program to check whether a given number is positive or negative. Go to the editor
Test Data : 14
Expected Output :
14 is a positive number
*/
public class ExerciseCond3
{
    public static void Main( )
    {   
        int n = System.Convert.ToInt32(System.Console.ReadLine());
        
        if (n > 0) 
        {
            System.Console.WriteLine("Positif");
        } 
        else if (n == 0)
        {
            System.Console.WriteLine(0);
        }
        else
        {
            System.Console.WriteLine("Negatif");
        }
    }
}
/*
9. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
Test Data :
Input the value for X coordinate :7
Input the value for Y coordinate :9
Expected Output :
The coordinate point (7,9) lies in the First quadrant.
*/
public class Exercise1
{
    public static void Main( )
    {
         int x = System.Convert.ToInt32(System.Console.ReadLine());
         int y = System.Convert.ToInt32(System.Console.ReadLine());
    if ( x> 0 && y > 0)
    {
        System.Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the First Qaudrant.");
    }
    else if (x < 0 && y >0)
    {
        System.Console.WriteLine( "The coordinate point (" + x + "," + y + ") lies in the Second Qaudrant.");
    }
    else if (x < 0 && y < 0)
    {
        System.Console.WriteLine( "The coordinate point (" + x + "," + y + ") lies in the Third Qaudrant.");
    }
    else if (x > 0 && y < 0)
    {
        System.Console.WriteLine( "The coordinate point (" + x + "," + y + ") lies in the Forth Qaudrant");   
    }
    else
    {
        System.Console.WriteLine( "The coordinate point (" + x + "," + y + ") lies in the middle");
    }
  }
}
/*
22. Write a program in C# Sharp to read any Month Number in integer and display Month name in the word. Go to the editor
Test Data :
4
Expected Output:
April
*/
using System; /* Avec switch */
public class ExerciseCond3
{
    public static void Main( )
    {   
        int mois = System.Convert.ToInt32(System.Console.ReadLine());
        
        switch (mois) 
        {
            case 1:
                Console.WriteLine("Janvier");
                break;
            case 2:
                Console.WriteLine("Fevrier");
                break;
            case 3:
                Console.WriteLine("Mars");
                break;
            case 4:
                Console.WriteLine("Avril");
                break;
            case 5:
                Console.WriteLine("Mai");
                break;
            case 6:
                Console.WriteLine("Juin");
                break;
            case 7:
                Console.WriteLine("Juillet");
                break;
            /* etc....... */
            default:
                Console.WriteLine("Mettre un mois");
                break;
        }
    }
}

using System; /* Avec else if */
public class ExerciseCond3
{
    public static void Main( )
    {   
        int mois = System.Convert.ToInt32(System.Console.ReadLine());
        
        if (mois == 1)
        {
            Console.WriteLine("Janvier");
        }
        else if (mois == 2)
        {
            Console.WriteLine("Fevrier");
        }
        else if (mois == 3)
        {
            Console.WriteLine("Mars");
        }
        else if (mois == 4)
        {
            Console.WriteLine("Avril");
        }
        /* blah blah blah */
        else
        {
            Console.WriteLine("Mettre un mois");
        }
    }
}

