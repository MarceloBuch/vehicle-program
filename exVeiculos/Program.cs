using System;

namespace exVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ccar = 300;
            const int ccami = 200;
            Carro[] Car = new Carro[ccar];
            Caminhao[] Cami = new Caminhao[ccami];
            int contadorCarro = 0;
            int contadorCaminhao = 0;
            int options = 0;
            String esc = null;
            String pla = null;
            String model = null;
            String marc = null;
            String conCor = null;
            do
            {
                options = menu();
                switch (options)
                {
                    case 1: Car[contadorCarro++]=cadastrarCarro(); break;
                    case 2: Cami[contadorCaminhao++]=cadastrarCaminhao(); break;
                    case 3: consultarPlaca(Car, Cami, pla, contadorCarro, contadorCaminhao, esc); break;
                    case 4: consultarModeloMarca(Cami, model, marc, contadorCaminhao); break;
                    case 5: consultarCor(Car, conCor,contadorCarro); break;
                    case 6: exibirCarro(Car,contadorCarro); break;
                    case 7: exibirCaminhao(Cami,contadorCaminhao); break;
                    case 0: break;
                    default: Console.WriteLine("Opção inválida!"); break;
                }
                Console.ReadKey();
            } while (options != 0);
            static int menu()
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar Carro");
                Console.WriteLine("2 - Cadastrar Caminhão");
                Console.WriteLine("3 - Consulta por placa");
                Console.WriteLine("4 - Consulta por modelo/marca");
                Console.WriteLine("5 - Consulta de carro por cor");
                Console.WriteLine("6 - Exibir todos os carros cadastrados");
                Console.WriteLine("7 - Exibir todos os caminhões cadastrados");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite algo para continuar: ");
                return int.Parse(Console.ReadLine());
            }
            static Carro cadastrarCarro()
            {
                Console.Clear();
                Console.Write("Digite o modelo do carro: "); String mode = Console.ReadLine();
                Console.Write("Digite o fabricante do carro: "); String fab = Console.ReadLine();
                Console.Write("Digite o ano do carro: "); int an = int.Parse(Console.ReadLine());
                Console.Write("Digite a cor do carro: "); String co = Console.ReadLine();
                Console.Write("Digite a quantidade de portas do carro: "); int np = int.Parse(Console.ReadLine());
                Console.Write("Digite a placa do carro: "); String pla = Console.ReadLine();
                Console.Write("Digite a capacidade do porta malas(em litros): "); int cpm = int.Parse(Console.ReadLine());
                Console.Write("Digite se o carro tem ou não bagageiro: "); String bga = Console.ReadLine();
                bool statusbga;
                if (bga == "sim" || bga == "Sim")
                {
                    statusbga = true;
                }
                else
                {
                    statusbga = false;
                }
                Console.Write("Digite se o carro tem ou não correia dentada: "); String corr = Console.ReadLine();
                bool statuscorr;
                if (corr == "sim" || corr == "Sim")
                {
                    statuscorr = true;
                }
                else 
                {
                    statuscorr = false;
                }
                Console.WriteLine("\nSeu veículo foi cadastrado! Tecle enter para ir ao menu principal!");
                return new Carro(mode, fab, an, co, np, pla, cpm, statusbga, statuscorr);
            }

            static Caminhao cadastrarCaminhao()
            {
                Console.Clear();
                Console.Write("Digite o modelo do caminhão: "); String mod = Console.ReadLine();
                Console.Write("Digite o fabricante do caminhão: "); String fabri = Console.ReadLine();
                Console.Write("Digite o ano do caminhão: "); int ano = int.Parse(Console.ReadLine());
                Console.Write("Digite a cor do caminhão: "); String cor = Console.ReadLine();
                Console.Write("Digite a quantidade de portas do caminhão: "); int np = int.Parse(Console.ReadLine());
                Console.Write("Digite a placa do caminhão: "); String pla = Console.ReadLine();
                Console.Write("Digite quantos eixos tem o caminhão: "); int ne = int.Parse(Console.ReadLine());
                Console.Write("Digite o peso maxímo de carga do caminhão: "); double pmc = double.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de alavancas de câmbio tem o caminhão: "); int nac = int.Parse(Console.ReadLine());
                Console.Write("\nSeu veículo foi cadastrado! Tecle enter para ir ao menu principal!");
                return new Caminhao(mod, fabri, ano, cor, np, pla, ne, pmc, nac);
            }
            static void exibirCarro(Carro[] Car, int contadorCarro)
            {
                Console.Clear();
                for (int i = 0; i < contadorCarro; i++)
                    Console.WriteLine(Car[i].CarroCadastrados());
            }
            static void exibirCaminhao(Caminhao[] Cami, int contadorCaminhao)
            {
                Console.Clear();
                for(int x = 0; x < contadorCaminhao; x++)
                    Console.WriteLine(Cami[x].CaminhaoCadastrados());
            }

            static void consultarPlaca(Carro[] Car,Caminhao[] Cami, String pla,int contadorCarro,int contadorCaminhao, String esc)
            {
                Console.Clear();
                Console.Write("Qual tipo de veículo será procurado?(Carro ou caminhão): ");
                esc = Console.ReadLine();
                if (esc == "carro")
                {
                    Console.Clear();
                    Console.Write("Digite o número da placa que ser procurado: ");
                    pla = Console.ReadLine();
                    for (int y = 0; y < contadorCarro; y++)
                    {
                        if ((Car[y].placa).Equals(pla))
                        {
                            Console.Write("O carro é: \n\n" + Car[y].CarroCadastrados()+"\n\n") ;
                            Console.WriteLine("Veículo encontrado! Tecle enter para voltar ao menu principal!");
                            break;
                        }
                        else 
                        {
                            Console.Write("Essa placa não está cadastrada!\n\n");
                            Console.WriteLine("Tecle enter para voltar ao menu principal!");
                            break;
                        }
                    }
                }else if (esc == "caminhao" || esc=="caminhão")
                {
                    Console.Clear();
                    Console.Write("Digite o número da placa que ser procurado: ");
                    pla = Console.ReadLine();
                    for (int y = 0; y < contadorCaminhao; y++)
                    {
                        if ((Cami[y].placa).Equals(pla))
                        {
                            Console.Write("O caminhão é: \n\n" + Cami[y].CaminhaoCadastrados()+"\n\n");
                            Console.WriteLine("Veículo encontrado! Tecle enter para voltar ao menu principal: ");
                            break;
                        }
                        else
                        {
                            Console.Write("Essa placa não está cadastrada!\n\n");
                            Console.WriteLine("Tecle enter para voltar ao menu principal!");
                            break;
                        }
                    }
                }
            }

            static void consultarModeloMarca(Caminhao[] Cami, String model, String marc, int contadorCaminhao)
            {
                Console.Clear();
                Console.Write("Digite a marca do caminhão: ");
                marc = Console.ReadLine();
                Console.Write("Digite o modelo do caminhão: ");
                model = Console.ReadLine();
                for (int w=0;w<contadorCaminhao;w++)
                {
                    if(((Cami[w].modelo).Equals(model)) && ((Cami[w].fabricante).Equals(marc)))
                    {
                        Console.WriteLine(Cami[w].CaminhaoCadastrados()+"\n\n");
                        Console.WriteLine("Tecle enter para voltar ao menu principal!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Esse caminhão não foi cadastrado!\n\n");
                        Console.WriteLine("Tecle enter para voltar ao menu principal!");
                        break;
                    }
                }
            }
            
            static void consultarCor(Carro[] Car, String conCor, int contadorCarro)
            {
                Console.Clear();
                Console.Write("Digite a cor que quer ser buscada: ");
                conCor = Console.ReadLine();
                for(int z=0; z < contadorCarro; z++)
                {
                    if ((Car[z].cor).Equals(conCor))
                    {
                        Console.WriteLine(Car[z].CarroCadastrados()+"\n\n");
                        Console.WriteLine("Tecle enter para voltar ao menu principal!");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum carro foi cadastrado com essa cor!\n\n");
                        Console.WriteLine("Tecle enter para voltar ao menu principal!");
                    }
                }
            }
        }
    }
}
