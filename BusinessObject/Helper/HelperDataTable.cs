using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Helper
{
    public static class HelperDataTable
    {

        /// <summary>
        /// Converts the <see cref="IEnumerable{T}"/> into a <see cref="DataTable"/>
        /// </summary>
        /// <typeparam name="T">The current type/></typeparam>
        /// <param name="data">The data to convert into <see cref="DataTable"/></param>
        /// <param name="tableName">A name for the <see cref="DataTable.TableName"/></param>
        /// <returns>A new <see cref="DataTable"/></returns>
        public static DataTable ToDataTable<T>(this IEnumerable<T> data, string tableName) where T : class
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable(tableName);
            foreach (PropertyDescriptor prop in properties)
            {
                if (!prop.PropertyType.IsEnum)
                {
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                }
                else
                {
                    table.Columns.Add(prop.Name, typeof(int));
                }
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {

                    if (!prop.PropertyType.IsEnum)
                    {
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    }
                    else
                    {
                        row[prop.Name] = (int)prop.GetValue(item);
                    }
                }

                table.Rows.Add(row);
            }
            return table;
        }

    }
}
