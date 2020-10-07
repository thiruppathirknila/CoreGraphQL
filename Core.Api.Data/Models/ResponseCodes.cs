using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Api.Data.Models
{
    [Table("merchant_reporting")]
    public class ResponseCodes
    {
            public int id { get; set; }

            public int merchant_id { get; set; }

            public string storename { get; set; }

            public string order_id { get; set; }

            public string processor { get; set; }

            public int transaction_id { get; set; }

            public int reference_number { get; set; }

            public int amount { get; set; }

            public string etc_trans_type { get; set; }

            public bool success { get; set; }

            public string auth_response { get; set; }

            public string auth_code { get; set; }

            public string avs_response { get; set; }

            public string cvv2_response { get; set; }

            public DateTime transaction_date { get; set; }

            public string card_num { get; set; }

            public string card_exp { get; set; }

            public string name_on_card { get; set; }

            public string card_street { get; set; }

            public string card_street2 { get; set; }

            public string card_city { get; set; }

            public string card_state { get; set; }

            public string card_zip { get; set; }

            public string card_country { get; set; }

            public string card_phone { get; set; }

            public string card_email { get; set; }

            public string batch_number { get; set; }

            public string posted_by { get; set; }

            public string card_type { get; set; }

            public string sales_tax { get; set; }

            public string aba { get; set; }

            public string dda { get; set; }

            public bool? is_ach { get; set; }

            public string ach_account_type { get; set; }

            public long? ach_number { get; set; }

            public bool? is_moto { get; set; }

            public bool? is_retail { get; set; }

            public bool? is_ecom { get; set; }

            public string ach_category_text { get; set; }

            public string ach_class_code { get; set; }

            public string ach_entry { get; set; }

            public string cim_ref_num { get; set; }

            public int? cim_sequence { get; set; }

            public bool? is_directmarketing { get; set; }

            public bool? is_restaurant { get; set; }

            public bool? is_hotel { get; set; }

            public string gratuity_amount { get; set; }

            public string mid { get; set; }

            public string tid { get; set; }

            public int? txn_sources_id { get; set; }

            public string firstfund_username { get; set; }

            public int? event_id { get; set; }

            public bool sig_avail { get; set; }

            public bool? is_pin_debit { get; set; }

            public bool? is_sig_debit { get; set; }

            public bool? is_partial { get; set; }

            public long? partial_id { get; set; }

            public decimal? lat { get; set; }

            public decimal? lng { get; set; }

            public string mobile_device_id { get; set; }

            public string memo { get; set; }

            public DateTime? close_date { get; set; }

            public string iats_bank_number { get; set; }

            public string iats_transit_number { get; set; }

            public int? TipAmount { get; set; }

            public string STIN { get; set; }

            public bool? HasChargeback { get; set; }

            public int? FullAmount { get; set; }

            public bool? settled { get; set; }

            public int? OnlineBillPayFee { get; set; }

            public int? ProcessingFee { get; set; }

        
    }
}
