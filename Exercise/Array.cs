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

/*
11. Write a program in C# Sharp to sort elements of array in ascending order. Go to the editor
Test Data :
Input the size of array : 5
Input 5 elements in the array :
element - 0 : 2
element - 1 : 7
element - 2 : 4
element - 3 : 5
element - 4 : 9
Expected Output :
Elements of array in sorted ascending order:
2 4 5 7 9
*/
public class ExerciseArray11
{
    public static void Main( )
    {
        int[] unsortedArray = {3, 4, 0, -1, 10, -2}; /* Array exemple */
        int tmp;
        
        for (int i=0; i<unsortedArray.Length; i++)
        {
            
            for (int j=i+1; j<unsortedArray.Length; j++)
            {
                
                if (unsortedArray[j] < unsortedArray[i]) 
                {
                    /* Inverser le precendent avec le prochain si le premier
                    est plus grand que l'autre */
                    tmp = unsortedArray[i];
                    unsortedArray[i] = unsortedArray[j];
                    unsortedArray[j] = tmp;
                }
            }
        }
        
        /*Montrer resultats du sorted array*/
        foreach (int element in unsortedArray)
        {
            System.Console.WriteLine(element);
        }
    }
}
