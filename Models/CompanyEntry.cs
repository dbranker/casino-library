using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace CasinoLibrary.Models
{
    public class CompanyEntry
    {
        //public int CompanyID { get; set; }
        //public int EmployeeID { get; set; }
        //public DateTime EntryDate { get; set; }        
        public decimal atmcash { get; set; }        
        public decimal blackjack { get; set; }        
        public decimal creditcardsales { get; set; }        
        public decimal houseaccount { get; set; }
        public bool isdateformatted { get; set; } = true;       
        public decimal netcashin { get; set; }        
        public decimal netslotcash { get; set; }        
        public decimal nettotalcashout { get; set; }        
        public decimal pettycash { get; set; }        
        public decimal revelpos { get; set; }        
        public decimal slotvouchers { get; set; }        
        public decimal threecardpoker { get; set; }        
        public decimal vouchersreentered { get; set; }        
        public decimal acbatm { get; set; }        
        public decimal wagespaid { get; set; }        
        public decimal cubatm { get; set; }        
        public decimal cubcc { get; set; }        
        public decimal acbcc { get; set; }        
        public decimal lottery { get; set; }        
        public decimal scracthtotal { get; set; }        
        public decimal scratchoffwinner { get; set; }
        public decimal topup { get; set; }
        public string notes { get; set; }          
    }
}
