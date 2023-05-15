using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perez_MultiUserBank_
{
    internal class Bank
    {

        string[] idname = new string[4] { "jlennon", "pmccartney", "gharrison", "rstarr" };
        string[] idpassword = new string[4] { "johnny", "pauly", "georgy", "ringoy" };
        decimal[] idbalance = new decimal[4] { 1250, 2500, 3000, 1000 };
        private decimal _bankbalance = 10000M;

        public bool CheckId(string username, string password)
        {
            for (int i = 0; i < 4; i++)
            {
                if (username == idname[0] && password == idpassword[0])
                {
                    return true;
                }
                if (username == idname[1] && password == idpassword[1])
                {
                    return true;
                }
                if (username == idname[2] && password == idpassword[2])
                {
                    return true;
                }
                if (username == idname[3] && password == idpassword[3])
                {
                    return true;
                }


            }
            return false;
        }

        public decimal Deposit(decimal deposit, string username)
        {
            for (int i = 0; i < 4; i++)

            {
                if (deposit > 0 && username == idname[0])
                {
                    idbalance[0] += deposit;
                    return idbalance[0];
                }

                if (deposit > 0 && username == idname[1])
                {
                    idbalance[1] += deposit;
                    return idbalance[1];
                }

                if (deposit > 0 && username == idname[2])
                {
                    idbalance[2] += deposit;
                    return idbalance[2];
                }

                if (deposit > 0 && username == idname[3])
                {
                    idbalance[3] += deposit;
                    return idbalance[3];
                }
            }

            return deposit;


        }

        public decimal withdraw(decimal withdraw, string username)
        {
            for (int i = 0; i < 4; i++)
            {

                if (username == idname[0])
                {
                    if (withdraw > 500)
                        withdraw = 500;
                    if (withdraw > idbalance[0])
                        withdraw = idbalance[0];

                    idbalance[0] -= withdraw;

                    if (idbalance[0] == 0 && withdraw > 0)
                        idbalance[0] = 0;
                    return idbalance[0];


                }

                if (username == idname[1])
                {
                    if (withdraw > 500)
                        withdraw = 500;
                    if (withdraw > idbalance[1])
                        withdraw = idbalance[1];

                    idbalance[1] -= withdraw;

                    if (idbalance[1] == 0 && withdraw > 0)
                        idbalance[1] = 0;



                    return idbalance[1];



                }

                if (username == idname[2])
                {
                    if (withdraw > 500)
                        withdraw = 500;
                    if (withdraw > idbalance[2])
                        withdraw = idbalance[2];

                    idbalance[2] -= withdraw;

                    if (idbalance[2] == 0 && withdraw > 0)
                        idbalance[2] = 0;
                    return idbalance[2];


                }

                if (username == idname[3])
                {
                    if (withdraw > 500)
                        withdraw = 500;
                    if (withdraw > idbalance[3])
                        withdraw = idbalance[3];

                    idbalance[3] -= withdraw;

                    if (idbalance[3] == 0 && withdraw > 0)
                        idbalance[3] = 0;
                    return idbalance[3];


                }

            }


            return withdraw;
        }

        public decimal withdrawbank(decimal withdraw, string username)
        {
            if (withdraw > 500)
                withdraw = 500M;

            if (withdraw > idbalance[0] && username == idname[0])
            {
                withdraw = idbalance[0];
            }
            if (withdraw > idbalance[1] && username == idname[1])
            {
                withdraw = idbalance[1];
            }
            if (withdraw > idbalance[2] && username == idname[2])
            {
                withdraw = idbalance[2];
            }
            if (withdraw > idbalance[3] && username == idname[3])
            {
                withdraw = idbalance[3];
            }

            if (idbalance[0] == 0 && withdraw > 0 && username == idname[0])
            {
                withdraw = 0;
            }
            if (idbalance[1] == 0 && withdraw > 0 && username == idname[1])
            {
                withdraw = 0;
            }
            if (idbalance[2] == 0 && withdraw > 0 && username == idname[2])
            {
                withdraw = 0;
            }
            if (idbalance[3] == 0 && withdraw > 0 && username == idname[3])
            {
                withdraw = 0;
            }


            _bankbalance -= withdraw;

            return _bankbalance;
        }

        public decimal BankBalancedeposit(decimal deposit)
        {
            _bankbalance += deposit;
            return _bankbalance;
        }

        public decimal User1Balance
        {
            get { return idbalance[0]; }
        }

        public decimal User2Balance
        {
            get { return idbalance[1]; }
        }

        public decimal User3Balance
        {
            get { return idbalance[2]; }
        }

        public decimal User4Balance
        {
            get { return idbalance[3]; }
        }

        public decimal BankBalance
        {
            get { return _bankbalance; }
        }


    }
}
