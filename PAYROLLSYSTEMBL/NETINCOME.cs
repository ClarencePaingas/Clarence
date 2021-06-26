using System;
using System.Collections.Generic;
using System.Text;
using PAYROLLSYSTEMDL;

namespace PAYROLLSYSTEMBL
{
    public class NETINCOME
    {
        public static int GetNetIncome { get; set; }

        //public static void NetIncome()
        //{
        //    var AllDeductions = CALCULATE.Tax + CALCULATE.SSS + CALCULATE.PhilHealth +
        //                        CALCULATE.PagIbig + CALCULATE.CashAdvance +
        //                        CALCULATE.SalaryLoan + CALCULATE.PagIbigLoan +
        //                        CALCULATE.Others;
        //    GetNetIncome = GROSSINCOME.GetGrossIncome - AllDeductions;
        //}

    }
}
