using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballSample_HHI.Model
{
    class Batter_Rank
    {
        public int B_Rank { get; set; }
        public String B_Player { get; set; }
        public double B_Average { get; set; }
        public int B_Games { get; set; }
        public String B_Innings { get; set; }
        public int B_Win { get; set; }
        public int B_Loss { get; set; }
        public int B_Save { get; set; }
        public int B_Hold { get; set; }
        public int B_Strikeout { get; set; }
        public int B_Hits { get; set; }
        public int B_Homerun { get; set; }
        public int B_Concession { get; set; }
        public int B_Walk { get; set; }
        public int B_deadball { get; set; }
        public double B_odds { get; set; }

        public List<Batter_Rank> GetMyBatterData()
        {
            var items = new List<Batter_Rank>();
            items.Add(new Batter_Rank
            {
                B_Rank = 1,
                B_Player = "요키시 (키움)",
                B_Average = 2.14,
                B_Games = 27,
                B_Innings = "159 2/3",
                B_Win = 12,
                B_Loss = 7,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 115,
                B_Hits = 144,
                B_Homerun = 6,
                B_Concession = 53,
                B_Walk = 25,
                B_deadball = 6,
                B_odds = 0.632
            });

            items.Add(new Batter_Rank
            {
                B_Rank = 2,
                B_Player = "스트레일리 (롯데)",
                B_Average = 2.50,
                B_Games = 31,
                B_Innings = "194 2/3",
                B_Win = 15,
                B_Loss = 4,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 205,
                B_Hits = 148,
                B_Homerun = 10,
                B_Concession = 61,
                B_Walk = 51,
                B_deadball = 7,
                B_odds = 0.790
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 3,
                B_Player = "브룩스 (기아)",
                B_Average = 2.50,
                B_Games = 23,
                B_Innings = "151 1/3",
                B_Win = 11,
                B_Loss = 4,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 130,
                B_Hits = 131,
                B_Homerun = 4,
                B_Concession = 43,
                B_Walk = 24,
                B_deadball = 3,
                B_odds = 0.733
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 4,
                B_Player = "알칸타라 (두산)",
                B_Average = 2.54,
                B_Games = 31,
                B_Innings = "198 1/3",
                B_Win = 20,
                B_Loss = 2,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 182,
                B_Hits = 174,
                B_Homerun = 12,
                B_Concession = 58,
                B_Walk = 30,
                B_deadball = 9,
                B_odds = 0.909
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 5,
                B_Player = "루친스키 (NC)",
                B_Average = 3.05,
                B_Games = 30,
                B_Innings = "183",
                B_Win = 19,
                B_Loss = 5,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 167,
                B_Hits = 173,
                B_Homerun = 14,
                B_Concession = 67,
                B_Walk = 52,
                B_deadball = 11,
                B_odds = 0.792
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 6,
                B_Player = "켈리 (LG)",
                B_Average = 3.32,
                B_Games = 28,
                B_Innings = "173 1/3",
                B_Win = 15,
                B_Loss = 7,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 134,
                B_Hits = 160,
                B_Homerun = 16,
                B_Concession = 67,
                B_Walk = 40,
                B_deadball = 11,
                B_odds = 0.682
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 7,
                B_Player = "뷰캐넌 (삼성)",
                B_Average = 3.45,
                B_Games = 27,
                B_Innings = "174 2/3",
                B_Win = 15,
                B_Loss = 7,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 121,
                B_Hits = 172,
                B_Homerun = 16,
                B_Concession = 71,
                B_Walk = 50,
                B_deadball = 7,
                B_odds = 0.682
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 8,
                B_Player = "뷰캐넌 (삼성)",
                B_Average = 3.45,
                B_Games = 27,
                B_Innings = "174 2/3",
                B_Win = 15,
                B_Loss = 7,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 123,
                B_Hits = 131,
                B_Homerun = 12,
                B_Concession = 67,
                B_Walk = 51,
                B_deadball = 7,
                B_odds = 0.647
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 9,
                B_Player = "문승원 (SK)",
                B_Average = 3.65,
                B_Games = 25,
                B_Innings = "145 2/3",
                B_Win = 6,
                B_Loss = 8,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 117,
                B_Hits = 136,
                B_Homerun = 13,
                B_Concession = 64,
                B_Walk = 45,
                B_deadball = 6,
                B_odds = 0.429
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 10,
                B_Player = "임찬규 (LG)",
                B_Average = 4.08,
                B_Games = 27,
                B_Innings = "147 2/3",
                B_Win = 10,
                B_Loss = 9,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 138,
                B_Hits = 143,
                B_Homerun = 14,
                B_Concession = 76,
                B_Walk = 65,
                B_deadball = 5,
                B_odds = 0.526
            });

            items.Add(new Batter_Rank
            {
                B_Rank = 11,
                B_Player = "쿠에바스 (KT)",
                B_Average = 4.10,
                B_Games = 27,
                B_Innings = "158",
                B_Win = 10,
                B_Loss = 8,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 110,
                B_Hits = 152,
                B_Homerun = 16,
                B_Concession = 80,
                B_Walk = 46,
                B_deadball = 9,
                B_odds = 0.556
            });

            items.Add(new Batter_Rank
            {
                B_Rank = 12,
                B_Player = "데스파이네 (KT)",
                B_Average = 4.33,
                B_Games = 35,
                B_Innings = "207 2/3",
                B_Win = 15,
                B_Loss = 8,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 152,
                B_Hits = 233,
                B_Homerun = 18,
                B_Concession = 105,
                B_Walk = 68,
                B_deadball = 8,
                B_odds = 0.652
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 13,
                B_Player = "가뇽 (KIA)",
                B_Average = 4.34,
                B_Games = 28,
                B_Innings = "159 2/3",
                B_Win = 11,
                B_Loss = 8,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 152,
                B_Hits = 233,
                B_Homerun = 18,
                B_Concession = 105,
                B_Walk = 68,
                B_deadball = 8,
                B_odds = 0.652
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 14,
                B_Player = "윌슨 (LG)",
                B_Average = 4.42,
                B_Games = 25,
                B_Innings = "144 2/3",
                B_Win = 10,
                B_Loss = 8,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 109,
                B_Hits = 161,
                B_Homerun = 13,
                B_Concession = 81,
                B_Walk = 39,
                B_deadball = 8,
                B_odds = 0.556
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 15,
                B_Player = "라이트 (NC)",
                B_Average = 4.68,
                B_Games = 29,
                B_Innings = "157 2/3",
                B_Win = 11,
                B_Loss = 9,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 125,
                B_Hits = 164,
                B_Homerun = 12,
                B_Concession = 87,
                B_Walk = 63,
                B_deadball = 10,
                B_odds = 0.550
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 16,
                B_Player = "양현종 (KIA)",
                B_Average = 4.70,
                B_Games = 31,
                B_Innings = "172 1/3",
                B_Win = 11,
                B_Loss = 10,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 149,
                B_Hits = 180,
                B_Homerun = 13,
                B_Concession = 99,
                B_Walk = 64,
                B_deadball = 5,
                B_odds = 0.524
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 17,
                B_Player = "박세웅 (롯데)",
                B_Average = 4.70,
                B_Games = 28,
                B_Innings = "147 1/3",
                B_Win = 8,
                B_Loss = 10,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 108,
                B_Hits = 177,
                B_Homerun = 20,
                B_Concession = 85,
                B_Walk = 47,
                B_deadball = 8,
                B_odds = 0.444
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 18,
                B_Player = "박종훈 (롯데)",
                B_Average = 4.81,
                B_Games = 29,
                B_Innings = "157 1/3",
                B_Win = 13,
                B_Loss = 11,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 134,
                B_Hits = 146,
                B_Homerun = 14,
                B_Concession = 90,
                B_Walk = 78,
                B_deadball = 22,
                B_odds = 0.542
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 19,
                B_Player = "서폴드 (한화)",
                B_Average = 4.91,
                B_Games = 28,
                B_Innings = "165",
                B_Win = 10,
                B_Loss = 13,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 97,
                B_Hits = 203,
                B_Homerun = 19,
                B_Concession = 107,
                B_Walk = 42,
                B_deadball = 13,
                B_odds = 0.435
            });
            items.Add(new Batter_Rank
            {
                B_Rank = 20,
                B_Player = "핀토 (SK)",
                B_Average = 6.17,
                B_Games = 30,
                B_Innings = "162",
                B_Win = 6,
                B_Loss = 15,
                B_Save = 0,
                B_Hold = 0,
                B_Strikeout = 112,
                B_Hits = 198,
                B_Homerun = 19,
                B_Concession = 121,
                B_Walk = 90,
                B_deadball = 11,
                B_odds = 0.286
            });
            return items;

            }
    }
}
