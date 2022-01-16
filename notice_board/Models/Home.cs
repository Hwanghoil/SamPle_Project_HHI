using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notice_board.Models
{
    
    public class Home
    {
        public static Home Instance { get; set; }
        static Home()
        {
            Instance = new Home();
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string image { get; set; }
        public int Comment { get; set; }


        public List<string> GetTag(string[] tag)
        {
            var list = new List<string>();
            foreach (var item in tag)
            {
                list.Add(item);
            }
            return list;
        }
        
        public List<Home> GetHome()
        {
            List<Home>home = new List<Home>();          
            home.Add(new Home
            {
                Title = "생활 속 꿀팁",
                Content ="건전지를 바닥에서 약 15cm 위에서 떨어트린 후 한번 약하게 튕긴다면 전력이 남은상태",
                Comment =15,
                image = "/Images/power.png"
            }
          );
            home.Add(new Home
            {
                Title = "현대 2022 싼타페 6인승 출시",      
                Comment = 35,
                image = "/Images/santafe.jpg"
            }
         );

            home.Add(new Home
            {
                Title = "미세먼지 심한 날 환기 시키는 방법 ",            
                Comment = 5,
                image = "/Images/dust.jpg"
            }
         );

            home.Add(new Home
            {
                Title = "호랑이와 사자가 싸우면 누가 이길까? ",
                Comment = 150,
                image = "/Images/tiger.jpg"
            }
      );
            home.Add(new Home
            {
                Title = "기억력을 떨어뜨리는 음식 Best 5 ",
                Comment = 80,
                image = "/Images/life.jpg"
            }
    );
            home.Add(new Home
            {
                Title = "CES 2022 주목할 만한 기술은? ",
                Comment = 50,
                image = "/Images/CES.jpg"
            }
);

            return home;
        }
    }


}

