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
