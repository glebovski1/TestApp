using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class MassageContainer
    {
        public int MaxSize { get; set; }
        List<KeyValuePair<string, Massage>> ListOfMassageWithUserId { get; set; }

        public MassageContainer(int maxSize)
        {
            MaxSize = maxSize;
            ListOfMassageWithUserId = new List<KeyValuePair<string, Massage>>();
            
        }

        public void AddMassage(string userId, Massage massage)
        {
           
            if (ListOfMassageWithUserId.Count == MaxSize)
            {
                ListOfMassageWithUserId.RemoveAt(MaxSize);
                ListOfMassageWithUserId.Add(new KeyValuePair<string, Massage>(userId, massage));
            }
            if (ListOfMassageWithUserId.Count < MaxSize)
            {
                ListOfMassageWithUserId.Add(new KeyValuePair<string, Massage>(userId, massage));
            }
        }

        public List<KeyValuePair<string, Massage>> GetListOfMassageWithUserId()
        {
            return ListOfMassageWithUserId;

        }

        public List<KeyValuePair<string, Massage>> GetListOfMassageWithUserIdSortedById()
        {
            var unsortedList = ListOfMassageWithUserId;
            var sortedList = unsortedList.OrderBy( pair => pair.Key).ToList();
            return sortedList;
        }

        public List<KeyValuePair<string, Massage>> GetListOfMassageWithUserIdSortedByDate()
        {
            var unsortedList = ListOfMassageWithUserId;
            var sortedList = unsortedList.OrderBy(pair => pair.Value.DateTime).ToList();
            return sortedList;
        }
    }
}
