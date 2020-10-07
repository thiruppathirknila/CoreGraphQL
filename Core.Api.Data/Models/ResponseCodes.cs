using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Api.Data.Models
{
    [Table("Response_Codes")]
    public class ResponseCodes
    {
       
        public int Id { get; set; }
        public string Processor { get; set; }
        public string Response_Code { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public string? Type { get; set; }
        public bool? Can_Retry { get; set; }
    }
}
