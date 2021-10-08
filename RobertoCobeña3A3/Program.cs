using System;

namespace RobertoCobeña3A3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; double nume2 = 0; double suma = 0;
                do{
                Console.Write("Introduzca la cantidad a comprar:");
                num1 = int.Parse(Console.ReadLine());
                if (num1 >= 1){
                Console.Write("Introduzca el precio del producto:");
                nume2 = Double.Parse(Console.ReadLine());
                if (nume2 >= 1)
                suma = (num1 * nume2);
                Console.WriteLine("Su valor total a pagar es de" + suma + "$ dolares");
                Console.WriteLine("Si desea finalizar el proceso presione 0, en caso de querer continuar vuelva a introducir su cantidad deseada.");}
            } while (num1 > 0);
            Console.WriteLine("Gracias por su compra");
        }
    }
}
