using System;

namespace atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {    //variaveis usadas

            string texto = "";
            int soma=0, valor_digitado=0;
            
            Console.WriteLine($"Ex1: {MostrarSoma(ref soma)}");
            Console.WriteLine($"Ex2:{MostrarFibonacci(ref valor_digitado)}\nEx3:A=9\nB=128\nC=49\nD=100\nE=13\nF=200\nEx4: O caminhão, ja que esta mais devagar e parou mais, realizei usando a formula Torricelli\nEx5: {Inverter(ref texto)}");

        }
        /// <summary>
        ///     Função para o Ecercicio 1
        /// </summary>
        /// <param name="soma">guardar a soma</param>
        /// <returns>retornar a soma pro main</returns>
        static int MostrarSoma(ref int soma)
        {

            int indice = 13, k = 0;
            //caso queira perguntar o numero pro usuario
           // Console.WriteLine("Digite um numero"); k=int.Parse(Console.ReadLine());

            if (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }
            //valor de soma=1
            return soma;
        }
        /// <summary>
        /// função feita para mostrar resultado do exercicio 2
        /// </summary>
        /// <param name="valor_digitado">valor para armazenar o valor que o usuario inserir</param>
        /// <returns>retornar o valor</returns>
        static int MostrarFibonacci(ref int valor_digitado)
        {
            int num1 = 0, aux,  termos, num2 = 1;
            Console.WriteLine("Digite o numero de termos");
            termos = int.Parse(Console.ReadLine());

            for (int i = 0; i​​​​​​​ < termos; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
   
            }
            Console.WriteLine("Digite o numero que procura");
            valor_digitado = int.Parse(Console.ReadLine());
            if (valor_digitado == num2 )
            {
                Console.WriteLine("Valor Encontrado");
            }
            else
            {
                Console.WriteLine("Valor nao encontrado");
            }
            return valor_digitado;
        }



        /// <summary>
        /// Funcao para inverso
        /// </summary>
        /// <param name="texto">variavel para pegar o valor</param>
        /// <returns>retornar o array</returns>
        static public string Inverter( ref string texto)
        {
            Console.WriteLine("Digite a palavra para ver seu inverso");
            texto=Console.ReadLine();
            char[] ArrayChar = texto.ToCharArray();
            Array.Reverse(ArrayChar);
            return new string(ArrayChar);
        }




    }
}
