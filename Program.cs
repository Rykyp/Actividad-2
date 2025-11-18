class Program
{
    static void Main(string[] args)
    {
        string? cmd;
        Console.WriteLine("Bienvenido al programa de ejercicios de C#. ACTIVIDAD 3");
        Console.WriteLine("Ricardo Palomares Viseras");
        Console.WriteLine("Daniel Molina Gimenez");
        Menu();
        do
        {
            cmd = Console.ReadLine();
            switch (cmd?.ToLower())
            {
                case "exit":
                    break;
                case "menu":
                    Menu();
                    break;
                default:
                    if (int.TryParse(cmd, out int num))
                    {
                        switch (num)
                        {
                            case 0:
                                Ejercicio0();
                                break;
                            case 1:
                                Ejercicio1();
                                break;
                            case 2:
                                Ejercicio2();
                                break;
                            case 3:
                                Ejercicio3();
                                break;
                            case 4:
                                Ejercicio4();
                                break;
                            case 5:
                                Ejercicio5();
                                break;
                            case 6:
                                Ejercicio6();
                                break;
                            case 7:
                                Ejercicio7();
                                break;
                            case 8:
                                Ejercicio8();
                                break;
                            case 9:
                                Ejercicio9();
                                break;
                            case 10:
                                Ejercicio10();
                                break;
                            default:
                                Console.WriteLine(
                                    "Comando no permitido.\nEscriba un nÚmero del 0 al 10, para ejecutar el ejercicio.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Comando no permitido.");
                        Console.WriteLine("Escriba un nÚmero del 0 al 10 para ejecutar el ejercicio.");
                        Console.WriteLine("Escriba EXIT para salir.");
                        Console.WriteLine("Escriba MENU para mostar el menu principal.");
                    }

                    break;
            }
        } while (cmd?.ToLower() != "exit");
        Console.WriteLine("Gracias por usar el programa.");
    }

    static void Menu()
    {
        Console.WriteLine("======== MENU PRINCIPAL ========");
        Console.WriteLine("0. Hola Mundo!");
        Console.WriteLine("1. Ejercicio 1");
        Console.WriteLine("2. Ejercicio 2");
        Console.WriteLine("3. Ejercicio 3");
        Console.WriteLine("4. Ejercicio 4");
        Console.WriteLine("5. Ejercicio 5");
        Console.WriteLine("6. Ejercicio 6");
        Console.WriteLine("7. Ejercicio 7");
        Console.WriteLine("8. Ejercicio 8");
        Console.WriteLine("9. Ejercicio 9");
        Console.WriteLine("10. Ejercicio 10");
        Console.WriteLine("Escriba EXIT para salir.");
        Console.WriteLine("Escriba MENU para mostrar el menu principal.");
        Console.WriteLine("================================");
    }

    static void Ejercicio0()
    {
        Console.WriteLine("Hola Mundo!");
    }

    static void Ejercicio1()
    {
        //Pedimos al usuario un numero y luego lo muestra en pantalla
        Console.Write("introduce un numero: ");
        string entrada = Console.ReadLine();
        Console.WriteLine("Introdujiste el numero: " + entrada);
    }

    static void Ejercicio2()
    {
        //El usuario intreduce su edad y el programa le dice la edad que tendra en el proximo año
        Console.Write("Introduce tu edad: ");
        var edad = int.Parse(Console.ReadLine());
        Console.WriteLine("El próximo año tendrás " + (edad + 1) + "años.");
    }

    static void Ejercicio3()
    {
        //El usuario introduce el año actual y su año de nacimiento, el programa calcula su edad
        Console.Write("Ingrese el año actual: ");
        int anioActual = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su año de nacimiento: ");
        int anioNacimiento = int.Parse(Console.ReadLine());

        int edad = anioActual - anioNacimiento;
        Console.WriteLine($"Usted tiene {edad} años.");
    }

    static void Ejercicio4()
    {
        //Muestra el valor máximo de un short y el valor siguiente al máximo
        short max = 32767;
        short min = (short)(max + 1);
        Console.WriteLine("Valor máximo de short: " + max);
        Console.WriteLine("Valor siguiente al máximo (max + 1): " + min);
    }

    static void Ejercicio5()
    {
        //Primero te pide que introduzcas el radio de la circunferencia y luego calcula y muestra la longitud y el área de la circunferencia
        Console.Write("introduce el radio de la circunferencia: ");
        double radio = Convert.ToDouble(Console.ReadLine());
        double longitud = 2 * Math.PI * radio;
        double area = Math.PI * Math.Pow(radio, 2);
        Console.WriteLine("la longitud de la circunferencia es: " + longitud);
        Console.WriteLine("el area de la circunferencia es: " + area);
    }

    static void Ejercicio6()
    {
        //Le pedimos al usuario su edad, la comvertimos en entero, comprobamos si el usuario es mayor de edad (+18) y el resultado lo almacenamos en booleano
        Console.Write("Introduce tu edad: ");
        int edad = int.Parse(Console.ReadLine());
        bool es_mayor_de_edad = edad >= 18;
        Console.WriteLine(es_mayor_de_edad);

    }

    static void Ejercicio7()
    {
        //Le pedimos al usuario un entero, si el número ingresado por el es par e imprime true o false
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());
        bool esPar = numero % 2 == 0;
        Console.WriteLine(esPar);
    }

    static void Ejercicio8()
    {
        //Comprobar si el usuario puede salir a la calle segun si llueve, si ha terminado sus tareas o si tiene que ir a la biblioteca, e imprime el resultado.
        Console.Write("¿Esta llobiendo? (true/false): ");
        bool llueve = bool.Parse(Console.ReadLine());

        Console.Write("¿Ha terminado sus tareas? (true/false): ");
        bool tareasTerminadas = bool.Parse(Console.ReadLine());

        Console.Write("¿Necesita ir a la biblioteca? (true/false): ");
        bool irBiblioteca = bool.Parse(Console.ReadLine());

        string puedeSalir = (!llueve && tareasTerminadas) || irBiblioteca ? "Puede salir" : "No puede salir";

        Console.WriteLine(puedeSalir);
    }

    static void Ejercicio9()
    {
        // Calcula y muestrael beneficio total anual de la venta de manzanas y peras segun las ventas de los dos semestres.
        double precioManzana = 2.35;
        double precioPera = 1.95;

        Console.Write("Introduce las ventas (en kg) de manzanas del primer semestre: ");
        double manzanas1 = double.Parse(Console.ReadLine());
        Console.Write("Introduce las ventas (en kg) de peras del primer semestre: ");
        double peras1 = double.Parse(Console.ReadLine());


        Console.Write("Introduce las ventas (en kg) de manzanas del segundo semestre: ");
        double manzanas2 = double.Parse(Console.ReadLine());
        Console.Write("Introduce las ventas (en kg) de peras del segundo semestre: ");
        double peras2 = double.Parse(Console.ReadLine());

        double totalManzanas = (manzanas1 + manzanas2) * precioManzana;
        double totalPeras = (peras1 + peras2) * precioPera;

        double total = totalManzanas + totalPeras;

        Console.WriteLine("Beneficio total por manzanas: " + totalManzanas + " €");
        Console.WriteLine("Beneficio total por peras: " + totalPeras + " €");
        Console.WriteLine("Beneficio total anual: " + total + " €");

    }

    static void Ejercicio10()
    {
        //El usuario introduce un numero y el programa indica si es par o impar en vez de true or false como hizimos en el ejercicio 7
        Console.Write("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());

        string[] resultado = { "Par", "inpar" };
        Console.WriteLine(resultado[numero % 2]);

    }
}