using System;
using System.Collections.Generic;
using System.Text;

namespace Arranjos2_POO {
    class Produto {

        public string Name { get; set; }
        public double Price { get; set; }

        public Produto(string name, double price) {
            this.Name = name;
            this.Price = price;
        }

    }
}
