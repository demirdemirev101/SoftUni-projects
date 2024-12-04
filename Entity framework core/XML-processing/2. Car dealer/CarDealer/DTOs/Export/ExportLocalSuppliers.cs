using CarDealer.Data;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarDealer.DTOs.Export
{
    [XmlType("supplier")]
    public class ExportLocalSuppliers
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; } = null!;

        private bool IsImporter { get; set; }


        [XmlAttribute("parts-count")]
        public int PartsCount { get; set; }
    }
}
