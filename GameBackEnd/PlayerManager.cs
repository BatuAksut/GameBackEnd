using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackEnd
{
    public class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player))
            {
                Console.WriteLine("Player added");

            }

            else
            {
                Console.WriteLine("Validation failed.");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Player deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player updated.");
        }
    }
}
