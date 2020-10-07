using Core.Api.Data.Models;
using GraphQL.Types;

namespace GraphQLCore.Types
{
    public class ResponseCodeType : ObjectGraphType<ResponseCodes>
    {
        public ResponseCodeType()
        {
            Name = "ResponseCode";
            Field(x => x.id, type: typeof(IdGraphType)).Description("Id");
            Field(x => x.merchant_id).Description("Merchant Id");
            Field(x => x.storename).Description("Store Name");
            Field(x => x.order_id).Description("Order Id");
            Field(x => x.processor).Description("Processor");
            Field(x => x.transaction_id).Description("Transaction Id");
            Field(x => x.reference_number).Description("Reference Number");
            
            Field(x => x.amount).Description("Amount");
            Field(x => x.etc_trans_type).Description("Etc Trans Type");
            Field(x => x.success).Description("Success");
            Field(x => x.auth_response, nullable: true).Description("Auth Response");
            Field(x => x.auth_code).Description("Auth Code");
            Field(x => x.avs_response).Description("Avs Response");
            Field(x => x.cvv2_response).Description("Cvv2 Response");

            Field(x => x.transaction_date).Description("Transaction Date");
            Field(x => x.card_num).Description("Card Number");
            Field(x => x.card_exp).Description("Card Exp");
            Field(x => x.name_on_card).Description("Name On Card");
            Field(x => x.card_street).Description("Card Street");

            Field(x => x.card_street2).Description("Card Street2");
            Field(x => x.card_city).Description("Card City");
            Field(x => x.card_state).Description("Card State");
            Field(x => x.card_zip).Description("Card Zip");
            Field(x => x.card_country).Description("Card Country");
            Field(x => x.card_phone).Description("Card Phone");
            Field(x => x.card_email).Description("Card Email");

            Field(x => x.batch_number, nullable: true).Description("batch_number");
            Field(x => x.card_type).Description("card type");
            Field(x => x.sales_tax).Description("sales tax");
            Field(x => x.is_moto,nullable:true).Description("is moto");
            Field(x => x.is_retail, nullable: true).Description("is retail");
            Field(x => x.is_ecom, nullable: true).Description("is ecom");
            Field(x => x.mid).Description("mid");

            Field(x => x.tid).Description("tid");
            Field(x => x.txn_sources_id, nullable: true).Description("txn sources id");
            Field(x => x.is_partial, nullable: true).Description("is partial");

        }
    }
}

