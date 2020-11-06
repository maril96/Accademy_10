using Accademy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public interface IDataManager
    {
        bool LoginIsOk(string username, string password);
        bool ThereIsCC(string username);
        DataOperationResult CreateNewCliente(Cliente newclient);
        ContoCorrente GetContoCorrenteByUsername(string username);
    }
}
