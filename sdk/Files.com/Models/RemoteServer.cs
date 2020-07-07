using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Files.Models
{
    public class RemoteServer
    {
        private Dictionary<string, object> attributes;
        private Dictionary<string, object> options;
        public RemoteServer()
        {
            this.attributes = new Dictionary<string, object>();
            this.options = new Dictionary<string, object>();

            this.attributes.Add("id", null);
            this.attributes.Add("authentication_method", null);
            this.attributes.Add("hostname", null);
            this.attributes.Add("name", null);
            this.attributes.Add("port", null);
            this.attributes.Add("max_connections", null);
            this.attributes.Add("s3_bucket", null);
            this.attributes.Add("s3_region", null);
            this.attributes.Add("server_certificate", null);
            this.attributes.Add("server_host_key", null);
            this.attributes.Add("server_type", null);
            this.attributes.Add("ssl", null);
            this.attributes.Add("username", null);
            this.attributes.Add("google_cloud_storage_bucket", null);
            this.attributes.Add("google_cloud_storage_project_id", null);
            this.attributes.Add("backblaze_b2_s3_endpoint", null);
            this.attributes.Add("backblaze_b2_bucket", null);
            this.attributes.Add("wasabi_bucket", null);
            this.attributes.Add("wasabi_region", null);
            this.attributes.Add("rackspace_username", null);
            this.attributes.Add("rackspace_region", null);
            this.attributes.Add("rackspace_container", null);
            this.attributes.Add("auth_setup_link", null);
            this.attributes.Add("auth_status", null);
            this.attributes.Add("auth_account_name", null);
            this.attributes.Add("one_drive_account_type", null);
            this.attributes.Add("aws_access_key", null);
            this.attributes.Add("aws_secret_key", null);
            this.attributes.Add("password", null);
            this.attributes.Add("private_key", null);
            this.attributes.Add("google_cloud_storage_credentials_json", null);
            this.attributes.Add("wasabi_access_key", null);
            this.attributes.Add("wasabi_secret_key", null);
            this.attributes.Add("backblaze_b2_key_id", null);
            this.attributes.Add("backblaze_b2_application_key", null);
            this.attributes.Add("rackspace_api_key", null);
            this.attributes.Add("reset_authentication", null);
        }

        public RemoteServer(Dictionary<string, object> attributes, Dictionary<string, object> options)
        {
            this.attributes = attributes;
            this.options = options;
        }

        /// <summary>
        /// Remote server ID
        /// </summary>
        [JsonPropertyName("id")]
        public Nullable<Int64> Id
        {
            get { return (Nullable<Int64>) attributes["id"]; }
            set { attributes["id"] = value; }
        }

        /// <summary>
        /// Type of authentication method
        /// </summary>
        [JsonPropertyName("authentication_method")]
        public string AuthenticationMethod
        {
            get { return (string) attributes["authentication_method"]; }
            set { attributes["authentication_method"] = value; }
        }

        /// <summary>
        /// Hostname or IP address
        /// </summary>
        [JsonPropertyName("hostname")]
        public string Hostname
        {
            get { return (string) attributes["hostname"]; }
            set { attributes["hostname"] = value; }
        }

        /// <summary>
        /// Internal name for your reference
        /// </summary>
        [JsonPropertyName("name")]
        public string Name
        {
            get { return (string) attributes["name"]; }
            set { attributes["name"] = value; }
        }

        /// <summary>
        /// Port for remote server.  Not needed for S3.
        /// </summary>
        [JsonPropertyName("port")]
        public Nullable<Int64> Port
        {
            get { return (Nullable<Int64>) attributes["port"]; }
            set { attributes["port"] = value; }
        }

        /// <summary>
        /// Max number of parallel connections.  Ignored for S3 connections (we will parallelize these as much as possible).
        /// </summary>
        [JsonPropertyName("max_connections")]
        public Nullable<Int64> MaxConnections
        {
            get { return (Nullable<Int64>) attributes["max_connections"]; }
            set { attributes["max_connections"] = value; }
        }

        /// <summary>
        /// S3 bucket name
        /// </summary>
        [JsonPropertyName("s3_bucket")]
        public string S3Bucket
        {
            get { return (string) attributes["s3_bucket"]; }
            set { attributes["s3_bucket"] = value; }
        }

        /// <summary>
        /// S3 region
        /// </summary>
        [JsonPropertyName("s3_region")]
        public string S3Region
        {
            get { return (string) attributes["s3_region"]; }
            set { attributes["s3_region"] = value; }
        }

        /// <summary>
        /// Remote server certificate
        /// </summary>
        [JsonPropertyName("server_certificate")]
        public string ServerCertificate
        {
            get { return (string) attributes["server_certificate"]; }
            set { attributes["server_certificate"] = value; }
        }

        /// <summary>
        /// Remote server SSH Host Key. If provided, we will require that the server host key matches the provided key. Uses OpenSSH format similar to what would go into ~/.ssh/known_hosts
        /// </summary>
        [JsonPropertyName("server_host_key")]
        public string ServerHostKey
        {
            get { return (string) attributes["server_host_key"]; }
            set { attributes["server_host_key"] = value; }
        }

        /// <summary>
        /// Remote server type.
        /// </summary>
        [JsonPropertyName("server_type")]
        public string ServerType
        {
            get { return (string) attributes["server_type"]; }
            set { attributes["server_type"] = value; }
        }

        /// <summary>
        /// Should we require SSL?
        /// </summary>
        [JsonPropertyName("ssl")]
        public string Ssl
        {
            get { return (string) attributes["ssl"]; }
            set { attributes["ssl"] = value; }
        }

        /// <summary>
        /// Remote server username.  Not needed for S3 buckets.
        /// </summary>
        [JsonPropertyName("username")]
        public string Username
        {
            get { return (string) attributes["username"]; }
            set { attributes["username"] = value; }
        }

        /// <summary>
        /// Google Cloud Storage bucket name
        /// </summary>
        [JsonPropertyName("google_cloud_storage_bucket")]
        public string GoogleCloudStorageBucket
        {
            get { return (string) attributes["google_cloud_storage_bucket"]; }
            set { attributes["google_cloud_storage_bucket"] = value; }
        }

        /// <summary>
        /// Google Cloud Project ID
        /// </summary>
        [JsonPropertyName("google_cloud_storage_project_id")]
        public string GoogleCloudStorageProjectId
        {
            get { return (string) attributes["google_cloud_storage_project_id"]; }
            set { attributes["google_cloud_storage_project_id"] = value; }
        }

        /// <summary>
        /// Backblaze B2 Cloud Storage S3 Endpoint
        /// </summary>
        [JsonPropertyName("backblaze_b2_s3_endpoint")]
        public string BackblazeB2S3Endpoint
        {
            get { return (string) attributes["backblaze_b2_s3_endpoint"]; }
            set { attributes["backblaze_b2_s3_endpoint"] = value; }
        }

        /// <summary>
        /// Backblaze B2 Cloud Storage Bucket name
        /// </summary>
        [JsonPropertyName("backblaze_b2_bucket")]
        public string BackblazeB2Bucket
        {
            get { return (string) attributes["backblaze_b2_bucket"]; }
            set { attributes["backblaze_b2_bucket"] = value; }
        }

        /// <summary>
        /// Wasabi region
        /// </summary>
        [JsonPropertyName("wasabi_bucket")]
        public string WasabiBucket
        {
            get { return (string) attributes["wasabi_bucket"]; }
            set { attributes["wasabi_bucket"] = value; }
        }

        /// <summary>
        /// Wasabi Bucket name
        /// </summary>
        [JsonPropertyName("wasabi_region")]
        public string WasabiRegion
        {
            get { return (string) attributes["wasabi_region"]; }
            set { attributes["wasabi_region"] = value; }
        }

        /// <summary>
        /// Rackspace username used to login to the Rackspace Cloud Control Panel.
        /// </summary>
        [JsonPropertyName("rackspace_username")]
        public string RackspaceUsername
        {
            get { return (string) attributes["rackspace_username"]; }
            set { attributes["rackspace_username"] = value; }
        }

        /// <summary>
        /// Three letter airport code for Rackspace region. See https://support.rackspace.com/how-to/about-regions/
        /// </summary>
        [JsonPropertyName("rackspace_region")]
        public string RackspaceRegion
        {
            get { return (string) attributes["rackspace_region"]; }
            set { attributes["rackspace_region"] = value; }
        }

        /// <summary>
        /// The name of the container (top level directory) where files will sync.
        /// </summary>
        [JsonPropertyName("rackspace_container")]
        public string RackspaceContainer
        {
            get { return (string) attributes["rackspace_container"]; }
            set { attributes["rackspace_container"] = value; }
        }

        /// <summary>
        /// Returns link to login with an Oauth provider
        /// </summary>
        [JsonPropertyName("auth_setup_link")]
        public string AuthSetupLink
        {
            get { return (string) attributes["auth_setup_link"]; }
            set { attributes["auth_setup_link"] = value; }
        }

        /// <summary>
        /// Either `in_setup` or `complete`
        /// </summary>
        [JsonPropertyName("auth_status")]
        public string AuthStatus
        {
            get { return (string) attributes["auth_status"]; }
            set { attributes["auth_status"] = value; }
        }

        /// <summary>
        /// Describes the authorized account
        /// </summary>
        [JsonPropertyName("auth_account_name")]
        public string AuthAccountName
        {
            get { return (string) attributes["auth_account_name"]; }
            set { attributes["auth_account_name"] = value; }
        }

        /// <summary>
        /// Either personal or business_other account types
        /// </summary>
        [JsonPropertyName("one_drive_account_type")]
        public string OneDriveAccountType
        {
            get { return (string) attributes["one_drive_account_type"]; }
            set { attributes["one_drive_account_type"] = value; }
        }

        /// <summary>
        /// AWS Access Key.
        /// </summary>
        [JsonPropertyName("aws_access_key")]
        public string AwsAccessKey
        {
            get { return (string) attributes["aws_access_key"]; }
            set { attributes["aws_access_key"] = value; }
        }

        /// <summary>
        /// AWS secret key.
        /// </summary>
        [JsonPropertyName("aws_secret_key")]
        public string AwsSecretKey
        {
            get { return (string) attributes["aws_secret_key"]; }
            set { attributes["aws_secret_key"] = value; }
        }

        /// <summary>
        /// Password if needed.
        /// </summary>
        [JsonPropertyName("password")]
        public string Password
        {
            get { return (string) attributes["password"]; }
            set { attributes["password"] = value; }
        }

        /// <summary>
        /// Private key if needed.
        /// </summary>
        [JsonPropertyName("private_key")]
        public string PrivateKey
        {
            get { return (string) attributes["private_key"]; }
            set { attributes["private_key"] = value; }
        }

        /// <summary>
        /// A JSON file that contains the private key. To generate see https://cloud.google.com/storage/docs/json_api/v1/how-tos/authorizing#APIKey
        /// </summary>
        [JsonPropertyName("google_cloud_storage_credentials_json")]
        public string GoogleCloudStorageCredentialsJson
        {
            get { return (string) attributes["google_cloud_storage_credentials_json"]; }
            set { attributes["google_cloud_storage_credentials_json"] = value; }
        }

        /// <summary>
        /// Wasabi access key.
        /// </summary>
        [JsonPropertyName("wasabi_access_key")]
        public string WasabiAccessKey
        {
            get { return (string) attributes["wasabi_access_key"]; }
            set { attributes["wasabi_access_key"] = value; }
        }

        /// <summary>
        /// Wasabi secret key.
        /// </summary>
        [JsonPropertyName("wasabi_secret_key")]
        public string WasabiSecretKey
        {
            get { return (string) attributes["wasabi_secret_key"]; }
            set { attributes["wasabi_secret_key"] = value; }
        }

        /// <summary>
        /// Backblaze B2 Cloud Storage keyID.
        /// </summary>
        [JsonPropertyName("backblaze_b2_key_id")]
        public string BackblazeB2KeyId
        {
            get { return (string) attributes["backblaze_b2_key_id"]; }
            set { attributes["backblaze_b2_key_id"] = value; }
        }

        /// <summary>
        /// Backblaze B2 Cloud Storage applicationKey.
        /// </summary>
        [JsonPropertyName("backblaze_b2_application_key")]
        public string BackblazeB2ApplicationKey
        {
            get { return (string) attributes["backblaze_b2_application_key"]; }
            set { attributes["backblaze_b2_application_key"] = value; }
        }

        /// <summary>
        /// Rackspace API key from the Rackspace Cloud Control Panel.
        /// </summary>
        [JsonPropertyName("rackspace_api_key")]
        public string RackspaceApiKey
        {
            get { return (string) attributes["rackspace_api_key"]; }
            set { attributes["rackspace_api_key"] = value; }
        }

        /// <summary>
        /// Reset authenticated account
        /// </summary>
        [JsonPropertyName("reset_authentication")]
        public bool ResetAuthentication
        {
            get { return (bool) attributes["reset_authentication"]; }
            set { attributes["reset_authentication"] = value; }
        }

        /// <summary>
        /// Parameters:
        ///   aws_access_key - string - AWS Access Key.
        ///   aws_secret_key - string - AWS secret key.
        ///   password - string - Password if needed.
        ///   private_key - string - Private key if needed.
        ///   google_cloud_storage_credentials_json - string - A JSON file that contains the private key. To generate see https://cloud.google.com/storage/docs/json_api/v1/how-tos/authorizing#APIKey
        ///   wasabi_access_key - string - Wasabi access key.
        ///   wasabi_secret_key - string - Wasabi secret key.
        ///   backblaze_b2_key_id - string - Backblaze B2 Cloud Storage keyID.
        ///   backblaze_b2_application_key - string - Backblaze B2 Cloud Storage applicationKey.
        ///   rackspace_api_key - string - Rackspace API key from the Rackspace Cloud Control Panel.
        ///   reset_authentication - boolean - Reset authenticated account
        ///   hostname - string - Hostname or IP address
        ///   name - string - Internal name for your reference
        ///   max_connections - int64 - Max number of parallel connections.  Ignored for S3 connections (we will parallelize these as much as possible).
        ///   port - int64 - Port for remote server.  Not needed for S3.
        ///   s3_bucket - string - S3 bucket name
        ///   s3_region - string - S3 region
        ///   server_certificate - string - Remote server certificate
        ///   server_host_key - string - Remote server SSH Host Key. If provided, we will require that the server host key matches the provided key. Uses OpenSSH format similar to what would go into ~/.ssh/known_hosts
        ///   server_type - string - Remote server type.
        ///   ssl - string - Should we require SSL?
        ///   username - string - Remote server username.  Not needed for S3 buckets.
        ///   google_cloud_storage_bucket - string - Google Cloud Storage bucket name
        ///   google_cloud_storage_project_id - string - Google Cloud Project ID
        ///   backblaze_b2_bucket - string - Backblaze B2 Cloud Storage Bucket name
        ///   backblaze_b2_s3_endpoint - string - Backblaze B2 Cloud Storage S3 Endpoint
        ///   wasabi_bucket - string - Wasabi region
        ///   wasabi_region - string - Wasabi Bucket name
        ///   rackspace_username - string - Rackspace username used to login to the Rackspace Cloud Control Panel.
        ///   rackspace_region - string - Three letter airport code for Rackspace region. See https://support.rackspace.com/how-to/about-regions/
        ///   rackspace_container - string - The name of the container (top level directory) where files will sync.
        ///   one_drive_account_type - string - Either personal or business_other account types
        /// </summary>
        public async Task<RemoteServer> Update(Dictionary<string, object> parameters)
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            parameters["id"] = attributes["id"];

            if (!attributes.ContainsKey("id")) {
                throw new ArgumentException("Current object doesn't have a id");
            }
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (parameters.ContainsKey("aws_access_key") && !(parameters["aws_access_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: aws_access_key must be of type string", "parameters[\"aws_access_key\"]");
            }
            if (parameters.ContainsKey("aws_secret_key") && !(parameters["aws_secret_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: aws_secret_key must be of type string", "parameters[\"aws_secret_key\"]");
            }
            if (parameters.ContainsKey("password") && !(parameters["password"] is string ))
            {
                throw new ArgumentException("Bad parameter: password must be of type string", "parameters[\"password\"]");
            }
            if (parameters.ContainsKey("private_key") && !(parameters["private_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: private_key must be of type string", "parameters[\"private_key\"]");
            }
            if (parameters.ContainsKey("google_cloud_storage_credentials_json") && !(parameters["google_cloud_storage_credentials_json"] is string ))
            {
                throw new ArgumentException("Bad parameter: google_cloud_storage_credentials_json must be of type string", "parameters[\"google_cloud_storage_credentials_json\"]");
            }
            if (parameters.ContainsKey("wasabi_access_key") && !(parameters["wasabi_access_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: wasabi_access_key must be of type string", "parameters[\"wasabi_access_key\"]");
            }
            if (parameters.ContainsKey("wasabi_secret_key") && !(parameters["wasabi_secret_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: wasabi_secret_key must be of type string", "parameters[\"wasabi_secret_key\"]");
            }
            if (parameters.ContainsKey("backblaze_b2_key_id") && !(parameters["backblaze_b2_key_id"] is string ))
            {
                throw new ArgumentException("Bad parameter: backblaze_b2_key_id must be of type string", "parameters[\"backblaze_b2_key_id\"]");
            }
            if (parameters.ContainsKey("backblaze_b2_application_key") && !(parameters["backblaze_b2_application_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: backblaze_b2_application_key must be of type string", "parameters[\"backblaze_b2_application_key\"]");
            }
            if (parameters.ContainsKey("rackspace_api_key") && !(parameters["rackspace_api_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: rackspace_api_key must be of type string", "parameters[\"rackspace_api_key\"]");
            }
            if (parameters.ContainsKey("reset_authentication") && !(parameters["reset_authentication"] is bool ))
            {
                throw new ArgumentException("Bad parameter: reset_authentication must be of type bool", "parameters[\"reset_authentication\"]");
            }
            if (parameters.ContainsKey("hostname") && !(parameters["hostname"] is string ))
            {
                throw new ArgumentException("Bad parameter: hostname must be of type string", "parameters[\"hostname\"]");
            }
            if (parameters.ContainsKey("name") && !(parameters["name"] is string ))
            {
                throw new ArgumentException("Bad parameter: name must be of type string", "parameters[\"name\"]");
            }
            if (parameters.ContainsKey("max_connections") && !(parameters["max_connections"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: max_connections must be of type Nullable<Int64>", "parameters[\"max_connections\"]");
            }
            if (parameters.ContainsKey("port") && !(parameters["port"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: port must be of type Nullable<Int64>", "parameters[\"port\"]");
            }
            if (parameters.ContainsKey("s3_bucket") && !(parameters["s3_bucket"] is string ))
            {
                throw new ArgumentException("Bad parameter: s3_bucket must be of type string", "parameters[\"s3_bucket\"]");
            }
            if (parameters.ContainsKey("s3_region") && !(parameters["s3_region"] is string ))
            {
                throw new ArgumentException("Bad parameter: s3_region must be of type string", "parameters[\"s3_region\"]");
            }
            if (parameters.ContainsKey("server_certificate") && !(parameters["server_certificate"] is string ))
            {
                throw new ArgumentException("Bad parameter: server_certificate must be of type string", "parameters[\"server_certificate\"]");
            }
            if (parameters.ContainsKey("server_host_key") && !(parameters["server_host_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: server_host_key must be of type string", "parameters[\"server_host_key\"]");
            }
            if (parameters.ContainsKey("server_type") && !(parameters["server_type"] is string ))
            {
                throw new ArgumentException("Bad parameter: server_type must be of type string", "parameters[\"server_type\"]");
            }
            if (parameters.ContainsKey("ssl") && !(parameters["ssl"] is string ))
            {
                throw new ArgumentException("Bad parameter: ssl must be of type string", "parameters[\"ssl\"]");
            }
            if (parameters.ContainsKey("username") && !(parameters["username"] is string ))
            {
                throw new ArgumentException("Bad parameter: username must be of type string", "parameters[\"username\"]");
            }
            if (parameters.ContainsKey("google_cloud_storage_bucket") && !(parameters["google_cloud_storage_bucket"] is string ))
            {
                throw new ArgumentException("Bad parameter: google_cloud_storage_bucket must be of type string", "parameters[\"google_cloud_storage_bucket\"]");
            }
            if (parameters.ContainsKey("google_cloud_storage_project_id") && !(parameters["google_cloud_storage_project_id"] is string ))
            {
                throw new ArgumentException("Bad parameter: google_cloud_storage_project_id must be of type string", "parameters[\"google_cloud_storage_project_id\"]");
            }
            if (parameters.ContainsKey("backblaze_b2_bucket") && !(parameters["backblaze_b2_bucket"] is string ))
            {
                throw new ArgumentException("Bad parameter: backblaze_b2_bucket must be of type string", "parameters[\"backblaze_b2_bucket\"]");
            }
            if (parameters.ContainsKey("backblaze_b2_s3_endpoint") && !(parameters["backblaze_b2_s3_endpoint"] is string ))
            {
                throw new ArgumentException("Bad parameter: backblaze_b2_s3_endpoint must be of type string", "parameters[\"backblaze_b2_s3_endpoint\"]");
            }
            if (parameters.ContainsKey("wasabi_bucket") && !(parameters["wasabi_bucket"] is string ))
            {
                throw new ArgumentException("Bad parameter: wasabi_bucket must be of type string", "parameters[\"wasabi_bucket\"]");
            }
            if (parameters.ContainsKey("wasabi_region") && !(parameters["wasabi_region"] is string ))
            {
                throw new ArgumentException("Bad parameter: wasabi_region must be of type string", "parameters[\"wasabi_region\"]");
            }
            if (parameters.ContainsKey("rackspace_username") && !(parameters["rackspace_username"] is string ))
            {
                throw new ArgumentException("Bad parameter: rackspace_username must be of type string", "parameters[\"rackspace_username\"]");
            }
            if (parameters.ContainsKey("rackspace_region") && !(parameters["rackspace_region"] is string ))
            {
                throw new ArgumentException("Bad parameter: rackspace_region must be of type string", "parameters[\"rackspace_region\"]");
            }
            if (parameters.ContainsKey("rackspace_container") && !(parameters["rackspace_container"] is string ))
            {
                throw new ArgumentException("Bad parameter: rackspace_container must be of type string", "parameters[\"rackspace_container\"]");
            }
            if (parameters.ContainsKey("one_drive_account_type") && !(parameters["one_drive_account_type"] is string ))
            {
                throw new ArgumentException("Bad parameter: one_drive_account_type must be of type string", "parameters[\"one_drive_account_type\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/remote_servers/{attributes["id"]}", System.Net.Http.HttpMethod.Patch, parameters, options);

            return JsonSerializer.Deserialize<RemoteServer>(responseJson);
        }


        /// <summary>
        /// </summary>
        public async Task<RemoteServer> Delete(Dictionary<string, object> parameters)
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            parameters["id"] = attributes["id"];

            if (!attributes.ContainsKey("id")) {
                throw new ArgumentException("Current object doesn't have a id");
            }
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/remote_servers/{attributes["id"]}", System.Net.Http.HttpMethod.Delete, parameters, options);

            return JsonSerializer.Deserialize<RemoteServer>(responseJson);
        }

        public async void Destroy(Dictionary<string, object> parameters)
        {
            Delete(parameters);
        }


        public async Task Save()
        {
            if (this.attributes["id"] != null)
            {
                await this.Update(this.attributes);
            }
            else
            {
                // TODO: Remove this cast after return types are implemented
                var newObj = (RemoteServer) await RemoteServer.Create(this.attributes, this.options);
                this.attributes = newObj.attributes;
            }
        }

        /// <summary>
        /// Parameters:
        ///   page - int64 - Current page number.
        ///   per_page - int64 - Number of records to show per page.  (Max: 10,000, 1,000 or less is recommended).
        ///   action - string - Deprecated: If set to `count` returns a count of matching records rather than the records themselves.
        /// </summary>
        public static async Task<RemoteServer[]> List(
            
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            if (parameters.ContainsKey("page") && !(parameters["page"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: page must be of type Nullable<Int64>", "parameters[\"page\"]");
            }
            if (parameters.ContainsKey("per_page") && !(parameters["per_page"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: per_page must be of type Nullable<Int64>", "parameters[\"per_page\"]");
            }
            if (parameters.ContainsKey("action") && !(parameters["action"] is string ))
            {
                throw new ArgumentException("Bad parameter: action must be of type string", "parameters[\"action\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/remote_servers", System.Net.Http.HttpMethod.Get, parameters, options);

            return JsonSerializer.Deserialize<RemoteServer[]>(responseJson);
        }

        public static async Task<RemoteServer[]> All(
            
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await List(parameters, options);
        }

        /// <summary>
        /// Parameters:
        ///   id (required) - int64 - Remote Server ID.
        /// </summary>
        public static async Task<RemoteServer> Find(
            Nullable<Int64> id, 
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            parameters.Add("id", id);
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/remote_servers/{parameters["id"]}", System.Net.Http.HttpMethod.Get, parameters, options);

            return JsonSerializer.Deserialize<RemoteServer>(responseJson);
        }

        public static async Task<RemoteServer> Get(
            Nullable<Int64> id, 
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await Find(id, parameters, options);
        }

        /// <summary>
        /// Parameters:
        ///   aws_access_key - string - AWS Access Key.
        ///   aws_secret_key - string - AWS secret key.
        ///   password - string - Password if needed.
        ///   private_key - string - Private key if needed.
        ///   google_cloud_storage_credentials_json - string - A JSON file that contains the private key. To generate see https://cloud.google.com/storage/docs/json_api/v1/how-tos/authorizing#APIKey
        ///   wasabi_access_key - string - Wasabi access key.
        ///   wasabi_secret_key - string - Wasabi secret key.
        ///   backblaze_b2_key_id - string - Backblaze B2 Cloud Storage keyID.
        ///   backblaze_b2_application_key - string - Backblaze B2 Cloud Storage applicationKey.
        ///   rackspace_api_key - string - Rackspace API key from the Rackspace Cloud Control Panel.
        ///   reset_authentication - boolean - Reset authenticated account
        ///   hostname - string - Hostname or IP address
        ///   name - string - Internal name for your reference
        ///   max_connections - int64 - Max number of parallel connections.  Ignored for S3 connections (we will parallelize these as much as possible).
        ///   port - int64 - Port for remote server.  Not needed for S3.
        ///   s3_bucket - string - S3 bucket name
        ///   s3_region - string - S3 region
        ///   server_certificate - string - Remote server certificate
        ///   server_host_key - string - Remote server SSH Host Key. If provided, we will require that the server host key matches the provided key. Uses OpenSSH format similar to what would go into ~/.ssh/known_hosts
        ///   server_type - string - Remote server type.
        ///   ssl - string - Should we require SSL?
        ///   username - string - Remote server username.  Not needed for S3 buckets.
        ///   google_cloud_storage_bucket - string - Google Cloud Storage bucket name
        ///   google_cloud_storage_project_id - string - Google Cloud Project ID
        ///   backblaze_b2_bucket - string - Backblaze B2 Cloud Storage Bucket name
        ///   backblaze_b2_s3_endpoint - string - Backblaze B2 Cloud Storage S3 Endpoint
        ///   wasabi_bucket - string - Wasabi region
        ///   wasabi_region - string - Wasabi Bucket name
        ///   rackspace_username - string - Rackspace username used to login to the Rackspace Cloud Control Panel.
        ///   rackspace_region - string - Three letter airport code for Rackspace region. See https://support.rackspace.com/how-to/about-regions/
        ///   rackspace_container - string - The name of the container (top level directory) where files will sync.
        ///   one_drive_account_type - string - Either personal or business_other account types
        /// </summary>
        public static async Task<RemoteServer> Create(
            
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            if (parameters.ContainsKey("aws_access_key") && !(parameters["aws_access_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: aws_access_key must be of type string", "parameters[\"aws_access_key\"]");
            }
            if (parameters.ContainsKey("aws_secret_key") && !(parameters["aws_secret_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: aws_secret_key must be of type string", "parameters[\"aws_secret_key\"]");
            }
            if (parameters.ContainsKey("password") && !(parameters["password"] is string ))
            {
                throw new ArgumentException("Bad parameter: password must be of type string", "parameters[\"password\"]");
            }
            if (parameters.ContainsKey("private_key") && !(parameters["private_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: private_key must be of type string", "parameters[\"private_key\"]");
            }
            if (parameters.ContainsKey("google_cloud_storage_credentials_json") && !(parameters["google_cloud_storage_credentials_json"] is string ))
            {
                throw new ArgumentException("Bad parameter: google_cloud_storage_credentials_json must be of type string", "parameters[\"google_cloud_storage_credentials_json\"]");
            }
            if (parameters.ContainsKey("wasabi_access_key") && !(parameters["wasabi_access_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: wasabi_access_key must be of type string", "parameters[\"wasabi_access_key\"]");
            }
            if (parameters.ContainsKey("wasabi_secret_key") && !(parameters["wasabi_secret_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: wasabi_secret_key must be of type string", "parameters[\"wasabi_secret_key\"]");
            }
            if (parameters.ContainsKey("backblaze_b2_key_id") && !(parameters["backblaze_b2_key_id"] is string ))
            {
                throw new ArgumentException("Bad parameter: backblaze_b2_key_id must be of type string", "parameters[\"backblaze_b2_key_id\"]");
            }
            if (parameters.ContainsKey("backblaze_b2_application_key") && !(parameters["backblaze_b2_application_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: backblaze_b2_application_key must be of type string", "parameters[\"backblaze_b2_application_key\"]");
            }
            if (parameters.ContainsKey("rackspace_api_key") && !(parameters["rackspace_api_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: rackspace_api_key must be of type string", "parameters[\"rackspace_api_key\"]");
            }
            if (parameters.ContainsKey("reset_authentication") && !(parameters["reset_authentication"] is bool ))
            {
                throw new ArgumentException("Bad parameter: reset_authentication must be of type bool", "parameters[\"reset_authentication\"]");
            }
            if (parameters.ContainsKey("hostname") && !(parameters["hostname"] is string ))
            {
                throw new ArgumentException("Bad parameter: hostname must be of type string", "parameters[\"hostname\"]");
            }
            if (parameters.ContainsKey("name") && !(parameters["name"] is string ))
            {
                throw new ArgumentException("Bad parameter: name must be of type string", "parameters[\"name\"]");
            }
            if (parameters.ContainsKey("max_connections") && !(parameters["max_connections"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: max_connections must be of type Nullable<Int64>", "parameters[\"max_connections\"]");
            }
            if (parameters.ContainsKey("port") && !(parameters["port"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: port must be of type Nullable<Int64>", "parameters[\"port\"]");
            }
            if (parameters.ContainsKey("s3_bucket") && !(parameters["s3_bucket"] is string ))
            {
                throw new ArgumentException("Bad parameter: s3_bucket must be of type string", "parameters[\"s3_bucket\"]");
            }
            if (parameters.ContainsKey("s3_region") && !(parameters["s3_region"] is string ))
            {
                throw new ArgumentException("Bad parameter: s3_region must be of type string", "parameters[\"s3_region\"]");
            }
            if (parameters.ContainsKey("server_certificate") && !(parameters["server_certificate"] is string ))
            {
                throw new ArgumentException("Bad parameter: server_certificate must be of type string", "parameters[\"server_certificate\"]");
            }
            if (parameters.ContainsKey("server_host_key") && !(parameters["server_host_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: server_host_key must be of type string", "parameters[\"server_host_key\"]");
            }
            if (parameters.ContainsKey("server_type") && !(parameters["server_type"] is string ))
            {
                throw new ArgumentException("Bad parameter: server_type must be of type string", "parameters[\"server_type\"]");
            }
            if (parameters.ContainsKey("ssl") && !(parameters["ssl"] is string ))
            {
                throw new ArgumentException("Bad parameter: ssl must be of type string", "parameters[\"ssl\"]");
            }
            if (parameters.ContainsKey("username") && !(parameters["username"] is string ))
            {
                throw new ArgumentException("Bad parameter: username must be of type string", "parameters[\"username\"]");
            }
            if (parameters.ContainsKey("google_cloud_storage_bucket") && !(parameters["google_cloud_storage_bucket"] is string ))
            {
                throw new ArgumentException("Bad parameter: google_cloud_storage_bucket must be of type string", "parameters[\"google_cloud_storage_bucket\"]");
            }
            if (parameters.ContainsKey("google_cloud_storage_project_id") && !(parameters["google_cloud_storage_project_id"] is string ))
            {
                throw new ArgumentException("Bad parameter: google_cloud_storage_project_id must be of type string", "parameters[\"google_cloud_storage_project_id\"]");
            }
            if (parameters.ContainsKey("backblaze_b2_bucket") && !(parameters["backblaze_b2_bucket"] is string ))
            {
                throw new ArgumentException("Bad parameter: backblaze_b2_bucket must be of type string", "parameters[\"backblaze_b2_bucket\"]");
            }
            if (parameters.ContainsKey("backblaze_b2_s3_endpoint") && !(parameters["backblaze_b2_s3_endpoint"] is string ))
            {
                throw new ArgumentException("Bad parameter: backblaze_b2_s3_endpoint must be of type string", "parameters[\"backblaze_b2_s3_endpoint\"]");
            }
            if (parameters.ContainsKey("wasabi_bucket") && !(parameters["wasabi_bucket"] is string ))
            {
                throw new ArgumentException("Bad parameter: wasabi_bucket must be of type string", "parameters[\"wasabi_bucket\"]");
            }
            if (parameters.ContainsKey("wasabi_region") && !(parameters["wasabi_region"] is string ))
            {
                throw new ArgumentException("Bad parameter: wasabi_region must be of type string", "parameters[\"wasabi_region\"]");
            }
            if (parameters.ContainsKey("rackspace_username") && !(parameters["rackspace_username"] is string ))
            {
                throw new ArgumentException("Bad parameter: rackspace_username must be of type string", "parameters[\"rackspace_username\"]");
            }
            if (parameters.ContainsKey("rackspace_region") && !(parameters["rackspace_region"] is string ))
            {
                throw new ArgumentException("Bad parameter: rackspace_region must be of type string", "parameters[\"rackspace_region\"]");
            }
            if (parameters.ContainsKey("rackspace_container") && !(parameters["rackspace_container"] is string ))
            {
                throw new ArgumentException("Bad parameter: rackspace_container must be of type string", "parameters[\"rackspace_container\"]");
            }
            if (parameters.ContainsKey("one_drive_account_type") && !(parameters["one_drive_account_type"] is string ))
            {
                throw new ArgumentException("Bad parameter: one_drive_account_type must be of type string", "parameters[\"one_drive_account_type\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/remote_servers", System.Net.Http.HttpMethod.Post, parameters, options);

            return JsonSerializer.Deserialize<RemoteServer>(responseJson);
        }


        /// <summary>
        /// Parameters:
        ///   aws_access_key - string - AWS Access Key.
        ///   aws_secret_key - string - AWS secret key.
        ///   password - string - Password if needed.
        ///   private_key - string - Private key if needed.
        ///   google_cloud_storage_credentials_json - string - A JSON file that contains the private key. To generate see https://cloud.google.com/storage/docs/json_api/v1/how-tos/authorizing#APIKey
        ///   wasabi_access_key - string - Wasabi access key.
        ///   wasabi_secret_key - string - Wasabi secret key.
        ///   backblaze_b2_key_id - string - Backblaze B2 Cloud Storage keyID.
        ///   backblaze_b2_application_key - string - Backblaze B2 Cloud Storage applicationKey.
        ///   rackspace_api_key - string - Rackspace API key from the Rackspace Cloud Control Panel.
        ///   reset_authentication - boolean - Reset authenticated account
        ///   hostname - string - Hostname or IP address
        ///   name - string - Internal name for your reference
        ///   max_connections - int64 - Max number of parallel connections.  Ignored for S3 connections (we will parallelize these as much as possible).
        ///   port - int64 - Port for remote server.  Not needed for S3.
        ///   s3_bucket - string - S3 bucket name
        ///   s3_region - string - S3 region
        ///   server_certificate - string - Remote server certificate
        ///   server_host_key - string - Remote server SSH Host Key. If provided, we will require that the server host key matches the provided key. Uses OpenSSH format similar to what would go into ~/.ssh/known_hosts
        ///   server_type - string - Remote server type.
        ///   ssl - string - Should we require SSL?
        ///   username - string - Remote server username.  Not needed for S3 buckets.
        ///   google_cloud_storage_bucket - string - Google Cloud Storage bucket name
        ///   google_cloud_storage_project_id - string - Google Cloud Project ID
        ///   backblaze_b2_bucket - string - Backblaze B2 Cloud Storage Bucket name
        ///   backblaze_b2_s3_endpoint - string - Backblaze B2 Cloud Storage S3 Endpoint
        ///   wasabi_bucket - string - Wasabi region
        ///   wasabi_region - string - Wasabi Bucket name
        ///   rackspace_username - string - Rackspace username used to login to the Rackspace Cloud Control Panel.
        ///   rackspace_region - string - Three letter airport code for Rackspace region. See https://support.rackspace.com/how-to/about-regions/
        ///   rackspace_container - string - The name of the container (top level directory) where files will sync.
        ///   one_drive_account_type - string - Either personal or business_other account types
        /// </summary>
        public static async Task<RemoteServer> Update(
            Nullable<Int64> id, 
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            parameters.Add("id", id);
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (parameters.ContainsKey("aws_access_key") && !(parameters["aws_access_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: aws_access_key must be of type string", "parameters[\"aws_access_key\"]");
            }
            if (parameters.ContainsKey("aws_secret_key") && !(parameters["aws_secret_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: aws_secret_key must be of type string", "parameters[\"aws_secret_key\"]");
            }
            if (parameters.ContainsKey("password") && !(parameters["password"] is string ))
            {
                throw new ArgumentException("Bad parameter: password must be of type string", "parameters[\"password\"]");
            }
            if (parameters.ContainsKey("private_key") && !(parameters["private_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: private_key must be of type string", "parameters[\"private_key\"]");
            }
            if (parameters.ContainsKey("google_cloud_storage_credentials_json") && !(parameters["google_cloud_storage_credentials_json"] is string ))
            {
                throw new ArgumentException("Bad parameter: google_cloud_storage_credentials_json must be of type string", "parameters[\"google_cloud_storage_credentials_json\"]");
            }
            if (parameters.ContainsKey("wasabi_access_key") && !(parameters["wasabi_access_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: wasabi_access_key must be of type string", "parameters[\"wasabi_access_key\"]");
            }
            if (parameters.ContainsKey("wasabi_secret_key") && !(parameters["wasabi_secret_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: wasabi_secret_key must be of type string", "parameters[\"wasabi_secret_key\"]");
            }
            if (parameters.ContainsKey("backblaze_b2_key_id") && !(parameters["backblaze_b2_key_id"] is string ))
            {
                throw new ArgumentException("Bad parameter: backblaze_b2_key_id must be of type string", "parameters[\"backblaze_b2_key_id\"]");
            }
            if (parameters.ContainsKey("backblaze_b2_application_key") && !(parameters["backblaze_b2_application_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: backblaze_b2_application_key must be of type string", "parameters[\"backblaze_b2_application_key\"]");
            }
            if (parameters.ContainsKey("rackspace_api_key") && !(parameters["rackspace_api_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: rackspace_api_key must be of type string", "parameters[\"rackspace_api_key\"]");
            }
            if (parameters.ContainsKey("reset_authentication") && !(parameters["reset_authentication"] is bool ))
            {
                throw new ArgumentException("Bad parameter: reset_authentication must be of type bool", "parameters[\"reset_authentication\"]");
            }
            if (parameters.ContainsKey("hostname") && !(parameters["hostname"] is string ))
            {
                throw new ArgumentException("Bad parameter: hostname must be of type string", "parameters[\"hostname\"]");
            }
            if (parameters.ContainsKey("name") && !(parameters["name"] is string ))
            {
                throw new ArgumentException("Bad parameter: name must be of type string", "parameters[\"name\"]");
            }
            if (parameters.ContainsKey("max_connections") && !(parameters["max_connections"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: max_connections must be of type Nullable<Int64>", "parameters[\"max_connections\"]");
            }
            if (parameters.ContainsKey("port") && !(parameters["port"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: port must be of type Nullable<Int64>", "parameters[\"port\"]");
            }
            if (parameters.ContainsKey("s3_bucket") && !(parameters["s3_bucket"] is string ))
            {
                throw new ArgumentException("Bad parameter: s3_bucket must be of type string", "parameters[\"s3_bucket\"]");
            }
            if (parameters.ContainsKey("s3_region") && !(parameters["s3_region"] is string ))
            {
                throw new ArgumentException("Bad parameter: s3_region must be of type string", "parameters[\"s3_region\"]");
            }
            if (parameters.ContainsKey("server_certificate") && !(parameters["server_certificate"] is string ))
            {
                throw new ArgumentException("Bad parameter: server_certificate must be of type string", "parameters[\"server_certificate\"]");
            }
            if (parameters.ContainsKey("server_host_key") && !(parameters["server_host_key"] is string ))
            {
                throw new ArgumentException("Bad parameter: server_host_key must be of type string", "parameters[\"server_host_key\"]");
            }
            if (parameters.ContainsKey("server_type") && !(parameters["server_type"] is string ))
            {
                throw new ArgumentException("Bad parameter: server_type must be of type string", "parameters[\"server_type\"]");
            }
            if (parameters.ContainsKey("ssl") && !(parameters["ssl"] is string ))
            {
                throw new ArgumentException("Bad parameter: ssl must be of type string", "parameters[\"ssl\"]");
            }
            if (parameters.ContainsKey("username") && !(parameters["username"] is string ))
            {
                throw new ArgumentException("Bad parameter: username must be of type string", "parameters[\"username\"]");
            }
            if (parameters.ContainsKey("google_cloud_storage_bucket") && !(parameters["google_cloud_storage_bucket"] is string ))
            {
                throw new ArgumentException("Bad parameter: google_cloud_storage_bucket must be of type string", "parameters[\"google_cloud_storage_bucket\"]");
            }
            if (parameters.ContainsKey("google_cloud_storage_project_id") && !(parameters["google_cloud_storage_project_id"] is string ))
            {
                throw new ArgumentException("Bad parameter: google_cloud_storage_project_id must be of type string", "parameters[\"google_cloud_storage_project_id\"]");
            }
            if (parameters.ContainsKey("backblaze_b2_bucket") && !(parameters["backblaze_b2_bucket"] is string ))
            {
                throw new ArgumentException("Bad parameter: backblaze_b2_bucket must be of type string", "parameters[\"backblaze_b2_bucket\"]");
            }
            if (parameters.ContainsKey("backblaze_b2_s3_endpoint") && !(parameters["backblaze_b2_s3_endpoint"] is string ))
            {
                throw new ArgumentException("Bad parameter: backblaze_b2_s3_endpoint must be of type string", "parameters[\"backblaze_b2_s3_endpoint\"]");
            }
            if (parameters.ContainsKey("wasabi_bucket") && !(parameters["wasabi_bucket"] is string ))
            {
                throw new ArgumentException("Bad parameter: wasabi_bucket must be of type string", "parameters[\"wasabi_bucket\"]");
            }
            if (parameters.ContainsKey("wasabi_region") && !(parameters["wasabi_region"] is string ))
            {
                throw new ArgumentException("Bad parameter: wasabi_region must be of type string", "parameters[\"wasabi_region\"]");
            }
            if (parameters.ContainsKey("rackspace_username") && !(parameters["rackspace_username"] is string ))
            {
                throw new ArgumentException("Bad parameter: rackspace_username must be of type string", "parameters[\"rackspace_username\"]");
            }
            if (parameters.ContainsKey("rackspace_region") && !(parameters["rackspace_region"] is string ))
            {
                throw new ArgumentException("Bad parameter: rackspace_region must be of type string", "parameters[\"rackspace_region\"]");
            }
            if (parameters.ContainsKey("rackspace_container") && !(parameters["rackspace_container"] is string ))
            {
                throw new ArgumentException("Bad parameter: rackspace_container must be of type string", "parameters[\"rackspace_container\"]");
            }
            if (parameters.ContainsKey("one_drive_account_type") && !(parameters["one_drive_account_type"] is string ))
            {
                throw new ArgumentException("Bad parameter: one_drive_account_type must be of type string", "parameters[\"one_drive_account_type\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/remote_servers/{parameters["id"]}", System.Net.Http.HttpMethod.Patch, parameters, options);

            return JsonSerializer.Deserialize<RemoteServer>(responseJson);
        }


        /// <summary>
        /// </summary>
        public static async Task<RemoteServer> Delete(
            Nullable<Int64> id, 
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            parameters.Add("id", id);
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/remote_servers/{parameters["id"]}", System.Net.Http.HttpMethod.Delete, parameters, options);

            return JsonSerializer.Deserialize<RemoteServer>(responseJson);
        }

        public static async Task<RemoteServer> Destroy(
            Nullable<Int64> id, 
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await Delete(id, parameters, options);
        }

    }
}

