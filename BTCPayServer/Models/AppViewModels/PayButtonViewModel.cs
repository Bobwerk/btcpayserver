﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BTCPayServer.Models.AppViewModels
{
    public class PayButtonViewModel
    {
        public decimal Price { get; set; }
        [Required]
        public string Currency { get; set; }
        public string CheckoutDesc { get; set; }
        public string OrderId { get; set; }
        public int ButtonSize { get; set; }
        [Url]
        public string ServerIpn { get; set; }
        [Url]
        public string BrowserRedirect { get; set; }
        [EmailAddress]
        public string NotifyEmail { get; set; }

        public string AppId { get; set; }

        // Data that influences Pay Button UI, but not invoice creation
        public string UrlRoot { get; set; }
        public List<string> CurrencyDropdown { get; set; }
        public string PayButtonImageUrl { get; set; }
    }
}
