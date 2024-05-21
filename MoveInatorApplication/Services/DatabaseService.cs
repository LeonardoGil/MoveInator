﻿using MoveInatorApplication.Services.Interfaces;
using System.Text.Json;
using System.Text;
using MoveInatorDomain.Entities.Outros;

namespace MoveInatorApplication.Services
{
    public class DatabaseService : IDatabaseService
    {
        public DatabaseJson Database { get; set; }

        public DatabaseService() => Database = Load().Result;
        
        public async Task Save()
        {
            try
            {
                if (File.Exists(DatabaseJson.FilePath))
                    File.Delete(DatabaseJson.FilePath);

                var content = JsonSerializer.Serialize(Database);

                using (var file = File.Create(DatabaseJson.FilePath))
                {
                    var info = new UTF8Encoding(true).GetBytes(content);
                    await file.WriteAsync(info);
                }

                Database.Atualizado = true;
            }
            catch (UnauthorizedAccessException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DatabaseJson> Load()
        {
            try
            {
                if (!File.Exists(DatabaseJson.FilePath))
                    throw new FileNotFoundException($"Arquivo {DatabaseJson.FilePath} não encontrado!");

                var database = JsonSerializer.Deserialize<DatabaseJson>(File.ReadAllText(DatabaseJson.FilePath));
                
                database.AddCollectionChangeEvent();
                database.Atualizado = true;

                return database;
            }
            catch (FileNotFoundException)
            {
                var database = new DatabaseJson();
                await Save();

                return database;
            }
            catch (UnauthorizedAccessException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
