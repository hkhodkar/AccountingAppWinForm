using Accounting.DataLayer.Context.UnitOfWorks;
using System;
using System.Linq;
using ViewModels.Report;

namespace Accounting.Business
{
    public class Account
    {
        public static HomeReportViewModels HomeReport()
        {
            var rp = new HomeReportViewModels();
            using (var uow = new UnitOfWorks())
            {
                var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                var endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                var recieve = uow.AccountingRepo.GetAll(r => r.TypeID_typ == 2 && r.CreationDate >= startDate && r.CreationDate<= endDate)
                    .Sum(r => int.Parse(r.Amount));
                var pays = uow.AccountingRepo.GetAll(p => p.TypeID_typ == 1 && p.CreationDate >= startDate && p.CreationDate <= endDate)
                              .Sum(s => int.Parse(s.Amount));
                rp.Receive = recieve;
                rp.Pay = pays;
                rp.AccountBalance = recieve - pays;
            }
            return rp;
        }
    }
}
