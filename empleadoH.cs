class empleadoH:empleado{
    
    public empleadoH (string nombre,double sueldoporhora,double horastrabajadas):base(nombre,sueldoporhora,horastrabajadas){
        
    }

    public override double calculosalario()
    {
        double sueldoT = horastrabajadas * sueldoporhora;
        return sueldoT; 
    }
}