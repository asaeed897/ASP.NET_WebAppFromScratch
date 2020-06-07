using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_WebAppFromScratch.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Awais", Department = Dept.HR, Email = "mawas__7@gmail.com" },
                new Employee() { Id = 2, Name = "Asim", Department = Dept.HR, Email = "asim__7@gmail.com" },
                new Employee() { Id = 3, Name = "Mustensar", Department = Dept.IT, Email = "mustensar__7@gmail.com" },
                new Employee() { Id = 4, Name = "Ayesha", Department = Dept.HR, Email = "ayesha__7@gmail.com" }
           );
        }
    }
}
