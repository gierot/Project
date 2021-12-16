using System;

namespace aula01
{
    class Passagem
    {

        Onibus obj = new Onibus();
        private int valor;
        public Passagem()
        {
            valor = 500;
        }
        public void Pass()
        {
        Inicio:
            Console.Clear();
            Console.WriteLine("Por favor, digite quantas passagens irá comprar");
            int quantidadepass = int.Parse(Console.ReadLine());
            int valorTotal = quantidadepass * valor;
            obj.quantidade--;
            Console.WriteLine("deseja comprar outra passagem?\n s/n");
            string resposta = Console.ReadLine();
            if (resposta == "s" || resposta == "S")
            {
                goto Inicio;

            }
        }


    }
    class Destino
    {
        protected string[] lugar = new string[12];
        public Destino()
        {
            lugar[0] = "Espirito santo"; lugar[1] = "São paulo"; lugar[2] = "Amazonas";
            lugar[3] = "Recife"; lugar[4] = "Rio de Janeiro"; lugar[5] = "Bahia";
            lugar[6] = "Florianópolis"; lugar[7] = "Salvador"; lugar[8] = "Minas Gerais";
            lugar[9] = "Santa catarina"; lugar[10] = "Porto Alegre"; lugar[11] = "Coritiba";

        }
        public string lugares
        {
            get
            {
                return lugar[12];
            }
            set
            {
                lugar[12] = value;
            }
        }
    }
    class Onibus
    {

        protected int quant_passageiros_total;
        protected float valor_passagem;

        public Onibus()
        {
            quant_passageiros_total = 30;
        }
        public int quantidade
        {
            get
            {
                return quant_passageiros_total;
            }
            set
            {
                quant_passageiros_total = value;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
