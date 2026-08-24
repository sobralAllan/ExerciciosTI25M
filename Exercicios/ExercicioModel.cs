using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioModel
    {
        //Área para declaração de variáveis globais
        private int num1;
        private int num2;
        private double num3;
        private double num4;
        private int resultado;
        public int[] vet;//Criando um vetor

        //Método Construtor: Instância as variáveis na memória
        public ExercicioModel()
        {
            SetNum1(0);
            SetNum2(0);
            SetResultado(0);
        }//fim do método construtor

        public ExercicioModel(int num1, int num2)
        {
            SetNum1(num1);
            SetNum2(num2);
            SetResultado(0);
        }//fim do construtor

        public ExercicioModel(double num1, double num2)
        {
            SetNum3(num1);
            SetNum4(num2);
        }//fim do construtor

        //Métodos GETS E SETS
        //GET = Pegar, Obter, Consultar
        //SET = Alterar, Modificar, Configurar
        public int GetNum1()
        {
            return this.num1;
        }//fim do getNum1

        public void SetNum1(int num1)
        {
            this.num1 = num1;
        }//fim do setNum1

        public int GetNum2()
        {
            return this.num2;
        }//fim do getNum2

        public void SetNum2(int num2)
        {
            this.num2 = num2;
        }//fim do setNum2

        public int GetResultado()
        {
            return this.resultado;
        }//fim do método

        public void SetResultado(int resultado)
        {
            this.resultado = resultado;
        }//fim do método setResultado

        public double GetNum3()
        {
            return this.num3;
        }//fim do GetNum3

        public void SetNum3(double num3)
        {
            this.num3 = num3;
        }//fim do setNum3

        public double GetNum4()
        {
            return this.num4;
        }//fim do GetNum4

        public void SetNum4(double num4)
        {
            this.num4 = num4;
        }//fim do SetNum4

        public int Somar()
        {
            return this.num1 + this.num2;
        }//fim do método somar

        public int Subtrair()
        {
            SetResultado(GetNum1() - GetNum2());
            return GetResultado();
        }//fim do método subtrair

        public int Multiplicar()
        {
            SetResultado(GetNum1() * GetNum2());
            return GetResultado(); 
        }//fim do multiplicar

        public double Dividir()
        {
            if(GetNum2() < 0)
            {
                return -2;
            }
            else if(GetNum2() == 0)
            {
                return -1;
            }
            else
            {
                SetResultado(GetNum1() / GetNum2());
                return GetResultado();
            }//fim do if
        }//fim do dividir

        public double Potencia(double bas, double expoente)
        {
            return Math.Pow(bas, expoente);
        }//fim da potencia

        public double Raiz(double num)
        {
            return Math.Sqrt(num);
        }//fim da Raiz

        public double Potencia()
        {
            return Math.Pow(GetNum3(), GetNum4());
        }//fim do potencia sem parâmetros

        public double RaizNum3()
        {
            return Math.Sqrt(GetNum3());
        }//fim do raiz

        public double RaizNum4()
        {
            return Math.Sqrt(GetNum4());
        }//fim do raiz num 4

        public string Exercicio01(int ano)
        {
            if(ano % 4 == 0)
            {
                return ano + " é bissexto!";
            }
            else
            {
                return ano + " não é bissexto!";
            }
        }//fim do ano Bissexto

        //Leia um número inteiro e retornar todos os múltiplos menores que 100
        public string multiplo(int numero)
        {
            //Contador
            int i = 1;//Criando o contador e definindo o ponto de partida
            string resultado = "";
            while(i < 100)
            {
                if(numero % i == 0)
                {
                    resultado += i + "\n";
                }
                //Rodar o meu contador
                i++;
            }//fim do while
            return resultado;
        }//fim do método

        public string multiploFor(int numero)
        {
            string resultado = "";
            for (int i = 1; i < 100; i++)
            {
                if(numero % i == 0)
                {
                    resultado += i + "\n";
                }//fim do if
            }//fim do for
            return resultado;
        }//fim do método

        //Leia um número e verifique se ele é palíndromo(ex: 121, 1331, 1441, 0660)
        public bool EhPalindromo(string palin)
        {
            int fim = palin.Length-1;//Meço o tamanho de um conjunto de caracteres
            int inicio = 0;
          
            while (inicio < fim)
            {
                if(palin.Substring(inicio,1) != palin.Substring(fim, 1))
                {
                    return false;
                }
                inicio++;
                fim--;
            }//fim do while
            return true;
        }//fim do método

        //Solicite ao usuário 10 números e conte os pares e ímpares
        public void ContarParImpar()
        {
            int contarPar   = 0;
            int contarImpar = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + "º número: ");
                int num = Convert.ToInt32(Console.ReadLine());
                //Comparações
                if(num % 2 == 0)
                {
                    contarPar++;
                }
                else
                {
                    contarImpar++;
                }
            }//fim do for
            Console.WriteLine("A quantidade de pares é: " + contarPar + "\nA quantidade de ímpares é: " + contarImpar);
        }//fim do parImpar
        
        //Vetores 
        //Preencher o vetor
        public void PreencherVetor()
        {
            this.vet = new int[10];//instanciando  
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + "ª Posição: ");
                this.vet[i] = Convert.ToInt32(Console.ReadLine());
            }//fim do for
        }//fim do preencherVetor

        public void MostrarVetor()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + "ª Posição: " + this.vet[i]);
            }//fim do for
        }//fim do método

        public string ProcurarNumero(int num)
        {
            for(int i = 0; i < 10; i++)
            {
                if (vet[i] == num)
                {
                    return "O número está na posição: " + (i+1);
                }
            }//fim do for
            return "O " + num + " não foi encontrado no vetor";
        }//fim do método
    }//fim da classe
}//fim do projeto
