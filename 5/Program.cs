using System;

class Trabajador
{
    public decimal SalarioDiario { get; set; }

    public Trabajador(decimal salarioDiario)
    {
        SalarioDiario = salarioDiario; // Asigna el salario diario
    }

    public decimal CalcularSalarioAnual()
    {
        return SalarioDiario * 365; // 365 días del año por el salario diario
    }
}

class AguinaldoTrabajador : Trabajador // Clase AguinaldoTrabajador que hereda de Trabajador
{
    public AguinaldoTrabajador(decimal salarioDiario)
        : base(salarioDiario) { }

    public decimal CalcularAguinaldo()
    {
        return SalarioDiario * 15; // Se multiplica el salario diario por 15
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el salario diario del trabajador: "); // Pide el salario
        decimal salario = Convert.ToDecimal(Console.ReadLine());

        AguinaldoTrabajador trabajador = new AguinaldoTrabajador(salario);

        decimal aguinaldo = trabajador.CalcularAguinaldo();
        decimal salarioAnual = trabajador.CalcularSalarioAnual();

        Console.WriteLine($"El aguinaldo del trabajador es: ${aguinaldo}."); // Imprime el aguinaldo
        Console.WriteLine($"El salario anual del trabajador es: ${salarioAnual}."); // Imprime el salario anual
    }
}
