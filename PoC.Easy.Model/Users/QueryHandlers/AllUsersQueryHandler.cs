using PoC.Easy.Dto.Users;
using PoC.Easy.Dto.Users.Queries;
using PoC.Easy.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC.Easy.Model.Users.QueryHandlers
{
    public class AllUsersQueryHandler : IQueryHandler<AllUsersQuery, MegaWorkContext>
    {
        private readonly IQueryHandlerFactory _queryHandlerFactory;
        public AllUsersQueryHandler(IQueryHandlerFactory queryHandlerFactory)
        {
            _queryHandlerFactory = queryHandlerFactory;
        }
        public MegaWorkContext Execute(AllUsersQuery query)
        {
            //Здесь сложная инициализация контекста и выборки из хранилища
            var users = new UsersDto();

            //Тут правило мепинга конкретной сущности на поле контекста. Меппинг может быть сложнее чем простое присвоение.
            //Сложные правила меппинга можно спрятать за отдельным интерфейсом IMapper<TSource, TDest>
            return new MegaWorkContext(_queryHandlerFactory)
            {
                Users = users
            };
        }

        public Task<MegaWorkContext> ExecuteAsync(AllUsersQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
