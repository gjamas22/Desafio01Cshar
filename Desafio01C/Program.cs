using System;

namespace Desafio01C
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v1 = new Veiculo("Jeep", "Jeep Renegate", "123-123", "branco", 50, true, 50, 10, 12.50);
            v1.exibedados();
            v1.Ligar();
            v1.Abastecer(50);
            v1.Acelerar();
            v1.Acelerar();
            v1.Frear();
            v1.Desligar();

           
        }
    }
}
