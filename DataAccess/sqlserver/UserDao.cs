using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Soporte.Cache;

namespace DataAccess.sqlserver
{
    public class UserDao : ConnectionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Position = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);
                            UserLoginCache.Saldos = reader.GetInt32(7);
                            UserLoginCache.Cedula = reader.GetString(8);
                            UserLoginCache.LoginName = reader.GetString(2);

                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);
                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                          subject: "SOPORTE: Recuperar contraseña",
                          body: "Hola, " + userName + "\nSolicitaste recuperar tu contraseña.\n" +
                          "Tu contraseña actual es: " + accountPassword +
                          "\nTe pediremos que cambies tu contraseña inmediatamente una vez entres al sistema.",
                          recipientMail: new List<string> { userMail }
                          );
                        return "Hola, " + userName + "\nSolicitaste recuperar tu contraseña.\n" +
                          "Por favor revisa tu correo electronico: " + userMail +
                          "\nTe pediremos que cambies tu contraseña inmediatamente una vez entres al sistema.";
                    }
                    else
                        return "Lo siento, no encontramos un correo electronico asociado a esta cuenta";
                }
            }
        }

        public void AnyMethod()
        {
            if (UserLoginCache.Position == Positions.Administrator)
            {

            }
            if (UserLoginCache.Position == Positions.usuario)
            {

            }
        }
    }
}
