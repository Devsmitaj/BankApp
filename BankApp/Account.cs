using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    /// <summary>
    /// Bank account
    /// </summary>
    class Account
    {
        #region
        /// <summary>
        /// Unique account number for the account
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// Email address of 
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Account Current Balance
        /// </summary>
        public decimal Balance { get; set; }

        public string TypeOfAccount { get; set; }
        #endregion

    }
}
