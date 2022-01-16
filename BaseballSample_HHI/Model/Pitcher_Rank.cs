using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballSample_HHI.Model
{
    class Pitcher_Rank
    {
        public int P_rank { get; set; }
        public string P_player { get; set; }
        public double P_Batting_average { get; set; }
        public int P_games { get; set; }
        public int P_steersman { get; set; }
        public int P_hit { get; set; }
        public int P_double { get; set; }
        public int P_triple { get; set; }
        public int P_homerun { get; set; }
        public int P_RBI { get; set; }
        public int P_score { get; set; }
        public int P_theft { get; set; }
        public int P_Walk { get; set; }
        public int P_strikeout { get; set; }
        public double P_OBS { get; set; }
        public double P_SP { get; set; }

        public List<Pitcher_Rank> GetMyPitcherData()
        {
            var items = new List<Pitcher_Rank>();
            items.Add(new Pitcher_Rank
            {
                P_rank = 1,
                P_player = "최형우 (기아)",
                P_Batting_average = 0.354,
                P_games = 140,
                P_steersman = 522,
                P_hit = 185,
                P_double = 37,
                P_triple = 1,
                P_homerun = 28,
                P_RBI = 115,
                P_score = 93,
                P_theft = 0,
                P_Walk = 70,
                P_strikeout = 101,
                P_OBS = 0.433,
                P_SP = 0.590
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 2,
                P_player = "손아섭 (롯데)",
                P_Batting_average = 0.352,
                P_games = 141,
                P_steersman = 540,
                P_hit = 190,
                P_double = 43,
                P_triple = 0,
                P_homerun = 11,
                P_RBI = 85,
                P_score = 98,
                P_theft = 5,
                P_Walk = 61,
                P_strikeout = 56,
                P_OBS = 0.415,
                P_SP = 0.493
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 3,
                P_player = "로하스 (KT)",
                P_Batting_average = 0.349,
                P_games = 142,
                P_steersman = 550,
                P_hit = 192,
                P_double = 39,
                P_triple = 1,
                P_homerun = 47,
                P_RBI = 135,
                P_score = 116,
                P_theft = 0,
                P_Walk = 65,
                P_strikeout = 132,
                P_OBS = 0.417,
                P_SP = 0.680
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 4,
                P_player = "박민우 (NC)",
                P_Batting_average = 0.345,
                P_games = 126,
                P_steersman = 467,
                P_hit = 161,
                P_double = 27,
                P_triple = 5,
                P_homerun = 8,
                P_RBI = 63,
                P_score = 82,
                P_theft = 13,
                P_Walk = 36,
                P_strikeout = 48,
                P_OBS = 0.402,
                P_SP = 0.475
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 5,
                P_player = "페르난데스 (두산)",
                P_Batting_average = 0.340,
                P_games = 144,
                P_steersman = 586,
                P_hit = 199,
                P_double = 29,
                P_triple = 0,
                P_homerun = 21,
                P_RBI = 105,
                P_score = 104,
                P_theft = 0,
                P_Walk = 58,
                P_strikeout = 42,
                P_OBS = 0.404,
                P_SP = 0.497
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 6,
                P_player = "이정후 (키움)",
                P_Batting_average = 0.333,
                P_games = 140,
                P_steersman = 544,
                P_hit = 181,
                P_double = 49,
                P_triple = 5,
                P_homerun = 15,
                P_RBI = 101,
                P_score = 85,
                P_theft = 12,
                P_Walk = 59,
                P_strikeout = 47,
                P_OBS = 0.397,
                P_SP = 0.524
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 7,
                P_player = "허경민 (두산)",
                P_Batting_average = 0.332,
                P_games = 117,
                P_steersman = 437,
                P_hit = 145,
                P_double = 25,
                P_triple = 1,
                P_homerun = 7,
                P_RBI = 58,
                P_score = 70,
                P_theft = 14,
                P_Walk = 35,
                P_strikeout = 28,
                P_OBS = 0.382,
                P_SP = 0.442
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 8,
                P_player = "심현수 (LG)",
                P_Batting_average = 0.331,
                P_games = 142,
                P_steersman = 547,
                P_hit = 181,
                P_double = 35,
                P_triple = 2,
                P_homerun = 22,
                P_RBI = 119,
                P_score = 98,
                P_theft = 0,
                P_Walk = 63,
                P_strikeout = 53,
                P_OBS = 0.397,
                P_SP = 0.523
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 9,
                P_player = "강백호 (KT)",
                P_Batting_average = 0.330,
                P_games = 129,
                P_steersman = 500,
                P_hit = 165,
                P_double = 36,
                P_triple = 1,
                P_homerun = 23,
                P_RBI = 89,
                P_score = 95,
                P_theft = 7,
                P_Walk = 66,
                P_strikeout = 93,
                P_OBS = 0.411,
                P_SP = 0.544
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 10,
                P_player = "양의지 (NC)",
                P_Batting_average = 0.328,
                P_games = 130,
                P_steersman = 461,
                P_hit = 151,
                P_double = 26,
                P_triple = 1,
                P_homerun = 33,
                P_RBI = 124,
                P_score = 86,
                P_theft = 5,
                P_Walk = 46,
                P_strikeout = 47,
                P_OBS = 0.400,
                P_SP = 0.603
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 11,
                P_player = "나성범 (NC)",
                P_Batting_average = 0.324,
                P_games = 130,
                P_steersman = 525,
                P_hit = 170,
                P_double = 37,
                P_triple = 2,
                P_homerun = 34,
                P_RBI = 112,
                P_score = 115,
                P_theft = 3,
                P_Walk = 49,
                P_strikeout = 148,
                P_OBS = 0.390,
                P_SP = 0.596
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 12,
                P_player = "황재균 (KT)",
                P_Batting_average = 0.312,
                P_games = 134,
                P_steersman = 541,
                P_hit = 169,
                P_double = 35,
                P_triple = 5,
                P_homerun = 21,
                P_RBI = 97,
                P_score = 108,
                P_theft = 11,
                P_Walk = 47,
                P_strikeout = 98,
                P_OBS = 0.370,
                P_SP = 0.512
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 13,
                P_player = "김동엽 (삼성)",
                P_Batting_average = 0.312,
                P_games = 127,
                P_steersman = 471,
                P_hit = 147,
                P_double = 35,
                P_triple = 0,
                P_homerun = 20,
                P_RBI = 74,
                P_score = 60,
                P_theft = 4,
                P_Walk = 29,
                P_strikeout = 79,
                P_OBS = 0.360,
                P_SP = 0.478
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 14,
                P_player = "오재일 (두산)",
                P_Batting_average = 0.312,
                P_games = 127,
                P_steersman = 471,
                P_hit = 147,
                P_double = 32,
                P_triple = 0,
                P_homerun = 16,
                P_RBI = 89,
                P_score = 62,
                P_theft = 2,
                P_Walk = 61,
                P_strikeout = 92,
                P_OBS = 0.390,
                P_SP = 0.482
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 15,
                P_player = "구자욱 (삼성)",
                P_Batting_average = 0.307,
                P_games = 118,
                P_steersman = 446,
                P_hit = 137,
                P_double = 27,
                P_triple = 2,
                P_homerun = 15,
                P_RBI = 78,
                P_score = 70,
                P_theft = 19,
                P_Walk = 51,
                P_strikeout = 91,
                P_OBS = 0.385,
                P_SP = 0.478
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 16,
                P_player = "최주환 (두산)",
                P_Batting_average = 0.306,
                P_games = 140,
                P_steersman = 509,
                P_hit = 156,
                P_double = 29,
                P_triple = 4,
                P_homerun = 16,
                P_RBI = 88,
                P_score = 63,
                P_theft = 2,
                P_Walk = 47,
                P_strikeout = 66,
                P_OBS = 0.366,
                P_SP = 0.473
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 17,
                P_player = "티커 (KT)",
                P_Batting_average = 0.306,
                P_games = 142,
                P_steersman = 542,
                P_hit = 166,
                P_double = 40,
                P_triple = 0,
                P_homerun = 32,
                P_RBI = 113,
                P_score = 100,
                P_theft = 0,
                P_Walk = 76,
                P_strikeout = 67,
                P_OBS = 0.398,
                P_SP = 0.557
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 18,
                P_player = "박석민 (NC)",
                P_Batting_average = 0.306,
                P_games = 123,
                P_steersman = 356,
                P_hit = 109,
                P_double = 15,
                P_triple = 0,
                P_homerun = 14,
                P_RBI = 63,
                P_score = 58,
                P_theft = 0,
                P_Walk = 75,
                P_strikeout = 62,
                P_OBS = 0.436,
                P_SP = 0.369
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 19,
                P_player = "이명기 (NC)",
                P_Batting_average = 0.306,
                P_games = 136,
                P_steersman = 477,
                P_hit = 146,
                P_double = 18,
                P_triple = 3,
                P_homerun = 2,
                P_RBI = 45,
                P_score = 82,
                P_theft = 12,
                P_Walk = 50,
                P_strikeout = 78,
                P_OBS = 0.374,
                P_SP = 0.369
            });
            items.Add(new Pitcher_Rank
            {
                P_rank = 20,
                P_player = "김하성 (키움)",
                P_Batting_average = 0.306,
                P_games = 138,
                P_steersman = 533,
                P_hit = 163,
                P_double = 24,
                P_triple = 1,
                P_homerun = 30,
                P_RBI = 109,
                P_score = 111,
                P_theft = 23,
                P_Walk = 75,
                P_strikeout = 68,
                P_OBS = 0.397,
                P_SP = 0.523
            });
            return items;



        }
    }
}
