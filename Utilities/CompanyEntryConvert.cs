using System;
using System.Collections.Generic;
using System.Text;
using CasinoLibrary.Models;
using Newtonsoft.Json;

namespace CasinoLibrary.Cleaning
{
    public static class CompanyEntryConvert
    {
        public static bool TryParse(string json, out CompanyEntry companyEntry,out Dictionary<string, string> parsingIssues)
        {            
            bool hasParseSucessfully = true;
            parsingIssues = new Dictionary<string,string>();                        
            //Create dictionary for final values
            var finalDic = new Dictionary<string, string>();
            //Cleaning fields
            var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);            
            foreach(KeyValuePair<string,string> kvp in dic)
            {
                string cleaningString = "";
                decimal cleaningDecimal;
                switch(kvp.Key.ToLower())
                {
                    //case "companyid":
                    //    finalDic.Add("CompanyID", kvp.Value);
                    //    break;
                    //case "entrydate":
                    //    DateTime dt;
                    //    try { 
                    //        DateTime.TryParse(kvp.Value, out dt);
                    //    }
                    //    catch
                    //    {
                    //        hasParseSucessfully = false;
                    //        parsingIssues.Add("entrydate","Couldn't parse EntryDate into DateTime");
                    //        break;
                    //    }
                    //    finalDic.Add("EntryDate", dt.ToString("MM/dd/yyyy"));
                    //    break;
                    case "atmcash": 
                    case "blackjack":                        
                    case "creditcardsales":                        
                    case "houseaccount":                        
                    case "isdateformatted":                        
                    case "netcashin":                        
                    case "netslotcash":                        
                    case "nettotalcashout":                        
                    case "pettycash":                        
                    case "revelpos":                        
                    case "slotvouchers":                        
                    case "threecardpoker":                        
                    case "vouchersreentered":                        
                    case "acbatm":                        
                    case "wagespaid":                        
                    case "cubatm":                        
                    case "cubcc":                        
                    case "acbcc":                        
                    case "lottery":                       
                    case "scracthtotal":                        
                    case "scratchoffwinner":
                        cleaningString = kvp.Value.Replace(" ", "");
                        try
                        {
                            Decimal.TryParse(kvp.Value, out cleaningDecimal);
                        }
                        catch
                        {
                            hasParseSucessfully = false;
                            parsingIssues.Add(kvp.Key,"Couldn't parse value into decimal");
                            break;
                        }
                        finalDic.Add(kvp.Key.ToLower(), cleaningDecimal.ToString());
                        break;
                    case "notes":
                        if(kvp.Value.Length > 2000) {
                            hasParseSucessfully = false;
                            parsingIssues.Add(kvp.Key, "Notes field needs to be below the 2000 character limit");
                        }
                        else
                            finalDic.Add("notes", kvp.Value);
                        break;
                    default:
                        parsingIssues.Add(kvp.Key,"Column doesn't exist");
                        hasParseSucessfully = false;
                        break;
                }
            }
            if(!hasParseSucessfully) {
                var jsonString = JsonConvert.SerializeObject(finalDic);
                companyEntry = JsonConvert.DeserializeObject<CompanyEntry>(jsonString);
            } else
                companyEntry = new CompanyEntry();            
            return hasParseSucessfully;
        }
        
    }
}
