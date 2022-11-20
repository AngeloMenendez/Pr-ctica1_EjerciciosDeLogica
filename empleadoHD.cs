class empleadoHD:empleado{
    public double horasextras {get;set;}

    public empleadoHD (string nombre,double sueldoporhora,double horastrabajadas):base(nombre,sueldoporhora,horastrabajadas){
        if (horastrabajadas > 40 && horasextras <=45){
        this.horasextras = horastrabajadas - 40;
        }else{
            this.horasextras = 0;
        }
    }

    public override double calculosalario(){
       
            double sueldohorasextras = (horasextras * sueldoporhora)*2; 
            double horasT = (horastrabajadas - horasextras) * sueldoporhora; 
            double sueldoT = horasT + sueldohorasextras; 
            return sueldoT;  
        

    }
}