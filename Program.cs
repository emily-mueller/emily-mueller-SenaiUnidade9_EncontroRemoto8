using EncontroRemoto8.Classes;

Console.Clear();
Console.WriteLine(@$"
===============================================
|      Bem vindo ao sistema de cadastro de    | 
|        Pessoas Físicas e Jurídicas          | 
===============================================
");


Utils.BarraCarregamento("Iniciando", 100, 10);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
===============================================
|        Escolha uma das opções abaixo        |
|                                             |
|        1 - Pessoa Física                    |
|        2 - Pessoa Jurídica                  |
|                                             | 
|        0 - Sair                             |
===============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
===============================================
|        Escolha uma das opções abaixo        |
|                                             |
|        1 - Cadastrar Pessoa Física          |
|        2 - Listar Pessoas Físicas           |
|                                             | 
|        0 - Voltar ao Menu anterior          |
===============================================
");


                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();


                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                        novaPf.Nome = Console.ReadLine();

                        bool dataValida;
                        // do
                        // {
                        //     Console.WriteLine($"Digite a data de nascimento Ex: DD/MM/AAAA");
                        //     string? dataNascimento = Console.ReadLine();

                        //     dataValida = metodosPf.ValidarDataNasc(dataNascimento);

                        //     if (dataValida)
                        //     {
                        //         DateTime DataConvertida;
                        //         DateTime.TryParse(dataNascimento, out DataConvertida);
                        //         novaPf.dataNasc = DataConvertida;
                        //     }
                        //     else
                        //     {
                        //         Console.ForegroundColor = ConsoleColor.DarkRed;
                        //         Console.WriteLine($"Data digitada inválida, por favor digite uma data válida");
                        //         Console.ResetColor();
                        //         Thread.Sleep(3000);
                        //     }

                        // } while (dataValida == false);

                        // Console.WriteLine($"Digite o numero do CPF");
                        // novaPf.Cpf = Console.ReadLine();

                        // Console.WriteLine($"Digite o rendimento mensal (DIGITE SOMENTE NÚMEROS)");
                        // novaPf.Rendimento = float.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o logradouro");
                        // novoEndPf.logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o número");
                        // novoEndPf.numero = int.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio)");
                        // novoEndPf.complemento = Console.ReadLine();

                        // Console.WriteLine($"Este endereço é comercial? S/N");
                        // string endCom = Console.ReadLine().ToUpper();

                        // if (endCom == "S")
                        // {
                        //     novoEndPf.endComercial = true;
                        // }
                        // else
                        // {
                        //     novoEndPf.endComercial = false;
                        // }

                        // novaPf.Endereco = novoEndPf;

                        // listaPf.Add(novaPf);

                        // StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt");
                        // sw.WriteLine(novaPf.Nome);
                        // sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt"))
                        {
                            sw.WriteLine(novaPf.Nome); 
                        }

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Console.ResetColor();
                        Thread.Sleep(3000);


                        break;

                    case "2":

                        Console.Clear();

//                         if (listaPf.Count > 0)
//                         {
//                             foreach (PessoaFisica cadaPessoa in listaPf)
//                             {
//                                 Console.Clear();
//                                 Console.WriteLine(@$"
// Nome: {cadaPessoa.Nome}
// Endereço : {cadaPessoa.Endereco.logradouro}, {cadaPessoa.Endereco.numero}
// Imposto a ser pago: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C")} 
// ");

//                                 Console.WriteLine("Aperte ENTER para continuar");
//                                 Console.ReadLine();
//                             }
//                         }
//                         else
                        // {
                        //     Console.WriteLine($"Lista vazia");
                        //     Thread.Sleep(3000);
                        // }

                        using (StreamReader sr = new StreamReader("Emily.txt"))
                        {
                            string linha;
                            while ((linha = sr.ReadLine()) !=null)
                            {
                                Console.WriteLine($"{linha}");
                            }
                        }

                        Console.WriteLine("Aperte ENTER para continuar");
                        Console.ReadLine();

                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }


            } while (opcaoPf != "0");

            break;
            //    PessoaFisica novaPf = new PessoaFisica();
            //   PessoaFisica metodosPf = new PessoaFisica();
            //    Endereco novoEndPf = new Endereco();

            //    novaPf.Nome = "Odirlei";
            //    novaPf.dataNasc = new DateTime(2000, 01, 01);
            //    novaPf.Cpf = "1234567890";
            //    novaPf.Rendimento = 3500.5f;

            //    novoEndPf.logradouro = "Alameda barao de limeira";
            //    novoEndPf.numero = 539;
            //    novoEndPf.complemento = "SENAI Informatica";
            //    novoEndPf.endComercial = true;

            //    novaPf.Endereco = novoEndPf;

            //    Console.Clear();
            //    Console.WriteLine(@$"
            //Nome: {novaPf.Nome}
            //Endereço : {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
            //Maior de idade: {(metodosPf.ValidarDataNasc(novaPf.dataNasc) ? "Sim" : "Não")}
            //Imposto a ser pago: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C")} 
            //");
            // if ternário? ele existe para facilitar a escrita no código, se queremos que o retorno é "sim" ou "não"
            //exemplo: condicao ? "Sim" : Não"

            // .ToString("C") transforma o valor em reais e deixa com duas casa decimais ao mostrar o resultado

            //Console.WriteLine(metodosPf.ValidarDataNasc("01/01/2000"));

            //novaPf.ValidarDataNasc(novaPf.dataNasc);

            //Console.WriteLine(novaPf.Nome);

            //Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");
            //Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome);
            //Com concatenação, é mais difícil a construção


        case "2":

            string? opcaoPj;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
