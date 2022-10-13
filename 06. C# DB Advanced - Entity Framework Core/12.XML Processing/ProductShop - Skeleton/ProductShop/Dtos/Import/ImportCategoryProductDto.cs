﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop.Dtos.Import
{
    [XmlType("CategoryProduct")]
    public class ImportCategoryProductDto
    {
        [XmlElement("CategoryId")] //като имената са еднакви, xml ги мапва без атрибути
        public int CategoryId { get; set; }

        [XmlElement("ProductId")]
        public int ProductId { get; set; }

        //<CategoryProduct>
        //<CategoryId>4</CategoryId>
        //<ProductId>1</ProductId>
        //</CategoryProduct>
    }
}
