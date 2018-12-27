using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdf2
{
    public class Product
    {
        public string pr_name, pr_type, pr_picture;
        public int pr_number, pr_price,id;
        public Product(int id,string name, string type, string pic, int n, int price) {
            this.id = id;
            this.pr_name = name;
            this.pr_type = type;
            this.pr_picture = pic;
            this.pr_number = n;
            this.pr_price = price;
        }
    }
}
