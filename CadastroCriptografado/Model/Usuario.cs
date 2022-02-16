using CadastroCriptografado.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCriptografado.Model
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }


        public bool gravarLogim()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;


            command.CommandText = " insert into tb_login values (@Nome, @Email, @Senha)";
            command.Parameters.Add("@Nome", SqlDbType.VarChar);
            command.Parameters.Add("@Email", SqlDbType.VarChar);
            command.Parameters.Add("@Senha", SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Email;
            command.Parameters[2].Value = Senha;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                MessageBox.Show("Usuario cadastrado com sucesso!");
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();

                return false;
            }

            finally
            {
                bd.fecharConexao();
            }

        }

        public Usuario retornaUsuario(string email)
        {
            Banco bd = new Banco();
            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("select * from tb_login", cn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(2) == email)
                    {
                        Id = reader.GetInt32(0);
                        Nome = reader.GetString(1);
                        Email = reader.GetString(2);
                        Senha = reader.GetString(3);

                        return this;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}
