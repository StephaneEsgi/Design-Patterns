using System;

namespace Observer
{
    public interface Observer
    {
        // Cette méthode sera à implémenter dans toutes les classes qui implémenteront l'interface Observer
        void Update();
    }
}