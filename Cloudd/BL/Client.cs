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
                if ((client._id == id || id == 0) && client._lastname.ToLower().StartsWith(lastname.ToLower()) && 
                    client._firstname.ToLower().StartsWith(firstname.ToLower()))
                {
                    clientArr.Add(client);
                }
            }
            return clientArr;
        }
    }
    public class Client
    {
        public int _id;
        public string _firstname;
        public string _lastname;
        public string _username;
        public string _password;
        public string _email;
        public string _gender;
        public Client(DataRow row)
        {
            _id = int.Parse(row["id"].ToString());
            _firstname = row["Firstname"].ToString();
            _lastname = row["Lastname"].ToString();
            _username = row["Username"].ToString();
            _password = row["Password"].ToString();
            _email = row["Email"].ToString();
            _gender = row["Gender"].ToString();
        }
        public override string ToString()
        {
            return $"{_firstname} {_lastname} ({_username})";
        }
        public Client(string firstname, string lastname, string username, string password, string email, string gender)
        {
            _firstname = firstname; _lastname = lastname; _username = username;
            _password = password; _email = email; _gender = gender;
        }
        public bool Insert()
        {
            return Client_Dal.Insert(_firstname,_lastname,_username, _password,_email,_gender);
        }
        public bool Update(string firstname, string lastname, string username, string email)
        {
            return Client_Dal.Update(_id,firstname,lastname,username,_password,email,_gender);
        }
        public bool Delete()
        {
            return Client_Dal.Delete(_id);
        }
    }
}
