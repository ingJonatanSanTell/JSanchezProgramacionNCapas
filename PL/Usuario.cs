using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        //INSERTAR
        static public void Add()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("INGRESA LOS DATOS DEL USUARIO");
            Console.WriteLine("COLCA SU NOMBRE DE USUARIO");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("COLCA SU NOMBRE");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("COLCA SU APELLIDO PATERNO");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("COLCA SU APELLIDO MATERNO");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("COLCA SU EMAIL");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("COLCA SU CONTRASEÑA");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("COLCA SU FECHA DE NACIMIENTO");
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("COLCA SU SEXO");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("COLCA SU TELEFONO");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("COLCA SU CELULAR");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("COLCA SU CURP");
            usuario.CURP = Console.ReadLine();


            ML.Result result = BL.Usuario.Add(usuario);

            if (result.Correct)
            {
                Console.WriteLine("SE INSERTO CORRECTAMENTE");
            }
            else
            {
                Console.WriteLine("OCURRIO UN ERROR AL INSERTAR EL USUARIO \n" + result.ErrorMessage);
            }
            Console.ReadLine();
        }

        //ACTUALIZAR
        static public void Update()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("INGRESA LOS DATOS A ACTUALIZAR");
            Console.WriteLine("COLOCA EL ID DEL USUARIO A MODIFICAR");
            usuario.IdUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("COLCA SU NOMBRE DE USUARIO");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("COLCA SU NOMBRE");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("COLCA SU APELLIDO PATERNO");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("COLCA SU APELLIDO MATERNO");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("COLCA SU EMAIL");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("COLCA SU CONTRASEÑA");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("COLCA SU FECHA DE NACIMIENTO");
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("COLCA SU SEXO");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("COLCA SU TELEFONO");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("COLCA SU CELULAR");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("COLCA SU CURP");
            usuario.CURP = Console.ReadLine();
            //Console.WriteLine("COLCA UNA IMAGEN");
            //usuario.Imagen = Byte.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.Update(usuario);

            if (result.Correct)
            {
                Console.WriteLine("SE ACTUALIZO CORRECTAMENTE");
            }
            else
            {
                Console.WriteLine("OCURRIO UN ERROR AL ACTUALIZAR EL USUARIO \n" + result.ErrorMessage);
            }
            Console.ReadLine();

        }

        //ELIMINAR
        static public void Delete()
        {

            Console.WriteLine("COLOCA EL ID DEL USUARIO A ELIMINAR");
            int IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.Delete(IdUsuario);

            if (result.Correct)
            {
                Console.WriteLine("SE ELIMINO CORRECTAMENTE");
            }
            else
            {
                Console.WriteLine("OCURRIO UN ERROR AL ELIMINAR EL USUARIO \n" + result.ErrorMessage);
            }
            Console.ReadLine();

        }

        //MOSTRAR GETALL
        static public void GetAll()
        {
            ML.Result result = BL.Usuario.GetAll();
            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
            {
                Console.WriteLine("EL ID DEL USUARIO ES: " + usuario.IdUsuario);
                Console.WriteLine("EL USERNAME DEL USUARIO ES: " + usuario.UserName);
                Console.WriteLine("EL NOMBRE DEL USUARIO ES: " + usuario.Nombre);
                Console.WriteLine("EL APELLIDO PATERNO DEL USUARIO ES: " + usuario.ApellidoPaterno);
                Console.WriteLine("EL APELLIDO MATERNO DEL USUARIO ES: " + usuario.ApellidoMaterno);
                Console.WriteLine("LA CONTRASEÑA DEL USUARIO ES: " + usuario.Password);
                Console.WriteLine("LA FECHA DE NACIMIENTO DEL USUARIO ES: " + usuario.FechaNacimiento);
                Console.WriteLine("EL SEXO DEL USUARIO ES: " + usuario.Sexo);
                Console.WriteLine("EL TELEFONO DEL USUARIO ES: " + usuario.Telefono);
                Console.WriteLine("EL CELULAR DEL USUARIO ES: " + usuario.Celular);
                Console.WriteLine("LA CURP DEL USUARIO ES: " + usuario.CURP);
                Console.WriteLine("----------------------------------------------------------------------------------");

            }
            }
            else
            {
                Console.WriteLine("OCURRIO UN ERROR " + result.ErrorMessage);
            }
        }

        //MOSTRAR CON GETBYID
        static public void GetById()
        {
            Console.WriteLine("COLOCA EL ID DEL USUARIO A VISUALIZAR");
            int IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.GetById(IdUsuario);

            if (result.Correct)
            {
                ML.Usuario usuario = (ML.Usuario)result.Object; //unboxing

                Console.WriteLine("EL ID DEL USUARIO ES: " + usuario.IdUsuario);
                Console.WriteLine("EL USERNAME DEL USUARIO ES: " + usuario.UserName);
                Console.WriteLine("EL NOMBRE DEL USUARIO ES: " + usuario.Nombre);
                Console.WriteLine("EL APELLIDO PATERNO DEL USUARIO ES: " + usuario.ApellidoPaterno);
                Console.WriteLine("EL APELLIDO MATERNO DEL USUARIO ES: " + usuario.ApellidoMaterno);
                Console.WriteLine("LA CONTRASEÑA DEL USUARIO ES: " + usuario.Password);
                Console.WriteLine("LA FECHA DE NACIMIENTO DEL USUARIO ES: " + usuario.FechaNacimiento);
                Console.WriteLine("EL SEXO DEL USUARIO ES: " + usuario.Sexo);
                Console.WriteLine("EL TELEFONO DEL USUARIO ES: " + usuario.Telefono);
                Console.WriteLine("EL CELULAR DEL USUARIO ES: " + usuario.Celular);
                Console.WriteLine("LA CURP DEL USUARIO ES: " + usuario.CURP);

            }
            else
            {
                Console.WriteLine("OCURRIO UN ERROR " + result.ErrorMessage);
            }
        }


        //MOSTRAR CON GETALL Y SP
        static public void GetAllSP()
        {
            ML.Result result = BL.Usuario.GetAllSP();
            if (result.Correct)
            {
                foreach (ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("EL ID DEL USUARIO ES: " + usuario.IdUsuario);
                    Console.WriteLine("EL USERNAME DEL USUARIO ES: " + usuario.UserName);
                    Console.WriteLine("EL NOMBRE DEL USUARIO ES: " + usuario.Nombre);
                    Console.WriteLine("EL APELLIDO PATERNO DEL USUARIO ES: " + usuario.ApellidoPaterno);
                    Console.WriteLine("EL APELLIDO MATERNO DEL USUARIO ES: " + usuario.ApellidoMaterno);
                    Console.WriteLine("LA CONTRASEÑA DEL USUARIO ES: " + usuario.Password);
                    Console.WriteLine("LA FECHA DE NACIMIENTO DEL USUARIO ES: " + usuario.FechaNacimiento);
                    Console.WriteLine("EL SEXO DEL USUARIO ES: " + usuario.Sexo);
                    Console.WriteLine("EL TELEFONO DEL USUARIO ES: " + usuario.Telefono);
                    Console.WriteLine("EL CELULAR DEL USUARIO ES: " + usuario.Celular);
                    Console.WriteLine("LA CURP DEL USUARIO ES: " + usuario.CURP);
                    Console.WriteLine("----------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine("OCURRIO UN ERROR " + result.ErrorMessage);
            }
        }

        //MOSTRAR CON GETBYID Y SP
        static public void GetByIdSP()
        {
            Console.WriteLine("COLOCA EL ID DEL USUARIO A VISUALIZAR");
            int IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.GetByIdSP(IdUsuario);

            if (result.Correct)
            {
                ML.Usuario usuario = (ML.Usuario)result.Object; //unboxing

                Console.WriteLine("EL ID DEL USUARIO ES: " + usuario.IdUsuario);
                Console.WriteLine("EL USERNAME DEL USUARIO ES: " + usuario.UserName);
                Console.WriteLine("EL NOMBRE DEL USUARIO ES: " + usuario.Nombre);
                Console.WriteLine("EL APELLIDO PATERNO DEL USUARIO ES: " + usuario.ApellidoPaterno);
                Console.WriteLine("EL APELLIDO MATERNO DEL USUARIO ES: " + usuario.ApellidoMaterno);
                Console.WriteLine("LA CONTRASEÑA DEL USUARIO ES: " + usuario.Password);
                Console.WriteLine("LA FECHA DE NACIMIENTO DEL USUARIO ES: " + usuario.FechaNacimiento);
                Console.WriteLine("EL SEXO DEL USUARIO ES: " + usuario.Sexo);
                Console.WriteLine("EL TELEFONO DEL USUARIO ES: " + usuario.Telefono);
                Console.WriteLine("EL CELULAR DEL USUARIO ES: " + usuario.Celular);
                Console.WriteLine("LA CURP DEL USUARIO ES: " + usuario.CURP);

            }
            else
            {
                Console.WriteLine("OCURRIO UN ERROR " + result.ErrorMessage);
            }
        }

        //INSERTAR CON SP
        static public void AddSP()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("INGRESA LOS DATOS DEL USUARIO");
            Console.WriteLine("COLCA SU NOMBRE DE USUARIO");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("COLCA SU NOMBRE");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("COLCA SU APELLIDO PATERNO");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("COLCA SU APELLIDO MATERNO");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("COLCA SU EMAIL");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("COLCA SU CONTRASEÑA");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("COLCA SU FECHA DE NACIMIENTO");
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("COLCA SU SEXO");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("COLCA SU TELEFONO");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("COLCA SU CELULAR");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("COLCA SU CURP");
            usuario.CURP = Console.ReadLine();


            ML.Result result = BL.Usuario.Add(usuario);

            if (result.Correct)
            {
                Console.WriteLine("SE INSERTO CORRECTAMENTE");
            }
            else
            {
                Console.WriteLine("OCURRIO UN ERROR AL INSERTAR EL USUARIO \n" + result.ErrorMessage);
            }
            Console.ReadLine();
        }

        //ACTUALIZAR CON SP
        static public void UpdateSP()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("INGRESA LOS DATOS A ACTUALIZAR");
            Console.WriteLine("COLOCA EL ID DEL USUARIO A MODIFICAR");
            usuario.IdUsuario = int.Parse(Console.ReadLine());
            Console.WriteLine("COLCA SU NOMBRE DE USUARIO");
            usuario.UserName = Console.ReadLine();
            Console.WriteLine("COLCA SU NOMBRE");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("COLCA SU APELLIDO PATERNO");
            usuario.ApellidoPaterno = Console.ReadLine();
            Console.WriteLine("COLCA SU APELLIDO MATERNO");
            usuario.ApellidoMaterno = Console.ReadLine();
            Console.WriteLine("COLCA SU EMAIL");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("COLCA SU CONTRASEÑA");
            usuario.Password = Console.ReadLine();
            Console.WriteLine("COLCA SU FECHA DE NACIMIENTO");
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("COLCA SU SEXO");
            usuario.Sexo = Console.ReadLine();
            Console.WriteLine("COLCA SU TELEFONO");
            usuario.Telefono = Console.ReadLine();
            Console.WriteLine("COLCA SU CELULAR");
            usuario.Celular = Console.ReadLine();
            Console.WriteLine("COLCA SU CURP");
            usuario.CURP = Console.ReadLine();
            //Console.WriteLine("COLCA UNA IMAGEN");
            //usuario.Imagen = Byte.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.Update(usuario);

            if (result.Correct)
            {
                Console.WriteLine("SE ACTUALIZO CORRECTAMENTE");
            }
            else
            {
                Console.WriteLine("OCURRIO UN ERROR AL ACTUALIZAR EL USUARIO \n" + result.ErrorMessage);
            }
            Console.ReadLine();

        }

        //ELIMINAR CON SP
        static public void DeleteSP()
        {

            Console.WriteLine("COLOCA EL ID DEL USUARIO A ELIMINAR");
            int IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.Delete(IdUsuario);

            if (result.Correct)
            {
                Console.WriteLine("SE ELIMINO CORRECTAMENTE");
            }
            else
            {
                Console.WriteLine("OCURRIO UN ERROR AL ELIMINAR EL USUARIO \n" + result.ErrorMessage);
            }
            Console.ReadLine();

        }

    }

}
