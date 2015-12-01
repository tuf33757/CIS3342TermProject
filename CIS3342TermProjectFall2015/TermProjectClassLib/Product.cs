using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectClassLib
{
    class Product
    {
        public int productNum;
        public int productPrice;
        string prodDescript;
        int QOH;
        string departmentNum;
        string url = "";

        public Product()
        {
        }

        public Product(int productNum, int productPrice, string prodDescript, int QOH, string departmentNum, string url)
        {
            this.productNum = productNum;
            this.productPrice = productPrice;
            this.prodDescript = prodDescript;
            this.QOH = QOH;
            this.departmentNum = departmentNum;
            this.url = url;
        }
    }
}
