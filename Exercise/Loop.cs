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
