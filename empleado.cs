abstract class empleado{
    public string nombre {get;set;}
    public double sueldoporhora {get;set;}
    public double horastrabajadas {get;set;}

    public empleado (string nombre,double sueldoporhora,double horastrabajadas){
        this.nombre = nombre;
        this.sueldoporhora = sueldoporhora;
        this.horastrabajadas = horastrabajadas ; 
    }

    public abstract double calculosalario();
    public void imprimir(){
        Console.WriteLine ("Nombre: "+nombre+"   Sueldo por hora: "+sueldoporhora+"    horas trabajadas: "+horastrabajadas); 
    }
    
}