using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Seneca
{
    public static class FileManager
    {
        public static List<string> ReadFile(string filePath)
        {
            List<string> lines = new List<string>();
            //string[] lines
            List<string> finalLines = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string Line;

                while ((Line = reader.ReadLine()) != null)
                {
                    //lines = Line;
                    lines.Add(Line);
                    if (Line == "")
                    {
                        finalLines.AddRange(lines);
                        lines.Clear();
                    }
                    //Console.WriteLine(columns[1]);
                    // Access the ISBN value (first column)
                }
            }
            return finalLines;
        }


        //private static List<string> splitForLines(string line)
        //{
        //    List<string> columns = new List<string>();
        //    //string columnBuilder = "";

        //    StringBuilder columnBuilder = new StringBuilder();
        //    bool inQuotes = false;

        //    foreach (char character in line)
        //    {
        //        if (character == '"')
        //        {
        //            inQuotes = !inQuotes;
        //            columnBuilder.Append('"');
        //        }
        //        else if (character == ',' && !inQuotes)
        //        {
        //            columns.Add(columnBuilder.ToString().Trim());
        //            columnBuilder.Clear();
        //        }
        //        else
        //        {
        //            columnBuilder.Append(character);
        //        }
        //    }

        //    columns.Add(columnBuilder.ToString().Trim());

        //    return columns;
        //}


        public static bool WriteFile()
        {
            string path = Directory.GetCurrentDirectory();
            string filePath = System.IO.Path.Combine(path, "User_Informations.txt");

            try
            {
                if (File.Exists(filePath))
                {
                    File.Create(filePath).Dispose();
                }
                foreach (var user in User.Credentials.Values)
                {
                    File.AppendAllText(filePath, $"{user.firstName}\n");
                    File.AppendAllText(filePath, $"{user.lastName}\n");
                    File.AppendAllText(filePath, $"{user.email}\n");
                    File.AppendAllText(filePath, $"{user.passWord}\n");
                    File.AppendAllText(filePath, $"\n");
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public static bool DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return true;
            }
            else { return false; }
        }
    }
}
