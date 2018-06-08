using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using SQLite;

namespace Command
{
    /**
     * Ce manager propose des méthodes génériques, 
     * pouvant fonctionner avec toute classe proposant un constructeur public sans paramètres
     */
    public class DBManager {

        private SQLiteConnection connection;

        #region Singleton
        static readonly Lazy<DBManager> lazy = new Lazy<DBManager>(() => new DBManager());

        public static DBManager Instance => lazy.Value;

        private DBManager() {
            connection = new SQLiteConnection("CommandPatternDB.db");
        }
        #endregion

        public int CreateTable<T>() where T : new() => connection.CreateTable<T>();
        public int DropTable<T>() where T : new() => connection.DropTable<T>();
        public List<T> GetAll<T>() where T : new() => connection.Table<T>().ToList();
        public T Get<T>(object pk) where T : new() => connection.Get<T>(pk);
        public int Insert<T>(T t) where T : new() => connection.Insert(t);
        public int Update<T>(T t) where T : new() => connection.Update(t);
        public int Delete<T>(T t) where T : new() => connection.Delete(t);
    } 
}
