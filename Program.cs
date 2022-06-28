using POO_Dio.src.Entities;
internal class Program
{
    private static void Main(string[] args)
    {
        Hero arus = new Knight( "Arus" , 24 , "Knight" );

        // Hero opponent = new Hero("Maleficus" , 99 , "Demon");

        Wizard wizard = new Wizard("Jennica", 23 , "White Wizard");

        Console.WriteLine(arus);

        Console.WriteLine(wizard.Attack());
        



    }
}