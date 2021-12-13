using System.Data;

namespace Cloudd.DAL
{
    class City_DAL
    {
        public static bool Insert(string name)
        {
            string str = "INSERT INTO Table_City"
            + "("
            + "[Name]"
            + ")"
            + " VALUES "
            + "("
            + $"N'{ name }'"
            + ")";
            return Dal.ExecuteSql(str);
        }
        public static bool Update(int Id, string name)
        {
            string str = "UPDATE Table_City SET"
            + $" [Name] = N'{ name }'"
            + $" WHERE [Id] = { Id }";
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {
            string str = $"DELETE FROM Table_City WHERE ID = { id }";
            return Dal.ExecuteSql(str);
        }
        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_City"))
                Dal.FillDataSet(dataSet, "Table_City", "[Name]");
        }
        public static DataTable GetDataTable()
        {
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            DataTable dataTable = dataSet.Tables["Table_City"];
            return dataTable;
        }
    }
}
