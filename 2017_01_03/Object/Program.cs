using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public class Object
    {
        public Object();
        public virtual bool Equals(object obj);
        public static bool Equals(object objA, object objB);
        public virtual int GenHashCode();
        public Type GetType();
        protected object MemberwiseClone();
        public static bool ReferenceEquals(object objA, object objB);
        public virtual string ToString();
    }
}
