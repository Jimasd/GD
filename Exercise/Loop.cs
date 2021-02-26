/*
7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n. Go to the editor
Test Data :
Input upto the table number starting from 1 : 8
Expected Output :
Multiplication table from 1 to 8
1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
...
1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80
*/
public class LoopExercise7
{
    public static void Main( )
    {
    int n = System.Convert.ToInt32(System.Console.ReadLine());
    
    for (int i=1; i<=n; i++)
         {
             
             for (int j=1; j<=n; j++)
             {
                 System.Console.WriteLine(i + "*" + j + "=" + i*j);
             }
         }
    }
}

/*
9. Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk. Go to the editor
The pattern like :

*
**
***
****
*/
public class LoopExercise9
{
    public static void Main( )
    {
    string line = "";
   
    for (int i=1; i<=4; i++)
         {
            
             for (int j=1; j<=i; j++)
             {
                 line += "*";
             }
             System.Console.WriteLine(line);
             line = "";
         }
    }
}

/*
11. Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row. Go to the editor
The pattern like :

1
22
333
4444
*/
public class LoopExercise11
{
    public static void Main( )
    {
    string line = "";
   
    for (int i=1; i<=4; i++)
         {
            
             for (int j=1; j<=i; j++)
             {
                 line += i;
             }
             System.Console.WriteLine(line);
             line = "";
         }
    }
}

/*
36. Write a program in C# Sharp to display the such a pattern for n number of rows using a number which will start with the number 1 and the first and a last number of each row will be 1. Go to the editor
  1
 121
12321
*/
using System;  
public class LoopExercice36
{  
    public static void Main()
{
   int n = Convert.ToInt32(Console.ReadLine());
   string ligne = "";
   
   for(int i=1;i<=n;i++)
   {
       
        /* Mettre espaces blancs*/
        for(int j=1;j<=n-i;j++)
        {
            ligne += " ";
        }

        /* Afficher chiffre jusqu'au milieu*/
        for (int k=1; k<=i; k++) 
        {
            ligne += k;
        }
 
        /* Afficher a l'envers*/
        for(int l=i-1; l>=1;l--) {
            ligne += l;
        }
        Console.WriteLine(ligne);
        ligne = "";
    }
  } 
}

/*
57. Write a program in C# Sharp to print a string in reverse order. Go to the editor
Test Data :
Input a string to reverse : Welcome
Expected Output :
Reversed string is: emocleW
*/
using System;
public class LoopExercice57
    {
    public static void Main()
        {
        string line = Console.ReadLine();
        string reverse = "";
        
        for(int i=line.Length-1; i>=0; i--)
        {
            reverse += line[i] ;
        }
        Console.WriteLine(reverse);
    }
}
