using System;

namespace UrnaEletronica
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidato candidato = new Candidato();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Urna eletronica criada por Gabriel!");
            Console.WriteLine("--Urna suporta até 10 Candidatos!---");
            Console.WriteLine("-------------------------------------");
            Console.Write("Quantos candidatos terá nessa urna? ");
            var QtnUrna = int.Parse(Console.ReadLine());
            if (QtnUrna >= 11 || QtnUrna <= 1)
            {
                Console.WriteLine("Essa urna só suporta até 10 cadidatos e candidatos acima de 1. :(");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("-------------------------------------");
                Console.Write("Quantos Votos terá nessa Urna? ");
                Int32 VotosNaUrna = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------");
                int contadorNumero = 0;
                int contadorNome = 0;
                int QuantidadeVoto = 0;
                int[] VotosPorPessoa = new int[QtnUrna];
                int[] numeros = new int[QtnUrna];
                string[] nomes = new string[QtnUrna];


                for (int i = 1; i <= QtnUrna; i++)
                {

                    Console.Write("Me informe o numero do " + i + "º candidato: ");
                    candidato.Numero = int.Parse(Console.ReadLine());
                    numeros[contadorNumero] = candidato.Numero;
                    contadorNumero++;
                    Console.Write("Me informe o nome do " + i + "º candidato: ");
                    candidato.Nome = Console.ReadLine();
                    nomes[contadorNome] = candidato.Nome;
                    contadorNome++;
                    Console.WriteLine("Candidato cadastrado.");
                    Console.WriteLine();
                }
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("         Bem vindo a sessão de votos.");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine();
                for (int i = 1; i <= VotosNaUrna; i++)
                {
                    Console.Write("Me informe seu voto: ");
                    Int32 Voto = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Tem certeza?");
                    string resposta = Console.ReadLine();
                    if (resposta == "s" || resposta == "S")
                    {

                        if (QtnUrna <= 0)
                        {
                            Console.WriteLine("Erro!");
                        }
                        else if (QtnUrna == 2)
                        {
                            if (Voto == numeros[0])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[0] = VotosPorPessoa[0] + QuantidadeVoto;
                                QuantidadeVoto = 0;


                            }

                            if (Voto == numeros[1])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[1] = VotosPorPessoa[1] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                        }
                        else if (QtnUrna == 3)
                        {
                            if (Voto == numeros[0])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[0] = VotosPorPessoa[0] + QuantidadeVoto;
                                QuantidadeVoto = 0;

                            }

                            if (Voto == numeros[1])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[1] = VotosPorPessoa[1] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[2])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[2] = VotosPorPessoa[2] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                        }
                        else if (QtnUrna == 4)
                        {
                            if (Voto == numeros[0])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[0] = VotosPorPessoa[0] + QuantidadeVoto;
                                QuantidadeVoto = 0;


                            }

                            if (Voto == numeros[1])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[1] = VotosPorPessoa[1] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[2])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[2] = VotosPorPessoa[2] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[3])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[3] = VotosPorPessoa[3] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                        }
                        else if (QtnUrna == 5)
                        {
                            if (Voto == numeros[0])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[0] = VotosPorPessoa[0] + QuantidadeVoto;
                                QuantidadeVoto = 0;


                            }

                            if (Voto == numeros[1])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[1] = VotosPorPessoa[1] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[2])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[2] = VotosPorPessoa[2] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[3])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[3] = VotosPorPessoa[3] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[4])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[4] = VotosPorPessoa[4] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                        }
                        else if (QtnUrna == 6)
                        {
                            if (Voto == numeros[0])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[0] = VotosPorPessoa[0] + QuantidadeVoto;
                                QuantidadeVoto = 0;


                            }

                            if (Voto == numeros[1])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[1] = VotosPorPessoa[1] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[2])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[2] = VotosPorPessoa[2] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[3])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[3] = VotosPorPessoa[3] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[4])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[4] = VotosPorPessoa[4] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[5])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[5] = VotosPorPessoa[5] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }

                        }
                        else if (QtnUrna == 7)
                        {
                            if (Voto == numeros[0])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[0] = VotosPorPessoa[0] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }

                            if (Voto == numeros[1])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[1] = VotosPorPessoa[1] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[2])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[2] = VotosPorPessoa[2] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[3])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[3] = VotosPorPessoa[3] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[4])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[4] = VotosPorPessoa[4] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[5])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[5] = VotosPorPessoa[5] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[6])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[6] = VotosPorPessoa[6] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }

                        }
                        else if (QtnUrna == 8)
                        {
                            if (Voto == numeros[0])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[0] = VotosPorPessoa[0] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }

                            if (Voto == numeros[1])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[1] = VotosPorPessoa[1] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[2])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[2] = VotosPorPessoa[2] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[3])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[3] = VotosPorPessoa[3] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[4])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[4] = VotosPorPessoa[4] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[5])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[5] = VotosPorPessoa[5] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[6])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[6] = VotosPorPessoa[6] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[7])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[7] = VotosPorPessoa[7] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                        }
                        else if (QtnUrna == 9)
                        {
                            if (Voto == numeros[0])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[0] = VotosPorPessoa[0] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }

                            if (Voto == numeros[1])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[1] = VotosPorPessoa[1] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[2])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[2] = VotosPorPessoa[2] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[3])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[3] = VotosPorPessoa[3] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[4])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[4] = VotosPorPessoa[4] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[5])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[5] = VotosPorPessoa[5] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[6])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[6] = VotosPorPessoa[6] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[7])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[7] = VotosPorPessoa[7] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[8])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[8] = VotosPorPessoa[8] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }

                        }
                        else if (QtnUrna == 10)
                        {
                            if (Voto == numeros[0])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[0] = VotosPorPessoa[0] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }

                            if (Voto == numeros[1])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[1] = VotosPorPessoa[1] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[2])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[2] = VotosPorPessoa[2] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[3])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[3] = VotosPorPessoa[3] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[4])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[4] = VotosPorPessoa[4] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[5])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[5] = VotosPorPessoa[5] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[6])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[6] = VotosPorPessoa[6] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[7])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[7] = VotosPorPessoa[7] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[8])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[8] = VotosPorPessoa[8] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                            if (Voto == numeros[9])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Voto cadastrado.");
                                Console.WriteLine();
                                QuantidadeVoto++;
                                VotosPorPessoa[9] = VotosPorPessoa[9] + QuantidadeVoto;
                                QuantidadeVoto = 0;
                            }
                        }



                    }
                    else
                    {
                        Console.WriteLine("VOTO ABORTADO!!");
                    }


                }
                if (QtnUrna == 2)
                {
                    Console.WriteLine("o Candidato " + nomes[0] + " teve " + VotosPorPessoa[0] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[1] + " teve " + VotosPorPessoa[1] + " Votos.");

                    //Ganhador --
                    Console.WriteLine();
                    if (VotosPorPessoa[0] > VotosPorPessoa[1])
                    {
                        Console.WriteLine("Ganhador: " + nomes[0] + " com " + VotosPorPessoa[0] + " Votos.");
                    }
                    if (VotosPorPessoa[1] > VotosPorPessoa[0])
                    {
                        Console.WriteLine("Ganhador: " + nomes[1] + " com " + VotosPorPessoa[1] + " Votos.");
                    }
                }
                if (QtnUrna == 3)
                {
                    Console.WriteLine("o Candidato " + nomes[0] + " teve " + VotosPorPessoa[0] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[1] + " teve " + VotosPorPessoa[1] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[2] + " teve " + VotosPorPessoa[2] + " Votos.");

                    //Ganhador --
                    Console.WriteLine();
                    if (VotosPorPessoa[0] > VotosPorPessoa[1] && VotosPorPessoa[0] > VotosPorPessoa[2])
                    {
                        Console.WriteLine("Ganhador: " + nomes[0] + " com " + VotosPorPessoa[0] + " Votos.");
                    }
                    if (VotosPorPessoa[1] > VotosPorPessoa[0] && VotosPorPessoa[1] > VotosPorPessoa[2])
                    {
                        Console.WriteLine("Ganhador: " + nomes[1] + " com " + VotosPorPessoa[1] + " Votos.");
                    }
                    if (VotosPorPessoa[2] > VotosPorPessoa[0] && VotosPorPessoa[2] > VotosPorPessoa[1])
                    {
                        Console.WriteLine("Ganhador: " + nomes[2] + " com " + VotosPorPessoa[2] + " Votos.");
                    }
                }
                if (QtnUrna == 4)
                {
                    Console.WriteLine("o Candidato " + nomes[0] + " teve " + VotosPorPessoa[0] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[1] + " teve " + VotosPorPessoa[1] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[2] + " teve " + VotosPorPessoa[2] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[3] + " teve " + VotosPorPessoa[3] + " Votos.");

                    //Ganhador --
                    Console.WriteLine();
                    if (VotosPorPessoa[0] > VotosPorPessoa[1] && VotosPorPessoa[0] > VotosPorPessoa[2] && VotosPorPessoa[0] > VotosPorPessoa[3])
                    {
                        Console.WriteLine("Ganhador: " + nomes[0] + " com " + VotosPorPessoa[0] + " Votos.");
                    }
                    if (VotosPorPessoa[1] > VotosPorPessoa[0] && VotosPorPessoa[1] > VotosPorPessoa[2] && VotosPorPessoa[1] > VotosPorPessoa[3])
                    {
                        Console.WriteLine("Ganhador: " + nomes[1] + " com " + VotosPorPessoa[1] + " Votos.");
                    }
                    if (VotosPorPessoa[2] > VotosPorPessoa[0] && VotosPorPessoa[2] > VotosPorPessoa[1] && VotosPorPessoa[2] > VotosPorPessoa[3])
                    {
                        Console.WriteLine("Ganhador: " + nomes[2] + " com " + VotosPorPessoa[2] + " Votos.");
                    }
                    if (VotosPorPessoa[3] > VotosPorPessoa[0] && VotosPorPessoa[3] > VotosPorPessoa[1] && VotosPorPessoa[3] > VotosPorPessoa[2])
                    {
                        Console.WriteLine("Ganhador: " + nomes[3] + " com " + VotosPorPessoa[3] + " Votos.");
                    }
                }
                if (QtnUrna == 5)
                {
                    Console.WriteLine("o Candidato " + nomes[0] + " teve " + VotosPorPessoa[0] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[1] + " teve " + VotosPorPessoa[1] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[2] + " teve " + VotosPorPessoa[2] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[3] + " teve " + VotosPorPessoa[3] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[4] + " teve " + VotosPorPessoa[4] + " Votos.");

                    //Ganhador --
                    Console.WriteLine();
                    if (VotosPorPessoa[0] > VotosPorPessoa[1] && VotosPorPessoa[0] > VotosPorPessoa[2] && VotosPorPessoa[0] > VotosPorPessoa[3] && VotosPorPessoa[0] > VotosPorPessoa[4])
                    {
                        Console.WriteLine("Ganhador: " + nomes[0] + " com " + VotosPorPessoa[0] + " Votos.");
                    }
                    if (VotosPorPessoa[1] > VotosPorPessoa[0] && VotosPorPessoa[1] > VotosPorPessoa[2] && VotosPorPessoa[1] > VotosPorPessoa[3] && VotosPorPessoa[1] > VotosPorPessoa[4])
                    {
                        Console.WriteLine("Ganhador: " + nomes[1] + " com " + VotosPorPessoa[1] + " Votos.");
                    }
                    if (VotosPorPessoa[2] > VotosPorPessoa[0] && VotosPorPessoa[2] > VotosPorPessoa[1] && VotosPorPessoa[2] > VotosPorPessoa[3] && VotosPorPessoa[2] > VotosPorPessoa[4])
                    {
                        Console.WriteLine("Ganhador: " + nomes[2] + " com " + VotosPorPessoa[2] + " Votos.");
                    }
                    if (VotosPorPessoa[3] > VotosPorPessoa[0] && VotosPorPessoa[3] > VotosPorPessoa[1] && VotosPorPessoa[3] > VotosPorPessoa[2] && VotosPorPessoa[3] > VotosPorPessoa[4])
                    {
                        Console.WriteLine("Ganhador: " + nomes[3] + " com " + VotosPorPessoa[3] + " Votos.");
                    }
                    if (VotosPorPessoa[4] > VotosPorPessoa[0] && VotosPorPessoa[4] > VotosPorPessoa[1] && VotosPorPessoa[4] > VotosPorPessoa[2] && VotosPorPessoa[4] > VotosPorPessoa[3])
                    {
                        Console.WriteLine("Ganhador: " + nomes[4] + " com " + VotosPorPessoa[4] + " Votos.");
                    }
                }
                if (QtnUrna == 6)
                {
                    Console.WriteLine("o Candidato " + nomes[0] + " teve " + VotosPorPessoa[0] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[1] + " teve " + VotosPorPessoa[1] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[2] + " teve " + VotosPorPessoa[2] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[3] + " teve " + VotosPorPessoa[3] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[4] + " teve " + VotosPorPessoa[4] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[5] + " teve " + VotosPorPessoa[5] + " Votos.");

                    //Ganhador --
                    Console.WriteLine();
                    if (VotosPorPessoa[0] > VotosPorPessoa[1] && VotosPorPessoa[0] > VotosPorPessoa[2] && VotosPorPessoa[0] > VotosPorPessoa[3] && VotosPorPessoa[0] > VotosPorPessoa[4] && VotosPorPessoa[0] > VotosPorPessoa[5])
                    {
                        Console.WriteLine("Ganhador: " + nomes[0] + " com " + VotosPorPessoa[0] + " Votos.");
                    }
                    if (VotosPorPessoa[1] > VotosPorPessoa[0] && VotosPorPessoa[1] > VotosPorPessoa[2] && VotosPorPessoa[1] > VotosPorPessoa[3] && VotosPorPessoa[1] > VotosPorPessoa[4] && VotosPorPessoa[1] > VotosPorPessoa[5])
                    {
                        Console.WriteLine("Ganhador: " + nomes[1] + " com " + VotosPorPessoa[1] + " Votos.");
                    }
                    if (VotosPorPessoa[2] > VotosPorPessoa[0] && VotosPorPessoa[2] > VotosPorPessoa[1] && VotosPorPessoa[2] > VotosPorPessoa[3] && VotosPorPessoa[2] > VotosPorPessoa[4] && VotosPorPessoa[2] > VotosPorPessoa[5])
                    {
                        Console.WriteLine("Ganhador: " + nomes[2] + " com " + VotosPorPessoa[2] + " Votos.");
                    }
                    if (VotosPorPessoa[3] > VotosPorPessoa[0] && VotosPorPessoa[3] > VotosPorPessoa[1] && VotosPorPessoa[3] > VotosPorPessoa[2] && VotosPorPessoa[3] > VotosPorPessoa[4] && VotosPorPessoa[3] > VotosPorPessoa[5])
                    {
                        Console.WriteLine("Ganhador: " + nomes[3] + " com " + VotosPorPessoa[3] + " Votos.");
                    }
                    if (VotosPorPessoa[4] > VotosPorPessoa[0] && VotosPorPessoa[4] > VotosPorPessoa[1] && VotosPorPessoa[4] > VotosPorPessoa[2] && VotosPorPessoa[4] > VotosPorPessoa[3] && VotosPorPessoa[4] > VotosPorPessoa[5])
                    {
                        Console.WriteLine("Ganhador: " + nomes[4] + " com " + VotosPorPessoa[4] + " Votos.");
                    }
                    if (VotosPorPessoa[5] > VotosPorPessoa[0] && VotosPorPessoa[5] > VotosPorPessoa[1] && VotosPorPessoa[5] > VotosPorPessoa[2] && VotosPorPessoa[5] > VotosPorPessoa[3] && VotosPorPessoa[5] > VotosPorPessoa[4])
                    {
                        Console.WriteLine("Ganhador: " + nomes[5] + " com " + VotosPorPessoa[5] + " Votos.");
                    }
                }
                if (QtnUrna == 7)
                {
                    Console.WriteLine("o Candidato " + nomes[0] + " teve " + VotosPorPessoa[0] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[1] + " teve " + VotosPorPessoa[1] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[2] + " teve " + VotosPorPessoa[2] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[3] + " teve " + VotosPorPessoa[3] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[4] + " teve " + VotosPorPessoa[4] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[5] + " teve " + VotosPorPessoa[5] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[6] + " teve " + VotosPorPessoa[6] + " Votos.");

                    //Ganhador --
                    Console.WriteLine();
                    if (VotosPorPessoa[0] > VotosPorPessoa[1] && VotosPorPessoa[0] > VotosPorPessoa[2] && VotosPorPessoa[0] > VotosPorPessoa[3] && VotosPorPessoa[0] > VotosPorPessoa[4] && VotosPorPessoa[0] > VotosPorPessoa[5] && VotosPorPessoa[0] > VotosPorPessoa[6])
                    {
                        Console.WriteLine("Ganhador: " + nomes[0] + " com " + VotosPorPessoa[0] + " Votos.");
                    }
                    if (VotosPorPessoa[1] > VotosPorPessoa[0] && VotosPorPessoa[1] > VotosPorPessoa[2] && VotosPorPessoa[1] > VotosPorPessoa[3] && VotosPorPessoa[1] > VotosPorPessoa[4] && VotosPorPessoa[1] > VotosPorPessoa[5] && VotosPorPessoa[1] > VotosPorPessoa[6])
                    {
                        Console.WriteLine("Ganhador: " + nomes[1] + " com " + VotosPorPessoa[1] + " Votos.");
                    }
                    if (VotosPorPessoa[2] > VotosPorPessoa[0] && VotosPorPessoa[2] > VotosPorPessoa[1] && VotosPorPessoa[2] > VotosPorPessoa[3] && VotosPorPessoa[2] > VotosPorPessoa[4] && VotosPorPessoa[2] > VotosPorPessoa[5] && VotosPorPessoa[2] > VotosPorPessoa[6])
                    {
                        Console.WriteLine("Ganhador: " + nomes[2] + " com " + VotosPorPessoa[2] + " Votos.");
                    }
                    if (VotosPorPessoa[3] > VotosPorPessoa[0] && VotosPorPessoa[3] > VotosPorPessoa[1] && VotosPorPessoa[3] > VotosPorPessoa[2] && VotosPorPessoa[3] > VotosPorPessoa[4] && VotosPorPessoa[3] > VotosPorPessoa[5] && VotosPorPessoa[3] > VotosPorPessoa[6])
                    {
                        Console.WriteLine("Ganhador: " + nomes[3] + " com " + VotosPorPessoa[3] + " Votos.");
                    }
                    if (VotosPorPessoa[4] > VotosPorPessoa[0] && VotosPorPessoa[4] > VotosPorPessoa[1] && VotosPorPessoa[4] > VotosPorPessoa[2] && VotosPorPessoa[4] > VotosPorPessoa[3] && VotosPorPessoa[4] > VotosPorPessoa[5] && VotosPorPessoa[4] > VotosPorPessoa[6])
                    {
                        Console.WriteLine("Ganhador: " + nomes[4] + " com " + VotosPorPessoa[4] + " Votos.");
                    }
                    if (VotosPorPessoa[5] > VotosPorPessoa[0] && VotosPorPessoa[5] > VotosPorPessoa[1] && VotosPorPessoa[5] > VotosPorPessoa[2] && VotosPorPessoa[5] > VotosPorPessoa[3] && VotosPorPessoa[5] > VotosPorPessoa[4] && VotosPorPessoa[5] > VotosPorPessoa[6])
                    {
                        Console.WriteLine("Ganhador: " + nomes[5] + " com " + VotosPorPessoa[5] + " Votos.");
                    }
                    if (VotosPorPessoa[6] > VotosPorPessoa[0] && VotosPorPessoa[6] > VotosPorPessoa[1] && VotosPorPessoa[6] > VotosPorPessoa[2] && VotosPorPessoa[6] > VotosPorPessoa[3] && VotosPorPessoa[6] > VotosPorPessoa[4] && VotosPorPessoa[6] > VotosPorPessoa[5])
                    {
                        Console.WriteLine("Ganhador: " + nomes[6] + " com " + VotosPorPessoa[6] + " Votos.");
                    }
                }
                if (QtnUrna == 8)
                {
                    Console.WriteLine("o Candidato " + nomes[0] + " teve " + VotosPorPessoa[0] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[1] + " teve " + VotosPorPessoa[1] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[2] + " teve " + VotosPorPessoa[2] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[3] + " teve " + VotosPorPessoa[3] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[4] + " teve " + VotosPorPessoa[4] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[5] + " teve " + VotosPorPessoa[5] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[6] + " teve " + VotosPorPessoa[6] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[7] + " teve " + VotosPorPessoa[7] + " Votos.");

                    //Ganhador --
                    Console.WriteLine();
                    if (VotosPorPessoa[0] > VotosPorPessoa[1] && VotosPorPessoa[0] > VotosPorPessoa[2] && VotosPorPessoa[0] > VotosPorPessoa[3] && VotosPorPessoa[0] > VotosPorPessoa[4] && VotosPorPessoa[0] > VotosPorPessoa[5] && VotosPorPessoa[0] > VotosPorPessoa[6] && VotosPorPessoa[0] > VotosPorPessoa[7])
                    {
                        Console.WriteLine("Ganhador: " + nomes[0] + " com " + VotosPorPessoa[0] + " Votos.");
                    }
                    if (VotosPorPessoa[1] > VotosPorPessoa[0] && VotosPorPessoa[1] > VotosPorPessoa[2] && VotosPorPessoa[1] > VotosPorPessoa[3] && VotosPorPessoa[1] > VotosPorPessoa[4] && VotosPorPessoa[1] > VotosPorPessoa[5] && VotosPorPessoa[1] > VotosPorPessoa[6] && VotosPorPessoa[1] > VotosPorPessoa[7])
                    {
                        Console.WriteLine("Ganhador: " + nomes[1] + " com " + VotosPorPessoa[1] + " Votos.");
                    }
                    if (VotosPorPessoa[2] > VotosPorPessoa[0] && VotosPorPessoa[2] > VotosPorPessoa[1] && VotosPorPessoa[2] > VotosPorPessoa[3] && VotosPorPessoa[2] > VotosPorPessoa[4] && VotosPorPessoa[2] > VotosPorPessoa[5] && VotosPorPessoa[2] > VotosPorPessoa[6] && VotosPorPessoa[2] > VotosPorPessoa[7])
                    {
                        Console.WriteLine("Ganhador: " + nomes[2] + " com " + VotosPorPessoa[2] + " Votos.");
                    }
                    if (VotosPorPessoa[3] > VotosPorPessoa[0] && VotosPorPessoa[3] > VotosPorPessoa[1] && VotosPorPessoa[3] > VotosPorPessoa[2] && VotosPorPessoa[3] > VotosPorPessoa[4] && VotosPorPessoa[3] > VotosPorPessoa[5] && VotosPorPessoa[3] > VotosPorPessoa[6] && VotosPorPessoa[3] > VotosPorPessoa[7])
                    {
                        Console.WriteLine("Ganhador: " + nomes[3] + " com " + VotosPorPessoa[3] + " Votos.");
                    }
                    if (VotosPorPessoa[4] > VotosPorPessoa[0] && VotosPorPessoa[4] > VotosPorPessoa[1] && VotosPorPessoa[4] > VotosPorPessoa[2] && VotosPorPessoa[4] > VotosPorPessoa[3] && VotosPorPessoa[4] > VotosPorPessoa[5] && VotosPorPessoa[4] > VotosPorPessoa[6] && VotosPorPessoa[4] > VotosPorPessoa[7])
                    {
                        Console.WriteLine("Ganhador: " + nomes[4] + " com " + VotosPorPessoa[4] + " Votos.");
                    }
                    if (VotosPorPessoa[5] > VotosPorPessoa[0] && VotosPorPessoa[5] > VotosPorPessoa[1] && VotosPorPessoa[5] > VotosPorPessoa[2] && VotosPorPessoa[5] > VotosPorPessoa[3] && VotosPorPessoa[5] > VotosPorPessoa[4] && VotosPorPessoa[5] > VotosPorPessoa[6] && VotosPorPessoa[5] > VotosPorPessoa[7])
                    {
                        Console.WriteLine("Ganhador: " + nomes[5] + " com " + VotosPorPessoa[5] + " Votos.");
                    }
                    if (VotosPorPessoa[6] > VotosPorPessoa[0] && VotosPorPessoa[6] > VotosPorPessoa[1] && VotosPorPessoa[6] > VotosPorPessoa[2] && VotosPorPessoa[6] > VotosPorPessoa[3] && VotosPorPessoa[6] > VotosPorPessoa[4] && VotosPorPessoa[6] > VotosPorPessoa[5] && VotosPorPessoa[6] > VotosPorPessoa[7])
                    {
                        Console.WriteLine("Ganhador: " + nomes[6] + " com " + VotosPorPessoa[6] + " Votos.");
                    }
                    if (VotosPorPessoa[7] > VotosPorPessoa[0] && VotosPorPessoa[7] > VotosPorPessoa[1] && VotosPorPessoa[7] > VotosPorPessoa[2] && VotosPorPessoa[7] > VotosPorPessoa[3] && VotosPorPessoa[7] > VotosPorPessoa[4] && VotosPorPessoa[7] > VotosPorPessoa[5] && VotosPorPessoa[7] > VotosPorPessoa[6])
                    {
                        Console.WriteLine("Ganhador: " + nomes[7] + " com " + VotosPorPessoa[7] + " Votos.");
                    }
                }
                if (QtnUrna == 9)
                {
                    Console.WriteLine("o Candidato " + nomes[0] + " teve " + VotosPorPessoa[0] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[1] + " teve " + VotosPorPessoa[1] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[2] + " teve " + VotosPorPessoa[2] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[3] + " teve " + VotosPorPessoa[3] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[4] + " teve " + VotosPorPessoa[4] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[5] + " teve " + VotosPorPessoa[5] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[6] + " teve " + VotosPorPessoa[6] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[7] + " teve " + VotosPorPessoa[7] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[8] + " teve " + VotosPorPessoa[8] + " Votos.");

                    //Ganhador --
                    Console.WriteLine();
                    if (VotosPorPessoa[0] > VotosPorPessoa[1] && VotosPorPessoa[0] > VotosPorPessoa[2] && VotosPorPessoa[0] > VotosPorPessoa[3] && VotosPorPessoa[0] > VotosPorPessoa[4] && VotosPorPessoa[0] > VotosPorPessoa[5] && VotosPorPessoa[0] > VotosPorPessoa[6] && VotosPorPessoa[0] > VotosPorPessoa[7] && VotosPorPessoa[0] > VotosPorPessoa[8])
                    {
                        Console.WriteLine("Ganhador: " + nomes[0] + " com " + VotosPorPessoa[0] + " Votos.");
                    }
                    if (VotosPorPessoa[1] > VotosPorPessoa[0] && VotosPorPessoa[1] > VotosPorPessoa[2] && VotosPorPessoa[1] > VotosPorPessoa[3] && VotosPorPessoa[1] > VotosPorPessoa[4] && VotosPorPessoa[1] > VotosPorPessoa[5] && VotosPorPessoa[1] > VotosPorPessoa[6] && VotosPorPessoa[1] > VotosPorPessoa[7] && VotosPorPessoa[1] > VotosPorPessoa[8])
                    {
                        Console.WriteLine("Ganhador: " + nomes[1] + " com " + VotosPorPessoa[1] + " Votos.");
                    }
                    if (VotosPorPessoa[2] > VotosPorPessoa[0] && VotosPorPessoa[2] > VotosPorPessoa[1] && VotosPorPessoa[2] > VotosPorPessoa[3] && VotosPorPessoa[2] > VotosPorPessoa[4] && VotosPorPessoa[2] > VotosPorPessoa[5] && VotosPorPessoa[2] > VotosPorPessoa[6] && VotosPorPessoa[2] > VotosPorPessoa[7] && VotosPorPessoa[2] > VotosPorPessoa[8])
                    {
                        Console.WriteLine("Ganhador: " + nomes[2] + " com " + VotosPorPessoa[2] + " Votos.");
                    }
                    if (VotosPorPessoa[3] > VotosPorPessoa[0] && VotosPorPessoa[3] > VotosPorPessoa[1] && VotosPorPessoa[3] > VotosPorPessoa[2] && VotosPorPessoa[3] > VotosPorPessoa[4] && VotosPorPessoa[3] > VotosPorPessoa[5] && VotosPorPessoa[3] > VotosPorPessoa[6] && VotosPorPessoa[3] > VotosPorPessoa[7] && VotosPorPessoa[3] > VotosPorPessoa[8])
                    {
                        Console.WriteLine("Ganhador: " + nomes[3] + " com " + VotosPorPessoa[3] + " Votos.");
                    }
                    if (VotosPorPessoa[4] > VotosPorPessoa[0] && VotosPorPessoa[4] > VotosPorPessoa[1] && VotosPorPessoa[4] > VotosPorPessoa[2] && VotosPorPessoa[4] > VotosPorPessoa[3] && VotosPorPessoa[4] > VotosPorPessoa[5] && VotosPorPessoa[4] > VotosPorPessoa[6] && VotosPorPessoa[4] > VotosPorPessoa[7] && VotosPorPessoa[4] > VotosPorPessoa[8])
                    {
                        Console.WriteLine("Ganhador: " + nomes[4] + " com " + VotosPorPessoa[4] + " Votos.");
                    }
                    if (VotosPorPessoa[5] > VotosPorPessoa[0] && VotosPorPessoa[5] > VotosPorPessoa[1] && VotosPorPessoa[5] > VotosPorPessoa[2] && VotosPorPessoa[5] > VotosPorPessoa[3] && VotosPorPessoa[5] > VotosPorPessoa[4] && VotosPorPessoa[5] > VotosPorPessoa[6] && VotosPorPessoa[5] > VotosPorPessoa[7] && VotosPorPessoa[5] > VotosPorPessoa[8])
                    {
                        Console.WriteLine("Ganhador: " + nomes[5] + " com " + VotosPorPessoa[5] + " Votos.");
                    }
                    if (VotosPorPessoa[6] > VotosPorPessoa[0] && VotosPorPessoa[6] > VotosPorPessoa[1] && VotosPorPessoa[6] > VotosPorPessoa[2] && VotosPorPessoa[6] > VotosPorPessoa[3] && VotosPorPessoa[6] > VotosPorPessoa[4] && VotosPorPessoa[6] > VotosPorPessoa[5] && VotosPorPessoa[6] > VotosPorPessoa[7] && VotosPorPessoa[6] > VotosPorPessoa[8])
                    {
                        Console.WriteLine("Ganhador: " + nomes[6] + " com " + VotosPorPessoa[6] + " Votos.");
                    }
                    if (VotosPorPessoa[7] > VotosPorPessoa[0] && VotosPorPessoa[7] > VotosPorPessoa[1] && VotosPorPessoa[7] > VotosPorPessoa[2] && VotosPorPessoa[7] > VotosPorPessoa[3] && VotosPorPessoa[7] > VotosPorPessoa[4] && VotosPorPessoa[7] > VotosPorPessoa[5] && VotosPorPessoa[7] > VotosPorPessoa[6] && VotosPorPessoa[7] > VotosPorPessoa[8])
                    {
                        Console.WriteLine("Ganhador: " + nomes[7] + " com " + VotosPorPessoa[7] + " Votos.");
                    }
                    if (VotosPorPessoa[8] > VotosPorPessoa[0] && VotosPorPessoa[8] > VotosPorPessoa[1] && VotosPorPessoa[8] > VotosPorPessoa[2] && VotosPorPessoa[8] > VotosPorPessoa[3] && VotosPorPessoa[8] > VotosPorPessoa[4] && VotosPorPessoa[8] > VotosPorPessoa[5] && VotosPorPessoa[8] > VotosPorPessoa[6] && VotosPorPessoa[8] > VotosPorPessoa[7])
                    {
                        Console.WriteLine("Ganhador: " + nomes[8] + " com " + VotosPorPessoa[8] + " Votos.");
                    }
                }
                if (QtnUrna == 10)
                {
                    Console.WriteLine("o Candidato " + nomes[0] + " teve " + VotosPorPessoa[0] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[1] + " teve " + VotosPorPessoa[1] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[2] + " teve " + VotosPorPessoa[2] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[3] + " teve " + VotosPorPessoa[3] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[4] + " teve " + VotosPorPessoa[4] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[5] + " teve " + VotosPorPessoa[5] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[6] + " teve " + VotosPorPessoa[6] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[7] + " teve " + VotosPorPessoa[7] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[8] + " teve " + VotosPorPessoa[8] + " Votos.");
                    Console.WriteLine("o Candidato " + nomes[9] + " teve " + VotosPorPessoa[9] + " Votos.");

                    //Ganhador --
                    Console.WriteLine();
                    if (VotosPorPessoa[0] > VotosPorPessoa[1] && VotosPorPessoa[0] > VotosPorPessoa[2] && VotosPorPessoa[0] > VotosPorPessoa[3] && VotosPorPessoa[0] > VotosPorPessoa[4] && VotosPorPessoa[0] > VotosPorPessoa[5] && VotosPorPessoa[0] > VotosPorPessoa[6] && VotosPorPessoa[0] > VotosPorPessoa[7] && VotosPorPessoa[0] > VotosPorPessoa[8] && VotosPorPessoa[0] > VotosPorPessoa[9])
                    {
                        Console.WriteLine("Ganhador: " + nomes[0] + " com " + VotosPorPessoa[0] + " Votos.");
                    }
                    if (VotosPorPessoa[1] > VotosPorPessoa[0] && VotosPorPessoa[1] > VotosPorPessoa[2] && VotosPorPessoa[1] > VotosPorPessoa[3] && VotosPorPessoa[1] > VotosPorPessoa[4] && VotosPorPessoa[1] > VotosPorPessoa[5] && VotosPorPessoa[1] > VotosPorPessoa[6] && VotosPorPessoa[1] > VotosPorPessoa[7] && VotosPorPessoa[1] > VotosPorPessoa[8] && VotosPorPessoa[1] > VotosPorPessoa[9])
                    {
                        Console.WriteLine("Ganhador: " + nomes[1] + " com " + VotosPorPessoa[1] + " Votos.");
                    }
                    if (VotosPorPessoa[2] > VotosPorPessoa[0] && VotosPorPessoa[2] > VotosPorPessoa[1] && VotosPorPessoa[2] > VotosPorPessoa[3] && VotosPorPessoa[2] > VotosPorPessoa[4] && VotosPorPessoa[2] > VotosPorPessoa[5] && VotosPorPessoa[2] > VotosPorPessoa[6] && VotosPorPessoa[2] > VotosPorPessoa[7] && VotosPorPessoa[2] > VotosPorPessoa[8] && VotosPorPessoa[2] > VotosPorPessoa[9])
                    {
                        Console.WriteLine("Ganhador: " + nomes[2] + " com " + VotosPorPessoa[2] + " Votos.");
                    }
                    if (VotosPorPessoa[3] > VotosPorPessoa[0] && VotosPorPessoa[3] > VotosPorPessoa[1] && VotosPorPessoa[3] > VotosPorPessoa[2] && VotosPorPessoa[3] > VotosPorPessoa[4] && VotosPorPessoa[3] > VotosPorPessoa[5] && VotosPorPessoa[3] > VotosPorPessoa[6] && VotosPorPessoa[3] > VotosPorPessoa[7] && VotosPorPessoa[3] > VotosPorPessoa[8] && VotosPorPessoa[3] > VotosPorPessoa[9])
                    {
                        Console.WriteLine("Ganhador: " + nomes[3] + " com " + VotosPorPessoa[3] + " Votos.");
                    }
                    if (VotosPorPessoa[4] > VotosPorPessoa[0] && VotosPorPessoa[4] > VotosPorPessoa[1] && VotosPorPessoa[4] > VotosPorPessoa[2] && VotosPorPessoa[4] > VotosPorPessoa[3] && VotosPorPessoa[4] > VotosPorPessoa[5] && VotosPorPessoa[4] > VotosPorPessoa[6] && VotosPorPessoa[4] > VotosPorPessoa[7] && VotosPorPessoa[4] > VotosPorPessoa[8] && VotosPorPessoa[4] > VotosPorPessoa[9])
                    {
                        Console.WriteLine("Ganhador: " + nomes[4] + " com " + VotosPorPessoa[4] + " Votos.");
                    }
                    if (VotosPorPessoa[5] > VotosPorPessoa[0] && VotosPorPessoa[5] > VotosPorPessoa[1] && VotosPorPessoa[5] > VotosPorPessoa[2] && VotosPorPessoa[5] > VotosPorPessoa[3] && VotosPorPessoa[5] > VotosPorPessoa[4] && VotosPorPessoa[5] > VotosPorPessoa[6] && VotosPorPessoa[5] > VotosPorPessoa[7] && VotosPorPessoa[5] > VotosPorPessoa[8] && VotosPorPessoa[5] > VotosPorPessoa[9])
                    {
                        Console.WriteLine("Ganhador: " + nomes[5] + " com " + VotosPorPessoa[5] + " Votos.");
                    }
                    if (VotosPorPessoa[6] > VotosPorPessoa[0] && VotosPorPessoa[6] > VotosPorPessoa[1] && VotosPorPessoa[6] > VotosPorPessoa[2] && VotosPorPessoa[6] > VotosPorPessoa[3] && VotosPorPessoa[6] > VotosPorPessoa[4] && VotosPorPessoa[6] > VotosPorPessoa[5] && VotosPorPessoa[6] > VotosPorPessoa[7] && VotosPorPessoa[6] > VotosPorPessoa[8] && VotosPorPessoa[6] > VotosPorPessoa[9])
                    {
                        Console.WriteLine("Ganhador: " + nomes[6] + " com " + VotosPorPessoa[6] + " Votos.");
                    }
                    if (VotosPorPessoa[7] > VotosPorPessoa[0] && VotosPorPessoa[7] > VotosPorPessoa[1] && VotosPorPessoa[7] > VotosPorPessoa[2] && VotosPorPessoa[7] > VotosPorPessoa[3] && VotosPorPessoa[7] > VotosPorPessoa[4] && VotosPorPessoa[7] > VotosPorPessoa[5] && VotosPorPessoa[7] > VotosPorPessoa[6] && VotosPorPessoa[7] > VotosPorPessoa[8] && VotosPorPessoa[7] > VotosPorPessoa[9])
                    {
                        Console.WriteLine("Ganhador: " + nomes[7] + " com " + VotosPorPessoa[7] + " Votos.");
                    }
                    if (VotosPorPessoa[8] > VotosPorPessoa[0] && VotosPorPessoa[8] > VotosPorPessoa[1] && VotosPorPessoa[8] > VotosPorPessoa[2] && VotosPorPessoa[8] > VotosPorPessoa[3] && VotosPorPessoa[8] > VotosPorPessoa[4] && VotosPorPessoa[8] > VotosPorPessoa[5] && VotosPorPessoa[8] > VotosPorPessoa[6] && VotosPorPessoa[8] > VotosPorPessoa[7] && VotosPorPessoa[8] > VotosPorPessoa[9])
                    {
                        Console.WriteLine("Ganhador: " + nomes[8] + " com " + VotosPorPessoa[8] + " Votos.");
                    }
                    if (VotosPorPessoa[9] > VotosPorPessoa[0] && VotosPorPessoa[9] > VotosPorPessoa[1] && VotosPorPessoa[9] > VotosPorPessoa[2] && VotosPorPessoa[9] > VotosPorPessoa[3] && VotosPorPessoa[9] > VotosPorPessoa[4] && VotosPorPessoa[9] > VotosPorPessoa[5] && VotosPorPessoa[9] > VotosPorPessoa[6] && VotosPorPessoa[9] > VotosPorPessoa[7] && VotosPorPessoa[9] > VotosPorPessoa[8])
                    {
                        Console.WriteLine("Ganhador: " + nomes[8] + " com " + VotosPorPessoa[8] + " Votos.");
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
