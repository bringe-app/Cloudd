using System.Data;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Cloudd.BL
{
    public class ClientArr : ArrayList
    {
        public void Fill()
        {
            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Client_Dal.GetDataTable();

            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dataTable.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dataTable.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field =>
                  string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText("clients.csv", sb.ToString());

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Client curClient;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curClient = new Client(dataRow);
                Add(curClient);
            }
        }
        public ClientArr Filter(int id, string firstname, string lastname)
        {
            ClientArr clientArr = new ClientArr();
            Client client;
            for (int i = 0; i < this.Count; i++)
            {
                client = this[i] as Client;
                if ((client.m_id == id || id == 0) && client.m_lastname.ToLower().StartsWith(lastname.ToLower()) && 
                    client.m_firstname.ToLower().StartsWith(firstname.ToLower()))
                {
                    clientArr.Add(client);
                }
            }
            return clientArr;
        }
    }
    public class Client
    {
        public int m_id;
        public string m_firstname;
        public string m_lastname;
        public string m_username;
        public string m_password;
        public string m_email;
        public string m_gender;
        public Client(DataRow row)
        {
            m_id = int.Parse(row["id"].ToString());
            m_firstname = row["Firstname"].ToString();
            m_lastname = row["Lastname"].ToString();
            m_username = row["Username"].ToString();
            m_password = row["Password"].ToString();
            m_email = row["Email"].ToString();
            m_gender = row["Gender"].ToString();
        }
        public override string ToString()
        {
            return $"{m_firstname} {m_lastname} ({m_username})";
        }
        public Client(string firstname, string lastname, string username, string password, string email, string gender)
        {
            m_firstname = firstname; m_lastname = lastname; m_username = username;
            m_password = password; m_email = email; m_gender = gender;
        }
        public bool Insert()
        {
            return Client_Dal.Insert(m_firstname,m_lastname,m_username, m_password,m_email,m_gender);
        }
        public bool Update(string firstname, string lastname, string username, string email)
        {
            return Client_Dal.Update(m_id,firstname,lastname,username,m_password,email,m_gender);
        }
        public bool Delete()
        {
            return Client_Dal.Delete(m_id);
        }
    }
}
