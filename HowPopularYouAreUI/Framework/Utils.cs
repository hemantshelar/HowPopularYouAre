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
                    searchResult[i] = Path.Combine(Directory.GetCurrentDirectory(), searchResult[i]);
                }
                result.AddRange(searchResult.ToList<string>());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public static List<T> GetType<T>()
        {
            var result = new List<T>();
            var dllFiles = GetFiles(".", "*.dll");
            foreach (var item in dllFiles)
            {
                Assembly assembly = Assembly.LoadFile(item);
                
                
                assembly.GetType();
                
            }
            return result;
        }
    }
}
