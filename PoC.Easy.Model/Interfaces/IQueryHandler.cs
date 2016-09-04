using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC.Easy.Model.Interfaces
{
    public interface IQueryHandler<in TQuery, TResult>
    {
        TResult Execute(TQuery query);
        Task<TResult> ExecuteAsync(TQuery query);
    }
}
