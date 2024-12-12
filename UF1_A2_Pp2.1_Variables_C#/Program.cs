namespace Code_1_prac_1;

class Program
{
    static void Main(string[] args)
    {
        /*Comverteix la entrada de l'usuari en string*/
        int queTriar;
            Console.WriteLine("Exercici a provar? ");
            queTriar = Convert.ToInt32(Console.ReadLine());
            switch (queTriar)
            /*L'usuari pot triar l'exercici que vol*/
            {
                case 1:
                    /*Es demana el nom de l'usuari*/

                    Console.WriteLine("Exercici 1: Nom i edat");
                    Console.WriteLine("Quin és el teu nom?");
                    string nom  = Console.ReadLine();

                    /*Demana i calcula l'edat de l'usuari d'aquí 5 anys i el soble de la seva edat actual*/
                    Console.WriteLine("Quina és la teva edat?");
                    int edat = Convert.ToInt32(Console.ReadLine());
                    int suma_edat = edat + 5;
                    int doble_edat = edat * 2;

                    /*Resposta per pantalla de l'exercici 1*/
                    Console.WriteLine($"{nom} té {edat} anys, d'aquí 5 anys tindrà {suma_edat}");
                    Console.WriteLine("El doble de la seva edat és " + doble_edat);
                    /*Surt de l'exercici*/
                    break;
                    
                case 2:
                    /*Demana la longitud de l'aresta del cub*/

                    Console.WriteLine("Exercici 2: Càlcul de volum");
                    Console.WriteLine("Introdueix la longitus de l'aresta del cub en cm.");
                    
                    /*Converteix a tipus double*/
                    double aresta =Convert.ToDouble(Console.ReadLine());
                    /*Calcula el volum*/
                    double volum = Math.Pow(aresta, 3);
                    /*Resposta per pantalla de l'exercici 2*/
                    Console.WriteLine($"El volum del cub és {volum} cm3");
                    break;

                case 3:

                    /*Demana el valor A per la equació*/
                    Console.WriteLine("Exercici 3: equació de segon grau");
                    Console.WriteLine("Quin valor té A?");
                    double A = Convert.ToDouble(Console.ReadLine());

                    /*Demana quin valor té B i el converteix en double*/
                    Console.WriteLine("Quin valor té B? ");
                    double B = Convert.ToDouble(Console.ReadLine());

                    /*Demana quin valor té C i el converteix en double*/
                    Console.WriteLine("Quin valor té C? ");
                    double C = Convert.ToDouble(Console.ReadLine());

                    /*Càlcul del discriminant i si és positiu tindrà 2 solucions*/
                    double discriminant = B * B - 4 * A * C;
                    if (discriminant > 0)
                    {
                        /*Càlcul de solució 1 i 2*/
                        double x1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
                        double x2 = (-B - Math.Sqrt(discriminant)) / (2 * A);
                        Console.WriteLine($"Les solucions són: x1 = {x1}, x2 = {x2}");
                    }

                    /*Si el discriminant és igual a 0 tindrà solució doble*/
                    else if (discriminant == 0)
                    {
                        /*Càlcul de 1 solució*/
                        double x = -B / (2 * A);
                        Console.WriteLine($"Tenim doble solució: x = {x}");
                    }
                    else
                    {
                        /*Del contrari no hi ha solucions*/
                        Console.WriteLine("No hi ha solucions.");
                    }
                    break;

                /*Els altres exercicis*/
                case 4:
                    Console.WriteLine("Exercici 4");
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

/*Fet per Shaila Martínez - 2nC SMX*/