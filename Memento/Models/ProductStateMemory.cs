using System;

namespace Memento {
    public class ProductStateMemory
    {
        /**
         * Ici, cette simple propriété pourrait donner accès à une liste permettant de sauvegarder plusieurs instances à l'aide d'une clé
         */
        public ProductMemento Memento { get; set; }
    }
}