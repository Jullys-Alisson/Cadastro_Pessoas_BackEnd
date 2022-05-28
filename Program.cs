using Cadastro_Pessoas.Classes;

/// <summary>
/// metodo de cadastro de pessoa fisica
/// </summary>
/// <returns></returns>
/// 


Console.Clear();
Console.WriteLine(@$"
=====================================================
|        Bem vindo sistema de cadastro de           |
|           Pessoa Físicas e Jurídicas              |
=====================================================
");

Console.WriteLine($"Aperte 'ENTER' para continuar");
Console.ReadLine();

BarraCarregamento("Carregando", 500); //função carregamento

List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
=====================================================
|             Escolha uma opção abaixo              |
|---------------------------------------------------|
|              1 - Pessoa Física                    |
|              2 - Pessoa Jurídica                  |
|                                                   |
|              0 - Sair                             |
=====================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":


            PessoaFisica metodoPf = new PessoaFisica();

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=====================================================
|             Escolha uma opção abaixo              |
|---------------------------------------------------|
|              1 - Cadastrar Pessoa Física          |
|              2 - Listar Pessoa Física             |
|                                                   |
|              0 - Voltar ao menu anterior          |
=====================================================
");

                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();


                        Console.WriteLine($"Digite o nome");
                        novaPf.Nome = Console.ReadLine();

                        // bool dataValida;

                        // do
                        // {
                        //     Console.WriteLine($"Digite a data de nascimento Ex:DD/MM/AAAA");
                        //     string? dataNasc = Console.ReadLine();
                        //     dataValida = metodoPf.ValidarDataNasc(dataNasc);

                        //     if (dataValida)
                        //     {
                        //         novaPf.dataNasc = dataNasc;
                        //     }
                        //     else
                        //     {
                        //         Console.WriteLine($"Data digitada inválida");

                        //     }

                        // } while (!dataValida); //enquanto a data for inválida

                        // //novaPf.dataNasc = new DateTime(1982, 11, 13);

                        // Console.WriteLine($"Digite o número do CPF");
                        // novaPf.Cpf = Console.ReadLine();
                        // Console.WriteLine($"Digite o rendimento mensal (somente números) ");
                        // novaPf.Rendimento = float.Parse(Console.ReadLine());
                        // // Console.WriteLine($"Digite o endereço");
                        // Console.WriteLine($"Digite o logradouro");
                        // novoEnd.logradouro = Console.ReadLine();
                        // Console.WriteLine($"Digite o complemento");
                        // novoEnd.complemento = Console.ReadLine();
                        // Console.WriteLine($"Digite a casa  (SOMENTE NÚMEROS)");
                        // novoEnd.casa = int.Parse(Console.ReadLine());
                        // Console.WriteLine($"Este endereço é comercial? S/N");
                        // string endCom = Console.ReadLine().ToUpper();

                        // if (endCom == "S")
                        // {
                        //     novoEnd.endComercial = true;
                        // }
                        // else
                        // {
                        //     novoEnd.endComercial = false;
                        // }

                        // novaPf.endereco = novoEnd;

                        // listaPf.Add(novaPf);


                        // StreamWriter stw = new StreamWriter($"{novaPf.Nome}.txt");
                        // stw.WriteLine(novaPf.Nome);
                        // stw.Close();

                        using (StreamWriter stw = new StreamWriter($"{novaPf.Nome}.txt"))
                        {
                            stw.WriteLine(novaPf.Nome);
                        }

                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Thread.Sleep(500);


                        break;

                    case "2":

                        Console.Clear();

                        //                         if (listaPf.Count > 0)
                        //                         {
                        //                             foreach (PessoaFisica cadaPessoa in listaPf)
                        //                             {
                        //                                 Console.WriteLine(@$"
                        // Nome: {cadaPessoa.Nome}
                        // CPF: {cadaPessoa.Cpf}
                        // Rendimento: {cadaPessoa.Rendimento.ToString("C")}
                        // Maior de idade: {(metodoPf.ValidarDataNasc(cadaPessoa.dataNasc)? "SIM" : "NÃO")}
                        // Endereço: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.casa}
                        // Taxa de imposto: {metodoPf.PagarImpostos(cadaPessoa.Rendimento).ToString("C")}
                        // ");
                        //                                 //Data de Nascimento: {metodoPf.ValidarDataNasc(novaPf.dataNasc)}
                        //                                 //Console.WriteLine($"{metodoPf.ValidarDataNasc(new DateTime(1982, 11, 13))}");


                        //                                 Console.WriteLine($"Aperte 'ENTER' para continuar");
                        //                                 Console.ReadLine();
                        //                             }
                        //                         }
                        //                         else
                        //                         {
                        //                             Console.WriteLine($"Lista Vazia");
                        //                             Thread.Sleep(3000);

                        //                         }


                        using (StreamReader str = new StreamReader("Jullys.txt"))
                        {
                            string? linha;
                            while ((linha = str.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                            }
                        }

                        Console.WriteLine($"Aperte 'ENTER' para continuar");
                        Console.ReadLine();


                        break;

                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida");
                        Thread.Sleep(3000);
                        break;
                }


            } while (opcaoPf != "0");


            break;

        case "2":

            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco endPj = new Endereco();

            novaPj.Nome = "Dynamic";
            novaPj.razaoSocial = "Dynamic Services";
            novaPj.Cnpj = "00.001.002/0001-00";
            novaPj.Rendimento = 330000f;
            endPj.logradouro = "Setor Comercial";
            endPj.numero = 11;
            endPj.complemento = "Conjunto 02";
            endPj.endComercial = true;

            novaPj.endereco = endPj;

            metodoPj.Inserir(novaPj);

            List<PessoaJuridica> listaPj = metodoPj.LerArquivo();

            foreach (PessoaJuridica cadaPj in listaPj)
            {
                Console.Clear();
                Console.WriteLine(@$"
Nome: {cadaPj.Nome}
Razão Social: {cadaPj.razaoSocial}
CNPJ: {cadaPj.Cnpj}
");


                Console.WriteLine($"Aperte 'ENTER' para continuar");
                Console.ReadLine();

            }

            //             Console.Clear();
            //             Console.WriteLine(@$"
            // Nome: {novaPj.Nome}
            // Razão Social: {novaPj.razaoSocial}
            // CPF: {novaPj.Cnpj}
            // Rendimento: {novaPj.Rendimento.ToString("C")}
            // Endereço: {novaPj.endereco.logradouro}, {novaPj.endereco.numero}
            // CNPJ Válido: {metodoPj.ValidarCnpj(novaPj.Cnpj)}
            // Taxa de imposto: {metodoPj.PagarImpostos(novaPj.Rendimento).ToString("C")}
            // ");

            //             Console.WriteLine($"Aperte 'ENTER' para continuar");
            //             Console.ReadLine();

            break;

        case "0":

            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema");

            BarraCarregamento("Finalizando", 500);

            break;

        default:

            Console.Clear();
            Console.WriteLine($"Opção inválida");
            Thread.Sleep(3000);

            break;
    }

} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{

    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Black;

    Console.Write(texto);

    for (var i = 0; i < 6; i++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);
    }

    Console.ResetColor();
}


// Console.WriteLine(novaPf.Nome);
//Console.WriteLine($"Nome: {novaPf.Nome} Rendimento: {novaPf.Rendimento}"); //Interpolação
//Console.WriteLine("Nome: " + novaPf.Nome + " Rendimento: " + novaPf.Rendimento); //Concatenação




// Console.WriteLine(metodoPj.ValidarCnpj("00.000.000/0001-00"));
