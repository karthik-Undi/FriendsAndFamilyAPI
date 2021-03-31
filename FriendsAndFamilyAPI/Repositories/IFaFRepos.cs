using FriendsAndFamilyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsAndFamilyAPI.Repositories
{
    public interface IFaFRepos
    {
        public IEnumerable<FriendsAndFamily> GetAllFriendsAndFamily();
        public IEnumerable<FriendsAndFamily> GetFriendsAndFamilybyResidentId(int id);
        public Task<FriendsAndFamily> PostFriendsAndFamily(FriendsAndFamily item);


    }
}
