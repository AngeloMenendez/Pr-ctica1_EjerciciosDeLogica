class Ejercicio5
{
    public int numero;
    public SumaDeNumeros(int num)
    {
        this.numero=numero;
    }
    public void imprimir()
    {
        int sum=0;
        for(int i = 0; i<=7; i++)
        {
            Console.WriteLine("Ingrese un número: ");
            numero=int.Parse(Console.ReadLine());
            sum=sum+numero;
        }
        Console.WriteLine("La suma de los números ingresados es: " + sum);
        Console.ReadKey();
    }
}