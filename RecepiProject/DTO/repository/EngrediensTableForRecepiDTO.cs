using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.repository
{
    public class EngrediensTableForRecepiDTO
    {
        public int IdForRecepi { get; set; }
        public int IdRecepi { get; set; }
        public int IdEngrediens { get; set; }
         //הוספה שם רכיב
        public string EngrediensName { get; set; }
        public string? Count { get; set; }

       // public string EngrediensName { get; set; }
        //public string NameEngrediens { get; set; }
    }
}
