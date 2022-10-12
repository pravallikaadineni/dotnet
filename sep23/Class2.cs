using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep23library
{
    public class Class1
    {
        private int _productid;
        public int ProductId
        {
            get
            {
                return _productid;
            }
            set
            {

                if (value > 77)
                {
                    throw new Exception("product id not valid");

                }
                else
                {
                    _productid = value;
                }
            }
        }
        private string _productname;

        public string ProductName
        {
            get { return _productname; }
            set
            {
                if ((value.Length > 40) || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Not valid name.... Please check");
                }
                else
                {
                    _productname = value;
                }

            }
        }
       /* private float _unitprice;

        public string UnitPrice
        {
            get { return _unitprice; }
            set
            {
                if (value.Length > 8)
                {
                    throw new Exception("Length of pubid cannot be more than 8 chars/numbers");
                }
                else
                {
                    _unitprice = value;
                }

            }
        }*/

    }
}
