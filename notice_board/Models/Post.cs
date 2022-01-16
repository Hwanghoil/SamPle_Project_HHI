using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notice_board.Models
{
       public class Post
    {
        public static Post Instance { get; set; }

        static Post()
        {
            Instance = new Post();
        }

        public string P_Title { get; set; }
        public String P_Content { get; set; }
        public String P_Name { get; set; }
        public String P_Name2 { get; set; }
        public String P_Name3 { get; set; }

        public String P_Comment { get; set; }
        public String P_Comment2 { get; set; }
        public String P_Comment3 { get; set; }

        public String P_Images { get; set; }

        public List<string> GetTag(string[] tag)
        {
            var list = new List<string>();
            foreach (var item in tag)
            {
                list.Add(item);
            }
            return list;
        }

        public List<Post> GetPost()
        {
            List<Post> post = new List<Post>();
            post.Add(new Post
            {
                P_Title = "생활 속 꿀팁",
                P_Content = "건전지를 바닥에서 약 15cm 위에서 떨어트린 후 한번 약하게 튕긴다면 전력이 남은상태",
                P_Images = "/Images/power.png",
                P_Name = "홍길동",
                P_Comment = "좋은 말씀 감사합니다.",
                P_Name2 = "김기식",
                P_Comment2 = "집에서 확인해봐야지 ㅋㅋ.",
                P_Name3 = "둘리",
                P_Comment3 = "굿.",
            }
          ); 

            return post;
        }
    } 
}

       

