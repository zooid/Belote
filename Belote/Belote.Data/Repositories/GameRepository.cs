using Belote.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belote.Data.Repositories
{
    public class GameRepository : GenericRepository<Game>, IRepository<Game>
    {
        public GameRepository(DbContext context)
            :base(context)
        {
        }

        public override void Add(Game entity)
        {
            if(entity.FirstTeam.Count() != 2 || entity.SecondTeam.Count() != 2)
            {
                throw new ApplicationException("Teams must be consisted of two players");
            }

            base.Add(entity);
        }
    }
}
