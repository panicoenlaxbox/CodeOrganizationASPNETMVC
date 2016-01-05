using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeOrganization.Models
{
    public interface ICustomersRepository
    {
        void Save();
    }

    public class CustomersRepository : ICustomersRepository
    {
        public void Save()
        {
            
        }
    }
}