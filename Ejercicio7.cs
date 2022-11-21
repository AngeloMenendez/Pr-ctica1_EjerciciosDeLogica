class Ejercicio7
{
    public int lado1{get;set;}
    public int lado2{get;set;}
    public int lado3{get;set;}
    public TipoDeTriangulo()
    {

    }
    public void imprimir()
    {
        int opcion=0;
        do
        {
            Console.WriteLine("Ingrese el primer número: ");
            lado1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            lado2=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            lado3=int.Parse(Console.ReadLine());

            Console.WriteLine("El triángulo que se forma con los siguientes valores ingresados es: ");
            if(lado1==lado2 && lado1==lado3)
            {
                Console.WriteLine("Triángulo Equilatero");
            }
            if(lado1==lado2 && lado2!=lado3 || lado2==lado3 && lado3!=lado1 || lado3==lado1 && lado1!=lado2)
            {
                Console.WriteLine("Triángulo Isosceles");
            }
            if(lado1!=lado2 && lado2!=lado3 && lado3!=lado1)
            {
                Console.WriteLine("Triágunlo Escaleno");
            }
            Console.WriteLine("Continuar 1:S o 2:N ");
            opcion=int.Parse(Console.ReadLine());
        } while(opcion==2);
    }

}
//Pedir los número por teclado para ver que tipo de triángulo es según los numeros ingresados