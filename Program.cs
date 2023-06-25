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
