using System;
namespace MAUIUI.Core.Entities
{
    public interface IEntity
    {
        public Dictionary<string, Func<string, object>> Mapping();
    }
}

