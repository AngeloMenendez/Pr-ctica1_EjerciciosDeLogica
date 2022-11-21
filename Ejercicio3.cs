class Ejercicio3
{
    public int num1;
    public int num2;
    public int num3;
    public mayor(int num1,int num2,int num3)
    {
        this.num1=num1;
        this.num2=num2;
        this.num3=num3;
    }
    public void NumMayorDeLosTres()
    {
        if((num1>num2)&&(num1>num3))
        {
            Console.WriteLine("El número mayor de los tres es:"+num1);
        }
        else if ((num2>num1)&&(num2>num3))
        {
            Console.WriteLine("El numero mayor de los tres es:"+num2);
        }
        else
        {
            Console.WriteLine("El número mayor de los tres es:"+num3);
        }
        
    }

}