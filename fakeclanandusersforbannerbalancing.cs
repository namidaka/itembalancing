private static Clan lOTR = new() { Id = 1, Name = "LOTR" };
private static Clan dBZ = new() { Id = 2, Name = "DBZ" };
private static Clan gilead = new() { Id = 3, Name = "Gilead" };
private static Clan poudlard = new() { Id = 4, Name = "Poudlard" };
private static Clan xMen = new() { Id = 5, Name = "X-MEN" };
private static Clan xMenVillain = new() { Id = 6, Name = "X-MEN Villains" };

private static User arwen = new() { Id = 1, Rating = 2000, ClanMembership = new ClanMember { UserId = 1, User = arwen, ClanId = 1, Clan = lOTR } };
private static User frodon = new() { Id = 2, Rating = 1600, ClanMembership = new ClanMember { UserId = 2, User = frodon, ClanId = 1, Clan = lOTR } };
private static User sam = new() { Id = 3, Rating = 1500, ClanMembership = new ClanMember { UserId = 3, User = sam, ClanId = 1, Clan = lOTR } };
private static User sangoku = new() { Id = 4, Rating = 2000, ClanMembership = new ClanMember { UserId = 4, User = sangoku, ClanId = 2, Clan = dBZ } };
private static User krilin = new() { Id = 5, Rating = 1000, ClanMembership = new ClanMember { UserId = 5, User = krilin, ClanId = 2, Clan = dBZ } };
private static User rolandDeschain = new() { Id = 6, Rating = 2800, ClanMembership = new ClanMember { UserId = 6, User = rolandDeschain, ClanId = 3, Clan = gilead } };
private static User harryPotter = new() { Id = 7, Rating = 2000, ClanMembership = new ClanMember { UserId = 7, User = harryPotter, ClanId = 4, Clan = poudlard } };
private static User magneto = new() { Id = 8, Rating = 2700, ClanMembership = new ClanMember { UserId = 8, User = magneto, ClanId = 6, Clan = xMenVillain } };
private static User profCharles = new() { Id = 9, Rating = 2800, ClanMembership = new ClanMember { UserId = 9, User = profCharles, ClanId = 5, Clan = xMen } };
private static User usainBolt = new() { Id = 10, Rating = 1200 };
private static User agent007 = new() { Id = 11, Rating = 1300 };
private static User spongeBob = new() { Id = 12, Rating = 800 };
private static User patrick = new() { Id = 13, Rating = 500 };
private static User madonna = new() { Id = 14, Rating = 1100 };
private static User laraCroft = new() { Id = 15, Rating = 3500 };
private static User jeanneDArc = new() { Id = 16, Rating = 2400 };
private static User merlin = new() { Id = 17, Rating = 2700 };
private static User bob = new() { Id = 18, Rating = 1100 };
private static User thomas = new() { Id = 19, Rating = 2400 };
private static User ronWeasley = new() { Id = 20, Rating = 600, ClanMembership = new ClanMember { UserId = 7, User = ronWeasley, ClanId = 4, Clan = poudlard } };
private GameMatch game1 = new()
{
    TeamA = new List<User> { },
    TeamB = new List<User> { },
    Waiting = new List<User>
            {
                arwen,
                frodon,
                sam,
                sangoku,
                krilin,
                rolandDeschain,
                harryPotter,
                magneto,
                profCharles,
                usainBolt,
                agent007,
                spongeBob,
                patrick,
                madonna,
                laraCroft,
                jeanneDArc,
                merlin,
                bob,
                thomas,
                ronWeasley
            },
};
	private static Clan Black Baronesses = new(){ Id = 7, Name = "Black Baronesses" };
        private static Clan Navy Knights =new(){ Id = 8, Name = "Navy Knights" };
        private static Clan Purple Peasants =new(){ Id = 9, Name = "Purple Peasants" };
        private static Clan Red Ritters =new(){ Id = 10, Name = "Red Ritters" };
        private static Clan Lemon Levies =new(){ Id = 11, Name = "Lemon Levies" };
        private static Clan Scarlet Shieldmaidens =new(){ Id = 12, Name = "Scarlet Shieldmaidens" };

        private static User GerryShepherd =new(){ Id = 21, Rating = 2000, ClanMembership = new ClanMember { UserId = 21, User = GerryShepherd, ClanId = 7, Clan = Black Baronesses } };
        private static User BullyDog =new(){ Id = 22, Rating = 1600, ClanMembership = new ClanMember { UserId = 22, User = BullyDog, ClanId = 7, Clan = Black Baronesses } };
        private static User LabbyRetriever =new(){ Id = 23, Rating = 1500, ClanMembership = new ClanMember { UserId = 23, User = LabbyRetriever, ClanId = 7, Clan = Black Baronesses } };
        private static User GoldyRetriever =new(){ Id = 24, Rating = 2000, ClanMembership = new ClanMember { UserId = 24, User = GoldyRetriever, ClanId = 8, Clan = Navy Knights } };
        private static User SibbyHusky =new(){ Id = 25, Rating = 1000, ClanMembership = new ClanMember { UserId = 25, User = SibbyHusky, ClanId = 8, Clan = Navy Knights } };
        private static User Poodlums =new(){ Id = 26, Rating = 2800, ClanMembership = new ClanMember { UserId = 26, User = Poodlums, ClanId = 9, Clan = Purple Peasants } };
        private static User BordyCollie =new(){ Id = 27, Rating = 2000, ClanMembership = new ClanMember { UserId = 27, User = BordyCollie, ClanId = 10, Clan = Red Ritters } };
        private static User Rottyweiler =new(){ Id = 28, Rating = 2700, ClanMembership = new ClanMember { UserId = 28, User = Rottyweiler, ClanId = 11, Clan = Lemon Levies } };
        private static User Daschyhund =new(){ Id = 29, Rating = 2800, ClanMembership = new ClanMember { UserId = 29, User = Daschyhund, ClanId = 12, Clan = Scarlet Shieldmaidens } };
        private static User GreatieDane =new(){ Id = 30, Rating = 1200 };
        private static User YorkyTerrier =new(){ Id = 31, Rating = 1300 };
        private static User CockySpaniel =new(){ Id = 32, Rating = 800 };
        private static User Pomyranian =new(){ Id = 33, Rating = 500 };
        private static User Bullymastiff =new(){ Id = 34, Rating = 1100 };
        private static User JackyRussell =new(){ Id = 35, Rating = 3500 };
        private static User Akitayinu =new(){ Id = 36, Rating = 2400 };
        private static User Maltiepoo =new(){ Id = 37, Rating = 2700 };
        private static User Doberymann =new(){ Id = 38, Rating = 1100 };
        private static User Sheeiitzu =new(){ Id = 39, Rating = 2400 };
        private static User BassetyHound = new() { Id = 40, Rating = 600, ClanMembership = new ClanMember { UserId = 40, User = BassetyHound, ClanId = 4, Clan = Red Ritters } };
        private GameMatch game1 = new()
        {
            TeamA = new List<User> { },
            TeamB = new List<User> { },
            Waiting = new List<User>
            {
                GerryShepherd,
                BullyDog,
                LabbyRetriever,
                GoldyRetriever,
                SibbyHusky,
                Poodlums,
                BordyCollie,
                Rottyweiler,
                Daschyhund,
                GreatieDane,
                YorkyTerrier,
                CockySpaniel,
                Pomyranian,
                Bullymastiff,
                JackyRussell,
                Akitayinu,
                Maltiepoo,
                Doberymann,
                Sheeiitzu,
                BassetyHound
            },
        };
