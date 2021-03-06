using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoLibrary.Models
{
    public class CompanyEntryResponse
    {
        public List<EntryResponse> Entries { get; set; }
    }
    public class EntryResponse
    {
        public CompanyEntry Entry { get; set; }
        public Guid EntryID { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
