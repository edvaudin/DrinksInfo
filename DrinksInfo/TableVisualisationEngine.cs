using ConsoleTableExt;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfo
{
    internal class TableVisualisationEngine
    {
        public static void ShowTable<T>(List<T> tableData, [AllowNull] string tableName) where T : class
        {
            Console.Clear();
            if (tableData == null)
            {
                tableName= string.Empty;
            }
            Console.WriteLine("\n\n");
            ConsoleTableBuilder.From(tableData).WithColumn(tableName).ExportAndWriteLine();
            Console.Write("\n\n");
        }
    }
}
