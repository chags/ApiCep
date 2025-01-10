using apiCep.Models;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace apiCep.Services
{
    public class CepService
    {
        private readonly string _dataDir;

        public CepService()
        {
            // Define the directory for JSON files
            _dataDir = Path.Combine(Directory.GetCurrentDirectory(), "Data");
        }

        public (bool IsValid, string ErrorMessage) ValidateCep(string cep)
        {
            // Remove non-digit characters
            cep = Regex.Replace(cep, @"\D", "");

            if (cep.Length != 8)
            {
                return (false, "Invalid CEP. It must contain exactly 8 digits.");
            }

            return (true, string.Empty);
        }

        public CepInfo? GetCepInfo(string cep)
        {
            var filePath = Path.Combine(_dataDir, $"{cep}.json");

            if (!File.Exists(filePath))
                return null;

            var jsonData = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<CepInfo>(jsonData);
        }
    }
}
