using System;

class TransaccionOxxo //Aqui cree la clase TransaccionOxxo
{
    public decimal TotalCompra { get; set; }
    public decimal PagoCliente { get; set; }

    public decimal CalcularCambio() //Es el metodo para calcular el cambio
    {
        return PagoCliente - TotalCompra; //Se resta el total con el pago del cliente
    }
}

class Oxxo //Cree mi clase Oxxo
{
    static void Main()
    {
        while (true) //Es el bucle "While" para que el programa se ejecute hasta que el usuario decida cerrarlo
        {
            Console.Write("Ingrese el total de la compra: ");
            decimal total = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese el efectivo entregado por el cliente: ");
            decimal pago = Convert.ToDecimal(Console.ReadLine());

            TransaccionOxxo compra = new TransaccionOxxo
            {
                TotalCompra = total, //Aqui se asigna el total de la compra
                PagoCliente = pago, //Aqui se asigna el pago del cliente
            };

            decimal cambio = compra.CalcularCambio(); //Se asigna el cambio a la variable "cambio"

            if (cambio < 0)
            {
                Console.WriteLine("Dinero insuficiente. Falta: $" + Math.Abs(cambio)); //Se imprime el cambio faltante
            }
            else //Si el cambio es mayor a 0
            {
                Console.WriteLine("Cambio a devolver: $" + cambio); //Se imprime el cambio a devolver
            }

            Console.Write("\nEscriba 'cerrar' para salir o presione ENTER para continuar: "); //Se le pregunta al usuario si desea cerrarlo o continuar
            string opcion = Console.ReadLine();

            if (opcion.ToLower() == "cerrar")
                break;
        }
    }
}
