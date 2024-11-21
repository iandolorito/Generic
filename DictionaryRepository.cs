using System.Collections.Generic;

namespace GENERIC
{
    public class DictionaryRepository<TKey, TValue>
    {
        private Dictionary<TKey, TValue> data = new Dictionary<TKey, TValue>();

        public void Create(TKey key, TValue value) => data[key] = value;

        public TValue Read(TKey key) => data.ContainsKey(key) ? data[key] : default;

        public Dictionary<TKey, TValue> ReadAll() => new Dictionary<TKey, TValue>(data);

        public void Update(TKey key, TValue newValue)
        {
            if (data.ContainsKey(key)) data[key] = newValue;
        }

        public void Delete(TKey key) => data.Remove(key);
        public bool ContainsKey(TKey key)
        {
            return data.ContainsKey(key);
        }
        public void Add(TKey key, TValue value)
        {
            data[key] = value;
        }
        public TValue Get(TKey key)
        {
            if(!data.ContainsKey(key)) 
                throw new KeyNotFoundException( $"No item found in the key {key}");
            return data[key];
        }
    }
}
