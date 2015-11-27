using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoveMove
{
    interface KnowledgeBase
    {
        private string director;
        private string season;
        private string production;
        private string genre;
        private string grade;
        private string distributor;

        private string result;

        public KnowledgeBase(string director, string season, string production, string genre, string grade, string distributor)
        {
            this.director = director;
            this.season = season;
            this.production = production;
            this.genre = genre;
            this.grade = grade;
            this.distributor = distributor;
        }

        public string getResult();
    }
}
