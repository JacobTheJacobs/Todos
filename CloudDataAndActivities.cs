using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_s03.Models
{
    class CloudDataAndActivities
    {
        //End Point Uri
        private string endPointUri;
        public string EndPointUri { 
            get
            {
                return endPointUri; 
            } 
          }
        private string privateKey;

        //Private Key
        public string PrivateKey
        {
            get
            {
                return privateKey;
            }
        }

        //Is Cosmos Db Client Created
        private bool isCosmosDbClientCreated = false;
        public bool IsCosmosDbClientCreated
        {
            get
            {
                return isCosmosDbClientCreated;
            }
            set
            {
                isCosmosDbClientCreated = true;
            }
        }

        //Cosmos Client
        private Microsoft.Azure.Cosmos.CosmosClient cosmosClient;

        private List<Models.DataBase> cloudDatabase = new List<Models.DataBase>();
        public List<Models.DataBase> CloudDatabse
        {
            get
            {
                return cloudDatabase;
            }
            
        }
        //Cloud Tables
        private List<Models.Table> cloudTable = new List<Models.Table>();
        public List<Models.Table> CloudTable
        {
            get
            {
                return cloudTable;
            }

        }

        //Data Base Name
        private string dataBaseName;
        public string DataBaseName
        {
            get
            {
                return dataBaseName;
            }
            set
            {
                dataBaseName = value;
            }
        }


        //Data Base Object
        private Microsoft.Azure.Cosmos.Database dataBaseObject =null;
        public Microsoft.Azure.Cosmos.Database DataBaseObject
        {
            get
            {
                return dataBaseObject;
            }
          
        }

        //Table Name
        private string tableName;
        public string TableName
        {
            get
            {
                return tableName;
            }
            set
            {
                tableName = value;
            }
        }

        //Container
        private Microsoft.Azure.Cosmos.Container container = null;

        public Microsoft.Azure.Cosmos.Container Container
        {
            get
            {
                return container;
            }
        }


        //Students Data As String
        private string studentsDataAsString = String.Empty;
        public string StudentsDataAsString
        {
            get
            {
                return studentsDataAsString;
            }
            set
            {
                studentsDataAsString = value;
            }
        }

        //Students Data As String
        private enum rowStatus 
        {
            NotModified,
            Modified,
            New,
            Deleted
        }


    }
}
