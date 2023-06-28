
static void AgregarEmpleado()
        {
            if (contadorEmpleados < empleados.Length)
            {
                Empleado empleado = new Empleado();

                Console.Write("Nombre: ");
                empleado.Nombre = Console.ReadLine();

                Console.Write("Apellido: ");
                empleado.Apellido = Console.ReadLine();

                Console.Write("Edad: ");
                if (int.TryParse(Console.ReadLine(), out int edad))
                {
                    empleado.Edad = edad;
                }
                else
                {
                    Console.WriteLine("Edad inválida. Se establecerá como 0.");
                    empleado.Edad = 0;
                }

                Console.Write("Sexo (M/F): ");
                char sexo = Console.ReadKey().KeyChar;
                Console.WriteLine();
                empleado.Sexo = char.ToUpper(sexo);

                Console.Write("Fecha de nacimiento (yyyy-MM-dd): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
                {
                    empleado.FechaNacimiento = fechaNacimiento;
                }
                else
                {
                    Console.WriteLine("Fecha de nacimiento inválida. Se establecerá como la fecha actual.");
                    empleado.FechaNacimiento = DateTime.Now;
                }

                Console.Write("¿Posee licencia? (S/N): ");
                char tieneLicencia = Console.ReadKey().KeyChar;
                Console.WriteLine();
                empleado.PoseeLicencia = char.ToUpper(tieneLicencia) == 'S';

                Console.Write("Sueldo bruto: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal sueldoBruto))
                {
                    empleado.SueldoBruto = sueldoBruto;
                }
                else
                {
                    Console.WriteLine("Sueldo bruto inválido. Se establecerá como 0.");
                    empleado.SueldoBruto = 0;
                }

                empleado.CalcularTSS();
                empleado.CalcularImpuestoRenta();

                empleados[contadorEmpleados] = empleado;
                contadorEmpleados++;

                Console.WriteLine("Empleado agregado exitosamente.");
            }
            else
            {
                Console.WriteLine("No es posible agregar más empleados. Se ha alcanzado el límite.");
            }
        }

        static void VerEmpleados()
        {
            if (contadorEmpleados > 0)
            {
                Console.WriteLine("=== Empleados ===");

                for (int i = 0; i < contadorEmpleados; i++)
                {
                    Empleado empleado = empleados[i];
                    Console.WriteLine($"Empleado {i + 1}:");
                    Console.WriteLine($"Nombre: {empleado.Nombre}");
                    Console.WriteLine($"Apellido: {empleado.Apellido}");
                    Console.WriteLine($"Edad: {empleado.Edad}");
                    Console.WriteLine($"Sexo: {empleado.Sexo}");
                    Console.WriteLine($"Fecha de nacimiento: {empleado.FechaNacimiento.ToString("yyyy-MM-dd")}");
                    Console.WriteLine($"Posee licencia: {(empleado.PoseeLicencia ? "Sí" : "No")}");
                    Console.WriteLine($"Sueldo bruto: {empleado.SueldoBruto:C}");
                    Console.WriteLine($"Sueldo neto: {empleado.SueldoNeto:C}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No hay empleados registrados.");
            }
        }
