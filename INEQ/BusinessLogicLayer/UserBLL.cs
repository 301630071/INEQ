using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UserBLL
    {
        #region iniciarSesion
        public static string iniciarSesion(string us, string pwd)
        {
            //VALIDACION 0: Inspeccionar que ambos datos vengan con informacion
            if (string.IsNullOrEmpty(us) && string.IsNullOrEmpty(pwd))
            {
                return "Favor de llenar el formulario";
            }
            else
            {
                //VALIDACION 1: Inspeccionar que el usuario venga con datos
                if (string.IsNullOrEmpty(us))
                {
                    return "Favor de introducir el usuario";
                }
                else
                {
                    //VALIDACION 2: Inspeccionar que la contrasenia venga con datos
                    if (string.IsNullOrEmpty(pwd))
                    {
                        return "Favor de introducir la contrasenia";
                    }
                    else
                    {
                        //VALIDACION 3: Inspeccionar la longitud de la contrasenia (5 caracteres)
                        if (pwd.Length != 5)
                        {
                            return "Contrasenia no valida, favor de introducirla correctamente";
                        }
                        else
                        {
                            if (!email_bien_escrito(us))
                            {
                                return "Nombre de usuario no valido, favor de introducirlo correctamente";
                            }
                            else
                            {
                                //VALIDACION 4: Verificar que el usuario exista en la BD
                                bool isLogIn = DataAccessLayer.UserDAL.iniciarSesion(us, pwd);

                                if (isLogIn)
                                {
                                    return " Bienvenido ";
                                }
                                else
                                {
                                    return "No se pudo iniciar sesión";
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region email_bien_escrito
        private static Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
