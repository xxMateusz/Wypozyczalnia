//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wypozycalnia2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wypożyczalnia
    {
        public int IdWypozyczalni { get; set; }
        public int IdPracownikow { get; set; }
        public int IdSamochodow { get; set; }
        public string NazwaWypożyczalni { get; set; }
        public string Adres { get; set; }
    
        public virtual Pracownicy Pracownicy { get; set; }
        public virtual Samochody Samochody { get; set; }
    }
}
