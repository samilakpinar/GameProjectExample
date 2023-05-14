// See https://aka.ms/new-console-template for more information
using GameProject.Concrete;
using GameProject.Entites;

Console.WriteLine("Hello, World!");

Gamer gamer = new Gamer()
{
    Id = 1,
    Name = "Şamil",
    Surname = "Akpınar",
    Tckn = "22448574149",
    BirthOfYear = 2000,
};


Game game = new Game()
{
    Id = 1,
    Name = "Süper mario",
    Description = "Mario ile maceralara hazır ol",
    Price = 10,
    Provider = "Riot Games",
    RelaseDate = DateTime.Today,
};


Campaign campaign = new Campaign()
{
    Id = 1,
    Name = "Kış indirimleri",
    Description = "Her ürün için geçerlidir.",
    CampaignDiscount = "%25"
};


GamerManager gamerManager = new GamerManager(new CheckRealPersonManager());
gamerManager.Add(gamer);
gamerManager.Update(gamer);
gamerManager.Delete(gamer);

Console.WriteLine("--------------------------------------");

GameManager gameManager = new GameManager();
gameManager.Sell(gamer, game);


Console.WriteLine("---------------------------------------");

CampaignManager campaignManager = new CampaignManager();
campaignManager.Add(game, campaign);
campaignManager.Update(game,campaign);
campaignManager.Delete(game,campaign);

