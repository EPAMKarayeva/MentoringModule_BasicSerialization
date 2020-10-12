using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicSerialization
{
    public enum Genre
    {
      [XmlEnum("Computer")]
      Computer = 1,
      [XmlEnum("Fantasy")]
      Fantasy = 2,
      [XmlEnum("Romance")]
      Romance = 3,
      [XmlEnum("Horror")]
      Horror = 4,
      [XmlEnum("Science Fiction")]
      ScienceFiction = 5
    }
  
}
