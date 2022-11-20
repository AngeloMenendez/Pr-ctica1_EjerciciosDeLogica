class empleadoHT:empleado{
    public double horasextrasdos {get;set;}

    public empleadoHT (string nombre,double sueldoporhora,double horastrabajadas):base(nombre,sueldoporhora,horastrabajadas){
        if (horastrabajadas > 45){
        this.horasextrasdos = horastrabajadas - 40;
        }else{
            this.horasextrasdos = 0;
        }
    }

    public override double calculosalario(){
        
            double sueldohorasextras = (horasextrasdos * sueldoporhora)*3; 
            double horasT = (horastrabajadas - horasextrasdos)  * sueldoporhora; 
            double sueldoT = horasT + sueldohorasextras; 
            return sueldoT;   
       

    }
}