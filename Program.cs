internal class Program
{
    private static void Main(string[] args)
    {
        empleadoH empleado1 = new empleadoH ("alberto",2,40);
        empleadoHD empleado2 = new empleadoHD ("Valentina",2,43);
        empleadoHT empleado3 = new empleadoHT ("Rodrigo",2,46);
        List<empleado> empleados = new List<empleado> ();
        

        empleados.Add (empleado1);
        empleados.Add (empleado2);
        empleados.Add (empleado3);


        empleado1.imprimir(); 
        foreach (empleado item in empleados){
            empleado1.imprimir(); 
            empleado2.imprimir();
            empleado3.imprimir();  
            Console.WriteLine ("El "+item.ToString()+" tiene un salario de: "+item.calculosalario());
        }


    }
}