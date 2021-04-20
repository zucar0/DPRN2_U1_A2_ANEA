using System;

//Definición de la clase Empleado
public class Empleado
{
    //Declaración de datos miembros
    private double salarioMensual = 0.0;
    private double bonoMensual = 0.0;
    private int numeroDeEmpleado;
    private string nombre;
    private int numeroTelefonico;
    private string correoElectronico;
    
    //Constructor vacío
    public Empleado(){

    }
    //Constructor que recibe un dato
    public Empleado(double salarioMensual) : this(){
        this.salarioMensual=salarioMensual;
        Console.WriteLine("Se ha invocado el constructor que recibe como parámetro el salario mensual");
    }
    //Constructor que recibe dos datos miembros
    public Empleado(int numeroDeEmpleado, double salarioMensual) : this(){
        this.numeroDeEmpleado = numeroDeEmpleado;
        this.salarioMensual = salarioMensual;
        Console.WriteLine("Se ha invocado el constructor que recibe 2 parámetros");

    }
    //Constructor que recibe 5 datos miembros
    public Empleado(double salarioMensual, int numeroDeEmpleado, string nombre){
        this.salarioMensual = salarioMensual;
        this.numeroDeEmpleado = numeroDeEmpleado;
        this.nombre = nombre;
        Console.WriteLine("Se ha invocado el constructor que recibe 3 parámetros");

    }
    
    //Destructor
    ~Empleado() => Console.WriteLine("Este es el destructor ejecutándose para destruir el objeto de la clase Empleado");

    //Interfaz para el Salario de tipo double
    public double Salario
    {
        get 
        { 
            return salarioMensual; 
        }
        set 
        { 
            if(value < 0){
                salarioMensual = 0.0;
            }
            else{
                salarioMensual = value; 
            }
        } 
    }
    public double AsignarSalarioMensual(double salario){
        double salarioAnual = salario * 12;
        return salarioAnual;
    }
    public double AsignarSalarioMensual(double salario, int numeroDeEmpleado){
        double salarioAnual = salario * 12;
        Console.WriteLine("El salario anual es " + salario + " y corresponde al empleado " + numeroDeEmpleado);
        return salarioAnual;
    }

    //Interfaz para el Bono mensual de tipo double
    public double BonoMensual
    {
        get
        {
            return bonoMensual;
        }
        set
        {
            if(value < 0){
                bonoMensual = 0.0;
            }
            else{
                bonoMensual = value;
            }
        }
    } 

    public double aumentarSalario (double salarioPorAumentar)
    {
        if(salarioPorAumentar >= 3000 && salarioPorAumentar <= 7000)
        {
            double salarioAumentado = salarioPorAumentar * 0.10;
            salarioPorAumentar = salarioPorAumentar + salarioAumentado;
        }
        return salarioPorAumentar;
    }

    public double aumentarSalario (double salarioPorAumentar, double bono){
        double salarioAumentadoConBono;
        if(bono > 0 && bono < 5){
           salarioAumentadoConBono = salarioPorAumentar * 0.10;
        }else if (bono > 6 && bono <10){
            salarioAumentadoConBono = salarioPorAumentar * 0.20;
        }else{
            salarioAumentadoConBono = salarioPorAumentar;
        }
        return salarioAumentadoConBono;
    }

    public double salarioAnual (double salarioPorCalcular)
    {
        double salarioAnual=salarioPorCalcular*12;
        salarioPorCalcular=salarioAnual;
        return salarioPorCalcular;
    }

    public double salarioAnual (double salarioPorCalcular, double bonoanual)
    {
        double salarioAnual=(salarioPorCalcular*12)+bonoanual;
        salarioPorCalcular=salarioAnual;
        return salarioPorCalcular;
    }

}