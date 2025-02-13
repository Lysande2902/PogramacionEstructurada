using System;

class ReciboAgua
{
    public decimal MetrosCubicos { get; set; } 
    public decimal LitrosConsumidos { get; set; }

    public void ConvertirAMetrosCubicosALitros()
    {
        LitrosConsumidos = MetrosCubicos * 1000;
    }
}

class Program
{
    static void Main()
    {
        ReciboAgua recibo = new ReciboAgua();

        Console.Write("Ingrese los metros cúbicos de agua consumidos durante el mes: ");
        recibo.MetrosCubicos = Convert.ToDecimal(Console.ReadLine());

        recibo.ConvertirAMetrosCubicosALitros();

        Console.WriteLine("La familia consumió " + recibo.LitrosConsumidos + " litros de agua este mes.");
    }
}

