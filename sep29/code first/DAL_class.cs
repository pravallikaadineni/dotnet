using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep29library
{
    
        public class member
        {
            [Key]
            [Required]
            public int memberId { get; set; }
            [MaxLength(20, ErrorMessage = "Not allowed above 20 chars")]
            [MinLength(2, ErrorMessage = "Not allowed below 2 chars")]
            public string memberName { get; set; }

           
            
            public virtual ICollection<Issues> issues { get; set; }
           

        }

        public class book
        {
            [Key]
            public int bookID { get; set; }

            public string bookName { get; set; }

            [Range(100, 200, ErrorMessage = "not in range")]
            public int cost { get; set; }
            //1 course---- M enrollments
            public virtual ICollection<Issues> issues { get; set; }

        }

        public class Issues
        {
            [Key]
            public int issueID { get; set; }
            public int bookID { get; set; }
            public int memberId{ get; set; }

            [ForeignKey("bookID")]
            public virtual book BookDetails { get; set; }
            [ForeignKey("memberId")]
            public virtual member MemberDetails { get; set; }


        }

        public class MyContext : DbContext
        {
            public MyContext() : base("MyContext")
            {
                //createdatabase if not exists
                //drop create always
                //drop create if model changes

                Database.SetInitializer<MyContext>(new DropCreateDatabaseAlways<MyContext>());
            }

            public virtual DbSet<member> memberTable { get; set; }
            public virtual DbSet<book> BookTable { get; set; }
            public virtual DbSet<Issues> IssuesTable { get; set; }

        }
    }



