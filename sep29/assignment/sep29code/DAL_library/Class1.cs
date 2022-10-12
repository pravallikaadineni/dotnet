using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_library
{
    
        public class  Borrower

        {
            [Key]
            [Required]
            public int borrowerid { get; set; }
            [MaxLength(20, ErrorMessage = "Not allowed above 20 chars")]
            [MinLength(2, ErrorMessage = "Not allowed below 2 chars")]
            public string borr_Name { get; set; }
            public string city { get; set; }
        public string state{ get; set; }
        public string country{ get; set; }



        public virtual ICollection<Loan> loan { get; set; }


        }

        public class Loan
        {
            [Key]
            public int LoanId { get; set; }

            public string LoanType{ get; set; }

            [Range(2000, 3000, ErrorMessage = "not in range")]
            public int Amt{ get; set; }
        public int duration { get; set; }   
        public int rateofintrest { get; set; }
            //1 course---- M enrollments
           // public virtual ICollection<Loan> loan { get; set; }

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

            public virtual DbSet<Borrower> BorrowerTable { get; set; }
            public virtual DbSet<Loan> LoanTable { get; set; }
           

        }
    }

