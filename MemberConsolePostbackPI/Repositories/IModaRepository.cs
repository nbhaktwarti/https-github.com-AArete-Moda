using MemberConsolePostbackAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberConsolePostbackAPI.Repositories
{
    public interface IModaRepository 
    {
        bool Insert(DataModel addDataModel);
        List<DataModel> SelectAll();
        bool Update(DataModel updateDataModel);
        bool Delete(int id);

    }
}