using System;

namespace uri_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, quantidade1, quantidade2;
            double valor1, valor2, valortotal;

            Console.WriteLine("Codigo peça 1= ");
            cod1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade peça 1= ");
            quantidade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor peça 1= ");
            valor1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Codigo peça 2= ");
            cod2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade peça 2= ");
            quantidade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor peça 2= ");
            valor2 = double.Parse(Console.ReadLine());

            valortotal = (quantidade1 * valor1) + (quantidade2 * valor2);

            Console.WriteLine("O VALOR TOTAL A SER PAGO É: R$ " + valortotal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
