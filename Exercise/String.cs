/*2. Write a program in C# Sharp to find the length of a string without using library function. Go to the editor
Test Data :
Input the string : w3resource.com
Expected Output :

Length of the string is : 15 */
public class ExerciseString2
{
    public static void Main( )
    {
        string mot = System.Console.ReadLine();
        int nbDeLettre = 0;
        
        foreach (char lettre in mot)
        {
            nbDeLettre++;
        }
        System.Console.WriteLine($"Il y a {nbDeLettre} lettres dans le mot {mot}");
        System.Console.WriteLine("Il y a " + nbDeLettre + " lettres dans le mot " + mot);
    }
}
