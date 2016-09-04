using PoC.Easy.Dto.Roles;
using PoC.Easy.Dto.Roles.Queries;
using PoC.Easy.Dto.Users;
using PoC.Easy.Dto.Users.Queries;
using PoC.Easy.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC.Easy.Model
{
    public class MegaWorkContext
    {
        private readonly IQueryHandlerFactory _queryHandlerFactory;
        public MegaWorkContext(IQueryHandlerFactory queryHandlerFactory)
        {
            _queryHandlerFactory = queryHandlerFactory;


            //Здесь можно прикрутить асинхронщину и всё такое
            _users = new Lazy<UsersDto>(() =>
            {
                var defaultQueryHandler = _queryHandlerFactory.Create<AllUsersDefaultQuery, UsersDto>();
                return defaultQueryHandler.Execute(new AllUsersDefaultQuery());
            });

            _roles = new Lazy<RolesDto>(() =>
            {
                var defaultQueryHandler = _queryHandlerFactory.Create<AllRolesDefaultQuery, RolesDto>();
                return defaultQueryHandler.Execute(new AllRolesDefaultQuery());
            });
        }

        //Использование Lazy позволит подтягивать данные только тогда когда они реально используются.
        private Lazy<UsersDto> _users;
        public UsersDto Users
        {
            get { return _users.Value; }
            set { _users = new Lazy<UsersDto>(() => value); }
        }

        private Lazy<RolesDto> _roles;
        public RolesDto Roles
        {
            get { return _roles.Value; }
            set { _roles = new Lazy<RolesDto>(() => value); }
        }
    }
}
