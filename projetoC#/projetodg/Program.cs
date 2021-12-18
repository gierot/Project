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
        public void Pass(int quantidadepass)
        {
            int valorTotal = quantidadepass * valor;
            obj.quantidade--;
            Console.WriteLine("o valor total das passagens é de {0}", valorTotal);
        }


    }
    class Destino
    {
        public string[] lugar { get; set; } = new string[12];
        public int escolha;
        public Destino()
        {
            lugar[0] = "Espirito santo"; lugar[1] = "São paulo"; lugar[2] = "Amazonas";
            lugar[3] = "Recife"; lugar[4] = "Rio de Janeiro"; lugar[5] = "Bahia";
            lugar[6] = "Florianópolis"; lugar[7] = "Rio grande do sul"; lugar[8] = "Minas Gerais";
            lugar[9] = "Santa catarina"; lugar[10] = "Parana"; lugar[11] = "Acre";
        }
        public int valor
        {
            get
            {
                return escolha;
            }
            set
            {
                escolha = value;
            }
        }
        public string[] info()
        {
            int i = 0;
            for ( i = 0; i < lugar.Length; i++)
            {
                Console.WriteLine(lugar[i]);
            }        
            Console.WriteLine("Esolha um dos destinos para a sua viagem");
            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine(lugar[escolha - 1]);
            
            return lugar;
        }
        
    }
    class Onibus
    {
        protected int quant_passageiros_total;
        private int[,] assentos{ get; set;} = new int[2,5];

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
    class Distancia
    {
        Destino obj = new Destino();
        public string central = "Distrito federal";
        public float[] distance { get; set; } = new float[12];

        public Distancia()
        {
            distance[0] = 1441.6f; distance[1] = 1050.6f; distance[2] = 2262f; distance[3] = 2346.7f;
            distance[4] = 1452.4f; distance[5] = 995f; distance[6] = 1723.9f; distance[7] = 1915.4f;
            distance[8] = 642f; distance[9] = 1656.9f; distance[10] = 1423f; distance[11] = 2.441f;
        }
        public float[] relatorio()
        {
            int i = 0;
            for (i = 0; i < 1; i++)
            {
                Console.WriteLine(obj.lugar[obj.escolha]);
            }
            //Console.WriteLine("A distancia é de {0}", distance[obj.escolha]);
            return distance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Destino tst = new Destino();
            Distancia dst = new Distancia();
            tst.info();
            for (int i = 0; i < 1; i++)
            {
                
            }
            dst.relatorio();

        }
        
    }
}
