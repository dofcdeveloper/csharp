using System;
using System.Collections.Generic;

namespace UserRequestApp
{
    class Program
    {
        private static List<string> userRequests;

        static void Main(string[] args)
        {
            // Inicializar la lista de solicitudes de usuarios
            userRequests = new List<string>();

            while (true)
            {
                Console.WriteLine("Ingrese una solicitud de usuario (o escriba 'salir' para terminar):");
                string request = Console.ReadLine();

                if (request.ToLower() == "salir")
                {
                    break;
                }

                // Agregar la solicitud a la lista
                userRequests.Add(request);
            }

            Console.WriteLine("Solicitudes de usuarios ingresadas:");
            foreach (string request in userRequests)
            {
                Console.WriteLine(request);
            }
        }
    }
}