===============================================
|        Escolha uma das opções abaixo        |
|                                             |
|        1 - Cadastrar Pessoa Jurídica        |
|        2 - Listar Pessoas Jurídica          |
|                                             | 
|        0 - Voltar ao Menu anterior          |
===============================================
");


            opcaoPj = Console.ReadLine();
            PessoaJuridica metodosPj = new PessoaJuridica();


            switch (opcaoPj)
            {
                case "1":
                    PessoaJuridica novaPj = new PessoaJuridica();
                    Endereco novoEndPj = new Endereco();

                    Console.WriteLine($"Digite o nome da pessoa jurídica que deseja cadastrar");
                    novaPj.Nome = Console.ReadLine();

                    Console.WriteLine($"Digite o nome da razão social que deseja cadastrar");
                    novaPj.RazaoSocial = Console.ReadLine();

                    bool cnpjValido;
                    do
                    {

                            Console.WriteLine($"Digite o numero do Cnpj");
                            string? CnpjValido = Console.ReadLine();

                            cnpjValido = metodosPj.ValidarCnpj(CnpjValido);

                            if (cnpjValido)
                            {

                                novaPj.Cnpj = CnpjValido;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Cnpj digitado inválido, por favor digite um Cnpj válido");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                            }
                    } while (cnpjValido == false);              

                    Console.WriteLine($"Digite o rendimento mensal (DIGITE SOMENTE NÚMEROS)");
                    novaPj.Rendimento = float.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o logradouro");
                    novoEndPj.logradouro = Console.ReadLine();

                    Console.WriteLine($"Digite o número");
                    novoEndPj.numero = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio)");
                    novoEndPj.complemento = Console.ReadLine();

                    Console.WriteLine($"Este endereço é comercial? S/N");
                    string endCom = Console.ReadLine().ToUpper();

                    if (endCom == "S")
                    {
                        novoEndPj.endComercial = true;
                    }
                    else
                    {
                        novoEndPj.endComercial = false;
                    }


                    novaPj.Endereco = novoEndPj;

                    listaPj.Add(novaPj);

                    metodosPj.Inserir(novaPj);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Cadastro realizado com sucesso");
                    Console.ResetColor();
                    Thread.Sleep(3000);
                        
                    break;

                case "2":

                    List<PessoaJuridica> ListaPj = metodosPj.LerArquivo();

                    foreach (PessoaJuridica cadaItem in ListaPj)
                    {
                        Console.Clear();
                        Console.WriteLine(@$"
Nome: {cadaItem.Nome}
Razão Social: {cadaItem.RazaoSocial}
");                
                        Console.WriteLine("Aperte ENTER para continuar");
                        Console.ReadLine();        
                    }
                        
                        Console.Clear();

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica cadaPessoa in listaPj)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
Nome: {cadaPessoa.Nome}
Razão Social: {cadaPessoa.RazaoSocial}
Endereço : {cadaPessoa.Endereco.logradouro}, {cadaPessoa.Endereco.numero}
Imposto a ser pago: {metodosPj.PagarImposto(cadaPessoa.Rendimento).ToString("C")} 
");

                                Console.WriteLine("Aperte ENTER para continuar");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia");
                            Thread.Sleep(3000);
                        }

                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }


            } while (opcaoPj != "0");


            
            break;
            
            

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema");
            Thread.Sleep(3000);

            Utils.BarraCarregamento("Finalizando", 500, 6);

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");



//PessoaFisica novaPf = new PessoaFisica();
//PessoaFisica metodosPf = new PessoaFisica();
//Endereco novoEndPf = new Endereco();

//novaPf.Nome = "Odirlei";
//novaPf.dataNasc = new DateTime (2000, 01, 01);
//novaPf.Cpf = "1234567890";
//novaPf.Rendimento = 3500.5f;

//novoEndPf.logradouro = "Alameda barao de limeira";
//novoEndPf.numero = 539;
//novoEndPf.complemento = "SENAI Informatica";
//novoEndPf.endComercial = true;

//novaPf.Endereco = novoEndPf;

//Console.WriteLine(@$"
//Nome: {novaPf.Nome}
//Endereço : {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
//Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}
//");

//Console.WriteLine(metodosPf.ValidarDataNasc("01/01/2000"));

//novaPf.ValidarDataNasc(novaPf.dataNasc);

//Console.WriteLine(novaPf.Nome);

//Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");
//Console.WriteLine("Nome: " + novaPf.Nome + " Nome: " + novaPf.Nome); //Com concatenação, é mais difícil a construção

//PessoaJuridica novaPj = new PessoaJuridica();
//PessoaJuridica metodosPj = new PessoaJuridica();
//Endereco novoEndPj = new Endereco();

//novaPj.Nome = "SENAI INFORMATICA LDTA";
//novaPj.RazaoSocial = "Razão Social PJ";
//novaPj.Cnpj = "48282715000100";
//novaPj.Rendimento = 10000.5f;

//novoEndPj.logradouro = "Alameda barao de limeira";
//novoEndPj.numero = 539;
//novoEndPj.complemento = "SENAI Informatica";
//novoEndPj.endComercial = true;

//novaPj.Endereco = novoEndPj;

//Console.WriteLine(@$"
//Nome: {novaPj.Nome}
//Razão Social : {novaPj.RazaoSocial}
//Cnpj : {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
//Endereço : {novaPj.Endereco.logradouro}, {novaPj.Endereco.numero}
//Complemento : {novaPj.Endereco.complemento}
//");




