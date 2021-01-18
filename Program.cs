using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUser = ObterOpcaoUser();

            while (opcaoUser.ToUpper() != "X")
            {
                switch (opcaoUser)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");

                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        
                        Console.WriteLine();

                        Console.WriteLine("Informe a nota do aluno: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else 
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!!");
                        }
                        
                        alunos[indiceAluno] = aluno;
                        indiceAluno++; 
                        break;

                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }
                            
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;
                        var numAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                numAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / numAlunos;

                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral}");

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUser = ObterOpcaoUser();
            }
        }

        private static string ObterOpcaoUser()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUser = Console.ReadLine();
            Console.WriteLine();
            return opcaoUser;
        }
    }
}
