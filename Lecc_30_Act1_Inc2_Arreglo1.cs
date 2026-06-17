internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0;
        String[] color = new string[6];
        color[0]= "";
        color[1]= "Verde";
        color[2]= "Azul";
        color[3]= "lila";
        color[4]= "negro";
        color[5] = "blanco";

        Console.WriteLine("Ingrese un número del 1 al 5: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine(color[num]);


    }
}
