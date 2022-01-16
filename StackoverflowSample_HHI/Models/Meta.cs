using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackoverflowSample_HHI.Models
{
    public class Meta
    { 
       public static Meta Instance { get; set; }

        static Meta()
        {
        Instance = new Meta();
        }
    
        public string Image { get; set; }
       public string Content { get; set; }


 
        public List<Meta> GetMeta()
        { 
        var Meta = new List<Meta>();
        Meta.Add(new Meta { Image = "/images/Logo2.png", Content = @"Hot Meta Posts: Allow for removal by 
moderators, and thoughts about future…" });
            Meta.Add(new Meta { Image = "/images/Logo2.png", Content = @"Goodbye, Prettify. Hello highlight.js!
Swapping out our Syntax Highlighter" });
            Meta.Add(new Meta { Image = "/images/Logo2.png", Content = @"How does the highlight.js change affect 
Stack Overflow specifically?" });

            return Meta;
        }
    }
}