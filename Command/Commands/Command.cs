using System;

namespace Command {
    public interface Command {
        void Execute();
        void Cancel();
    }
}