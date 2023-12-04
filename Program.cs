Console.WriteLine("Reto 4: Votaciones de la CONFECH");
int Eleccion = 0;
while (Eleccion != 2)
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("Menu");
        Console.WriteLine("");
        Console.WriteLine("1. Votaciones de la CONFECH");
        Console.WriteLine("2. Salir");
        Console.WriteLine("");
        Console.Write("Ingrese opcion que desea revisar: ");
        Eleccion = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (Eleccion)
        {   
            case 1:
                Console.WriteLine("Votaciones de la CONFECH");
                Console.WriteLine("");
                Console.Write("Ingrese el número de universidades: ");
                int NumUniversidades = int.Parse(Console.ReadLine());
                Console.Clear();
                string[] Universidades = new string[NumUniversidades];
                string[] VotosUni = new string[NumUniversidades];
                int SumUniR = 0;
                int SumUniA = 0;
                int SumUniE = 0;
                for (int i = 0; i < NumUniversidades; i++)
                {
                    Console.Write("Ingrese el nombre de la universidad " + (i + 1) + " : ");
                    Universidades[i] = Console.ReadLine().ToUpper();
                    string[] Votos = new string[100];
                    int[] Sumas = new int[100];
                    var Voto = "P";
                    int j = 0;
                    while (Voto != "X")
                    {
                        Console.Write("Ingrese el voto del estudiante: ");
                        Voto = Console.ReadLine().ToUpper();
                        switch (Voto)
                        {
                            case "A":
                                Votos[j] = "A";
                                j++;
                                break;
                            case "R":
                                Votos[j] = "R";
                                j++;
                                break;
                            case "N":
                                Votos[j] = "N";
                                j++;
                                break;
                            case "B":
                                Votos[j] = "B";
                                j++;
                                break;
                            case "X":
                                VotosUni[i] = string.Join("", Votos);
                                break;
                            default:
                                Console.WriteLine("Ingrese una opcion valida");
                                Console.Write("Presione enter para continuar");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }
                    }
                    Console.Clear();
                }

                Console.WriteLine("Numero de universidades: " + NumUniversidades);
                for (int i = 0; i < NumUniversidades; i++)
                {
                    int SumA = 0;
                    int SumR = 0;
                    int SumN = 0;
                    int SumB = 0;

                    Console.WriteLine("");
                    Console.WriteLine("Universidad: " + Universidades[i]);
                    for (int j = 0; j < VotosUni[i].Length; j++)
                    {
                        Console.WriteLine("Voto: " + VotosUni[i][j]);
                        switch (VotosUni[i][j].ToString())
                        {
                            case "A":
                                SumA++;
                                break;
                            case "R":
                                SumR++;
                                break;
                            case "N":
                                SumN++;
                                break;
                            case "B":
                                SumB++;
                                break;
                            default:
                                break;
                        }
                        
                    }
                    Console.WriteLine(Universidades[i] + ": " + SumA + " aceptan, " + SumR + " rechazan, " + SumB + " blanco, " + SumN + " nulo.");
                    if (SumA == SumR)
                    {
                        SumUniE++;
                    } else if (SumA > SumR)
                    {
                        SumUniA++;
                    } else 
                    {
                        SumUniR++;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Universidades que aceptan: " + SumUniA);
                Console.WriteLine("Universidades que rechazan: " + SumUniR);
                Console.WriteLine("Universidades que empatan: " + SumUniE);

                Console.WriteLine("");
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
            case 2:
                Console.WriteLine("Lo esperamos pronto");
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
            default:
                break;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Valor incorrecto, ingrese un valor valido");
        Console.Write("Presione enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }
}