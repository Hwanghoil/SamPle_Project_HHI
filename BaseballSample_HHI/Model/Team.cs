using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballSample_HHI.Model
{
    public class Team
    {
        public int Rank { get; set; }
        public string Group { get; set; }
        public int Games { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }
        public int A_draw { get; set; }
        public double Winning_rate { get; set; }
        public double Difference { get; set; }
        public string Continuity { get; set; }
        public double On_base_rate { get; set; }
        public double Slugging_percentage { get; set; }
        public string Recently { get; set; }
        
        public List<Team> GetMyTeamData()
        {
            var items = new List<Team>();
            items.Add(new Team
            {
                Rank = 1,
                Group = "NC",
                Games = 144,
                Win = 83,
                Loss = 55,
                A_draw = 6,
                Winning_rate = 0.601,
                Difference = 0.0,
                Continuity = "1패",
                On_base_rate = 0.366,
                Slugging_percentage = 0.462,
                Recently = "4승-4패-2무"
            });
            items.Add(new Team
            {
                Rank = 2,
                Group = "KT",
                Games = 144,
                Win = 81,
                Loss = 62,
                A_draw = 1,
                Winning_rate = 0.566,
                Difference = 4.5,
                Continuity = "1패",
                On_base_rate = 0.358,
                Slugging_percentage = 0.436,
                Recently = "7승-3패-0무"
            });
            items.Add(new Team
            {
                Rank = 3,
                Group = "LG",
                Games = 144,
                Win = 79,
                Loss = 61,
                A_draw = 4,
                Winning_rate = 0.564,
                Difference = 5.0,
                Continuity = "2패",
                On_base_rate = 0.349,
                Slugging_percentage = 0.428,
                Recently = "5승-4패-1무"
            });
            items.Add(new Team
            {
                Rank = 4,
                Group = "두산",
                Games = 144,
                Win = 79,
                Loss = 61,
                A_draw = 4,
                Winning_rate = 0.564,
                Difference = 5.0,
                Continuity = "4승",
                On_base_rate = 0.365,
                Slugging_percentage = 0.427,
                Recently = "6승-4패-0무"
            });
            items.Add(new Team
            {
                Rank = 5,
                Group = "키움",
                Games = 144,
                Win = 80,
                Loss = 63,
                A_draw = 1,
                Winning_rate = 0.559,
                Difference = 5.5,
                Continuity = "1패",
                On_base_rate = 0.355,
                Slugging_percentage = 0.408,
                Recently = "6승-4패-0무"
            });
            items.Add(new Team
            {
                Rank = 6,
                Group = "롯데",
                Games = 144,
                Win = 71,
                Loss = 72,
                A_draw = 1,
                Winning_rate = 0.497,
                Difference = 14.5,
                Continuity = "1승",
                On_base_rate = 0.353,
                Slugging_percentage = 0.408,
                Recently = "3승-7패-0무"
            });
            items.Add(new Team
            {
                Rank = 7,
                Group = "KIA",
                Games = 144,
                Win = 73,
                Loss = 71,
                A_draw = 0,
                Winning_rate = 0.507,
                Difference = 13.0,
                Continuity = "1승",
                On_base_rate = 0.351,
                Slugging_percentage = 0.404,
                Recently = "4승-6패-0무"
            });
            items.Add(new Team
            {
                Rank = 8,
                Group = "삼성",
                Games = 144,
                Win = 64,
                Loss = 75,
                A_draw = 5,
                Winning_rate = 0.460,
                Difference = 19.5,
                Continuity = "1승",
                On_base_rate = 0.338,
                Slugging_percentage = 0.394,
                Recently = "6승-2패-2무"
            });
            items.Add(new Team
            {
                Rank = 9,
                Group = "SK",
                Games = 144,
                Win = 51,
                Loss = 92,
                A_draw = 1,
                Winning_rate = 0.357,
                Difference = 34.5,
                Continuity = "1승",
                On_base_rate = 0.329,
                Slugging_percentage = 0.383,
                Recently = "5승-5패-0무"
            });
            items.Add(new Team
            {
                Rank = 10,
                Group = "한화",
                Games = 144,
                Win = 46,
                Loss = 95,
                A_draw = 3,
                Winning_rate = 0.326,
                Difference = 38.5,
                Continuity = "1승",
                On_base_rate = 0.320,
                Slugging_percentage = 0.338,
                Recently = "3승-6패-1무"
            });


            return items;
        }
    }
}
