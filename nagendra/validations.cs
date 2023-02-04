namespace Productdetails
{
    class ItemNameInvalidException : ApplicationException
    {
        public string MyException()
        {
            Console.WriteLine("Exception occured,product name should contain only characters and numbers");
            string productname = Admin.Methodtogetproductname();
            return productname;
        }
    }
    class PriceNegativeException:ApplicationException
    {
        public double MyException(){
            Console.WriteLine("Exception Occured, price should not be negative");
            double price=Admin.methodtogetprice();
            return price;
        }
    }
    class QuantityNegativeException:ApplicationException
    {
        public Int32 MyException(){
            Console.WriteLine("Exception Occured, Quantity should not be negative");
            Int32 quantity=Admin.methodtogetquantity();
            return quantity;
        }
    }
}