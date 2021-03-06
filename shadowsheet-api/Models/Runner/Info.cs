﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShadowAPI.Models
{
    public class Info : BaseEntity
    {
        public string RealName { get; set; } 
        public List<Alias> Aliases { get; set; } // Maybe viruals
        public Metatype Metatype { get; set; }
        public string Sex { get; set; }
        public string Ethnicity { get; set; }
        public string Description { get; set; }
        public string Background { get; set; }
        public string ImageURL { get; set; }

        //Optional
        //public Awakened Awakened{ get; set; }

        [BindNever]
        public Runner Runner { get; set; }
    }
}