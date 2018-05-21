using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TemporaryProduct : product
    {
        public DateTime StartSelling
        { get; set; }
        public DateTime EndSelling
        { get; set; }
        public TemporaryProduct(int productID, string productName, scroll scrollID, double productVolume, 
                                 string productProducer, int productPrice, DateTime StartSelling, DateTime EndSelling) : 
            base (productID, productName, scrollID, productVolume, productPrice, productProducer)
        {
            this.StartSelling = StartSelling;
            this.EndSelling = EndSelling;
        }
        public override void info()
        {
            base.info();
            Console.WriteLine("Дата поступления в продажу: {0}", StartSelling);
            Console.WriteLine("Дата конца продажи: {0}", EndSelling);
        }

            
    }
}
