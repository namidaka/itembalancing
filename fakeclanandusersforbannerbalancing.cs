private static Clan lOTR = new() { Id = 1, Name = "LOTR" };
private static Clan dBZ = new() { Id = 2, Name = "DBZ" };
private static Clan gilead = new() { Id = 3, Name = "Gilead" };
private static Clan poudlard = new() { Id = 4, Name = "Poudlard" };
private static Clan xMen = new() { Id = 5, Name = "X-MEN" };
private static Clan xMenVillain = new() { Id = 6, Name = "X-MEN Villains" };
private static Clan JeanJean = new() { Id = 7, Name = "JeanJean" };
private static Clan Glut = new() { Id = 8, Name = "Glut" };
private static Clan Vlex = new() { Id = 9, Name = "Vlex" };
private static Clan Hudahut = new() { Id = 10, Name = "Hudahut" };
private static Clan BlackBaronesses = new() { Id = 7, Name = "Black Baronesses" };
private static Clan NavyKnights = new() { Id = 8, Name = "Navy Knights" };
private static Clan PurplePeasants = new() { Id = 9, Name = "Purple Peasants" };
private static Clan RedRitters = new() { Id = 10, Name = "Red Ritters" };
private static Clan LemonLevies = new() { Id = 11, Name = "Lemon Levies" };
private static Clan ScarletShieldmaidens = new() { Id = 12, Name = "Scarlet Shieldmaidens" };


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
private static User Jean_01 = new() { Id = 21, Rating = 3000, ClanMembership = new ClanMember { UserId = 21, User = Jean_01, ClanId = 7, Clan = JeanJean } };
private static User Jean_02 = new() { Id = 22, Rating = 2500, ClanMembership = new ClanMember { UserId = 22, User = Jean_02, ClanId = 7, Clan = JeanJean } };
private static User Jean_03 = new() { Id = 23, Rating = 2100, ClanMembership = new ClanMember { UserId = 23, User = Jean_03, ClanId = 7, Clan = JeanJean } };
private static User Jean_04 = new() { Id = 24, Rating = 1200, ClanMembership = new ClanMember { UserId = 24, User = Jean_04, ClanId = 7, Clan = JeanJean } };
private static User Jean_05 = new() { Id = 25, Rating = 800, ClanMembership = new ClanMember { UserId = 25, User = Jean_05, ClanId = 7, Clan = JeanJean } };
private static User Glutentag_01 = new() { Id = 26, Rating = 900, ClanMembership = new ClanMember { UserId = 26, User = Glutentag_01, ClanId = 8, Clan = Glut } };
private static User Glutentag_02 = new() { Id = 27, Rating = 200, ClanMembership = new ClanMember { UserId = 27, User = Glutentag_02, ClanId = 8, Clan = Glut } };
private static User Glutentag_03 = new() { Id = 28, Rating = 2200, ClanMembership = new ClanMember { UserId = 28, User = Glutentag_03, ClanId = 8, Clan = Glut } };
private static User Glutentag_04 = new() { Id = 29, Rating = 400, ClanMembership = new ClanMember { UserId = 29, User = Glutentag_04, ClanId = 8, Clan = Glut } };
private static User Glutentag_05 = new() { Id = 30, Rating = 800, ClanMembership = new ClanMember { UserId = 30, User = Glutentag_05, ClanId = 8, Clan = Glut } };
private static User Vlexance_01 = new() { Id = 31, Rating = 2600, ClanMembership = new ClanMember { UserId = 31, User = Vlexance_01, ClanId = 9, Clan = Vlex } };
private static User Vlexance_02 = new() { Id = 32, Rating = 2300, ClanMembership = new ClanMember { UserId = 32, User = Vlexance_02, ClanId = 9, Clan = Vlex } };
private static User Vlexance_03 = new() { Id = 33, Rating = 1300, ClanMembership = new ClanMember { UserId = 33, User = Vlexance_03, ClanId = 9, Clan = Vlex } };
private static User Vlexance_04 = new() { Id = 34, Rating = 1100, ClanMembership = new ClanMember { UserId = 34, User = Vlexance_04, ClanId = 9, Clan = Vlex } };
private static User Vlexance_05 = new() { Id = 35, Rating = 300, ClanMembership = new ClanMember { UserId = 35, User = Vlexance_05, ClanId = 9, Clan = Vlex } };
private static User Hudax_01 = new() { Id = 36, Rating = 1900, ClanMembership = new ClanMember { UserId = 36, User = Hudax_01, ClanId = 10, Clan = Hudahut } };
private static User Hudax_02 = new() { Id = 37, Rating = 1700, ClanMembership = new ClanMember { UserId = 37, User = Hudax_02, ClanId = 10, Clan = Hudahut } };
private static User Hudax_03 = new() { Id = 38, Rating = 1300, ClanMembership = new ClanMember { UserId = 38, User = Hudax_03, ClanId = 10, Clan = Hudahut } };
private static User Hudax_04 = new() { Id = 39, Rating = 1400, ClanMembership = new ClanMember { UserId = 39, User = Hudax_04, ClanId = 10, Clan = Hudahut } };
private static User Hudax_05 = new() { Id = 40, Rating = 700, ClanMembership = new ClanMember { UserId = 40, User = Hudax_05, ClanId = 10, Clan = Hudahut } };
private static User GerryShepherd = new() { Id = 41, Rating = 2000, ClanMembership = new ClanMember { UserId = 21, User = GerryShepherd, ClanId = 7, Clan = BlackBaronesses } };
private static User BullyDog = new() { Id = 42, Rating = 1600, ClanMembership = new ClanMember { UserId = 22, User = BullyDog, ClanId = 7, Clan = BlackBaronesses } };
private static User LabbyRetriever = new() { Id = 43, Rating = 1500, ClanMembership = new ClanMember { UserId = 23, User = LabbyRetriever, ClanId = 7, Clan = BlackBaronesses } };
private static User GoldyRetriever = new() { Id = 44, Rating = 2000, ClanMembership = new ClanMember { UserId = 24, User = GoldyRetriever, ClanId = 8, Clan = NavyKnights } };
private static User SibbyHusky = new() { Id = 45, Rating = 1000, ClanMembership = new ClanMember { UserId = 25, User = SibbyHusky, ClanId = 8, Clan = NavyKnights } };
private static User Poodlums = new() { Id = 46, Rating = 2800, ClanMembership = new ClanMember { UserId = 26, User = Poodlums, ClanId = 9, Clan = PurplePeasants } };
private static User BordyCollie = new() { Id = 47, Rating = 2000, ClanMembership = new ClanMember { UserId = 27, User = BordyCollie, ClanId = 10, Clan = RedRitters } };
private static User Rottyweiler = new() { Id = 48, Rating = 2700, ClanMembership = new ClanMember { UserId = 28, User = Rottyweiler, ClanId = 11, Clan = LemonLevies } };
private static User Daschyhund = new() { Id = 49, Rating = 2800, ClanMembership = new ClanMember { UserId = 29, User = Daschyhund, ClanId = 12, Clan = ScarletShieldmaidens } };
private static User GreatieDane = new() { Id = 50, Rating = 1200 };
private static User YorkyTerrier = new() { Id = 51, Rating = 1300 };
private static User CockySpaniel = new() { Id = 52, Rating = 800 };
private static User Pomyranian = new() { Id = 53, Rating = 500 };
private static User Bullymastiff = new() { Id = 54, Rating = 1100 };
private static User JackyRussell = new() { Id = 55, Rating = 3500 };
private static User Akitayinu = new() { Id = 56, Rating = 2400 };
private static User Maltiepoo = new() { Id = 57, Rating = 2700 };
private static User Doberymann = new() { Id = 58, Rating = 1100 };
private static User Sheeiitzu = new() { Id = 59, Rating = 2400 };
private static User BassetyHound = new() { Id = 60, Rating = 600, ClanMembership = new ClanMember { UserId = 40, User = BassetyHound, ClanId = 10, Clan = Red Ritters } };
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
                ronWeasley,
                Jean_01,
                Jean_02,
                Jean_03,
                Jean_04,
                Jean_05,
                Glutentag_01,
                Glutentag_02,
                Glutentag_03,
                Glutentag_04,
                Glutentag_05,
                Vlexance_01,
                Vlexance_02,
                Vlexance_03,
                Vlexance_04,
                Vlexance_05,
                Hudax_01,
                Hudax_02,
                Hudax_03,
                Hudax_04,
                Hudax_05,
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
