﻿using System.Collections.Generic;
using Glass.Mapper.Sites.Sc.Models.Content;

namespace Glass.Mapper.Sites.Sc.Models.Landing
{

    public class HomePage
    {
        public virtual string Title { get; set; }

        public virtual string MainBody { get; set; }

        public virtual IEnumerable<NewsArticle> News { get; set; }
    }
}