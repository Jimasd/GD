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
        
        if (n > 0) {
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

