using System;
using System.Collections.Generic;
using System.Text;

namespace AddItemsToDynamoDB
{

    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public string GUID { get; set; }
        public string LoanType { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CreditCardVarient { get; set; }
        public string CurrentCardLimit { get; set; }
        public string ServiceProvidingBank { get; set; }
        public string CreditScore { get; set; }
        public string RiskCatagory { get; set; }
    }
}
