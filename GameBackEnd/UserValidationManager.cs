using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEnd
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if(player.BirthYear==1998 && player.FirstName=="Batuhan"&&player.LastName=="Aksüt" &&player.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
