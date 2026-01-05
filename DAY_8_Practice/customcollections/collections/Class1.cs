using System.Collections;

namespace collections{

public class MyCollection:IList
{
    private ArrayList _items=new ArrayList();
    public object? this[int index] {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index]=value;
            } 
        }

        public bool IsFixedSize => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public int Add(object? value)
        {
           return  _items.Add(value);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object? value)
        {
           return  _items.Contains(value);
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object? value)
        {
            for(int i=0;i<_items.Count;i++)
            {
                if(_items[i]==value)
                {
                    return i;
                }
            }
        }

        public void Insert(int index, object? value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object? value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

}
}
