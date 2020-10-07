using GraphQL.Types;

namespace GraphQLCore.Types
{
    public class ResponseCodeInputType : InputObjectGraphType
    {
        public ResponseCodeInputType()
        {
            Name = "ResponseCodeInputType";

            Field<NonNullGraphType<IntGraphType>>("Id").Description = "Id";

            Field<NonNullGraphType<IntGraphType>>("merchant_id").Description = "merchant_id";
            Field<NonNullGraphType<StringGraphType>>("storename").Description = "storename";
            Field<NonNullGraphType<StringGraphType>>("order_id").Description = "order_id";
            Field<NonNullGraphType<StringGraphType>>("processor").Description = "processor";
            Field<NonNullGraphType<IntGraphType>>("transaction_id").Description = "transaction_id";
            Field<NonNullGraphType<IntGraphType>>("reference_number").Description = "reference_number";

            Field<NonNullGraphType<IntGraphType>>("amount").Description = "amount";
            Field<NonNullGraphType<StringGraphType>>("etc_trans_type").Description = "etc_trans_type";
            Field<NonNullGraphType<BooleanGraphType>>("success").Description = "success";
            Field<NonNullGraphType<StringGraphType>>("auth_code").Description = "auth_code";
            Field<NonNullGraphType<StringGraphType>>("avs_response").Description = "avs_response";
            Field<NonNullGraphType<StringGraphType>>("cvv2_response").Description = "cvv2 response";

            Field<NonNullGraphType<DateTimeGraphType>>("transaction_date").Description = "transaction_date";
            Field<NonNullGraphType<StringGraphType>>("card_num").Description = "card_num";
            Field<NonNullGraphType<StringGraphType>>("card_exp").Description = "card_exp";
            Field<NonNullGraphType<StringGraphType>>("name_on_card").Description = "name_on_card";
            Field<NonNullGraphType<StringGraphType>>("card_street").Description = "card_street";
            Field<NonNullGraphType<StringGraphType>>("card_street2").Description = "cvv2 card_street2";

            Field<NonNullGraphType<StringGraphType>>("card_city").Description = "card_city";
            Field<NonNullGraphType<StringGraphType>>("card_state").Description = "card_state";
            Field<NonNullGraphType<StringGraphType>>("card_zip").Description = "card_zip";
            Field<NonNullGraphType<StringGraphType>>("card_country").Description = "card_country";
            Field<NonNullGraphType<StringGraphType>>("card_phone").Description = "card_phone";
            Field<NonNullGraphType<StringGraphType>>("card_email").Description = "card_email";

            Field<NonNullGraphType<StringGraphType>>("batch_number").Description = "batch_number";
            Field<NonNullGraphType<StringGraphType>>("card_type").Description = "card_type";
            Field<NonNullGraphType<StringGraphType>>("sales_tax").Description = "sales_tax";
            Field<NonNullGraphType<BooleanGraphType>>("is_moto").Description = "is_moto";
            Field<NonNullGraphType<BooleanGraphType>>("is_retail").Description = "is_retail";
            Field<NonNullGraphType<BooleanGraphType>>("is_ecom").Description = "is_ecom";

            Field<NonNullGraphType<StringGraphType>>("mid").Description = "mid";
            Field<NonNullGraphType<StringGraphType>>("tid").Description = "tid";
            Field<NonNullGraphType<IntGraphType>>("txn_sources_id").Description = "txn_sources_id";
            Field<NonNullGraphType<BooleanGraphType>>("is_partial").Description = "is_partial";
            Field<NonNullGraphType<BooleanGraphType>>("sig_avail").Description = "is_partial";
            

        }
       
    }
}
