using System;

namespace Prototype {
    public interface IClonable<T>{
        T Clone();
    }
}