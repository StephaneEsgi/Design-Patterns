using System;
using System.Collections.Generic;

namespace Iterator 
{
    public class MyIterableData
    {
        private string _id;
        private List<string> _data;
        public MyIterableData(string id, params string[] data)
        {
            _id = id;
            _data = new List<string>(data);
        }
        public IEnumerator<string> GetEnumerator()
        {
            yield return _id;
            foreach(string d in _data) yield return d;
        }
    }
}