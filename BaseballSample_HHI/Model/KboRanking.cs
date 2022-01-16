using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballSample_HHI.Model
{
    public class KboRanking
    {
        public int Ranking { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public string Number { get; set; }


        public List<KboRanking> GetKboRanking(int num)
        {
            var major = new List<KboRanking>();
       
            switch (num)
            {
                case 1:            
                    major.Add(new KboRanking
                    {
                        Image ="/Image/a.png",                      
                        Ranking = 1,
                        Name = "알칸타라",
                        Team = "두산",
                        Number = "20승"
                    });
                    major.Add(new KboRanking
                    {
                        Image = "/Image/a.png",
                        Ranking = 2,
                        Name = "루친스키",
                        Team = "NC",
                        Number = "19승"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 3,
                        Name = "켈리",
                        Team = "LG",
                        Number = "15승"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 4,
                        Name = "데스파이네",
                        Team = "KT",
                        Number = "15승"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 5,
                        Name = "뷰캐넌",
                        Team = "삼성",
                        Number = "15승"
                    });


                    return major;
                case 2:
                    major.Add(new KboRanking
                    {
                        Ranking = 1,
                        Name = "요키시",
                        Image = "/Image/Yo.png",
                        Team = "키움",
                        Number = "2.14"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 2,
                        Name = "스트레일리",
                        Image = "/Image/Yo.png",
                        Team = "롯데",
                        Number = "2.50"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 3,
                        Name = "브룩스",
                        Team = "KIA",
                        Number = "2.50"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 4,
                        Name = "알칸타라",
                        Team = "두산",
                        Number = "2.54"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 5,
                        Name = "루친스키",
                        Team = "NC",
                        Number = "3.05"
                    });

                    return major;
                case 3:
                    major.Add(new KboRanking
                    {
                        Ranking = 1,
                        Name = "스트레일리",
                        Image = "/Image/S.png",
                        Team = "롯데",
                        Number = "205"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 2,
                        Name = "알칸타라",
                        Image = "/Image/S.png",
                        Team = "두산",
                        Number = "182"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 3,
                        Name = "루친스키",
                        Team = "NC",
                        Number = "167"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 4,
                        Name = "데스파이네",
                        Team = "KT",
                        Number = "152"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 5,
                        Name = "양현종",
                        Team = "KIA",
                        Number = "149"
                    });

                    return major;
                case 4:
                    major.Add(new KboRanking
                    {
                        Ranking = 1,
                        Name = "조상우",
                        Image = "/Image/Jo.png",
                        Team = "키움",
                        Number = "33"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 2,
                        Name = "원종현",
                        Team = "NC",
                        Number = "25"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 3,
                        Name = "김원중",
                        Team = "롯데",
                        Number = "25"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 4,
                        Name = "김재윤",
                        Team = "KT",
                        Number = "21"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 5,
                        Name = "오승환",
                        Team = "삼성",
                        Number = "18"
                    });
                    return major;
                case 5:
                    major.Add(new KboRanking
                    {
                        Ranking = 1,
                        Name = "최형우",
                        Image = "/Image/CHW.png",
                        Team = "KIA",
                        Number = "0.354"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 2,
                        Name = "손아섭",
                        Team = "롯데",
                        Number = "0.352"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 3,
                        Name = "로하스",
                        Team = "KT",
                        Number = "0.349"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 4,
                        Name = "박민우",
                        Team = "NC",
                        Number = "0.345"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 5,
                        Name = "페르난데스",
                        Team = "두산",
                        Number = "0.340"
                    });
                    return major;
                case 6:
                    major.Add(new KboRanking
                    {
                        Ranking = 1,
                        Name = "로하스",
                        Image = "/Image/Ro.png",
                        Team = "KT",
                        Number = "135"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 2,
                        Name = "양의지",
                        Team = "NC",
                        Number = "124"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 3,
                        Name = "김현수",
                        Team = "LG",
                        Number = "119"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 4,
                        Name = "최형우",
                        Team = "KIA",
                        Number = "115"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 5,
                        Name = "김재환",
                        Team = "두산",
                        Number = "113"
                    });
                    return major;
                case 7:
                    major.Add(new KboRanking
                    {
                        Ranking = 1,
                        Name = "로하스",
                        Image = "/Image/Ro.png",
                        Team = "KT",
                        Number = "47"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 2,
                        Name = "라모스",
                        Team = "LG",
                        Number = "38"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 3,
                        Name = "나성범",
                        Team = "NC",
                        Number = "34"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 4,
                        Name = "최정",
                        Team = "SK",
                        Number = "33"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 5,
                        Name = "양의지",
                        Team = "NC",
                        Number = "33"
                    });
                    return major;
                case 8:
                    major.Add(new KboRanking
                    {
                        Ranking = 1,
                        Name = "심우준",
                        Image = "/Image/Sim.png",
                        Team = "KT",
                        Number = "35"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 2,
                        Name = "박해민",
                        Team = "삼성",
                        Number = "34"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 3,
                        Name = "김혜성",
                        Team = "키움",
                        Number = "25"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 4,
                        Name = "시건창",
                        Team = "키움",
                        Number = "24"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 5,
                        Name = "김하성",
                        Team = "키움",
                        Number = "23"
                    });
                    return major;
                case 9:
                    major.Add(new KboRanking
                    {
                        Ranking = 1,
                        Name = "스트레일리",
                        Image = "/Image/S.png",
                        Team = "롯데",
                        Number = "1.02"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 2,
                        Name = "브룩스",
                        Team = "KIA",
                        Number = "1.02"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 3,
                        Name = "알칸타라",
                        Team = "두산",
                        Number = "1.03"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 4,
                        Name = "요키시",
                        Team = "키움",
                        Number = "1.06"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 5,
                        Name = "켈리",
                        Team = "LG",
                        Number = "1.15"
                    });
                    return major;
                case 10:
                    major.Add(new KboRanking
                    {
                        Ranking = 1,
                        Name = "로하스",
                        Image = "/Image/Ro.png",
                        Team = "KT",
                        Number = "1.097"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 2,
                        Name = "최영우",
                        Team = "KIA",
                        Number = "1.023"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 3,
                        Name = "양의지",
                        Team = "NC",
                        Number = "1.003"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 4,
                        Name = "나성범",
                        Team = "NC",
                        Number = "0.986"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 5,
                        Name = "강백호",
                        Team = "KT",
                        Number = "0.955"
                    });
                    return major;
                case 11:
                    major.Add(new KboRanking
                    {
                        Ranking = 1,
                        Name = "스트레일리",
                        Image = "/Image/S.png",
                        Team = "롯데",
                        Number = "7.80"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 2,
                        Name = "알칸타라",
                        Team = "두산",
                        Number = "6.52"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 3,
                        Name = "브룩스",
                        Team = "KIA",
                        Number = "6.31"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 4,
                        Name = "루친스키",
                        Team = "NC",
                        Number = "5.58"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 5,
                        Name = "요키시",
                        Team = "키움",
                        Number = "5.38"
                    });
                    return major;
                case 12:
                    major.Add(new KboRanking
                    {
                        Ranking = 1,
                        Name = "로하스",
                        Image = "/Image/Ro.png",
                        Team = "KT",
                        Number = "135"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 2,
                        Name = "양의지",
                        Team = "NC",
                        Number = "124"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 3,
                        Name = "김현수",
                        Team = "LG",
                        Number = "119"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 4,
                        Name = "최형우",
                        Team = "KIA",
                        Number = "115"
                    });
                    major.Add(new KboRanking
                    {
                        Ranking = 5,
                        Name = "김재환",
                        Team = "두산",
                        Number = "113"
                    });
                    return major;
            }

            return major;
        }

    }
}
