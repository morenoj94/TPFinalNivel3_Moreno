﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Article
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Brand ArticleBrand { get; set; }
        public Category ArticleCategory { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
    }
}
