using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictonary<TKey,TValue>
    {
        TKey[] _key;
        TValue[] _value;
        TKey[] _tempKey;
        TValue[] _tempValue;

        public MyDictonary()
        {
            _key = new TKey[1];
            _value = new TValue[1];
        }
        public void Add(TKey key, TValue value)
        {
            _tempKey =  _key;
            _tempValue =  _value;

            _key = new TKey[_key.Length + 1];
            _value = new TValue [_value.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i]; //eski değer
            }

            for (int i = 0; i <_tempValue.Length; i++)
            {
                _value[i] = _tempValue[i]; // eski değer
            }

            _key[_key.Length - 1] = key; //ekleme
            _value[_value.Length - 1] = value; // value ekleme
        }
        public int Count
        {
            get { return _key.Length; }
        }
    }
}
