using static ProductDemo.Models.Product;

namespace ProductDemo.Models
{
    public class productimplementinterface : TransientService
    {
        private int _Productid;

        public int  Productid
        {
            get { return _Productid; }
            set { _Productid = value; }
        }
        public int Quantity { get; set; }

        public string Productname { get; set; }
        public int productid()
        {
            Random random = new Random();
            return random.Next(1000);
            //throw new NotImplementedException();
        }
    }
}
