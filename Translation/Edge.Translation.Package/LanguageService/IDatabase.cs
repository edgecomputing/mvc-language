using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
namespace Edge.Translation.LanguageService
{
    interface IDatabase
    {
        void Database(IDbConnection connection);
        void Database(string connectionString, string providerName);
        void Database(string connectionString, DbProviderFactory provider);
        void Database(string connectionStringName);
    }
}
