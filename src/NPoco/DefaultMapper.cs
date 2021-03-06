using System;
using System.Reflection;

namespace NPoco
{
    public abstract class DefaultMapper : IMapper2
    {
        public virtual void GetTableInfo(Type t, TableInfo ti) { }
        public virtual bool MapPropertyToColumn(PropertyInfo pi, ref string columnName, ref bool resultColumn)
        {
            return true;
        }
        public virtual Func<object, object> GetFromDbConverter(PropertyInfo pi, Type SourceType)
        {
            return GetFromDbConverter(pi.PropertyType, SourceType);
        }
        public virtual Func<object, object> GetToDbConverter(Type SourceType)
        {
            return null;
        }
        public virtual Func<object, object> GetFromDbConverter(Type DestType, Type SourceType)
        {
            return null;
        }
    }
}