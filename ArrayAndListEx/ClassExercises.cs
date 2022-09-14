using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListEx
{
    public class StackExercise
    {
        List<object> list;

        public StackExercise()
        {
            list = new List<object>();
        }

        public  void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException();
            }

            list.Add(obj);
        }

        public object Pop()
        {
            if(list.Count == 0)
            {
                throw new InvalidOperationException();
            }

            object obj = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);

            return obj;

        }

        public  void Clear()
        {
            list.Clear();
        }
    }
}
