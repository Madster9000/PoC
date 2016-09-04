using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoC.Easy.Dto.Users
{
    public class UsersDto
    {
        public ICollection<UserDto> Users { get; set; }
    }
}
