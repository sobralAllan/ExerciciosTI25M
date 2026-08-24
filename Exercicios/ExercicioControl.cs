using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioControl
    {
        ExercicioModel modelo;//Conectando a Classe Model e Control
        private int opcao;

        public ExercicioControl()
        {
            this.modelo = new ExercicioModel();
            SetOpcao(0);
        }//Construtor Padrão

        public int GetOpcao()
        {
            return this.opcao;
        }//fim do getOpcao

        public void SetOpcao(int opcao)
        {
            this.opcao = opcao;
        }//fim do set

        public void Coletar()
        {
            //Peguei os dois
            Console.Write("Informe o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Vou passar para o construtor com parâmetro
            this.modelo = new ExercicioModel(num1, num2);
        }//fim do coletar = Pega os dois números digitados

        public void ColetarReal()
        {
            //Pegar dois números
            Console.WriteLine("Informe o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            //Chamar o construtor que recebe reais
            this.modelo = new ExercicioModel(num1, num2);
        }//fim do coletarReal

        //Mostrar as opções de operação na tela
        public void Menu()
        {
            Console.WriteLine("\nEscolha uma das opções abaixo: \n" +
                              "0. Sair\n"                         +
                              "1. Soma\n"                         +
                              "2. Subtração\n"                    +
                              "3. Divisão\n"                      +
                              "4. Multiplicação\n"                +
                              "5. Potência\n"                     +
                              "6. Potência com Parâmetros\n"      +
                              "7. Raiz\n"                         +
                              "8. Raiz com Parâmetros\n"          +
                              "9. Exercício 01\n"                 +
                              "10. Exercício Multiplo\n"          +
                              "11. Exercício Multiplo For\n"      +
                              "12. Exercício Palindromo\n"        +
                              "13. Exercício ParImpar\n"          +
                              "14. Exercício Vetor\n"             +
                              "15. Procurar número no vetor\n");
            SetOpcao(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();//Limpa o console
        }//fim do menu

        //Executar o menu
        public void ExecutarMenu()
        {
            do
            {
                Menu();//Mostrar as opções
                switch (GetOpcao())
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();//Pegar os dois números
                        Console.WriteLine("A soma é: " + this.modelo.Somar());//Fazer a operação de soma
                        break;//Finalizar o case
                    case 2:
                        Coletar();
                        Console.WriteLine("A subtração é: " + this.modelo.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        //Validação
                        if (this.modelo.Dividir() == -2)
                        {
                            Console.WriteLine("Impossível dividir por número negativo!");
                        }
                        else if (this.modelo.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("A Divisão é: " + this.modelo.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("A multiplicação é: " + this.modelo.Multiplicar());
                        break;
                    case 5:
                        ColetarReal();
                        Console.WriteLine("A Potência é: " + this.modelo.Potencia());
                        break;
                    case 6:
                        Console.WriteLine("Informe a base: ");
                        double bas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o expoente: ");
                        double expoente = Convert.ToDouble(Console.ReadLine());
                        //Mostrar o resultado da operação
                        Console.WriteLine("A potência é: " + this.modelo.Potencia(bas, expoente));
                        break;
                    case 7:
                        ColetarReal();
                        Console.WriteLine("A raiz do primeiro número é: " + this.modelo.RaizNum3());
                        Console.WriteLine("A raiz do segundo número é: " + this.modelo.RaizNum4());
                        break;
                    case 8:
                        Console.WriteLine("Informe o primeiro número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        //Chamar o método que calcula a Raiz
                        Console.WriteLine("A raiz do primeiro número é: " + this.modelo.Raiz(num1));
                        Console.WriteLine("A raiz do segundo número é: " + this.modelo.Raiz(num2));
                        break;
                    case 9:
                        Console.WriteLine("Informe o ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado
                        Console.WriteLine(this.modelo.Exercicio01(ano));
                        break;
                    case 10:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado da operação
                        Console.WriteLine(this.modelo.multiplo(num));
                        break;
                    case 11:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado da operação
                        Console.WriteLine(this.modelo.multiploFor(num));
                        break;
                    case 12:
                        Console.WriteLine("Informe um número: ");
                        string palin = Console.ReadLine();
                        if(this.modelo.EhPalindromo(palin) == false)
                        {
                            Console.WriteLine("Não é Palíndromo");
                        }
                        else
                        {
                            Console.WriteLine("É Palíndromo");
                        }
                        break;
                    case 13:
                        this.modelo.ContarParImpar();
                        break;
                    case 14:
                        this.modelo.PreencherVetor();
                        this.modelo.MostrarVetor();
                        break;
                    case 15:
                        this.modelo.PreencherVetor();
                        Console.WriteLine("Informe um número para procurar no vetor: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        //Chamar o método de procura
                        Console.WriteLine(this.modelo.ProcurarNumero(num));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é valida!");
                        break;
                }//fim do escolha
                
            } while (GetOpcao() != 0);//fim do do...while
        }//fim do método executar menu

    }//fim da classe
}//fim do projeto
