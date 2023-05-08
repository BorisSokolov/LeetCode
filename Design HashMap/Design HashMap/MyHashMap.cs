using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_HashMap
{
    public class Bucket
    {
        private List<Tuple<int, int>> bucket = new List<Tuple<int, int>>();

        public int Get(int key)
        {
            foreach (var pair in from pair in bucket
                                 where pair.Item1.Equals(key)
                                 select pair)
            {
                return pair.Item2;
            }

            return -1;
        }

        public void Update(int key, int value)
        {
            bool found = false;
            for (int i = 0; i < bucket.Count; i++)
            {
                if (bucket[i].Item1.Equals(key))
                {
                    bucket[i] = new Tuple<int, int>(key, value);
                    found = true;
                }
            }

            if (!found)
                bucket.Add(new Tuple<int, int>(key, value));
        }

        public void Remove(int key)
        {
            bucket.RemoveAll(p => p.Item1.Equals(key));
        }
    }

    public class MyHashMap
    {
        private int size = 2069;
        private List<Bucket> hashMap = new List<Bucket>();
        

        /** Initialize your data structure here. */
        public MyHashMap()
        {
            for (int i = 0; i < size; i++)
            {
                hashMap.Add(new Bucket());
            }
        }

        /** value will always be non-negative. */
        public void Put(int key, int value) => hashMap[HashKey(key)].Update(key, value);

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key) => hashMap[HashKey(key)].Get(key);

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key) => hashMap[HashKey(key)].Remove(key);

        private int HashKey(int key) => key % size;
    }

    /**
     * Your MyHashMap object will be instantiated and called as such:
     * MyHashMap obj = new MyHashMap();
     * obj.Put(key,value);
     * int param_2 = obj.Get(key);
     * obj.Remove(key);
     */
}
