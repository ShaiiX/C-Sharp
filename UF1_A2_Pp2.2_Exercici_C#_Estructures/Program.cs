namespace Code_1_prac_1;

class Program
{
    static void Main(string[] args)
    {
        /* Converteix la entrada de l'usuari en string */
        int queTriar;
            Console.WriteLine("Exercici a provar? ");
            queTriar = Convert.ToInt32(Console.ReadLine());
            switch (queTriar)
            /* L'usuari pot triar l'exercici que vol */
            {
                case 1:
                    Console.WriteLine("Exercici 1");
                    Console.Write("Introdueix un número: ");
                    int numero = Convert.ToInt32(Console.ReadLine());   // Demana que l'usuari introdueixi un número
                    int suma = 0;

                    /* Estructura de repetició for per sumar els números des de 13 fins al número */
                    for (int i = 13; i <= numero; i++)
                    {
                        suma += i; // Afegim el valor de i a la suma
                    }

                    /* El que sortirà per pantalla serà el número escollit i la seva suma */
                    Console.WriteLine($"La suma dels números enters des de 13 fins a {numero} és: {suma}");
                    break;  // Sortim de l'exercici
                    
                case 2:
                    Console.WriteLine("Exercici 2");
                    Console.Write("Introdueix un número: ");    // Demanar un número a l'usuari
                    /* S'introdueixen les variables */
                    int nombre = Convert.ToInt32(Console.ReadLine());   // Pasar de valor a nombre enter
                    int parells = 0;
                    int imparells = 0;
                    int parells_suma = 0;
                    int imparells_suma = 0;
                    int multiples13 = 0;

                    for (int i = 1; i <= nombre; i++)   // Del 1 fins al nombre
                    {
                        /* Comprova si és parell i si ho és fa la suma */
                        if (i % 2 == 0)
                        {
                            parells ++;
                            parells_suma += i;
                        }

                        /* Si no és parell ho compte com imparell i fa la suma */
                        else
                        {
                            imparells++;
                            imparells_suma += i;
                        }

                        /* Compriva els que siguin múltiples de 13 */
                        if (i % 13 == 0)
                        {
                            multiples13 ++;
                        }
                    }
                        /* Resultats per pantalla del tipus de cada nombre */
                        Console.WriteLine($"Números parells: {parells}");
                        Console.WriteLine($"Números imparells: {imparells}");
                        Console.WriteLine($"Suma de números parells: {parells_suma}");
                        Console.WriteLine($"Suma de números imparells: {imparells_suma}");
                        Console.WriteLine($"Múltiples de 13: {multiples13}");
                    break;

                case 3:
                    Console.WriteLine("Exercici 3");
                    Random random = new Random();   // Aleatori

                    /* Al jugador 1 genera un número aleatori del 0 al 2 inclosos */
                    int jugador1 = random.Next(0, 3);
                    int jugador2 = random.Next(0, 3);
                    
                    string[] tirada = { "Pedra", "Paper", "Tisora" };   // A la llista de tirades hi ha pedra, paper i tisora

                    /* Per pantalla mostra la tirada de cada jugador */
                    Console.WriteLine($"Jugador 1 juga: {tirada[jugador1]}");
                    Console.WriteLine($"Jugador 2 juga: {tirada[jugador2]}");

                    /* Si els dos jugador tiren el mateix serà un empat */
                    if (jugador1 == jugador2)
                        Console.WriteLine("Empat! No hi ha guanyador.");

                    else
                    {
                        /* Condicions del joc */
                        if (jugador1 == 0)  // Si el Jugador 1 tira pedra
                        {
                            if (jugador2 == 2)  // Jugador 2 tira tisora
                                Console.WriteLine("Jugador 1 guanya!"); // Jugador 1 guanya
                            else
                                Console.WriteLine("Jugador 2 guanya!"); // Jugador 2 guanya perquè serà pedra
                        }

                        else if (jugador1 == 1) // Si el Jugador 1 tira paper
                        {
                            if (jugador2 == 0) // Jugador 2 tira pedra
                                Console.WriteLine("Jugador 1 guanya!"); // Jugador 1 guanya
                            else
                                Console.WriteLine("Jugador 2 guanya!"); // Jugador 2 guanya perquè serà tisora
                        }

                        else // Si el Jugador 1 tira tisora
                        {
                            if (jugador2 == 1) // Jugador 2 tira paper
                                Console.WriteLine("Jugador 1 guanya!"); // Jugador 1 guanya
                            else
                                Console.WriteLine("Jugador 2 guanya!"); // Jugador 2 guanya perquè serà pedra
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("Exercici 4");
                    decimal saldo = 1000.00m; // Saldo amb el que es comença

                    while (true)
                    {
                        /* Definim les opcions que es poden realitzar al caixer */
                        Console.WriteLine("1. Treure efectiu");
                        Console.WriteLine("2. Dipòsit");
                        Console.WriteLine("3. Consultar saldo");
                        Console.Write("Tria una opció: ");
                        string? opcio = Console.ReadLine();

                        if (opcio == "1")   // Treure efectiu
                        {
                            Console.Write("Introdueix l'import a treure: ");
                            decimal import_treure = Convert.ToDecimal(Console.ReadLine());

                            if (import_treure <= saldo) // Si l'import a treure és menor o igual al saldo disponible
                            {
                                saldo -= import_treure; // Si es posible traiem els diners del saldo
                                Console.WriteLine($"Has tret {import_treure}€. El saldo actual és de: {saldo}€.");
                            }
                            else // Si l'import és més gran que el saldo disponible, es mostra el missatge d'error.
                            {
                                Console.WriteLine("Error: No pots treure més del saldo que n'hi ha.");
                            }
                        }

                        else if (opcio == "2")  // Dipòsit
                        {
                            Console.Write("Introdueix l'import a dipositar: ");
                            decimal import_dipositar = Convert.ToDecimal(Console.ReadLine());   // Es converteix en decimal
                            saldo += import_dipositar;  // L'import que es deposita es suma amb el saldo
                            Console.WriteLine($"Has dipositat {import_dipositar}€. Saldo actual: {saldo}€.");
                        }

                        else if (opcio == "3")  // Consultar saldo
                        {
                            Console.WriteLine($"El teu saldo actual és {saldo}€."); // Dona informació del saldo actual que té l'usuari
                        }
                        
                        else    // Si tria una opció de les que no estan sortirà aquest missatge d'error
                        {
                            Console.WriteLine("Error: introdueix una opció vàlida.");
                        }
                        break;
                    }
                    break;

                case 5:
                    Console.WriteLine("Exercici 5");

                    Console.WriteLine("Introdueix l'edat del client: ");    // Edat del client
                    int edat = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Introdueix els ingressos mensuals del client");  // Ingressos mensuals del client
                    decimal ingressos = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("El client té alguna referència de lloguer anterior positiva? "); // Referència del client
                    string? referencia = Console.ReadLine().Trim().ToLower();

                    Console.WriteLine("Introdueix el nombre d'infraccions de trànsit greu registrades en els últims 5 anys: "); // Infraccions de l'usuari
                    int infraccions = Convert.ToInt32(Console.ReadLine());

                    /* Comprovar les dades introduides anteriorment */
                    bool llogar_si = true;

                    if (edat < 22)  // Si l'edat és menor de 22 anys no podrà llogar, si és major si
                    {
                        Console.WriteLine("Error: Ha de ser major de 21 anys.");
                        llogar_si = false;  // No pot llogar
                    }
                    else if (edat > 64) // Si l'edat és major de 64 anys no podrà llogar però si és menor si
                    {
                        Console.WriteLine("Error: Ha de ser menor de 65 anys.");
                        llogar_si = false;  // No pot llogar
                    }

                    if (ingressos < 2500)   // Si els ingressos són menys de 2500€ el client no podrà llogar
                    {
                        Console.WriteLine("No pot llogar: ingressos insuficients");
                        llogar_si = false;
                    }

                    if (referencia != "si") // Si el client té una referència positiva pot llogar
                    {
                        Console.WriteLine("No pot llogar: no té referència de lloguer positiva.");
                        llogar_si = false;
                    }

                    if (infraccions > 1)    // Si ha fet més de 1 infracció no pot llogar
                    {
                        Console.WriteLine("No pot llogar: més d'una infracció de trànsit greus.");
                        llogar_si = false;
                    }

                    if (llogar_si)  // Si pot llogar sortirà aquest missatge
                    {
                        Console.WriteLine("El client pot llogar un apartament.");
                    }
                    else    // Sinó no pot llogar
                    {
                        Console.WriteLine("El client no pot llogar un apartament.");
                    }
                break;

                case 6:
                    Console.WriteLine("Exercici 6");
                    break;
            }
    }
}

/* Tasca feta per Shaila Martínez */