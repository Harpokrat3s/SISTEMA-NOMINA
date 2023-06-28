
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
