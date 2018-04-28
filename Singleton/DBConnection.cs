using System;
using System.Linq;
using System.Collections.Generic;

namespace Singleton {

    public class DBConnection {
        private static DBConnection instance;

        // Ces fausses données ne sont que pour simuler l'accès à une source de données externes, 
        // ce n'est pas le propos de ce projet qui présente simplement le pattern Singleton
        private FakeData connection;

        private DBConnection(){
            // établissement de la connexion à la BDD
            connection = new FakeData();
        }

        // Cette méthode instancie l'UNIQUE instance de DBConnection du projet, 
        // au besoin lors du premier appel à la méthode GetInstance()
        public static DBConnection GetInstance(){
            if(instance == null)
                instance = new DBConnection();
            return instance;
        }

        public void Add(string newValue){
            connection.theData.Add(newValue);
        }

        public void Update(string oldValue, string newValue){
            var nbErased = connection.theData.RemoveAll(o => o.Equals(oldValue));
            for(int i = 0; i < nbErased; i++)
                connection.theData.Add(newValue);
        }

        public int Delete(string valueToRemove){
            return connection.theData.RemoveAll(o => o.Equals(valueToRemove));
        }

        public List<string> GetAll(){
            return connection.theData;
        }

    }

}