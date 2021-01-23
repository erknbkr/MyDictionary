using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<T,U>
    {
        T[] _keys;
        U[] _values;
        public MyDictionary()
        {
            //Dizilere referans ataması yapıyoruz.
            _keys = new T[0];
            _values = new U[0];
        }

        public void Add(T key, U value)
        {
            //Dizilerimizin referanslarını tutuyoruz.
            T[] tempKeys = _keys;
            U[] tempValues = _values;

            //Dizilerimizin alanın arttırıyoruz.
            _keys = new T[_keys.Length + 1];
            _values = new U[_values.Length + 1];

            //Yeni alan atanan dizilerde kaybolan değerleri temp dizilerinden geri eşleştirme yapıyoruz.
            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
                _values[i] = tempValues[i];
            }
            //Son olarak yeni eklenmek istenen key ve value ifadelerini son elemana eşliyoruz.
            _keys[_keys.Length-1] = key;
            _values[_values.Length-1] = value;
        }
    }
}
