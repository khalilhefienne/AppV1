using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppV1.Models
{
    public class User
    {
       
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        [MaxLength(50)]
      
        public string email { get; set; }
        [MaxLength(100)]
        public string Password { get; set; }

    }
}
