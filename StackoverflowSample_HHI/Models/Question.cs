using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackoverflowSample_HHI.Models
{
    public class Tag
    {
        public string name { get; set; }        
        
    }    
    public class Question
    {
        public static Question Instance { get; set; }
        static Question()
        {
            Instance = new Question();
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public int View { get; set; }
        public string Views { get; set; }
        public DateTime Write_DT { get; set; }
        public string Button { get; set; }
        public string Button2 { get; set; }
        public int Vote { get; set; }
        public string Vote2 { get; set; }
        public int Answers { get; set; }
        public string Answers2 { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Name2 { get; set; }

        public List<string> tag { get; set; }


        public List<string> GetTag(string[] tag)
        {
            var list = new List<string>();
            foreach(var item in tag)
            {
                list.Add(item);
            }
            return list;
        }

        public List<Question> GetQuestion()
        {
            List<Question> question = new List<Question>();
            question.Add(new Question { Title = "Run bash script inside docker mounted volume", Content = @"i have php app run with builtin php server, i run it with docker: export APP_FOLDER='/usr/src/myapp' docker run -it --rm
--name calc ulator-api-server -v PWD:${APP_FOLDER} -w ${APP_FOLDER} ...", 
                
                Button ="wpf", Button2 ="grid",  View =2, Views="views", Answers=0, Answers2="answers", Vote=1, Vote2="votes",
                Image = "/images/profile1.jpg", Name="HOTDOG", Name2=5, Write_DT = DateTime.Now});

            question.Add(new Question { Title = "pdating iOS 14 Home Widget from StaticConfiguration to IntentConfiguration", 
            Content = @"Has anyone successfully migrated their iOS 14 Home Widget from using StaticConfiguration to IntentConfiguration? My
widgets are completely broken, stuck in placeholder state, after migration. The only ...", 
                
                Button = "C#", Button2 = "wpf", View = 46, Views = "views",Answers = 3, Answers2 = "answers", Vote=5, Vote2="votes",
                Image = "/images/profile2.jpg", Name="BANANA", Name2=15, Write_DT = DateTime.Now.AddMinutes(15) });

            question.Add(new Question { Title = "Multiple processes appending to file result in overwriting", 
            Content = @"I have a simple powershell command that appends a variable (string) into a .log file: powershell.exe -command \%V\ |o
ut-file C:\file.log -append This is stored...,",
          
                Button ="C#", Button2 = ".Net", View = 12, Views = "views", Answers = 0, Answers2 = "answers", Vote=-1,Vote2="votes",
                Image = "/images/profile3.jpg", Name="MONKEY", Name2=50, Write_DT = DateTime.Now });

            return question;
        }
    }
}
