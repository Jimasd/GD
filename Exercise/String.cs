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
        System.Console.WriteLine($"Il y a {nbDeLettre} lettres dans le mot \"{mot}\"\n");
        System.Console.WriteLine("Il y a " + nbDeLettre + " lettres dans le mot \"" + mot + "\"\n");
    }
}

/*
15. Write a program in C# Sharp to read a sentence and replace lowercase characters by uppercase and vice-versa. Go to the editor
Test Data :
Input the string : This is a string
Expected Output :

After conversion, the string is : tHIS IS A STRING 
*/
using System;
public class ExerciseString15
{
	public static void Main()
	{
        string phrase = Console.ReadLine();

        foreach(char lettre in phrase)
        {
            
            if (Char.IsLower(lettre)) //Verifier que le char lettre est une miniscule
            {
                Console.Write(Char.ToUpper(lettre));
            }
            else if (Char.IsUpper(lettre)) //Verifier que le char lettre est une majuscule
            {
                Console.Write(Char.ToLower(lettre)); 
            }
            else
            {
                Console.Write(lettre);
            }
        }
    }
}

/*
19. Write a program in C# Sharp to find the number of times a substring appears in a given string. Go to the editor
Test Data :
Input the original string : this is original string
Input the string to be searched for : str
Expected Output :

The string 'str' occurs 1 times
*/
using System;
public class ExerciseString19
{
	public static void Main()
	{
        int position = 0;
        int nbDeFois = -1;
        int index = -1;
        string phrase = Console.ReadLine();
        string sousString = Console.ReadLine();     
        
        //Avec while loop
        while (position != -1)
        {
            position = phrase.IndexOf(sousString, index+1);
            nbDeFois += 1;
            index = position;
        }
        Console.Write("Avec while loop: ");
        Console.WriteLine($"Le string \"{sousString}\" revient {nbDeFois} fois.\n");
        
        //Avec for loop et break
        position = 0;
        nbDeFois = -1;
        index = -1;
        for (int i=0; i<phrase.Length; i++) 
        {
            position = phrase.IndexOf(sousString, index+1);
            nbDeFois += 1;
            index = position;
            
            if (position == -1)
            {
                break;
            }
        }
        Console.Write("Avec for loop et break: ");
        Console.WriteLine($"Le string \"{sousString}\" revient {nbDeFois} fois.\n");
	}
}
