using System;
using System.Collections.Generic;

namespace CollectionDictionary
{
    class MyDictonary<TKey, TValue>
    {
        List<TKey> keyList;
        List<TValue> valueList;

        public MyDictonary()
        {
            keyList = new List<TKey>();
            valueList = new List<TValue>();
        }

        public bool AddKeyValuePair(TKey key, TValue value)
        {

            for (int i = 0; i < keyList.Count; i++)
            {
                if (keyList[i].Equals(key))
                {
                    Console.WriteLine("This key alreadry exits.");
                    return false;
                }
            }
            keyList.Add(key);
            valueList.Add(value);
            Console.WriteLine("");
            return true;
        }

        public TValue GetValue(TKey key)
        {
            for (int i = 0; i < keyList.Count; i++)
            {
                if (keyList[i].Equals(key))
                    return valueList[i];
            }
            return default;
        }

        public bool RemoveKeyValuePair(TKey key)
        {
            for (int i = 0; i < keyList.Count; i++)
            {
                if (keyList[i].Equals(key))
                {
                    keyList.RemoveAt(i);
                    valueList.RemoveAt(i);
                    Console.WriteLine("Value " + key + " has been deleted.");
                    return true;
                }
            }
            return false;
        }
    }
}