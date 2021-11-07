using AppName.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);

            _database.DropTableAsync<Stage>().Wait();
            _database.DropTableAsync<Stage>().Wait();
            _database.DropTableAsync<Theme>().Wait();
            _database.DropTableAsync<JoueurNiveauScore>().Wait();

            _database.CreateTableAsync<Stage>().Wait();
            _database.CreateTableAsync<Theme>().Wait();
            _database.CreateTableAsync<JoueurNiveauScore>().Wait();
        }

        public async Task<List<Theme>> GetThemeAsync()
        {
            return await _database.Table<Theme>().ToListAsync();
        }

        //public Task<int> SaveThemeAsync(Theme theme)
        //{

        //    return _database.InsertAsync(theme);
        //}

        public Task<int> SaveJoueurNiveauScore(JoueurNiveauScore dataJoueurNiveauScore)
        {
            _database.DeleteAllAsync<JoueurNiveauScore>();
            return _database.InsertAsync(dataJoueurNiveauScore);
        }

        public async Task<JoueurNiveauScore> GetdataJoueurNiveauScore()
        {
            return await _database.Table<JoueurNiveauScore>().FirstOrDefaultAsync();
        }

        public Task<int> SaveStagesAsync(List<Stage> lstStage)
        {
            _database.DeleteAllAsync<Stage>();
            return _database.InsertAllAsync(lstStage);
        }

        public async Task<List<Stage>> GetAllStagesAsync()
        {
            return await _database.Table<Stage>().ToListAsync();
        }

        public Task<int> SaveThemeAsync(List<Theme> lstTheme)
        {
            _database.DeleteAllAsync<Theme>();

            return _database.InsertAllAsync(lstTheme);
        }

        public Task<int> UpdateThemeStatut(Theme theme)
        {
            if (theme.ThemeID != 0)
            {
                return _database.UpdateAsync(theme);
            }
            else
                return null;
        }

        public string ActiveNextTheme(string CodeThemeSuivant)
        {
            var updateData = 0;
            if (!string.IsNullOrWhiteSpace(CodeThemeSuivant))
            {
                var resultData = _database.Table<Theme>().Where(t => t.CodeTheme == CodeThemeSuivant).FirstOrDefaultAsync();
               resultData.Result.ThemeActiveBackgroundColor = "Green";
                resultData.Result.Active = true;
                updateData =  _database.UpdateAsync(resultData.Result).Result;

                var testResult = _database.Table<Theme>().ToListAsync().Result;
            }
            else
                return "0";

            return updateData.ToString();
        }

        public Task<List<Theme>> GetThemeByIdStage(int IdStage)
        {
          return _database.Table<Theme>().Where(x => x.StageID == IdStage).ToListAsync();
        }

    }
}
