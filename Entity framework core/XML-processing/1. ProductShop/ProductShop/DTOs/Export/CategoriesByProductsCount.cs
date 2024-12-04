using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Export
{
    [XmlType("Category")]
    public class CategoriesByProductsCount
    {
        [XmlElement("name")]
        public string Name { get; set; }
        
        [XmlElement("count")]
        public int NumberOfProducts { get; set; }

        [XmlElement("averagePrice")]
        public decimal AveragePrice { get; set; }
        [XmlElement("totalRevenue")]
        public decimal TotalRevenue { get; set; }

    }
}
