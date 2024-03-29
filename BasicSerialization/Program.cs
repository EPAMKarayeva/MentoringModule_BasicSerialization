﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BasicSerialization
{
  class Program
  {
    static void Main(string[] args)
    {
      XmlSerializer serializer = new XmlSerializer(typeof(Catalog));

      Catalog catalog;
      using (var fileStream = File.OpenRead("books.xml"))
      {
        catalog = (Catalog)serializer.Deserialize(fileStream);
      }

      var namespaces = new XmlSerializerNamespaces();
      namespaces.Add(string.Empty, Catalog.XmlNamespace);

      using (var xmlWriter = XmlWriter.Create("books1.xml", new XmlWriterSettings
      {
        Encoding = Encoding.UTF8,
        Indent = true
      }))
      {
        serializer.Serialize(xmlWriter, catalog, namespaces);
      }
    }
  }
}
