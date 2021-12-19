using System;
namespace aula01
{
    class Passagem
    {
        Onibus obj = new Onibus();
        private int valor{ get; set; }
        public int quantidadepass { get; set; }
        //construtor da classe apssagem
        public Passagem()
        {
            valor = 500;
        }
        //metodo que irá calcular o valor da passagem e ira retirar um da quantidade total de passageiros 
        // quantidade pass recebe a quantidade de passagens que serão compradas
        public int Pass()
        {
            Console.WriteLine("Digite quantas passagens você irá comprar");
            quantidadepass = int.Parse(Console.ReadLine());
            int valorTotal = quantidadepass * valor;
            obj.quantidade--;
            Console.WriteLine("o valor total das passagens é de {0}", valorTotal);
            return quantidadepass;
        }
    }
    class Destino
    {
        //Array de possiveis lugares que a empresa pode realizar a viagem
        public string[] lugar { get; set; } = new string[12];
        public int escolha;
        //construtor da classe destino
        public Destino()
        {
            lugar[0] = "Espirito santo"; lugar[1] = "São paulo"; lugar[2] = "Amazonas";
            lugar[3] = "Recife"; lugar[4] = "Rio de Janeiro"; lugar[5] = "Bahia";
            lugar[6] = "Florianópolis"; lugar[7] = "Rio grande do sul"; lugar[8] = "Minas Gerais";
            lugar[9] = "Santa catarina"; lugar[10] = "Parana"; lugar[11] = "Acre";
        }
        //metodo que irá mostrar as possiveis viagens e deixará a escolha do usuario a partir do seu indice
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
        private string[,] assentos{ get; set;} = new string[2,15];
        //construtor da classe onibus, dando o total de passageiros do onibus
        public Onibus()
        {
            quant_passageiros_total = 30;
        }
        //get set da quantidade de passageiros total que o nosso onibus suporta
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
        //metodo de cadastro para o passageiro, anexando uma posição da matriz as suas informações(nome)
        public string[,] cadastro()
        {
            int i = 0;
            
            for ( i = 0; i < assentos.Length; i++)
            {
                for (var j = 0; j < assentos.Length; j++)
                {
                    Console.WriteLine("escreva o nome do passageiro\ncaso não queira mais adicionar passageiros insira sair");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    if (nome == "sair" || nome == "Sair" || nome == "SAIR")
                    {
                        goto final;
                    }
                    else
                    {
                        assentos[i, j] = nome;
                    }
                }
            }
            final:
            for (int s = 0; s < 2; s++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if(assentos[s,j] == null)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(assentos[s, j]);
                    }
                }
            }
            return assentos;
        }
    }
    class Distancia
    {
        //2 atributos um central e outro um array de posiveis destinos para o passageiro
        public string central = "Distrito federal";
        public float[] distance { get; set; } = new float[12];
        //construtor da classe distancia
        public Distancia()
        {
            distance[0] = 1441.6f; distance[1] = 1050.6f; distance[2] = 2262f; distance[3] = 2346.7f;
            distance[4] = 1452.4f; distance[5] = 995f; distance[6] = 1723.9f; distance[7] = 1915.4f;
            distance[8] = 642f; distance[9] = 1656.9f; distance[10] = 1423f; distance[11] = 2441f;
        }
        //metodo que diz aonde o passageiro vai e quanto que é a distancia entre a central e o destino
        public float[] relatorio(int escolha, string v_lugar)
        {
            int i = 0;
            for (i = 0; i < 1; i++)
            {
                Console.WriteLine("De {0} até {1}, a distancia é de {2} KM", central, v_lugar, distance[escolha]);
            }
            //Console.WriteLine("A distancia é de {0}", distance[obj.escolha]);
            return distance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Onibus onb = new Onibus();
            Destino tst = new Destino();
            Distancia dst = new Distancia();
            Passagem psg = new Passagem(); 
            tst.info();
            dst.relatorio(tst.escolha - 1, tst.lugar[tst.escolha - 1]);
            onb.cadastro();
            psg.Pass();
            Console.WriteLine("Agradecemos a sua preferencia!!!\nBoa viagem e volte sempre!!");
        }
    }
}
