using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Attendance
{
    class Storing<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> People; // for storing our People );

        public TValue this[TKey key] { get => People[key]; set => People[key] = value; } // init our Instance

        public ICollection<TKey> Keys => throw new NotImplementedException();

        public ICollection<TValue> Values => throw new NotImplementedException();


        public int Count => People.Count();

        public bool IsReadOnly => false; //becouse we are goint to add new users

        public Storing()
        {
            People = new Dictionary<TKey, TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            People.Add(key, value);
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            People.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            People.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            if (People.Contains(item))
            {
                return true;
            }
            return false;
        }

        public bool ContainsKey(TKey key)
        {
            if (People.ContainsKey(key))
            {
                return true;
            }
            return false;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            var copyTo = Keys.ToList();
            for (int i = 0; i < People.Count; ++i)
            {
                var currentKey = copyTo[i];
                var currentValue = People[copyTo[i]];
                array[i] = new KeyValuePair<TKey, TValue>(currentKey, currentValue);

            }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return People.GetEnumerator();
        }

        public bool Remove(TKey key)
        {
            People.Remove(key);
            return true;
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            bool Removed = Remove(item.Key);
            return Removed;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (!People.ContainsKey(key))
            {
              //  value = null ;
              //  return false;
            }
            value = People[key];
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
