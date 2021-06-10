using System;
using System.IO;

namespace aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção = 0;
            string pass = "";
            do
            {
                Console.Clear();

                System.Console.WriteLine("\n-- Menu MGSOFT --\n");
                System.Console.WriteLine("Obs: Suba um arquivo usuarios.txt na pasta do programa, com os nomes dos usuários.\n\n Escolha alguma opção abaixo:\n1) Gerar lista de usuários no arquivo .txt.\n2) Gerar lista de usuários no arquivo .xml.\n3) Gerar lista de usuários na tela.\n4) Sair.");
                opção = int.Parse(Console.ReadLine());
                switch (opção)
                {
                    case 1:
                        Console.Clear();
                        string linha,arquivo="resultado";
                        string teste = "", aux;
                        

                        System.Console.WriteLine("Digite a senha que deseja:\n");
                        pass = Console.ReadLine();

                        System.Console.WriteLine("\nDigite o nome do arquivo para concluir:");
                        arquivo = Console.ReadLine();


                        FileStream arq = new FileStream("usuarios.txt", FileMode.Open); // abrindo o arquivo
                        StreamReader ler = new StreamReader(arq); // objeto para ler o arquivo
                        string[] usuarios; // vetor para armazenar os valores do arquivo
                        do
                        {
                            linha = ler.ReadLine(); // alocando os valores do arquivo na variável 'linha'
                            if (linha != null) // enquanto linha foi diferente de vazio
                            {
                                usuarios = linha.Split('\n'); // alocando os valores no vetor, separando cada valor por "," por exemplo nome;endereço
                                aux = "user local\n" +
                                "user " + usuarios[0] + " password "+pass+"\n" +
                                "user " + usuarios[0] + "\n" +
                                "force-password-change\n" +
                                "exit\n" +
                                "exit";
                                teste = aux + teste;
                            }
                        } while (linha != null); // se o valor da linha for igual a vazio então vai sair da estrutura de repetição

                        FileStream arq1 = new FileStream(arquivo+".txt", FileMode.Create);
                        StreamWriter escreve = new StreamWriter(arq1);
                        escreve.Write(teste);
                        escreve.Close();                        
                        Console.ReadKey();


                        break;

                        case 2:
                        Console.Clear();
                        string linhaxml,arquivoxml="resultado";
                        string testexml = "", auxxml;

                        System.Console.WriteLine("Digite a senha que deseja:\n");
                        pass = Console.ReadLine();

                        System.Console.WriteLine("\nDigite o nome do arquivo para concluir:");
                        arquivoxml = Console.ReadLine();


                        FileStream arqxml = new FileStream("usuarios.txt", FileMode.Open); // abrindo o arquivo
                        StreamReader lerxml = new StreamReader(arqxml); // objeto para ler o arquivo
                        string[] usuariosxml; // vetor para armazenar os valores do arquivo
                        do
                        {
                            linhaxml = lerxml.ReadLine(); // alocando os valores do arquivo na variável 'linha'
                            if (linhaxml != null) // enquanto linha foi diferente de vazio
                            {
                                usuariosxml = linhaxml.Split('\n'); // alocando os valores no vetor, separando cada valor por "," por exemplo nome;endereço
                                auxxml = "user local\n" +
                                "user " + usuariosxml[0] + " password "+pass+"\n" +
                                "user " + usuariosxml[0] + "\n" +
                                "force-password-change\n" +
                                "exit\n" +
                                "exit";
                                testexml = auxxml + testexml;
                            }
                        } while (linhaxml != null); // se o valor da linha for igual a vazio então vai sair da estrutura de repetição

                        FileStream arqxxml = new FileStream(arquivoxml+".xml", FileMode.Create);
                        StreamWriter escrevexml = new StreamWriter(arqxxml);
                        escrevexml.Write(testexml);
                        escrevexml.Close();                        
                        Console.ReadKey();

                        break;
                    case 3:
                        Console.Clear();

                        System.Console.WriteLine("Digite a senha que deseja:\n");
                        pass = Console.ReadLine();


                        string linh;
                        string test = "", au;
                        FileStream ar = new FileStream("usuarios.txt", FileMode.Open); // abrindo o arquivo
                        StreamReader le = new StreamReader(ar); // objeto para ler o arquivo
                        string[] usuario; // vetor para armazenar os valores do arquivo
                        do
                        {
                            linh = le.ReadLine(); // alocando os valores do arquivo na variável 'linha'
                            if (linh != null) // enquanto linha foi diferente de vazio
                            {
                                usuario = linh.Split('\n'); // alocando os valores no vetor, separando cada valor por "," por exemplo nome;endereço
                                System.Console.WriteLine(au = "user local\n" +
                                "user " + usuario[0] + " password "+pass+"\n" +
                                "user " + usuario[0] + "\n" +
                                "force-password-change\n" +
                                "exit\n" +
                                "exit");
                                test = au + test;
                            }
                        } while (linh != null); // se o valor da linha for igual a vazio então vai sair da estrutura de repetição
                        Console.ReadKey();
                        break;
                    case 4:
                        break;
                    default:
                        System.Console.WriteLine("Opção inválida! Tente novamente.");
                        Console.ReadKey();
                        break;
                }

            } while (opção != 4);



        }
    }
}
