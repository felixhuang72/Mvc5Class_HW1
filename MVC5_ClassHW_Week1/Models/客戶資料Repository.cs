using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5_ClassHW_Week1.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        public override IQueryable<客戶資料> All()
        {
            return base.All().Where(p => p.IsDelete == false);
        }

        public IQueryable GetTop5_Datas()
        {
            return this.All().Take(5);
        }

        public 客戶資料 Find(int id)
        {
            return this.All().Where(p => p.Id == id).FirstOrDefault();
        }

        public override void Add(客戶資料 entity){
            base.Add(entity);
        }

        public override void Delete(客戶資料 entity)
        {
            entity.IsDelete = true;
        }
	}

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}