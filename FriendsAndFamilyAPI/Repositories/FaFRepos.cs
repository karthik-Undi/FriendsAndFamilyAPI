using FriendsAndFamilyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendsAndFamilyAPI.Repositories
{
    public class FaFRepos: IFaFRepos
    {
        private readonly CommunityGateDatabaseContext _context;

        public FaFRepos()
        {

        }

        public FaFRepos(CommunityGateDatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<FriendsAndFamily> GetAllFriendsAndFamily()
        {
            return _context.FriendsAndFamily.ToList();
        }

        public IEnumerable<FriendsAndFamily> GetFriendsAndFamilybyResidentId(int id)
        {
            return _context.FriendsAndFamily.Where(f=>f.ResidentId==id).ToList();
        }

        public async Task<FriendsAndFamily> PostFriendsAndFamily(FriendsAndFamily item)
        {
            FriendsAndFamily faf = null;
            if (item == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                faf = new FriendsAndFamily() {
                    FaFname = item.FaFname,
                    Relation = item.Relation,
                    ResidentId = item.ResidentId
                };
                await _context.FriendsAndFamily.AddAsync(faf);
                await _context.SaveChangesAsync();
            }
            return faf;
        }
    }
}
