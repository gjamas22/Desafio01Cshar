using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio01C
{
    class Veiculo
    {
        private String _marca;
        private String _modelo;
        private String _placa;
        private String _cor;
        private float _Km;
        private Boolean _isLigado;
        private int _litrosCombustivel;
        private int _velocidade;
        private Double _preço;
        public String marca { get; set; }
        public String modelo { get; set; }
        public String placa { get; set; }
        public float Km { get; set; }
        public Boolean isLigado { get; set; }
        public int litrosCombustivel { get; set; }
        public int velocidade { get; set; }
        public Double preço { get; set; }

        public Veiculo(string marca, string modelo, string placa, string cor, float km, bool isLigado, int litrosCombustivel, int velocidade, double preço)
        {
            this._marca = marca;
            this._modelo = modelo;
            this._placa = placa;
            this._cor = cor;
            _Km = Km;
            this._isLigado = isLigado;
            this._litrosCombustivel = litrosCombustivel;
            this._velocidade = velocidade;
            this._preço = preço;
        }

        public Veiculo()
        {
        }

        public void Acelerar()
        {
            if (this.isLigado == true)
            {
                this.velocidade += 20;
                this.litrosCombustivel -= 1;
                Console.WriteLine("O carro acelerou. Sua velocidade é de " + this.velocidade + " km por hora");
                Console.WriteLine("O seu combustivel é de " + this.litrosCombustivel + " litros.");
            }
            else
                Console.WriteLine("Voce precisa ligar o carro primeiro");
        }

        public void Abastecer(int qntdLitros)
        {
            if (this.litrosCombustivel >= 100)
            {
                Console.WriteLine("O tamque está cheio ");
            }
            else
            {
                if (qntdLitros >= 100)
                {
                    Console.WriteLine("Digite um número menor que 100 litros para abastecer");

                }
                else
                {
                    this.litrosCombustivel += qntdLitros;
                    Console.WriteLine("Seu combustivel é de " + qntdLitros);
                }
            }
        }

        public void Frear()
        {
            if (this.isLigado == true)
            {
                if (this.velocidade > 10)
                    ;
                this.velocidade -= 10;
            }
            else
            {
                if (this.velocidade <= 0)
                {
                    Console.WriteLine("O carro está parado");
                }
                else
                {
                    Console.WriteLine("O carro está desligado");
                }

            }
            Console.WriteLine("A velocidade é de " + this.velocidade + "km por hora");
        }

        public void Pintar(String cor)
        {
            Console.WriteLine("Seu carro está com a cor " + this._cor);
        }

        public void Ligar()
        {
            if (this.isLigado == true)
            {
                Console.WriteLine("O carro está igado");
            }
            else
            {
                this.isLigado = true;
                Console.WriteLine("Voce ligou o carro");
            }
        }

        public void Desligar()
        {
            if (this.isLigado == false)
            {
                Console.WriteLine("O carro esta desligado");
            }
            else
            {
                this.isLigado = false;
                Console.WriteLine("Você desligou o carro");
            }

        }
        public void exibedados()
        {
            Console.WriteLine("A marca do seu carro é: " + this._marca);
            Console.WriteLine("O modelo do seu carro é: " + this._modelo);
            Console.WriteLine("A placa do carro é: " + this._placa);
            Console.WriteLine("A cor do carro é: " + this._cor);
        }
    }
}
