using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the entries.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the team that is the winner.
        /// </summary>
        public TeamModel Winner { get; set; }
        
        /// <summary>
        /// Represents the rounds.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
