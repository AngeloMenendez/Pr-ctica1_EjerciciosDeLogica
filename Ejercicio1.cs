class Ejercicio1
{
    public int num1;
    public int num2;
    public NumMayor(int num1, int num2)
    {
    this.num1=num1;
    this.num2=num2;
    }
    public void MayorDeLosNumeros()
    {
        if(num1>num2)
        {
        Console.WriteLine("El numero mayor de los dos es: "+ num1);
        }
        else
        {
        Console.WriteLine("El numero mayor de los dos es: "+ num2);
        }

    }
}