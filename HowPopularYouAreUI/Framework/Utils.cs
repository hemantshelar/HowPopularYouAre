using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public static class Utils
    {
        public static List<string> GetFiles(string path = ".", string pattern = "*.*")
        {
            List<string> result = new List<string>();
            try
            {
                var searchResult = Directory.GetFiles(path, pattern, SearchOption.AllDirectories);
                for(int i = 0;i<searchResult.Count();i++)
                {
                    searchResult[i] = Path.Combine(path, Path.GetFileName(searchResult[i]));
                }
                result.AddRange(searchResult.ToList<string>());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public static List<T> GetType<T>() where T : class 
        {
            var result = new List<T>();

            string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "bin");
            var dllFiles = GetFiles(path, "*.dll");
            foreach (var item in dllFiles)
            {
                Assembly assembly = Assembly.LoadFile(item);
                var types = assembly.GetTypes();
                foreach (var typeName in types)
                {
                    if (typeof(T).IsAssignableFrom(typeName) && typeName.IsClass == true )
                    {
                        var typeInstance = Activator.CreateInstance(typeName);
                        result.Add(typeInstance as T);
                    }
                }
            }
            return result;
        }
    }
}
