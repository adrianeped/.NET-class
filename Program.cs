using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUser = Console.ReadLine();

            while (opcaoUser.ToUpper() != "X")
            {
                switch (opcaoUser)
                {
                    case "1":
                        //add aluno
                        break;

                    case "2":
                        //listar alunos
                        break;
                    
                    case "3":
                        //calcular media geral
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1 - Inserir novo aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Calcular média geral");
                Console.WriteLine("X - Sair");
                Console.WriteLine();
            }
        }
    }
}
