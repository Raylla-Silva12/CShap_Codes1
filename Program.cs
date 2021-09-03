using System;

namespace aulaPA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            Console.WriteLine("1) Escreva um programa que exiba na tela em ordem crescente, apenas os números pares existentes de 11 a 250.\n");
            
            for (int x = 11; x <= 250; x++) {
                if (x % 2 == 0) {
                    Console.WriteLine(x);
                }
            }


            Console.WriteLine("\n\n");


            //Exercício 2
            Console.WriteLine("2) Escreva um programa que exiba na tela em ordem decrescente, apenas os números ímpares existentes entre dois números digitados pelo usuário (inclusive eles). \n");
            
            int primeiro_numero, segundo_numero;
            
            Console.Write("Digite um número: ");
            primeiro_numero = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            segundo_numero = int.Parse(Console.ReadLine());

            if (primeiro_numero >= segundo_numero) {
                for (int x = primeiro_numero; x >= segundo_numero; x--) {
                    if (x % 2 != 0) { Console.WriteLine(x); }
                }

            } else {
                for (int x = segundo_numero; x >= primeiro_numero; x--) {
                    if (x % 2 != 0) { Console.WriteLine(x); }
                }
            }


            Console.WriteLine("\n\n");


            //Exercício 3
            Console.WriteLine("3) Escreva um programa que exiba na tela a tabuada de um número que deverá ser informado pelo usuário.\n");
            Console.Write("Digite um número: ");
            
            int numero, resultado;
            numero = int.Parse(Console.ReadLine());

            Console.Write("\n");

            for (int x = 1; x <= 10; x++) {
                resultado = numero * x;
                Console.Write("{0} x {1} = {2}\n", numero, x, resultado);
            }


            Console.WriteLine("\n\n");


            //Exercício 4
            Console.WriteLine("4) Escreva um programa que exiba na tela a quantidade de números ímpares existentes entre dois números que o usuário digitar. \n");
            
            int oprimeiro_numero, osegundo_numero, quantidade_numeros_impares = 0, omenor_numero, omaior_numero;

            Console.Write("Digite um número: ");
            oprimeiro_numero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite outro número: ");
            osegundo_numero = int.Parse(Console.ReadLine());

            if (oprimeiro_numero <= osegundo_numero) {
                omenor_numero = oprimeiro_numero;
                omaior_numero = osegundo_numero;
            } else {
                omenor_numero = osegundo_numero;
                omaior_numero = oprimeiro_numero;
            }

            for (int x = omenor_numero; x <= omaior_numero; x++) {
                if (x % 2 != 0) { quantidade_numeros_impares++; }
            }

            Console.WriteLine("Quantidade de números ímpares entre {0} e {1} é {2}", omenor_numero, omaior_numero, quantidade_numeros_impares);


            Console.WriteLine("\n\n");


            //Exercício 5
            Console.WriteLine("5) Escreva um programa que leia 15 números inteiros e exiba na tela ao final, o maior número que foi digitado pelo usuário.\n");
            
            int numero_inteiro, numero_maior;
            
            Console.Write("Digite o 1° número: ");
            numero_maior = int.Parse(Console.ReadLine());

            for (int x = 1; x < 15; x++) {
                Console.Write("Digite o {0}° número: ", x + 1);
                numero_inteiro = int.Parse(Console.ReadLine());

                if (numero_inteiro > numero_maior) {
                    numero_maior = numero_inteiro;
                }
            }

            Console.WriteLine("\nO maior número digitado foi: {0}", numero_maior);


            Console.WriteLine("\n\n");


            //Exercício 6
            Console.WriteLine("6) Escreva um programa que calcule e exiba a média de 10 notas digitadas pelo usuário. Considerar notas válidas, somente valores entre 0 (zero) e 10 (dez). \n");
            int media, soma = 0, nota;

            for (int x = 1; x <= 10; x++) {

                do {
                    Console.Write("Insira a " + x + "° nota: ");
                    nota = int.Parse(Console.ReadLine());

                    if (nota < 0 || nota > 10) {
                        Console.Write("Insira notas de 0 á 10! ");
                    }

                } while (nota < 0 || nota > 10);
                soma = soma + nota;
            }

            media = soma / 10;
            Console.WriteLine("A média é: " + media);


            Console.WriteLine("\n\n");


            //Exercício 7
            Console.WriteLine("7) Escreva um programa que exiba todos os números de 1 a 100 e a cada número que for múltiplo de 10, exiba a mensagem “MÚLTIPLO DE 10”. \n");
            for (int x = 1; x <= 100; x++)
            {
                if (x % 10 == 0) { Console.WriteLine("{0}: MÚLTIPLO DE 10!", x); }
                else { Console.WriteLine(x); }
            }


            Console.WriteLine("\n\n");


            //Exercício 8
            Console.WriteLine("8) Escreva um programa que calcule o fatorial de um número informado pelo usuário.\n");
            
            int o_numero = 0, o_resultado = 1;

            Console.Write("Digite um número: ");
            o_numero = int.Parse(Console.ReadLine());

            Console.Write("\n{0}!=1", o_numero);

            for (int x = 2; x <= o_numero; x++) {
                o_resultado = o_resultado * x;
                Console.Write("*{0}", x);
            }

            Console.WriteLine("={0}", o_resultado);


            Console.WriteLine("\n\n");


            //Exercício 9
            Console.WriteLine("9) Escreva um programa que leia vários números inteiros e ao final informe quantos números pares, quantos números ímpares, quantos números positivos e quantos números negativos foram digitados pelo usuário. \n");

            int um_numero, par = 0, impar = 0, positivo = 0, negativo = 0;
            string resposta = "S";

            do {
                Console.Write("Digite um número: ");
                um_numero = int.Parse(Console.ReadLine());

                if (um_numero % 2 == 0) {
                    par++;
                }else{
                    impar++;
                }

                if (um_numero >= 0) {
                    positivo++;
                }else{
                    negativo++;
                }

                Console.Write("Deseja encerrar o programa (S/N)? ");
                resposta = Console.ReadLine();

            } while (resposta != "S" && resposta != "s");

            Console.WriteLine("Pares: " + par);
            Console.WriteLine("Ímpares: " + impar);
            Console.WriteLine("Positivos: " + positivo);
            Console.WriteLine("Negativos: " + negativo);


            Console.WriteLine("\n\n");


            //Exercício 10
            Console.WriteLine("10) Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um operário. Calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. \n");

            int c, n, e = 0, salario, salario_excedente; 
            string aresposta;

            do {
                Console.Write("Digite o código do operário: ");
                c = int.Parse(Console.ReadLine());
                
                Console.Write("Digite a quantidade de horas trabalhadas: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 50) {
                    salario = n * 10;

                    Console.WriteLine("Salário total: R$" + salario + ",00");
                    Console.WriteLine("Salário excedente: 0");
                }
                else {
                    e = n - 50;
                    salario_excedente = e * 20;
                    salario = e * 20 + 500;

                    Console.WriteLine("Salário total: R$" + salario + ",00");
                    Console.WriteLine("Salário excedente: R$" + salario_excedente + ",00");
                }

                Console.Write("Deseja encerrar o programa (S/N)? ");
                aresposta = Console.ReadLine();

            } while (aresposta != "S" && aresposta != "s");

            Console.ReadKey();
        }
    }
}