using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace VotingForm.DAO
{
    public class VotingFormBase
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myBase"].ConnectionString);

        public bool CreatePoll(Entity.Poll poll)
        {
            string command = "INSERT INTO Poll (id_poll, creation_date, title_poll) VALUES (@idPoll, GETDATE(), @title)";

            SqlCommand cmd = new SqlCommand(command);

            cmd.Parameters.AddWithValue("@idPoll", poll.IdPoll);
            cmd.Parameters.AddWithValue("@title", poll.title);

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            try
            {
                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public bool CreatePollOptions(Entity.Poll poll)
        {
            string command = "INSERT INTO Poll_options (id_option, id_poll, creation_date, question, votes) VALUES (@idOption, @idPoll, GETDATE(), @question, @votes)";

            SqlCommand cmd = new SqlCommand(command);

            cmd.Parameters.AddWithValue("@idOption", DbType.String);
            cmd.Parameters.AddWithValue("@idPoll", DbType.String);
            cmd.Parameters.AddWithValue("@question", DbType.String);
            cmd.Parameters.AddWithValue("@votes", DbType.Int32);

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            try
            {
                conn.Open();

                foreach (Entity.Option value in poll.pollOption)
                {
                    cmd.Parameters[0].Value = value.idOption;
                    cmd.Parameters[1].Value = poll.IdPoll;
                    cmd.Parameters[2].Value = value.question;
                    cmd.Parameters[3].Value = 0;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }

        public DataTable GetPoll(string idPoll)
        {
            string command = "SELECT id_poll, title_poll FROM Poll WHERE id_poll = @idPoll";

            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(command);

            cmd.Parameters.AddWithValue("@idPoll", idPoll);
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            try
            {
                conn.Open();

                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable GetOptions(string idPoll)
        {
            string command = "SELECT * FROM Poll_options WHERE id_poll = @idPoll ORDER BY id_option";

            DataTable dt = new DataTable();

            SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(command);

            cmd.Parameters.AddWithValue("@idPoll", idPoll);
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            try
            {
                conn.Open();

                sda.SelectCommand = cmd;
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool CheckIP(string ipCod)
        {
            return false;
        }

        public bool DetectPoll(string idPoll)
        {
            int result;

            string command = "SELECT COUNT(*) FROM Poll WHERE id_poll = @idPoll";

            SqlCommand cmd = new SqlCommand(command);

            cmd.Parameters.AddWithValue("@idPoll", idPoll);
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            try
            {
                conn.Open();

                result = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

            if(result == 1)
            {
                return true;
            }

            return false;
        }
    }
}