class Empleado
{
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public int Edad { get; set; }
    public char Sexo { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public bool PoseeLicencia { get; set; }
    public decimal SueldoBruto { get; set; }
    public decimal SueldoNeto { get; set; }
    public decimal TSS { get; set; }
    public decimal ImpuestoRenta { get; set; }

    public void CalcularTSS()
    {
        decimal tasaTSS = 0.0304m; // Tasa de TSS (3.04%)
        TSS = SueldoBruto * tasaTSS;
        SueldoNeto = SueldoBruto - TSS - ImpuestoRenta;
    }

    public void CalcularImpuestoRenta()
    {
        decimal montoExento = 416220.00m; // Monto exento para el cálculo del Impuesto sobre la Renta
        decimal tasaInicial = 0.15m; // Tasa inicial del Impuesto sobre la Renta (15%)
        decimal tasaExcedente = 0.25m; // Tasa aplicable al excedente del monto exento (25%)

        decimal excedente = SueldoBruto - montoExento;

        if (excedente <= 0)
        {
            ImpuestoRenta = 0;
        }
        else if (excedente <= 416220.00m)
        {
            ImpuestoRenta = excedente * tasaInicial;
        }
        else
        {
            decimal impuestoInicial = montoExento * tasaInicial;
            decimal impuestoExcedente = (excedente - montoExento) * tasaExcedente;
            ImpuestoRenta = impuestoInicial + impuestoExcedente;
        }

        SueldoNeto = SueldoBruto - TSS - ImpuestoRenta;
    }
}
class Program
{
    static Empleado[] empleados = new Empleado[100];
    static int contadorEmpleados = 0;

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("=== Sistema de Nómina ===");
            Console.WriteLine("1. Agregar empleado");
            Console.WriteLine("2. Ver empleados");
            Console.WriteLine("3. Eliminar empleado");
            Console.WriteLine("4. Ver nómina");
            Console.WriteLine("5. Reporte de empleados mujeres");
            Console.WriteLine("6. Reporte de empleados con licencia");
            Console.WriteLine("7. Reporte de empleados con sueldo por encima de $50,000");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción: ");
            string? opcionStr = Console.ReadLine();

            if (int.TryParse(opcionStr, out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AgregarEmpleado();
                        break;
                    case 2:
                        VerEmpleados();
                        break;
                    case 3:
                        EliminarEmpleado();
                        break;
                    case 4:
                        VerNomina();
                        break;
                    case 5:
                        ReporteEmpleadosMujeres();
                        break;
                    case 6:
                        ReporteEmpleadosLicencia();
                        break;
                    case 7:
                        ReporteSueldoSuperior();
                        break;
                    case 8:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
            }

            Console.WriteLine();
        }
    }
}