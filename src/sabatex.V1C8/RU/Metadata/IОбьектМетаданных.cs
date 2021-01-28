using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.RU.Metadata
{
    public interface Iќбьектћетаданных: Iќписаниећетаданных
    {
        public string ѕолное»м€() => Method<string>("FullName");
        public string ѕредставление() => Method<string>("Presentation");
    }
   
}