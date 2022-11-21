class Ejercicio6
{
public int numero;
    public SumaDeNumeros2(int num)
    {
        this.numero=numero;
    }
    public void imprimir()
    {
        int sum=0;
        do
        {
            Console.WriteLine("Ingrese un número: ");
            numero=int.Parse(Console.ReadLine());
            sum=sum+numero;
        }while(numero==0);
        Console.WriteLine("La suma de los números ingresados es: " + sum);
        Console.ReadKey();
    }
}