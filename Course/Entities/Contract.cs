using System;
using System.Collections.Generic;

namespace Course.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; private set; }

        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallments(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
