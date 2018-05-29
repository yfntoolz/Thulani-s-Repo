using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data.Odbc;
using System.Configuration;

/// <summary>
/// Summary description for Connection
/// </summary>
public class Connection
{
    public static MySqlConnection connection;
    public static MySqlCommand command;

    static Connection()
    {
        var connectionString = ConfigurationManager.ConnectionStrings["WebDevNinjaConnection"].ToString();
        connection = new MySqlConnection(connectionString);
        command = new MySqlCommand("", connection);
    }

    // Checking if salesperson exists using email
    public bool CheckSalespersonEmail(string email)
    {
        var query = String.Format("SELECT COUNT(*) FROM tblSalesperson WHERE email = '{0}'", email);
        command.CommandText = query;

        try
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            var users = Convert.ToInt32(command.ExecuteScalar());

            return users == 0 ? false : true;
        }
        finally
        {
            connection.Close();
        }
    }

    public User SalespersonLogin(string email, string password)
    {
        var exists = CheckSalespersonEmail(email);

        if (exists)
        {
            var query = string.Format("SELECT password FROM tblSalesperson WHERE email = '{0}'", email);
            command.CommandText = query;

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                var salespersonPassword = (string)command.ExecuteScalar();

                if (salespersonPassword == password)
                {
                    query = string.Format("SELECT email, firstName, lastName FROM tblSalesperson WHERE password = '{0}'", salespersonPassword);
                    command.CommandText = query;

                    User salesperson = null;
                    var reader = command.ExecuteReader();

                    string salespersonEmail, firstName, lastName;

                    while (reader.Read())
                    {
                        salespersonEmail = reader.GetString(0);
                        firstName = reader.GetString(1);
                        lastName = reader.GetString(2);

                        salesperson = new User(email, firstName, lastName);

                    }

                    return salesperson;
                }
                else
                {
                    return null;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        else
        {
            return null;
        }
    }

    public string GetGraph(int id)
    {
        try
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            command.CommandText = string.Format("SELECT graphUrl FROM tblresult WHERE id = '{0}'", id);

            return (string)command.ExecuteScalar();
        }
        finally
        {
            connection.Close();
        }
    }

    // Get Feedback
    public string GetRelevantResults(int id)
    {
        try
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            command.CommandText = string.Format("SELECT research, graphUrl FROM tblresult WHERE id = '{0}'", id);

            return (string)command.ExecuteScalar();
        }
        finally
        {
            connection.Close();
        }
    }

    public bool RegisterSalesperson(User user)
    {
        var query = string.Format("INSERT INTO tblSalesperson VALUES('{0}', '{1}', '{2}', '{3}')",
        user.Email, user.FirstName, user.LastName, user.Password);

        command.CommandText = query;

        try
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            command.ExecuteNonQuery();

            return true;
        }
        finally
        {
            connection.Close();
        }
    }
}