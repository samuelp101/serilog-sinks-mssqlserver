﻿using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

// This is an empty stub implementaion of IAzureManagedServiceAuthenticator for the target frameworks
// that don't support Azure Managed Identities (net452, net461, netstandard2.0, netcoreapp2.0).
namespace Serilog.Sinks.MSSqlServer.Sinks.MSSqlServer.Platform
{
    [SuppressMessage("CodeQuality", "IDE0052:Remove unread private members", Justification = "Empty stub but has to implement interface therefore parameters are not used.")]
    internal class AzureManagedServiceAuthenticator : IAzureManagedServiceAuthenticator
    {
        private readonly bool _useAzureManagedIdentity;
        private readonly string _azureServiceTokenProviderResource;

        public AzureManagedServiceAuthenticator(bool useAzureManagedIdentity, string azureServiceTokenProviderResource)
        {
            _useAzureManagedIdentity = useAzureManagedIdentity;
            _azureServiceTokenProviderResource = azureServiceTokenProviderResource;
        }

        public void SetAuthenticationToken(SqlConnection sqlConnection)
        {
        }
    }
}
