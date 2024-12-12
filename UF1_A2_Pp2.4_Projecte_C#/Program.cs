namespace Pp2._4_SMG;

class Program
{
    static void Main(string[] args)
    {
        decimal saldo = 1000.00m;   // Sado inicial del casino

        while (saldo > 0)   // Bucle: mentre saldo sigui major de 0 podrem jugar al casino
        {
            // Llistat dels jocs
            Console.WriteLine($"Benvingut al Casino! Escull un dels jocs (1-5) que hi ha disponibles i gaudeix! (per sortir escull 6) Recorda que tens {saldo} euros");
            Console.WriteLine("AVÍS! En cap cas és aconsellable apostar en cap joc d’atzar, si no vols apostar hauràs d'indicar '0' a cada pregunta d'apostar.");
            Console.WriteLine("1. Ruleta");
            Console.WriteLine("2. Blackjack");
            Console.WriteLine("3. Carrera de caballs");
            Console.WriteLine("4. Màquina escarabutxaques");
            Console.WriteLine("5. Daus");
            Console.WriteLine("6. Sortir");
            
            int opcio = Convert.ToInt32(Console.ReadLine()); // Llegeix la sel·lecció del jugador
            switch (opcio)  // Executa la llista de les condicions
            {
                case 1: // Ruleta
                Console.WriteLine("Benvingut a la ruleta!");

                int apostat;    // Declara i guarda els diners que s'aposten

                // Bucle per verificar que l'aposta és vàlida i no més que el saldo
                while (true) 
                {
                    Console.Write("Quants diners vols apostar? ");  // Pregunta quants € vol apostar
                    apostat = int.Parse(Console.ReadLine());    // Llegeix la resposta

                    if (apostat > saldo)    // Si l'apostat és major al saldo no podrà apostar
                    {
                        Console.WriteLine("No tens diners suficients per aquesta aposta. Torna a intentar-ho.");
                    }
                    else
                    {
                        break; // Si l'aposta és vàlida, surt del bucle
                    }
                }

                Console.WriteLine("Escull a què vols apostar: un número (0-50) o un color? (escriu 'numero', 'vermell', 'negre' o 'verd')");   // El jugar tria a on vol apostar
                string lloc_aposta = Console.ReadLine().ToLower();

                int numero_resultat = new Random().Next(0, 51); // Generar número aleatori entre 0 i 50
                string color_resultat = (numero_resultat == 0) ? "verd" :
                                        (numero_resultat % 2 == 0) ? "negre" : "roig";

                if (lloc_aposta == "numero")    // Comprova si és un número
                {
                    Console.Write("Escull un número (0-50): "); // El jugador tria un número del 1 al 50
                    int numero_escollit = int.Parse(Console.ReadLine());    // Llegeix el número

                    if (numero_escollit == numero_resultat) // Si el número del jugador és el mateix al número guanyador
                    {
                        int premi = apostat * 2; // Premi per encertar el número
                        saldo += premi; // Es suma el premi al saldo
                        Console.WriteLine($"Has encertat el número i has guanyat {premi} euros!");
                    }
                    else
                    {
                        saldo -= apostat;   // Si no es resta del saldo i perd
                        Console.WriteLine($"Has perdut. El número guanyador era {numero_resultat}.");
                    }
                }
                
                else if (lloc_aposta == "vermell" || lloc_aposta == "negre" || lloc_aposta == "verd")   // Si escull un color
                {
                    if (lloc_aposta == color_resultat)  // Comprova que el color que aposta és igual al guanyador
                    {
                        int premi = lloc_aposta == "verd" ? apostat * 14 : apostat * 2;
                        saldo += premi; // Es suma el premi al saldo
                        Console.WriteLine($"El color guanyador és {color_resultat}. Has guanyat {premi} euros!");   // Resposta per pantalla del color guanyador
                    }
                    else
                    {
                        saldo -= apostat;   // Si no ho encerta, perd i es treu del saldo el que ha apostat
                        Console.WriteLine($"El color guanyador és {color_resultat}. Has perdut {apostat} euros.");  // Surt per pantalla
                    }
                }
                
                else    // Si no escull a on apostar no serà vàlid
                {
                    Console.WriteLine("Aquesta resposta no és vàlida.");
                }

                Console.WriteLine($"Ara tens {saldo} euros.");  // Mostra els diners després de la ruleta
                break;  // Surt


                case 2: // Blackjack
                Console.Write("Benvingut al joc de BlackJack, quan vols apostar? ");
                int apostat2 = int.Parse(Console.ReadLine());   // Variable per apostar

                saldo -= apostat2;  // Resta l'aposta del saldo
                Random random = new Random();   // Puntuació aleatòria
                int pts_jugador = random.Next(12, 21);  // Genera puntuació aleatòria entre 12 i 20
                int pts_oponent = random.Next(16, 22);  // Genera puntuació aleatòria entre 16 i 22

                Console.WriteLine($"La teva puntuació: {pts_jugador}"); // Indica per pantalla la puntuació de jugador
                Console.Write("Vols una altra carta? (s/n): "); // Pregunta si el jugador vol una carta més
                if (Console.ReadLine().ToLower() == "s")    // Si escriu "s" o "S":
                    pts_jugador += random.Next(1, 11);  // Es sumen els punts del jugador més punts aleatoris entre 1 i 11

                Console.WriteLine($"Puntuació del casino: {pts_oponent}");  // Mostra per pantalla la puntuació de la màquina (casino)

                if ((pts_jugador > pts_oponent && pts_jugador <= 21) || pts_oponent > 21)   // Calcula si ha guanyat
                {
                    saldo += apostat2 * 2;  // Es suma el doble del que s'ha apostat al saldo
                    Console.WriteLine("Has guanyat!");
                }
                else    // Si no ha perdut
                {
                    Console.WriteLine("Has perdut.");
                }

                if (apostat2 > saldo)   // Si el que ha apostat és inferior al saldo no tindrà prous diners per apostar.
                {
                    Console.WriteLine("No tens diners suficients per apostar.");
                }

                Console.WriteLine($"Tens {saldo} euros.");  // Surt per pantalla el saldo que té actualment el jugador.
                break;  // Surt


                case 3: // Carrera de cavalls
                Console.WriteLine("Benvingut a la carrera de caballs, quant vols apostar?");
                int apostat3 = int.Parse(Console.ReadLine());   // Variable per apostar al joc 3

                Console.WriteLine("Tria un cavall del 1 al 5:");    // Li preguntem al jugador quin cavall vol triar
                int cavall = int.Parse(Console.ReadLine()); // Llegeix la resposta

                int cavall_guanya = new Random().Next(1, 6);    // El cavall guanyador serà un aleatòri dels 6 cavalls 
                Console.WriteLine($"El cavall que ha guanyat la carrera és el {cavall_guanya}.");   // Mostra el cavall que ha guanyat

                if (cavall == cavall_guanya)    // Si el cavall escollit és el que guanya:
                {
                    saldo += apostat3 * 2;  // Es suma el doble del que s'ha apostat al saldo
                }
                else    // Si per es resta del saldo
                {
                    saldo -= apostat3;
                }
                Console.WriteLine($"Tens {saldo} euros.");  // Mostra el saldo actual

                if (apostat3 > saldo)   // Si l'apostat és major al saldo no tindrà diners per apostar.
                {
                    Console.WriteLine("No tens diners suficients per apostar.");
                    break;
                }
                break;  // Surt


                case 4: // Màquina escarabutxaques
                Console.WriteLine("Benvingut a la màquina escarabutxaques! Quant vols apostar?");
                int apostat4 = int.Parse(Console.ReadLine());   // Llegeix per apostar

                Console.WriteLine("Pressiona qualsevol tecla per tirar de la palanca i fer girar els elements..."); // El jugador pressiona una tecla
                Console.ReadKey();  // La màquina la llegeix

                string[] icona = { "| estrella |", "| plàtan |", "| diamant |", "| cirera |", "| taronja |", "| campana |", "| raïm |", "| cor |", "| 7 |"};    // Es crea un array d'icones
                Random random4 = new Random();  // Gererar aleatòriament
                string element1 = icona[random4.Next(icona.Length)];    // Element aleatòri de l'array per la posició 1
                string element2 = icona[random4.Next(icona.Length)];    // Element aleatòri de l'array per la posició 2
                string element3 = icona[random4.Next(icona.Length)];    // Element aleatòri de l'array per la posició 3

                Console.WriteLine($"El resultat aleatori és {element1} {element2} {element3}"); // Resultat per pantalla

                if (element1 == element2 && element2 == element3)   // Si tots 3 elements són els mateixos guanya
                {
                    int premi_escarabutxaques = apostat4 * 2;  // El premi és el doble delque ha apostat
                    saldo += premi_escarabutxaques; //  Es suma al saldo el premi que s'ha guanyat
                    Console.WriteLine($"Has guanyat, tots els elements són iguals! Ara tens {saldo} euros");
                }
                
                else
                {
                    saldo -= apostat4; // Si perd es resta del saldo
                    Console.WriteLine($"Has perdut, tots els elements no són iguals! Ara tens {saldo} euros");
                }
                break;  // Surt


                case 5: // Daus
                Console.WriteLine("Benvingut al joc dels daus!");
                Console.Write("Quant vols apostar? ");
                int apostat5 = int.Parse(Console.ReadLine());   // Llegeix per apostar

                if (apostat5 > saldo)   // Si l'apostat és major que el saldo no tindrà diners per apostar
                {
                    Console.WriteLine("No tens diners suficients per apostar.");
                    break;
                }

                // Explicació del joc i el jugador tria un número del 2 al 12
                Console.Write("En aquest joc hauràs de llençar 2 daus, la suma dels números de cada dau ha de donar el mateix nombre que escullis. Tria un número entre 2 i 12 (la suma dels dos daus): ");
                int num_triat = int.Parse(Console.ReadLine());  // Llegeix la resposta i ho declara en variable

                if (num_triat < 2 || num_triat > 12)    // Comprova que està entre els rangs
                {
                    Console.WriteLine("El número no és vàlid. Ha de ser entre 2 i 12.");    // Si no no serà vàlid
                    break;
                }

                Random rand_daus = new Random();    // Genera aleatòriament
                int dau1 = rand_daus.Next(1, 7);    // Generar un número aleatori entre 1 i 6
                int dau2 = rand_daus.Next(1, 7);    // Generar un altre número aleatori entre 1 i 6
                int daus_suma = dau1 + dau2;    // Calcula la suma dels dos daus

                Console.WriteLine($"Has tirat els daus: {dau1} i {dau2}. La suma és {daus_suma}."); // Resposta per pantalla

                if (daus_suma == num_triat) // Si la suma dels daus coincideix amb el número triat pel jugador guanya
                {
                    saldo += apostat5; // Guanya i es suma el que s'ha apostat al saldo
                    Console.WriteLine($"Has guanyat, els diners que tens són {saldo} euros.");
                }
                else
                {
                    saldo -= apostat5; // Si no perd l'aposta i es resta del saldo
                    Console.WriteLine($"Has perdut, la els diners que tens són {saldo} euros.");
                }
                break;


                case 6: // Surt del casino
                Console.WriteLine($"Has sortit del casino amb {saldo} euros, fins la propera!");
                return; // Retorna la resposta al jugador
            }
        }
    }
}