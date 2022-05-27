using System;

namespace comandosDeRepeticao;

class program 
{
        static void Main()
        {
            //condição verdadeira 
            Boolean condicao = true;
            int valor;


            Console.WriteLine("Digite um valor, 0 para sair:");
            valor = int.Parse(Console.ReadLine());
            
/****************************************************************************/ 
            //Uso do comando while - enquanto
            while(condicao == true)
            {
                if(valor == 0)
                {
                    Console.WriteLine("Você saiu da aplicação!");
                    condicao = false;
                }
                else
                {
                    Console.WriteLine("O valor informado é: "+ valor);
                }
            }
/****************************************************************************/         
            //Uso do comando do  - faz
            /*Ele verifica se a função do código é verdadeira ou não. */ 
            do
            {
                if(valor == 0)
                {
                    Console.WriteLine("Você saiu da aplicação!");
                    condicao = false;
                }
                else
                {
                    Console.WriteLine("O valor informado é: "+ valor);
                }
            }while(condicao == true);
/****************************************************************************/ 
            //Comando For - para 
            /*Neste exemplo ele imprime o valor fornecido pelo usuário. Se o número escolhido foi menor que 10, imprimi a númeração.  */ 
            for(int i = valor; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

        }
/****************************************************************************/ 
        /* O comando de repetição FOREACH imprime os números da lista*/ 
        static void demo1()
        {
            int [] lista = {1,2,3,4,5};
            foreach(int numero in lista)
            {
                Console.WriteLine("");
            }
        }

}

