using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC.Easy.Model.Interfaces
{
    //Реализация фабрики может быть любой.
    //Самый удобный вариант, на мой взгляд, используюя какой-либо DI контейнер.
    public interface IQueryHandlerFactory
    {
        IQueryHandler<TQuery, TResult> Create<TQuery, TResult>();
    }
}
