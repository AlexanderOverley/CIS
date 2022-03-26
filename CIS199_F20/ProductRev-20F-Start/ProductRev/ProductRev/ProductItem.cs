//Grading ID here R7834

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRev

{
    public class ProductItem
    {
        // #1 - Put needed backing fields here
        // Remember: Some properties may be
        // auto-implemented, so only create
        // backing fields for ones needed

        private int _quantity;
        private double _price;

        public string Description { get; set; }
    
            // #2 - Put your code here for get/set accessors
            // May be auto-implemented

        public string ProductNumber { get; set; }
      
            // #3 - Put your code here for get/set accessors
            // May be auto-implemented

        public int Quantity
        {
            // #4 - Put your code here for get/set accessors
            // Set must validate!

            get { return _quantity; }
            set
            {
                if (value >= 0)
                    _quantity = value;
                else
                    _quantity = 0;
            }

        }

        public double Price
        {
            // #5 - Put your code here for get/set accessors
            // Set must validate!

            get { return _price; }
            set
            {
                if (value >= 0)
                    _price = value;
                else
                    _price = 0;
            }

        }

        public ProductItem(string desc, string productNum, int quant, double price)
        {
            // #6 - Put your code here for constructor
            // Be sure your parameters get validated through properties

            Description = desc;
            ProductNumber = productNum;
            Quantity = quant;
            Price = price;

        }

        public double CalcValue()
        {
            // #7 - Put your code here to calculate value of
            // this item in inventory
            // Example: 2500 @ $4.99 = $12,475

            return Quantity * Price;

        }

        public override string ToString()
        {
            // #8 - Put your code here to create formatted string
            // Use format that would produce a string like:
            // "HS1234: Hand Soap (3000 @ $2.99)"
            // where HS1234 is the prodcut number, Hand Soap is the
            // description, 3000 is the quantity, and $2.99 is
            // the price. No newlines are needed.

            return $"{ProductNumber}: {Description} ({Quantity} @ {Price:C})";


        }
    }
}
