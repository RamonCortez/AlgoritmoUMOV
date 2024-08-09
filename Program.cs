using System;

namespace Program
{
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            public string Username { get; set; }
            public string Password { get; set; }
            private const string _correctUsername = perrito;
            private const string _correctPassword = azul1;
            public int Tries = 3;

            while(Tries > 0)
            {
                //Menu Principal
                Console..Clear();
                System.Console.WriteLine("Ingrese los datos de usuario y contraseña. \n");
                System.Console.WriteLine("Usuario: ");
                Username = Console.ReadLine();
                System.Console.WriteLine("Contraseña: ");
                Password = Console.ReadLine();
                try
                {
                    if(Username == _correctUsername && Password == _correctPassword)
                    {
                        //Autenticar usuario y termina el programa
                        Console.WriteLine($"El usuaio: {Username}, fue autenticado con exito.");
                        Environment.Exit(0);
                    }
                    else if(Tries > 0)
                    {
                        //Quitar un intento
                        Tries--;
                        System.Console.WriteLine("Datos incorrectos, numero restante de intentos: " + Tries);
                    }
                    else
                    {
                        //Todo aqui fallo, NO se pudo autenticar y termina el programa
                        Console.WriteLine("El usuario NO pudo ser autenticado.");
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
}