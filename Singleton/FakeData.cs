using System;
using System.Collections.Generic;

namespace Singleton {

    public class FakeData {
        // Nos FakeData ne sont finalement qu'une liste de chaînes de caractères,
        // que nous allons manipulées au travers de la classe à instance unique DBConnection
        public List<string> theData = new List<string>{
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
        }; 
    }

}