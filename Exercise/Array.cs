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
         System.Console.WriteLine("Write your code at here");
         
        /*Verifier que les deux array sont egal, element par element*/
        string message = "";
        for (int k=0; k<longueurArray; k++)
        {
            message = "Element egal?: " + (arrayNouveau[k] == arrayAncien[k]) + ", Ancien element: " + arrayAncien[k] + " Nouveau element: " + arrayNouveau[k];
            System.Console.WriteLine(message);
        }
    }
}
