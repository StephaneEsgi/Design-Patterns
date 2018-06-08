using System;
using Newtonsoft.Json;

namespace Command 
{
    public class UpdateCommand<T> : Command where T : new()
    {
        private T previousState;
        private T instance;

        public UpdateCommand(T t)
        {
            instance = t;
            // on conserve la version précédente en appliquant un mécanisme de DEEP COPY json (car la classe de test est simple)
            previousState = JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(t));
        }
        
        public void Execute() {
            if(DBManager.Instance.Update<T>(instance) == 0){
                throw new Exception($"Erreur lors de l'update : \"{instance}\"");
            }
        }

        public void Cancel() {
            DBManager.Instance.Update(previousState);
        }
    }
}