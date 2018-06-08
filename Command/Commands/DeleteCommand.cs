using System;
using Newtonsoft.Json;

namespace Command 
{
    public class DeleteCommand<T> : Command where T : new()
    {
        private T previousState;
        private T instance;

        public DeleteCommand(T t)
        {
            instance = t;
            // on conserve la version précédente en appliquant un mécanisme de DEEP COPY json car la classe de test est simple
            previousState = JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(t));
        }

        public void Execute() {
            if(DBManager.Instance.Delete<T>(instance) == 0) {
                throw new Exception($"Erreur lors de l'insertion : \"{instance}\"");
            }
        }

        public void Cancel() {
            DBManager.Instance.Insert(previousState);
        }
    }
}