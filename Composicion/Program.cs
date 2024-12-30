/* class Moto
{
    public string Tipo { get; set; }

    public Moto(string tipo)
    {
        Tipo = tipo;
    }
}

class Coche
{
    public Moto motor { get; set; }

    public Coche(string tipoMotor)
    {
        motor = new Moto(tipoMotor);
    }
}
 */





class Estudiante
{
    public string Nombre { get; set; }

    public Estudiante(string nombre)
    {
        Nombre = nombre;
    }

    public void MostrarNombre()
    {
        Console.WriteLine($"Estudiante: {Nombre}");
    }
}

class Escuela
{
    private List<Estudiante> estudiantes;

    public Escuela()
    {
        estudiantes = new List<Estudiante>();
    }

    public void AgregarEstudiante(Estudiante estudiante)
    {
        estudiantes.Add(estudiante);
    }

    public void MostrarEstudiantes()
    {
        foreach (var estudiante in estudiantes)
        {
            estudiante.MostrarNombre();
        }
    }
}

// Uso
Estudiante est1 = new Estudiante("María");
Estudiante est2 = new Estudiante("Carlos");

Escuela escuela = new Escuela();
escuela.AgregarEstudiante(est1);
escuela.AgregarEstudiante(est2);

escuela.MostrarEstudiantes();
