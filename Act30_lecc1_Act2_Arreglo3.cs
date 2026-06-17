internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0;
        String[] dinero = new string[6];
        dinero[0]= "";
        dinero[1]= "Q100";
        dinero[2]= "Q300";
        dinero[3]= "Q50";
        dinero[4]= "Q1,000";
        dinero[5]= "Q30,000";

        Console.WriteLine("Ingrese un número del 1 al 5: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine(dinero[num]);


    }
}   
