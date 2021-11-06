using System.Data;

namespace Cloudd.BL
{
    class Client_Dal
    {
        public static bool Insert(string firstname, string lastname, string username, string password, string email, string gender)
        {
            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Client"
            + "("
            + "[Firstname],[Lastname],[Username],[Password],[Email],[Gender]"
            + ")"
            + " VALUES "
            + "("
            + $"N'{firstname}',N'{lastname}',N'{username}','{password}','{email}','{gender}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Update(int Id, string firstname, string lastname, string username,string password, string email, string gender)
        {
            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"
            + $" [Firstname] = N'{firstname}',"
            + $" [Lastname] = N'{lastname}',"
            + $" [Username] = N'{username}',"
            + $" [Password] = '{password}',"
            + $" [Email] = '{email}',"
            + $" [Gender] = '{gender}'"
            + $" WHERE [Id] = {Id}";
            

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {
            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Client WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
        public static DataTable GetDataTable()
        {
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            DataTable dataTable = dataSet.Tables["Table_Client"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {
            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Client", "[Firstname],[Lastname],[Username],[Password],[Email],[Gender]");
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...
        }
    }
}
