using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackoverflowSample_HHI.Models
{
    public class Blog
    {
        public static Blog Instance { get; set; }
        
        static Blog ()
        {
            Instance = new Blog();
        }

        public string Image { get; set; }
        public string Content { get; set; }


        public  List<Blog> GetBlog()
        {
            var Blog = new List<Blog>();
            Blog.Add(new Blog { Image = "/images/Logo2.png", Content = @"How Stackers ditched the wiki and
migrated to Articles" });

            return Blog;
        }
    }
}
