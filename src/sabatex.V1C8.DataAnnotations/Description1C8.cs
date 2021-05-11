using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
namespace sabatex.V1C8.DataAnnotations
{
    /// <summary>
    ///     DisplayEnumAttribute is a general-purpose attribute to specify user-visible globalizable strings for enum.
    ///     The string properties of this class can be used either as literals or as resource identifiers into a specified
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property ,AllowMultiple=false) ]
    public sealed class Description1C8Attribute:Attribute
    {
        public string Name { get; set; }  
        public string Comment { get; set; } 
        public string Synonym { get; set; }  

    }
 

}