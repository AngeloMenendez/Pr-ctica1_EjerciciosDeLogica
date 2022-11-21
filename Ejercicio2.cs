class Ejercicio2
{
    public int num1;
    public NumeroPar(int num1)
    {
        this.num1=num1;
    }
    public void EsPar()
    {
        if(num1%2== 0)
        {
            Console.WriteLine("El número es PAR");
        }
        else
        {
            Console.WriteLine("El numero NO es PAR");
        }
    }

}