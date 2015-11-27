using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoveMove
{
    class OneRule : KnowledgeBase
    {

        public OneRule(string director, string season, string production, string genre, string grade, string distributor)
            : base(director, season, production, genre, grade, distributor)
        {
            
        }
    }
}
