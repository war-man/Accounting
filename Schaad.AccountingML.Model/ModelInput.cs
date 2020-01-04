// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace Schaad.AccountingML.Model
{
    public class ModelInput
    {
        [ColumnName("BankTransactionText"), LoadColumn(0)]
        public string BankTransactionText { get; set; }


        [ColumnName("Value"), LoadColumn(1)]
        public float Value { get; set; }


        [ColumnName("ValueDate"), LoadColumn(2)]
        public string ValueDate { get; set; }


        [ColumnName("Text"), LoadColumn(3)]
        public string Text { get; set; }


        [ColumnName("TargetAccountId"), LoadColumn(4)]
        public string TargetAccountId { get; set; }


    }
}