using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =================================== for ==========================================
            string[] palavars = { "Caderno", "celular", "tenis", "blusa", "caneta", "oculos" };
            for (int contador = 0; contador <palavars.Length; contador++)
            {
                Console.WriteLine(contador);
                Console.WriteLine(palavars[contador]);
            }
            Console.WriteLine("=================");
            for(int contador2 = palavars.Length-1; contador2 >= 0; contador2--)
            {
                Console.WriteLine(contador2);
                Console.WriteLine(palavars[contador2]);
            }
            Console.WriteLine(" Fim da linha");
            Console.ReadLine();
            // =================================== foreach ==========================================
            /*string[] palavars = { "Caderno", "celular", "tenis", "blusa", "caneta", "oculos" };
            foreach(string palava in palavars)
            {
                Console.WriteLine(palava);
            }
            Console.WriteLine("  Fim da linha");
            Console.ReadLine();*/
            // =================================== do while ==========================================
            /* int contador2 = 30;
             do
             {
                 Console.WriteLine("do while");   
                 contador2++;
             }while(contador2 < 20);
             Console.WriteLine("Fim da linha");
             Console.ReadLine(); */
            // =================================== while ==========================================
            /*int contador = 0;
            while (contador < 10)
            {
                Console.WriteLine(contador + 1);
                Console.WriteLine("Rodando o while");
                contador++;
            }
            Console.WriteLine("Fim da linha");
            Console.ReadLine();*/
            // ====================================================================================
            /*enum Opicao { Criar = 1, Deletar, Editar, Litar, Atualizar }
            static void Main(string[] args)
            {
                Console.WriteLine("Selecione uma das opiçao abaixo: ");
                Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
                int index = int.Parse(Console.ReadLine());
                Opicao opicaoselecionada = (Opicao)index;
                switch (opicaoselecionada)
                {
                    case Opicao.Criar:
                        Console.WriteLine("vc qer criar algo ?");
                        break;
                    case Opicao.Deletar:
                        Console.WriteLine("vc qer Deletar algo ?");
                        break;
                    case Opicao.Editar:
                        Console.WriteLine("vc qer Editar algo ?");
                        break;
                }
                Console.ReadLine();*/
            // ====================================================================================
            /*enum Cor { Azul, Verde, Amarelo, Vermelho }
            static void Main(string[] args)
            {
                Cor CorFavorita = Cor.Vermelho;
                Cor CorFavoritaAna = Cor.Amarelo;
                Console.WriteLine((int)CorFavorita);
                Console.WriteLine(CorFavoritaAna);
                Console.ReadLine();*/
            // ====================================================================================
            /*var meuTexto = "HELLO WORLD - Mateus Mouta";
            Console.WriteLine(meuTexto);
            Console.WriteLine("Hello World");
            Console.WriteLine("Meu nome é Mateus");*/
            // ====================================================================================
            /*int segundaGuerraMundial = 1942;
            string cor_favorita = "Ciano";
            float velocidadeF1 = 298.878f;
            bool segundaGuerraMundialAconteceu = true;
            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);
            velocidadeF1 = 356.867f;
            cor_favorita = "Roxo";
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);*/
            // ====================================================================================
            //var cor_favorita = "Laranja";
            //var modeloDoProduto = 2323;

            /*dynamic cor_favorita = "Azul";
            Console.WriteLine(cor_favorita);
            cor_favorita = 42;
            Console.WriteLine(cor_favorita);*/

            //const float PI = 3.1416f;

            /*tring nome = "";
             Console.WriteLine("Escreva seu nome");
             nome = Console.ReadLine();
             Console.WriteLine("seu nome é:");
             Console.WriteLine(nome);*/
            // ====================================================================================
            /*if (10 > 10)
            {
                Console.WriteLine("É verdadeiro");
            }
            else if (10 == 10)
            {
                Console.WriteLine("Volor é igual a 10");
            }
            else
            {
                Console.WriteLine("Valor é falso");
            }*/
            // ====================================================================================
            /*int a = 10;
            int b = 20;
            int c = 2;

            if (a > b)
            {
                Console.WriteLine("É verdadeiro");
            }
            else if (a > c )
            {
                Console.WriteLine("Volor é igual ifelse");
            }
            else
            {
                Console.WriteLine("Valor é falso");
            }*/
            // ====================================================================================
            // TRUE && TRUE = TRUE
            // TRUE && FALSE = FALSE
            // TRUE || False = TRUE 
            // FALSE || FALSE = FALSE 

            /*Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Voce é uma criança");
            } else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Voce é adolecente");
            }
            else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Voce é adulto");
            }
            else if (idade >= 61 && idade <= 125)
            {
                Console.WriteLine("Voce é idoso");
            }
            else
            {
                Console.WriteLine("Idade invalida");
            }*/
            // ====================================================================================
            /* ExibirMsg();
             ExibirMsg();
             ExibirMsg();
             Console.ReadLine();
         }
         static void ExibirMsg()
         {
             Console.WriteLine("ESSE SISTEMA É SHOW DE BOLA");
             Console.WriteLine("Estou usando funçoes");
             Console.WriteLine("bem vindo");*/
            // ====================================================================================
            /* GerarPreco(3,"Arroz");
             Console.ReadLine();
         }
         static void GerarPreco(int preco, string nome)
         {
             Console.WriteLine("Nome do produto: " + nome);
             Console.WriteLine("Seu preço é: R$" +  preco);*/
            // ====================================================================================
            /*GerarPreco(500);
            GerarPreco(-234);
            Console.ReadLine();
        }
        static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);*/
            // ====================================================================================
            /* int Somar1 = Somar(1, 2, 3);
             int Somar2 = Somar(30, 46, 83);
             Console.WriteLine(Somar1);
             Console.WriteLine(Somar2);
             Console.ReadLine();
         }                             //VOID E USADO QUANDO VC N QUER RETORNAR NADA 
         static int Somar(int a, int b, int c)
         {
             int resultadoFinal = a + b + c;
             return resultadoFinal;*/
            // ====================================================================================

            /*string[] produtos = new string[5] {
                 "Genshin impact",
                 "FIFA",
                 "Minecraft",
                 "T3 Arena",
                 "CS"
         };
            int [] valores = {10, 20, 30};
            produtos[1] = "FIFA 2022";
            Console.WriteLine(produtos[3]);
            Console.ReadLine();*/
            // ====================================================================================
            /* Console.WriteLine("dentre Amarelo, Azul e Vermelho qual é a cor que vc mais gosta ?");
             string cor = Console.ReadLine();
             switch (cor)
             {
                 case "Vermelho":
                     Console.WriteLine("SUA COR FAVORITA É VERMELHO ");
                     break;
                 case "Amarelo":
                     Console.WriteLine("SUA COR FAVORITA É AMARELO ");
                     break;
                 case "Azul":
                     Console.WriteLine("SUA COR FAVORITA É AZUL ");
                     break;
                 default:
                     Console.WriteLine("DESCULPA NAO FOI POSSIVEL INDENTIFICAR ESTA COR");
                     break;
             }
             Console.ReadLine();*/
            // ====================================================================================
        }
    }
}
