using System;

class Program
{
    static string senha;

    static void Main()
    {
        Console.WriteLine("\t\t\t\t\t***SISTEMA DE GESTÃO DE SENHA***");
        Console.Write("\n\t\t\t\t\tDefina a sua senha: ");
        senha = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("\n\n\t\t\t\t\tSENHA DEFINIDA COM SUCESSO!!!");

        Console.WriteLine("\n\t\t\t\t\tDeseja alterar a sua senha?");
        Console.Write("\n\t\t\t\t\tDigite 1 para alterar senha e 2 para continuar: ");

        string respostaDigitada = Console.ReadLine();

        if (respostaDigitada == "1")
        {
            AlterarSenha();
        }

        Console.Write("\n\t\t\t\t\tDigite a sua senha: ");
        string senhaDigitada = Console.ReadLine();

        if (ValidarSenha(senhaDigitada))
        {
            Console.WriteLine("\n\t\t\t\t\tSenha validada!");
            Console.WriteLine("\t\t\t\t\tPrograma encerrado!");
        }
        else
        {
            Console.WriteLine("\n\t\t\t\t\tSenha incorreta! Acesso negado.");
            Console.WriteLine("\n\t\t\t\t\tDeseja alterar a senha?");
            Console.Write("\t\t\t\t\tDigite 1 para alterar senha e 2 para sair");

            string resposta = Console.ReadLine();
            if (resposta == "1")
            {
                AlterarSenha();
            }
            else if (resposta == "2")
            {
                Console.WriteLine("\n\t\t\t\t\tPrograma encerrado!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\tOpção inválida! Programa encerrado.");
                Environment.Exit(0);
            }
        }
    }

    static bool ValidarSenha(string senhaDigitada)
    {
        return senhaDigitada == senha;
    }

    static void AlterarSenha()
    {
        Console.WriteLine("\n\n\t\t\t\t\tPainel de Alteração de Senha");

        Console.Write("\n\t\t\t\t\tInforme a senha antiga: ");
        string senhaAntiga = Console.ReadLine();

        if (ValidarSenha(senhaAntiga))
        {
            Console.Write("\n\t\t\t\t\tInforme a nova senha: ");
            string novaSenha = Console.ReadLine();

            Console.Write("\n\t\t\t\t\tConfirme a nova senha: ");
            string novaSenhaConfirmacao = Console.ReadLine();

            if (novaSenha == novaSenhaConfirmacao && novaSenha.Length >= 4)
            {
                senha = novaSenha;
                Console.WriteLine("\n\t\t\t\t\tSenha alterada com sucesso!");
            }
            else
            {
                Console.WriteLine("\n\t\t\t\t\tA nova senha não coincide ou é inválida! A senha precisa ter pelo menos 4 caracteres.");
            }
        }
        else
        {
            Console.WriteLine("\n\t\t\t\t\tA senha antiga está incorreta!");
        }
    }
}
