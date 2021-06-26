using System;
using System.Collections.Generic;
using System.Text;
using PAYROLLSYSTEMDL;
using PAYROLLSYSTEMBL;

namespace PAYROLLSYSTEMBL
{
    public class GROSSINCOME : CALCULATE

    {
        //public static int number { get; set; }
        //public static int numbers { get; set; }

        private int _hourlyRate = 40;
        private static int _oTRate = 200;
        private int _hoursWorked;
        private int _getGrossIncome;

        public static int HoursWorked { get; set; }

        public  int HourlyRate
        {
            get
            {
                return _hourlyRate;
            }
        }
        public  int OTWorked { get; set; }

        public int OTRate
        {
            get
            {
                return _oTRate;
            }
        }

        public int Bonus { get; set; }
        public  int GetGrossIncome
        {
            get { return _getGrossIncome; }
            set { _getGrossIncome = value; }
        }
        public static int HourlySalary { get; set; }
        //public static int GetGrossIncome { get; set; }
        public static void GrossIncome()
        {

            NETINCOME.GetNetIncome = HoursWorked * 5;
            //var OTSalary = OTWorked * 20;
            //_getGrossIncome = HourlySalary;

        }

        //public static int answer { get; set; }
        //public static void add()
        //{
        //    var hi = 20;
        //    var hello = CALCULATE.number * hi;
        //    var me = CALCULATE.numbers + hello;
        //}

    }
}
