// REPORTE SUELDO SUPERIOR

static void ReporteSueldoSuperior(int contadorEmpleados)
{
    if (contadorEmpleados > 0)
    {
        Console.WriteLine("=== Reporte de Empleados con Sueldo Superior a $50,000 ===");

        for (int i = 0; i < contadorEmpleados; i++)
        {
            contadorEmpleados empleado = empleado[i];
            if (empleado.SueldoBruto > 50000)
            {
                Console.WriteLine($"Empleado {i + 1}:");
                Console.WriteLine($"Nombre: {empleado.Nombre} {empleado.Apellido}");
                Console.WriteLine($"Sueldo bruto: {empleado.SueldoBruto:C}");
                Console.WriteLine();
            }
        }
    }
    else
    {
        Console.WriteLine("No hay empleados registrados.");
    }
}
    
