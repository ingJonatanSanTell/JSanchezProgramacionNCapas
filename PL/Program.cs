using System;

namespace PL // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\n ---------- COLOCA UNA OPCION DEL MENU ---------- \n\nOPCION (1): MOSTRAR CON GETALL \n\nOPCION (2): MOSTRAR CON GETBYID \n\nOPCION (3): INSERTAR \n\nOPCION (4): ACTUALIZAR \n\nOPCION (5): ELIMINAR \n\nOPCION (6): MOSTRAR CON GETALL Y SP \n\nOPCION (7): MOSTRAR CON GETBYID Y SP \n\nOPCION (8): AGREGAR CON ADD Y SP \n\nOPCION (9): ACTUALIZAR CON UPDATE Y SP \n\nOPCION (10): ELIMINAR CON DELETE Y SP \n\nOPCION (11): SALIR \n------------------------------------------");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        PL.Usuario.GetAll();
                        break;

                    case 2:
                        PL.Usuario.GetById();
                        break;

                    case 3:
                        PL.Usuario.Add();
                        break;

                    case 4:
                        PL.Usuario.Update();
                        break;

                    case 5:
                        PL.Usuario.Delete();
                        break;

                    case 6:
                        PL.Usuario.GetAllSP();
                        break;

                    case 7:
                        PL.Usuario.GetByIdSP();
                        break;

                    case 8:
                        PL.Usuario.AddSP();
                        break;

                    case 9:
                        PL.Usuario.UpdateSP();
                        break;

                    case 10:
                        PL.Usuario.DeleteSP();
                        break;

                    case 11:
                        Environment.Exit(0);
                        break;
                }
            } while (opcion != 11);
            Console.ReadKey();
        }
    }
}
