﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TattooConsultant.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password  { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Photo { get; set; }
        public string Role { get; set; }
   
    }
}