using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectClassLib
{
    [Serializable]
    public class Product
    {
        public int productNum;
        public int productPrice;
        public string prodDescript;
        public int QOH;
        public string departmentNum;
        public string url = "";

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

        public Product(int prodNum)
        {
            this.productNum = prodNum;
        }
    }
}
