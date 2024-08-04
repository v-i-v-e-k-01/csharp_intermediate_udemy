using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon;

namespace AccessModifiers
{

    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(excludeOrders: true);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            //customer.CalculateRating();

            Amazon.RateCalculator calculator = new RateCalculator(); 

        }
    }
}


