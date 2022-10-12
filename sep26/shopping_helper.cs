using BAL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class shopping_helper
    {
        shopping_DAL dal = null;
        public shopping_helper()
        {
            dal = new shopping_DAL();
        }


        public bool AddBook(shopping_BAL book)
        {
            return dal.InsertBook(book);

        }



    }
}
