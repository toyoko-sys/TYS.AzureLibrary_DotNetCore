using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TYS.AzureLibrary
{
    /// <summary>
    /// AzureStorageConnectionString から CloudStorageAccount を取得
    /// </summary>
    public class StorageConnectionSettings
    {
        public static CloudStorageAccount GetStorageAccount(string storageConnectiongString)
        {
            return CloudStorageAccount.Parse(storageConnectiongString);
        }
    }
}
