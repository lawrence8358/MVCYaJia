using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVCYaJia.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{

	}

	public  interface IClientRepository : IRepository<Client>
	{

	}
}