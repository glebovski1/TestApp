using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.Services
{
    public class MassageStorageService
    {
        public MassageContainer CammonMassageContainer {get;set;}

        public Dictionary<string, MassageContainer> MassageContainersForIndividualUsers { get; set; }

        private int MaxSizeForCammon = 20;

        private int MaxSizeForIndividual = 10;

        public MassageStorageService()
        {
            CammonMassageContainer = new MassageContainer(MaxSizeForCammon);
            MassageContainersForIndividualUsers =new Dictionary<string, MassageContainer>();
        }

        public void SetMassage(string userId, string text)
        {
            Massage massage = new Massage()
            {
                DateTime = DateTime.UtcNow,
                Text = text

            };
            CammonMassageContainer.AddMassage(userId, massage);

            if(!(MassageContainersForIndividualUsers.ContainsKey(userId)))
            {
                MassageContainersForIndividualUsers.Add(userId, new MassageContainer(MaxSizeForIndividual));
                MassageContainersForIndividualUsers[userId].AddMassage(userId, massage);
            }
            else
            {
                MassageContainersForIndividualUsers[userId].AddMassage(userId, massage);
            }
                
        }

        public List<KeyValuePair<string, Massage>> GetMassage()
        {
           return CammonMassageContainer.GetListOfMassageWithUserId();
        }

        public List<KeyValuePair<string, Massage>> GetMassage(string userId)
        {
            return MassageContainersForIndividualUsers[userId].GetListOfMassageWithUserId();
        }

        public List<KeyValuePair<string, Massage>> GetMassageSortedById()
        {
           var massages =  CammonMassageContainer.GetListOfMassageWithUserIdSortedById();
           
            return massages;
        }

        public List<KeyValuePair<string, Massage>> GetMassageSortedById(string userId)
        {
            return MassageContainersForIndividualUsers[userId].GetListOfMassageWithUserIdSortedById();
        }
        public List<KeyValuePair<string, Massage>> GetMassageSortedByDate()
        {
            return CammonMassageContainer.GetListOfMassageWithUserIdSortedByDate();
        }

        public List<KeyValuePair<string, Massage>> GetMassageSortedByDate(string userId)
        {
            return MassageContainersForIndividualUsers[userId].GetListOfMassageWithUserIdSortedByDate();
        }

    }
}
