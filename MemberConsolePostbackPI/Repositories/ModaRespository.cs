using MemberConsolePostbackAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MemberConsolePostbackAPI.Repositories
{
    public class ModaRespository : BaseRepository, IModaRepository
    {
        private string ConnectionString { get; }
        private const string _INSERT_SP_ = "";
        private const string _UPDATE_SP_ = "";
        private const string _SELECTALL_SP_ = "";
        private const string _DELETE_SP_ = "";

        public ModaRespository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        }

        public bool Insert(DataModel addDataModel)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            if (!IsValidJson(addDataModel.IJSON))
            {
                return false;
            }

            using (SqlCommand cmd = new SqlCommand(_INSERT_SP_, connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("IJSON", addDataModel.IJSON));

                cmd.ExecuteReader();
            }

            
            return true ;
        }

        public bool Delete(int id)
        {
            return false;
        }

        public List<DataModel> SelectAll()
        {
            return null;
        }

        public bool Update(DataModel updateDataModel)
        {
            return false;
        }

   
    }
}