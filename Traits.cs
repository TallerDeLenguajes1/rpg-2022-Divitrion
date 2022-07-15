public class Traits
{
    private int edad;
    private string apodo, nombre;
    private DateTime fechaNac;
    private razas raza;
    private clases clase;


    public int Edad {get => edad; set => edad = value; }
    public string Apodo {get => apodo; set => apodo = value; }
    public string Nombre {get => nombre; set => nombre = value; }
    public DateTime FechaNac {get => fechaNac; set => fechaNac = value;}
    public razas Raza {get => raza; set => raza = value;}
    public clases Clase {get => clase; set => clase = value;}

    public Traits()
    {
        this.raza = (razas)new Random().Next(1,4);
        this.clase = (clases)new Random().Next(1,4);
        this.fechaNac= DateTime.Now;
    }

    public static void Age(Traits traits)
    {
        if (traits.raza== razas.Elfo)
        {
            int time = new Random().Next(100,250);
            traits.fechaNac=traits.fechaNac.AddYears(-(time));
            traits.fechaNac=traits.fechaNac.AddDays(new Random().Next(1,150));
            traits.edad=time;
        }
        if (traits.raza == razas.Humano)
        {
            int time = new Random().Next(20,60);
            traits.fechaNac=traits.fechaNac.AddYears(-(time));
            traits.fechaNac=traits.fechaNac.AddDays(new Random().Next(1,150));
            traits.edad=time;
        }
        if (traits.raza == razas.Orco)
        {
            int time = new Random().Next(17,45);
            traits.fechaNac=traits.fechaNac.AddYears(-(time));
            traits.fechaNac=traits.fechaNac.AddDays(new Random().Next(1,150));
            traits.edad=time;
        }

    }

    public void Mostrar()
    {
        Console.WriteLine($"Tipo: {Raza}\n");
        Console.WriteLine($"Clase: {Clase}\n");
        Console.WriteLine($"Nombre: {Nombre}\n");
        Console.WriteLine($"Apodo: {Apodo}\n");
        Console.WriteLine($"Fecha de nacimiento: {FechaNac}\n");
        Console.WriteLine($"Edad: {Edad}\n");
    }
}