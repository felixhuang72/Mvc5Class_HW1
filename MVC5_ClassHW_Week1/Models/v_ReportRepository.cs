using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5_ClassHW_Week1.Models
{   
	public  class v_ReportRepository : EFRepository<v_Report>, Iv_ReportRepository
	{

	}

	public  interface Iv_ReportRepository : IRepository<v_Report>
	{

	}
}