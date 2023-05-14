using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Game game, Campaign campaign)
        {
            Console.WriteLine("Kampanya oluşturuldu: " + game.Name + " " +  campaign.Name);
        }

        public void Delete(Game game, Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi: "+ game.Name + " " + campaign.Name);
        }

        public void Update(Game game, Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi: " + game.Name + " " + campaign.Name);
        }
    }
}
