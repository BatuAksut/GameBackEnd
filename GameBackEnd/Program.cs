using GameBackEnd;

Player player1 = new Player();
player1.FirstName = "Batuhan";
player1.LastName = "Aksüt";
player1.BirthYear = 1998;
player1.IdentityNumber = 12345;

PlayerManager playerManager = new PlayerManager(new UserValidationManager());

playerManager.Add(player1);