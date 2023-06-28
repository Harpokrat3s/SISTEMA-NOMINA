static void EliminarEmpleado()
        {
            if (contadorEmpleados > 0)
            {
                Console.Write("Ingrese el número de empleado que desea eliminar: ");
                if (int.TryParse(Console.ReadLine(), out int numeroEmpleado))
                {
                    if (numeroEmpleado > 0 && numeroEmpleado <= contadorEmpleados)
                    {
                        numeroEmpleado--; // Ajustar al índice del arreglo

                        for (int i = numeroEmpleado; i < contadorEmpleados - 1; i++)
                        {
                            empleados[i] = empleados[i + 1];
                        }

                        contadorEmpleados--;

                        Console.WriteLine("Empleado eliminado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Número de empleado inválido. Por favor, ingrese un número válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Número de empleado inválido. Por favor, ingrese un número válido.");
                }
            }
            else
            {
                Console.WriteLine("No hay empleados registrados.");
            }
        }

        static void VerNomina()
        {
            if (contadorEmpleados > 0)
            {
                decimal sueldoTotal = 0;
                decimal tssTotal = 0;
                decimal impuestoRentaTotal = 0;

                Console.WriteLine("=== Nómina ===");

                for (int i = 0; i < contadorEmpleados; i++)
                {
                    Empleado empleado = empleados[i];
                    Console.WriteLine($"Empleado {i + 1}:");
                    Console.WriteLine($"Nombre: {empleado.Nombre} {empleado.Apellido}");
                    Console.WriteLine($"Sueldo bruto: {empleado.SueldoBruto:C}");
                    Console.WriteLine($"Sueldo neto: {empleado.SueldoNeto:C}");
                    Console.WriteLine();

                    sueldoTotal += empleado.SueldoBruto;
                    tssTotal += empleado.TSS;
                    impuestoRentaTotal += empleado.ImpuestoRenta;
                }

                Console.WriteLine($"Total sueldos: {sueldoTotal:C}");
                Console.WriteLine($"Total TSS: {tssTotal:C}");
                Console.WriteLine($"Total impuesto sobre la renta: {impuestoRentaTotal:C}");
                Console.WriteLine($"Total a pagar: {sueldoTotal - tssTotal - impuestoRentaTotal:C}");
            }
            else
            {
                Console.WriteLine("No hay empleados registrados.");
            }
        }
