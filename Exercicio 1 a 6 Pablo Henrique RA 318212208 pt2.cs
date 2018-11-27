using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios_1_a_6
{
    class Program
    {
        static void Main(string[] args)
        {

            #region N° 1
            /*1. Uma empresa quer transmitir dados pelo telefone, mas está preocupada com a interceptação telefônica. Todos os seus dados são transmitidos como
            inteiros de quatro dígitos. Ela pediu para que você escreva um programa que criptografe seus dados,
            para que eles possam ser transmitidos com mais segurança. Seu aplicativo deve ler um inteiro
            de quatro dígitos fornecidos pelo usuário e criptografá-lo da seguinte forma: Substitua cada
            dígito por (a soma desse dígitos mais 7) módulo 10. Em seguida, troque o primeiro dígitopelo terceiro e
            troque o segundo dígito pelo quarto e imprima o inteiro criptografado.
            */


            Console.Write("Digite um numero de 4 digitos :");

            int ent = Convert.ToInt32(Console.ReadLine());
            int temp1 = Entrada / 1000;
            int rest1 = Entrada % 1000;
            int num1 = temporario1;

            

            int temp2 = rest1 / 100;
            int rest2 = rest1 % 100;
            int num2 = temp2;
            int temp3 = rest2 / 10;
            int rest3 = rest2 % 10;
            int num3 = temp3;
            int num4 = rest3;

            

            var num1_crip = (num1 + 7) % 10;
            var num2_crip = (num2 + 7) % 10;
            var num3_crip = (num3 + 7) % 10;
            var num_4_crip = (num4 + 7) % 10;

            Console.WriteLine("Os numeros criptografados são :");
            Console.Write("[0][1][2][3]", num3_crip, num4_crip, num1_crip, num2_crip);
            Console.ReadLine();
            Console.Clear();

            #endregion



            #region N°2
            /*Crie um programa em C# que determina se o cliente de uma loja de departamentos
            ultrapassou o limite de crédito em uma conta. Para cada cliente modelado em uma classe, os seguintes dados estão disponíveis:
            a) Número da conta
            b) O saldo no início do mês;
            c) O total de todos os itens cobrados desse cliente no mês corrente;
            d) O total de todos os créditos aplicados na conta desse cliente no mês corrente;
            e) O limite de crédito permitido.
            O programa deve fornecer como valores inteiros cada um desses fatos, e através dos
            métodos da classe cliente: calcular o novo saldo(= saldo inicial + cobranças - créditos),
            exibir o novo saldo e determinar se o novo saldo ultrapassa o limite de crédito do cliente.
            Para os clientes cujo limite de crédito foi ultrapassado, o programa deve exibir a mensagem:
            “Limite de Crédito Excedido!”. Teste a classe criada, bem como os métodos propostos na classe principal do seu programa. 
            */

            int saldo = 0;

            Console.WriteLine("Digite o valor do saldo :");
            saldo = int.Parse(Console.ReadLine());

            Cliente_N2 cliente = new Cliente_N2(saldo, 2, 200, 300, 4000);
            Console.WriteLine("o seu novo limite de credito é :");
            Console.Write(cliente.calcular_novo_saldo());

            cliente.atualizar_saldo();

            if (cliente.verificar_limite()) ;

            else
                Console.ReadLine();
            Console.Clear();

            #endregion



            #region N°3
            /*Implemente em C# a função booleana Par que retorna verdadeiro se um número inteiro
            passado como parâmetro for par ou falso caso ele seja ímpar.Teste seu programa chamando a função para verificar os números de 0 à 10. 
            */

            Console.WriteLine("Insira um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("o numero inserido [0] é par", numero);
            else
                Console.WriteLine("o numero inserido [0] é impar", numero);

            Console.ReadKey();
            Console.Clear();

            #endregion



            #region N°4
            /*Escreva um programa que leia 3 números inteiros referente ao comprimento dos lados de
            um triângulo e classifique como: triângulo equilátero, isósceles ou escaleno. 
            */


            Console.Write("Digite o valor do primeiro valor:");
            string tri1 = Console.ReadLine();

            Console.Write("Digite o valor do segundo valor :");
            string tri2 = Console.ReadLine();

            Console.Write("Digite o valor do terceiro valor :");
            string tri3 = Console.ReadLine();

            if (tri1 == tri2 && tri2 == tri3)
                Console.WriteLine("Triangulo equilátero");

            else if (tri1 == tri2 || tri2 == tri3 || tri1 == tri3)
                Console.WriteLine("Triangulo isósceles");

            else
                Console.WriteLine("Este é um triangulo escaleno");
            Console.ReadLine();
            Console.Clear();

            #endregion



            #region N°5
            /*Escreva um programa que leia apenas uma letra do alfabeto como entrada e classifique-a como vogal ou consoante. Seu programa deverá aceitar como entrada apenas um
              caractere, ou seja, se o usuário digitar dois ou mais caracteres, o sistema deverá informar ao usuário a entrada rejeitada. 
            */


            int ver = 0;
            Console.Write("Insira uma letra :");

            var letra = Console.ReadLine().ToArray();

            string[] vogais = new string[] { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };

            if (letra.Length == 1)

                for (int i = 0; i < vogais.Length; i++)

                    if (letra[0].ToString() == vogais[i])
                        ver = 1;

            if (ver == 1)
                Console.WriteLine("\n \t A letra insirida é uma vogal.");

            else
                Console.WriteLine("\n \t A letra insirida é uma consoante ou um caracter qualquer.");
            
            else
                Console.WriteLine("Não Indentificado!");
            Console.ReadKey();
            Console.Clear();

            #endregion



            #region N°6
            /*“Um número é primo se ele for divisível por 1 e por ele mesmo”. 
            Escreva um programa C# que verifica se um número é primo. 
            */

            Console.WriteLine("\t Exercício 6: \n");
            Console.WriteLine("Digite um número natural maior que 2:\n");

            int numpri = 0;
            int restdivi = 0;
            int den = 0;
            int ver = 0;

            numpri = int.Parse(Console.ReadLine());

            for (den = 2; den < numpri; deno++)
                restdiv = numpri % den;

            if (restdiv == 0)
                ver = 1;

            if (ver == 1)
                Console.WriteLine("O número digitado não é PRIMO.");

            else
                Console.WriteLine("O número digitado é PRIMO.");
            Console.ReadKey();
            Console.Clear();

            #endregion




























        }

    }
}
