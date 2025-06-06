using System;

class Program
{
    static Biblioteca biblioteca = new();

    static void Main(string[] args)
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Cadastrar Livro");
            Console.WriteLine("2. Cadastrar Usuário");
            Console.WriteLine("3. Registrar Empréstimo");
            Console.WriteLine("4. Registrar Devolução");
            Console.WriteLine("5. Listar Livros");
            Console.WriteLine("6. Exibir Relatórios");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1": CadastrarLivro(); break;
                case "2": CadastrarUsuario(); break;
                case "3": RegistrarEmprestimo(); break;
                case "4": RegistrarDevolucao(); break;
                case "5": biblioteca.ListarLivros(); break;
                case "6": biblioteca.ExibirRelatorios(); break;
                case "0": sair = true; break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }

    static void CadastrarLivro()
    {
        Console.Write("Título: ");
        string titulo = Console.ReadLine();
        Console.Write("Autor: ");
        string autor = Console.ReadLine();
        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Quantidade: ");

        if (!int.TryParse(Console.ReadLine(), out int quantidade) || quantidade <= 0)
        {
            Console.WriteLine("Quantidade inválida.");
            return;
        }

        biblioteca.CadastrarLivro(titulo, autor, isbn, quantidade);
    }

    static void CadastrarUsuario()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Matrícula: ");
        string matricula = Console.ReadLine();

        biblioteca.CadastrarUsuario(nome, matricula);
    }

    static void RegistrarEmprestimo()
    {
        Console.Write("ISBN do livro: ");
        string isbn = Console.ReadLine();
        Console.Write("Matrícula do usuário: ");
        string matricula = Console.ReadLine();

        biblioteca.RegistrarEmprestimo(isbn, matricula);
    }

    static void RegistrarDevolucao()
    {
        Console.Write("ISBN do livro: ");
        string isbn = Console.ReadLine();
        Console.Write("Matrícula do usuário: ");
        string matricula = Console.ReadLine();

        biblioteca.RegistrarDevolucao(isbn, matricula);
    }
}