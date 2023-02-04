namespace Productdetails
{
    public class Insertion
    {
        public void Productinsert(string productname, Double price, Int32 quantity,Int32 rating)
        {
            string productprice = Convert.ToString(price);
            string productquantity = Convert.ToString(quantity);
            string productrating=Convert.ToString(rating);
            var lineCount = File.ReadLines("product.txt").Count();
            Int32 productid;
            if(lineCount==0)
            productid=1;
            else{
            string requiredline = File.ReadLines("product.txt").Skip(lineCount-6).Take(1).First();
            string newpid=requiredline.Substring(5,requiredline.Length-5);
            productid=Convert.ToInt32(newpid);
            productid++;
            }
            string pid=Convert.ToString(productid);
            string endpoint="*******************************************************************************************";
            string[] details = { "PID: "+pid,"PNAME: "+productname, "PRICE: "+productprice, "QUANTITY: "+productquantity,"RATING: "+productrating,endpoint };
            using StreamWriter file = new("product.txt",append:true);
            foreach (string line in details)
            {
                file.WriteLine(line);
            }
            Console.WriteLine("product insertion successfull");
        }
    }
}