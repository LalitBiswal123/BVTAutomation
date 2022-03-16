using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa.DataModels
{
    public class ItemDDData
    {
        public double ItemListPrice { get; set; }
        public double ItemSellingPrice { get; set; }
        public double ItemDiscount { get; set; }
        public double ItemDiscountPer { get; set; }
        public double HardwareListPrice { get; set; }
        public double HardwareDiscount { get; set; }
        public double HardwareSellingPrice { get; set; }
        public double ServiceListPrice { get; set; }
        public double ServiceDiscount { get; set; }
        public double ServiceSellingPrice { get; set; }
        public List<ItemServiceSkuDDData> ItemServiceSkuDDDatas { get; set; }
    }
    public class ItemServiceSkuDDData
    {
        public string SkuId { get; set; }
        public string SkuDiscountClass { get; set; }
        public double SkuListPrice { get; set; }
        public double SkuSellingPrice { get; set; }
    }
}
