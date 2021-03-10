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

/*
25. Write a program in C# Sharp to find sum of rows an columns of a Matrix.Go to the editor
Test Data :
Input the size of the square matrix: 2
Input elements in the first matrix:
element - [0],[0] : 5
element - [0],[1] : 6
element - [1],[0] : 7
element - [1],[1] : 8
Expected Output :
The First matrix is :
The matrix is :
5 6
7 8
The sum or rows and columns of the matrix is :
5 6 11
7 8 15

12 14
*/
using System;

public class ExerciseArray25
{
    public static void Main( )
    {
        /*Generer une matrice de taille n x n*/
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] mat = new int[n, n];
        Random rnd = new Random(); /* Intialiser un objet Random */

        for (int rng=0; rng<n; rng++)
        {
            
            for (int col=0; col<n; col++)
            {
                mat[rng, col] = rnd.Next(-10, 11); /* Donner un chiffre entre
                -10 et 10 pour chaque element de la matrice */
            }
        }

        /* Afficher somme de chaque rangee et colonne*/
        for (int i=0; i<n; i++)
        {
            int sommeRng = 0;
            int sommeCol = 0;
            
            for (int j=0; j<n; j++)
            {
                sommeRng += mat[i, j]; /* Somme de la rangee i */
                sommeCol += mat[j, i]; /* Somme de la colonne j */
            }
            System.Console.WriteLine("Somme de la rangee " + i + ": " + sommeRng);
            System.Console.WriteLine("Somme de la colonne " + i + ": " + sommeCol);
        }
        
        /* Bonus: somme de tous les elements */
        int somme = 0;
        
        foreach (int element in mat)
        {
            somme += element;
        }
        System.Console.WriteLine("Somme tous les elements: " + somme);
    }
}


3. Write a program in C# Sharp to find the product of all elements of the array. Go to the editor
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 8
Expected Output :
Product of all elements stored in the array is : 15
    
public class Exercise1
{
    public static void Main( )
    {
        int longueurArray = System.Convert.ToInt32(System.Console.ReadLine()); // longueur du array
        int [] arrayDepart = new int [longueurArray];
        for (int i=0; i<longueurArray; i++) // pour remplir arrayDepart
        {
            arrayDepart[i] = System.Convert.ToInt32(System.Console.ReadLine()); // les elements seront input
        } 
        int produit = 1;
        foreach (int element in arrayDepart)
        {
            produit *= element;
        }
        System.Console.WriteLine("Le produit de tous les elements: " + produit); 
    }    
}    
