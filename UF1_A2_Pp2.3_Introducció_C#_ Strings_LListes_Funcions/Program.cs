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
                    Random random = new Random();   // Números aleatoris
                    int[] numeros = new int[55];    // Llista per guardar els 55 números

                    /* Genera 55 números aleatoris */
                    for (int i = 0; i < numeros.Length; i++)    // Pasa per cada posició del número
                    {
                        numeros[i] = random.Next(2, 1559);  // Genera un número entre 2 i 1559
                    }

                    // Gestió del valor més petit i més gran
                    int valor_min = numeros.Min(); // Busca el valor més petit
                    int valor_max = numeros.Max(); // Busca el valor més gran

                    Console.WriteLine("El valor més petit és: " + valor_min);   // Mostra per pantalla el valor més petit
                    Console.WriteLine("El valor més gran és: " + valor_max);    // Mostra per pantalla el valor més gran

                    break;  // Sortim de l'exercici
                    
                case 2:
                    Console.WriteLine("Exercici 2");
                    Random random_ex2 = new Random();   // Genera números aleatoris, li he posar "random_ex2" ja que sinó agafava la variable de l'exercici 1 i amb "num" també
                    int[] nums = new int[333];  // Guarda 333 números a dins de la llista

                    /* Genera 333 números aleatoris */
                    for (int i = 0; i < nums.Length; i++)   // Pasa per cada posició del múmero
                        nums[i] = random_ex2.Next(1, 800);

                    /* Càlcul de la mitjana */
                    double mitjana = nums.Average();    // Fa la mitjana del número
                    Console.WriteLine("La mitjana és: " + mitjana); // Mostra per pantalla la mitjana

                    /* Comptar múltiples de 4 i 11 */
                    int multiples_4 = nums.Count(n => n % 4 == 0);
                    int multiples_11 = nums.Count(n => n % 11 == 0);

                    /* Mostra per pantalla els múltiples de 4 i 11 */
                    Console.WriteLine("Múltiples de 4: " + multiples_4);
                    Console.WriteLine("Múltiples de 11: " + multiples_11);
                    break;

                case 3:
                    Console.WriteLine("Exercici 3");
                    Console.WriteLine("Escriu una frase");  // Li diem a l'usuari que introdueixi una frase
                    string? frase = Console.ReadLine();
                    if (frase == null)  // És perquè no doni error de valor null a frase i que a l'inici no s'assigni cap valor
                    {
                        frase = "";
                    }

                    /* Definim cadascuna de les vocals i amb valor 0 al principi */
                    int vocal_a = 0;
                    int vocal_e = 0;
                    int vocal_i = 0;
                    int vocal_o = 0;
                    int vocal_u = 0;

                    /* Executa cada caràcter de la frase que ha escrit l'usuari */
                    foreach (char caracter in frase)
                    {
                        if (caracter == 'a') vocal_a++; // Si és a, es suma 1 a la vocal
                        if (caracter == 'e') vocal_e++; // Si és e, es suma 1 a la vocal
                        if (caracter == 'i') vocal_i++; // Si és i, es suma 1 a la vocal
                        if (caracter == 'o') vocal_o++; // Si és o, es suma 1 a la vocal
                        if (caracter == 'u') vocal_u++; // Si és u, es suma 1 a la vocal
                    }

                    /* La resposta per pantalla les vocals i la quantitat que n'hi ha a la frase */
                    Console.WriteLine($"Nombre de vocals: a: {vocal_a}, e: {vocal_e}, i: {vocal_i}, o: {vocal_o}, u: {vocal_u}");
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
                            saldo = TreureSaldo(saldo, import_treure);
                        }

                        else if (opcio == "2")  // Dipòsit
                        {
                            Console.Write("Introdueix l'import a dipositar: ");
                            decimal import_dipositar = Convert.ToDecimal(Console.ReadLine());
                            saldo = AfegirSaldo(saldo, import_dipositar);
                        }

                        else if (opcio == "3")  // Consultar saldo
                        {
                            MirarSaldo(saldo);
                        }

                        else    // Si tria una opció de les que no estan sortirà aquest missatge d'error
                        {
                            Console.WriteLine("Error: introdueix una opció vàlida.");
                        }
                        break;
                    }
                    
                    /* Funció treure saldo */
                    static decimal TreureSaldo(decimal saldo, decimal import_treure)    // static decimal retorna valor
                    {
                        if (import_treure <= saldo) // Si l'import a treure és menor o igual al saldo disponible
                        {
                            saldo -= import_treure; // Si es possible traiem els diners del saldo
                            Console.WriteLine($"Has tret {import_treure}€. El saldo actual és de: {saldo}€.");
                        }
                        
                        else // Si l'import és més gran que el saldo disponible, es mostra el missatge d'error.
                        {
                            Console.WriteLine("Error: No pots treure més del saldo que n'hi ha.");
                        }
                        return saldo; // Retorna el saldo actualitzat
                    }

                    /* Funció mirar el saldo */
                    static void MirarSaldo(decimal saldo)   // static void no retorna valor
                    {
                        Console.WriteLine($"El teu saldo actual és {saldo}€."); // Dona informació del saldo actual que té l'usuari
                    }

                    /* Funció afegir saldo */
                    static decimal AfegirSaldo(decimal saldo, decimal import_dipositar)
                    {
                        saldo += import_dipositar;  // L'import que es deposita es suma amb el saldo
                        Console.WriteLine($"Has dipositat {import_dipositar}€. Saldo actual: {saldo}€.");
                        return saldo; // Retorna el saldo actualitzat
                    }
                    break;

                case 5:
                    Console.WriteLine("Exercici 5");
                    break;

                case 6:
                    Console.WriteLine("Exercici 6");
                    break;
            }
    }
}

// Fet per Shaila Martínez - 2nC SMX