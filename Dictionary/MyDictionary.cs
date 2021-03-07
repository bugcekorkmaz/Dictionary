using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T,K>
    {
        T[] tKey;
        K[] tValue;
        public MyDictionary()
        {
            tKey = new T[0];
            tValue = new K[0];
        }
        public void Add(T key, K value)
        {
            T[] tempKey = tKey;
            K[] tempValue = tValue;
            tKey = new T[tKey.Length + 1];
            tValue = new K[tValue.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                tKey[i] = tempKey[i];
                tValue[i] = tempValue[i];
            }
            tKey[tKey.Length - 1] = key;
            tValue[tKey.Length - 1] = value;
        }
        public T[] Key
        {
            get{ return tKey; }
        }
        public K[] Value
        {
            get { return tValue; }
        }
        public int Length
        {
            get{ return tKey.Length; }
        }

    }
}
