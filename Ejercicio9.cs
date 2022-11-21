class Ejercicio9
{
    public int numero{get;set;}
    public MediaAritmetica()
    {

    }
    public void CalcularMediaAritmetica()
    {
        double promedio;
        int sum=0;
        do
        {
            Console.WriteLine("Ingrese un número para sacar media aritmética: ");
            numero= int.Parse(Console.ReadLine());
            sum=sum/2;
        }while(numero==0);
        Console.WriteLine("El promedio de los números ingresados es: "+promedio);
        Console.ReadKey();
    }
}