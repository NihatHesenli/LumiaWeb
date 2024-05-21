﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LUMIA_WEBSITE.Models
{
    public class Team
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string ImgUrl { get; set; }

        [NotMapped]
        public IFormFile ImgFile { get; set; }

    }
}
