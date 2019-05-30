using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrolojiApp.Functions
{
    public class PrintHelp
    {
        public DataTable ConvertTo<T>(IList<T> list)
        {
            DataTable tb = CreateTable<T>();
            Type entityType = typeof(T);
            PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(entityType);
            foreach (T item in list)
            {
                DataRow row = tb.NewRow();
                foreach (PropertyDescriptor prop in pdc)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                tb.Rows.Add(row);
            }
            return tb;
        }
        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable dt = new DataTable(entityType.Name);
            PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(entityType);
            foreach (PropertyDescriptor prop in pdc)
            {
                dt.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            return dt;
        }
    }
}
