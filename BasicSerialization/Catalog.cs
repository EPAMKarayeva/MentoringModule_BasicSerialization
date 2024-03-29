﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicSerialization
{
  [XmlRoot(ElementName = "catalog", Namespace = XmlNamespace)]
  public class Catalog
  {
    [XmlAttribute(AttributeName = "date", DataType = "date")]
    public DateTime Date { get; set; }
    [XmlElement("book")]
    public List<Book> Books { get; set; }

    public const string XmlNamespace = "http://library.by/catalog";
  }
}
