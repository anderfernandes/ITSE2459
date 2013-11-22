using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class CDAccount : SavingsAccount
    {
        // Field
        private string _maturityDate;

        // Constructor
        public CDAccount()
        {
            _maturityDate = "";
        }

        // Constructor
        public CDAccount(string sAcct, decimal dIrate, decimal dBal, string sMat)
            : base(sAcct, dIrate, dBal)
        {
            _maturityDate = sMat;
        }

        // Maturitydate property
        public string MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }
    }
}
