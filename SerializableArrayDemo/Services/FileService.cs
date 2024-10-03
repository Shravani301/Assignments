using SerializableArrayDemo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SerializableArrayDemo.Services
{
    public class FileService
    {
        private readonly string filePath;

        public FileService()
        {
            filePath = ConfigurationManager.AppSettings["myFile"];
        }

        public List<Account> DeserializeAccounts()
        {
            if (File.Exists(filePath))
            {
                var jsonData = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Account>>(jsonData) ?? new List<Account>();
            }

            return new List<Account>();
        }

        public void SerializeAccounts(List<Account> accounts)
        {
            var json = JsonSerializer.Serialize(accounts);
            File.WriteAllText(filePath, json);
            Console.WriteLine("Account data saved successfully!");
        }
    }
}
