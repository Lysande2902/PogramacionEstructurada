using System;

class RegistroConsumoPerro
{
    public int DiasFuera { get; set; } //Dias que estará fuera de casa 
    public const decimal ConsumoDiarioGramos = 750; //Cosumo diario en gramos 

    public decimal CalcularTotalAlimentoKg() 
    {
        return (DiasFuera * ConsumoDiarioGramos) / 1000; //Se multiplica los dias por el consumo diario y se divide entre 1000 para obtener el total en kilogramos 
    }
}

class Program
{
    static void Main()
    {
        RegistroConsumoPerro registro = new RegistroConsumoPerro(); //Objeto de la clase

        Console.Write("Ingrese la cantidad de días que estará fuera de casa: "); //Ingresa los dias que esta fuera de casa 
        registro.DiasFuera = Convert.ToInt32(Console.ReadLine()); //Asigna la variable a la propiedad

        decimal alimentoRequerido = registro.CalcularTotalAlimentoKg(); //Asigna el total de alimento a la variable 

        Console.WriteLine($"\nDebe dejar {alimentoRequerido} kilogramos de comida para su perro."); //Imprime el total de alimento
    }
}

