using System;

namespace Command 
{
    public class InsertCommand<T> : Command where T : new()
    {
        private T instance;

        public InsertCommand(T t)
        {
            instance = t;
        }
        
        public void Execute() {
            if(DBManager.Instance.Insert<T>(instance) == 0){
                throw new Exception($"Erreur lors de l'insertion : \"{instance}\"");
            }
        }

        public void Cancel() {
            DBManager.Instance.Delete(instance);
        }
    }
}