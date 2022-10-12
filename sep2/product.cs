using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace productlibrary
{
    public class product
    {
        private int _productid;

        public int Productid
        {
            get { return _productid; }
            set { _productid = value; }
        }
        private string _productname;


        public string Productname

        {
            get { return _productname; }
            set { _productname = value; }
        }

        private int _qtysold;

        public int _Qtysold
        {
            get { return _qtysold; }
            set { _qtysold = value; }
        }
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private int _measure;

        public int Measure
        {
            get { return _measure; }
            set { _measure = value; }
        }
        private int _qtyinhand;

        public int Qtyinhand
        {
            get { return _qtyinhand; }
            set { _qtyinhand = value; }
        }
        private int _reorder;

        public int Reorder
        {
            get { return _reorder; }
            set { _reorder = value; }
        }



    }


}
    


