using DevExpress.ExpressApp.Xpo;
using System;
using System.Data;

namespace HRM.Spa {
    public class XpoDataStoreProviderService
    {
        private IXpoDataStoreProvider dataStoreProvider;
        public IXpoDataStoreProvider GetDataStoreProvider(string connectionString, IDbConnection connection, bool enablePoolingInConnectionString) {
            if(dataStoreProvider == null) {
                dataStoreProvider = XPObjectSpaceProvider.GetDataStoreProvider(connectionString, connection, true);
            }
            return dataStoreProvider;
        }

    }
}
