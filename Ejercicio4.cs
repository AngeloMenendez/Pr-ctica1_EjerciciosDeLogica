class Ejercicio4
{
    public int numero;
    public Indefinido()
    {

    }
    public void imprimir()
    {
        do
        {
            Console.WriteLine("Ingrese un número:" );
            numero=int.Parse(Console.ReadLine());
            int x=numero;
        }while(numero!=0);
    }
}