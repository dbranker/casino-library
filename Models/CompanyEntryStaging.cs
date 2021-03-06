using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CasinoLibrary.Models
{
    public class CompanyEntryStaging
    {
        public int CompanyID { get; set; }
        public string EntryDate { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string atmcash { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string blackjack { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string creditcardsales { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string houseaccount { get; set; }
        public bool isdateformatted { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string netcashin { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string netslotcash { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string nettotalcashout { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string pettycash { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string revelpos { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string slotvouchers { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string threecardpoker { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string vouchersreentered { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string acbatm { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string wagespaid { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string cubatm { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string cubcc { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public string acbcc { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public double lottery { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public double scracthtotal { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "Varchar(200)")]
        public double scratchoffwinner { get; set; }
    }

}

