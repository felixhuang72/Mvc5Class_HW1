using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5_ClassHW_Week1.Models
{   
	public  class sysdiagramsRepository : EFRepository<sysdiagrams>, IsysdiagramsRepository
	{

	}

	public  interface IsysdiagramsRepository : IRepository<sysdiagrams>
	{

	}
}