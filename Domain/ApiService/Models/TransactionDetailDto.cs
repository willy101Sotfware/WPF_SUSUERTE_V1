﻿namespace WPF_SUSUERTE_V1.Domain.ApiService.Models
{
    public class TransactionDetailDto : DtoCommon
    {
        public int IdTransaction { get; set; }
        public int IdCurrencyDenomination { get; set; }
        public int CurrencyDenomination { get; set; }
        public int IdTypeOperation { get; set; }
        public string TypeOperation { get; set; }
    }

}
