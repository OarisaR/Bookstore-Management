using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assignment129
{
    public class Media<T>
    {
        public List<T> Mediaitems = new List<T>();
        public void Add(T media) => Mediaitems.Add(media);
        public void Update(T existing,T update)
        {
            int i = Mediaitems.IndexOf(existing);
            Mediaitems[i] = update;
        }
        public void Remove(T item)
        {
            Mediaitems.Remove(item);
        }
       


    }
}
