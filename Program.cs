using System;

namespace AlgoritmoUMOV.Program;

public class Program{
    public static void Main(string[] args)
    {
        string Username;
        string Password;
        const string CorrectUsername = "perrito";
        const string CorrectPassword = "azul1";
        int Tries = 3;

        while(Tries > 0)
            {
                //Menu Principal
                Console.Clear();
                System.Console.WriteLine("Ingrese los datos de usuario y contraseña. \n");
                System.Console.WriteLine("Usuario: ");
                Username = Console.ReadLine();
                System.Console.WriteLine("Contraseña: ");
                Password = Console.ReadLine();
                try
                {
                    if(Username == CorrectUsername && Password == CorrectPassword)
                    {
                        //Autenticar usuario y termina el programa
                        Console.WriteLine($"El usuario: {Username}, fue autenticado con exito.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else if(Tries > 0)
                    {
                        //Quitar un intento
                        Tries--;
                        Console.Clear();
                        System.Console.WriteLine("Datos incorrectos, numero restante de intentos: " + Tries);
                        Console.ReadKey();
                    }
                    if (Tries == 0)
                    {
                        //Todo aqui fallo, NO se pudo autenticar y termina el programa
                        Console.Clear();
                        Console.WriteLine("El usuario NO pudo ser autenticado. Fin del programa.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }
    }
}