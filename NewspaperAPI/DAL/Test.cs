using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewspaperAPI.DAL
{
    public static class Tests
    {
        public static void Testmethod()
        { 
                using (var db = new NewspaperContext())
                {
                
                    var blog = new Author { email= "Abrarbhat008@gmail.com",id=11,name="Abrar"};
                    db.Authors.Add(blog);
                    db.SaveChanges();

                    var dbAuthors = db.Authors.ToList();

                }
            }
        }
    
}