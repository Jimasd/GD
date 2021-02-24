/*
4. Write a program in C# Sharp to copy the elements one array into another array. Go to the editor
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 15
element - 1 : 10
element - 2 : 12
Expected Output:
The elements stored in the first array are :
15 10 12
The elements copied into the second array are :
15 10 12
*/
public class ExerciseArray4
{
    public static void Main( )
    {
        int longueurArray = System.Convert.ToInt32(System.Console.ReadLine());
        int[] arrayAncien = new int[longueurArray];
        int[] arrayNouveau = new int[longueurArray];
        
        /*Mettre des trucs dans le 1er array*/
        for (int i=0; i<arrayAncien.Length; i++) /*ou i<longueurArray*/
        {
            arrayAncien[i] = i+100; /*L'index du array commence tjrs a 0*/
        }
        
        /*Copier dans un autre array*/
        for (int j=0; j<arrayAncien.Length; j++) 
        {
            arrayNouveau[j] = arrayAncien[j];
        }
         
        /*Verifier que les deux array sont egal, element par element*/
        string message = "";
        for (int k=0; k<longueurArray; k++)
        {
            message = "Element egal?: " + (arrayNouveau[k] == arrayAncien[k]) + ", Ancien element: " + arrayAncien[k] + " Nouveau element: " + arrayNouveau[k];
            System.Console.WriteLine(message);
        }
    }
}
