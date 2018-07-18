using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkillTreeHw1.Repository;
using SkillTreeHw1.Models;
using SkillTreeHw1.Models.ViewModels;

namespace SkillTreeHw1.Services
{
    public class AccountBookService
    {
        private readonly IRepository<AccountBook> _accountBookRepo;

        public AccountBookService(IUnitOfWork unitOfWork)
        {
            _accountBookRepo = new Repository<AccountBook>(unitOfWork);
        }

        public IEnumerable<AccountBookViewModel> GetAll()
        {
            var source = _accountBookRepo.LookupAll().OrderByDescending(a => a.Dateee);
            var result = source.Select(r => new AccountBookViewModel
            {
                Category = (Category)r.Categoryyy,
                Date = r.Dateee,
                Amount = r.Amounttt
            });
            return result;
        }

        public void Add(AccountBook accountBook)
        {
            _accountBookRepo.Create(accountBook);
        }

        //public void Edit(Guid id, AccountBook newData)
        //{
        //    var oldData = _accountBookRepo.GetSingle(a => a.Id == id);
        //    if(oldData != null)
        //    {
        //        oldData.Categoryyy = newData.Categoryyy;
        //        oldData.Dateee = newData.Dateee;
        //        oldData.Amounttt = newData.Amounttt;
        //    }
        //}

        public void Delete(Guid id)
        {
            _accountBookRepo.Remove(_accountBookRepo.GetSingle(a => a.Id == id));
        }
    }
}