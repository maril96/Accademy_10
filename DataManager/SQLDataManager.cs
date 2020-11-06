using Accademy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class SQLDataManager : IDataManager
    {
        public DataOperationResult CreateNewCliente(Cliente newclient)
        {
            throw new NotImplementedException();
        }


        public bool LoginIsOk(string username, string password)
        {
            throw new NotImplementedException();
        }
        public bool ThereIsCC(string username)
        {
            throw new NotImplementedException();
        }

        ContoCorrente IDataManager.GetContoCorrenteByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
