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

            command.CommandText = string.Format("SELECT imageUrl FROM tblresult WHERE id = '{0}'", id);

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

    /*public static Services DisplaySingleService(string servCode)
    {
        bool exists = CheckServiceCode(servCode);

        if (exists)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                    string query = string.Format("SELECT srate, servicehours FROM tblservice WHERE scode = '{0}'", servCode);
                    command.CommandText = query;

                    Services serv = null;
                    MySqlDataReader reader = command.ExecuteReader();
                    string rate, hours;
                    while (reader.Read())
                    {
                        rate = reader.GetString(2);
                        hours = reader.GetString(3);

                        serv = new Services(rate, hours);
                    }
                    return serv;
            }
            finally
            {
                conn.Close();
            }
        }
    }*/
    /*
    public static bool RegisterComplaint(Complaint complaint)
    {
        string query = string.Format("INSERT INTO tblcomplaint (cno, cdate, cdesc) VALUES('{0}','{1}', '{2}')",
        complaint.ComplaintNo, complaint.ComplaintDate, complaint.ComplaintDescription);

        command.CommandText = query;

        try
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            command.ExecuteNonQuery();
            return true;
        }
        finally
        {
            conn.Close();
        }
    }*/

    /* public static Services FilterServices(string serviceCode)
     {
         bool exists = CheckServiceCode(serviceCode);

         if (exists)
         {
             try
             {
                 if (conn.State == System.Data.ConnectionState.Closed)
                 {
                     conn.Open();
                 }

                 string query = string.Format("SELECT srate, servicehours FROM tblservice WHERE scode = '{0}'", serviceCode);
                 command.CommandText = query;

                 Services myService = null;
                 MySqlDataReader reader = command.ExecuteReader();

                 string srate, shours;

                 while (reader.Read())
                 {
                     srate = reader.GetString(2);
                     shours = reader.GetString(3);

                     myService = new Services(srate, shours);
                    
                 return myService;
                 }
                 else
                 {
                     return null;
                 }
             }
             finally
             {
                 conn.Close();
             }
         }
         else
         {
             return null;
         }
     }*/

    /*
    public static string getMax(string surname)
    {
        command.CommandText = string.Format("SELECT MAX(MID(clcode, 4, 3)) from tblclient WHERE substr(clcode, 1, 3) = '{0}'", surname);

        try
        {
            conn.Open();
            return (string)command.ExecuteScalar();
        }
        finally
        {
            conn.Close();
        }
    }

    public static bool CheckVehicleReg(string registrationNo)
    {
        string query = String.Format("SELECT COUNT(*) FROM tblvehicle WHERE regno = '{0}'", registrationNo);
        command.CommandText = query;

        try
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            int vehicles = Convert.ToInt32(command.ExecuteScalar());

            if (vehicles < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static bool RegisterVehicle(Vehicle vehicle)
    {
        string query = string.Format("INSERT INTO tblvehicle VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
        vehicle.RegNum, vehicle.Make, vehicle.Model, vehicle.Colour, vehicle.Year, vehicle.FuelType, vehicle.ClientCode);

        command.CommandText = query;

        try
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            command.ExecuteNonQuery();
            return true;
        }
        finally
        {
            conn.Close();
        }
    }

    public static bool generateJob(string regno, string mech, string kilo, string start)
    {
        command.CommandText = string.Format("INSERT INTO tbljobcard(regno, mno, kmreading, datejobtbd) VALUES('{0}', '{1}','{2}','{3}')", regno, mech, kilo, start);

        try
        {
            conn.Open();
            command.ExecuteNonQuery();
            return true;
        }
        finally
        {
            conn.Close();
        }
    }

    public static int getMaxCard()
    {
        command.CommandText = "SELECT MAX(jobcardno) FROM tbljobcard";


        return (int)command.ExecuteScalar();

    }

    public static void insertJob(string jobId)
    {

        try
        {
            conn.Open();
            int max = getMaxCard();
            command.CommandText = string.Format("INSERT INTO tbljobservice VALUES({0}, '{1}')", max, jobId);
            command.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
    }

    public static bool issueInvoice(string jobno, string finishdate)
    {
        command.CommandText = string.Format("UPDATE tbljobcard SET datejobfn = '{0}' WHERE jobcardno = {1}", finishdate, jobno);
        try
        {
            conn.Open();

            command.ExecuteNonQuery();

            command.CommandText = string.Format("INSERT INTO tblinvoice(idate, jobcardno) VALUES('{0}', {1})", DateTime.Now.ToString("yyyy-MM-dd"), jobno);
            command.ExecuteNonQuery();
            return true;

        }
        finally
        {
            conn.Close();
        }
    }

    public static Invocie getInvoice()
    {
        command.CommandText = string.Format(@"SELECT max(i.ino), i.idate, c.clcode, c.surname, c.initials, c.contactno, v.regno, v.make, v.model, v.year, j.jobcardno, datejobtbd, kmreading, m.surname, m.initials
        FROm tblclient c, tbljobcard j, tblmechanic m, tblinvoice i, tblvehicle v
        WHERE i.jobcardno = j.jobcardno
        AND j.mno = m.mno
        AND j.regno = v.regno
        AND v.clcode = c.clcode");

        try
        {
            conn.Open();
            Invocie inv = null;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                inv = new Invocie(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                    reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13),
                    reader.GetString(14));
            }

            return inv;

        }
        finally
        {
            conn.Close();
        }
    }
    public static bool AddressComplaint(string dateAddressed, string satisfiedYN, string complaintNo)
    {
        command.CommandText = string.Format("UPDATE tblcomplaint SET dateaddressed = '{0}', satisfiedYN = '{1}' WHERE cno = '{2}'", DateTime.Now.ToString("yyyy-MM-dd"), satisfiedYN, Convert.ToInt32(complaintNo));
        try
        {
            conn.Open();

            command.ExecuteNonQuery();
            return true;

        }
        finally
        {
            conn.Close();
        }
    }

    //Check if a certificate code already exists
    public static bool CheckCertCode(string certCode)
    {
        string query = String.Format("SELECT COUNT(*) FROM tblcertificate WHERE ccode = '{0}'", certCode);
        command.CommandText = query;

        try
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            int users = Convert.ToInt32(command.ExecuteScalar());

            if (users < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        finally
        {
            conn.Close();
        }
    }


    public static ArrayList getServices(string jobcode)
    {
        command.CommandText = string.Format("SELECT s.sdesc, s.srate, s.servicehours FROM tblservice s, tbljobservice j WHERE j.jobcardno = {0} AND j.scode = s.scode ", jobcode);

        ArrayList servi = new ArrayList();

        try
        {
            conn.Open();

            MySqlDataReader reader = command.ExecuteReader();

            Services serv = null;

            while (reader.Read())
            {
                serv = new Services(reader.GetString(0), reader.GetInt32(1).ToString(), reader.GetString(2));

                servi.Add(serv);
            }

            return servi;
        }
        finally
        {
            conn.Close();
        }
    }

    //Add new certificate
    public static bool AddCertificate(Certificate certificate)
    {
        string query = string.Format("INSERT INTO tblcertificate VALUES('{0}','{1}')",
        certificate.CertCode, certificate.CertDescription);

        command.CommandText = query;

        try
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            command.ExecuteNonQuery();
            return true;
        }
        finally
        {
            conn.Close();
        }
    }

    public static Invocie getInvoice(string id)
    {
        command.CommandText = string.Format(@"SELECT i.ino, i.idate, c.clcode, c.surname, c.initials, c.contactno, v.regno, v.make, v.model, v.year, j.jobcardno, datejobtbd, kmreading, m.surname, m.initials
		FROm tblclient c, tbljobcard j, tblmechanic m, tblinvoice i, tblvehicle v
		WHERE i.jobcardno = j.jobcardno
		AND j.mno = m.mno
		AND j.regno = v.regno
		AND v.clcode = c.clcode
		AND i.ino = {0}", id);

        try
        {
            conn.Open();
            Invocie inv = null;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                inv = new Invocie(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                    reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13),
                    reader.GetString(14));
            }

            return inv;

        }
        finally
        {
            conn.Close();
        }
    } */
}