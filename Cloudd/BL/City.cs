using System.Data;
using System.Collections;
using Cloudd.DAL;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cloudd.BL
{
    class CityArr : ArrayList
    {
        public City GetCityWithMaxId()
        {
            City maxCity = this[0] as City;

            for (int i = 0; i < Count; i++)
            {
                if ((this[i] as City).Id > maxCity.Id)
                    maxCity = this[i] as City;
            }

            return maxCity;
        }
        public bool IsContains(string cityName)
        {
            for (int i = 0; i < Count; i++)
            {
                if ((this[i] as City).Name == cityName)
                    return true;
            }
            return false;
        }
        public void Fill()
        {
            DataTable dataTable = City_DAL.GetDataTable();

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

            File.WriteAllText("cities.csv", sb.ToString());

            DataRow dataRow;
            City currCity;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                currCity = new City(dataRow);

                if (IsContains(currCity.Name))
                    continue;

                Add(currCity);
            }
        }
    }
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
        public City(DataRow row)
        {
            Id = int.Parse(row["Id"].ToString());
            Name = row["Name"].ToString();
        }
        public City(string name)
        {
            Name = name;
        }
        public bool Insert()
        {
            return City_DAL.Insert(Name);
        }
        public bool Update(string name)
        {
            return City_DAL.Update(Id, name);
        }
        public bool Delete()
        {
            return City_DAL.Delete(Id);
        }
    }
}
