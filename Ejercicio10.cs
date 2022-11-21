class Ejercicio10
{
    public int numero{get;set;}
    public Factor()
    {

    }
    public void CalcularFactorial()
    {
        Console.WriteLine("Ingrese el número a factorizar: ");
        int numero=Convert.ToInt32(Console.ReadLine());
        int factorial=1;
        for(int i = 1; i <= numero; i++)
        {
            factorial=factorial*i;
        }
        Console.WriteLine("El factorial de: " +numero+ "es :" +factorial);
        Console.ReadLine();
    }
}