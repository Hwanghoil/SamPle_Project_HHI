using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KakaotalkSample_HHI.Model
{
    public class FriendListModel
    {
        public string image { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }


        public static List<FriendListModel> GetFriendLists()
        {
            var FriendList = new List<FriendListModel>();
            FriendList.Add(new FriendListModel { image = "/images/profile1.png", Name = "황호일", Content = "상태 메시지" });
            FriendList.Add(new FriendListModel { image = "/images/profile2.png", Name = "홍길동", Content = "1" });
            FriendList.Add(new FriendListModel { image = "/images/profile3.png", Name = "둘리", Content = "2" });
            FriendList.Add(new FriendListModel { image = "/images/profile3.png", Name = "고길동", Content = "3" });
            FriendList.Add(new FriendListModel { image = "/images/profile3.png", Name = "마이콜", Content = "4" });
            FriendList.Add(new FriendListModel { image = "/images/profile3.png", Name = "김철수", Content = "5" });
            FriendList.Add(new FriendListModel { image = "/images/profile3.png", Name = "김유리", Content = "6" });         

            return FriendList;
        }
    }
}
