# authservice.Api.DefaultApi

All URIs are relative to *http://localhost:3000/auth*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClientGet**](DefaultApi.md#clientget) | **GET** /client | Get client ID and secret |
| [**LoginClientPost**](DefaultApi.md#loginclientpost) | **POST** /login/client | Logs in a user using client ID and secret |
| [**RegenerateClientCredentialsPost**](DefaultApi.md#regenerateclientcredentialspost) | **POST** /regenerate-client-credentials | Regenerate client credentials |
| [**RegisterPost**](DefaultApi.md#registerpost) | **POST** /register | Registers a new user |

<a id="clientget"></a>
# **ClientGet**
> ClientGet200Response ClientGet (string username, string password)

Get client ID and secret

Returns the client ID and client secret of the user associated with the provided username and password.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using authservice.Api;
using authservice.Client;
using authservice.Model;

namespace Example
{
    public class ClientGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3000/auth";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var username = johndoe;  // string | User's username
            var password = password123;  // string | User's password

            try
            {
                // Get client ID and secret
                ClientGet200Response result = apiInstance.ClientGet(username, password);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ClientGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ClientGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get client ID and secret
    ApiResponse<ClientGet200Response> response = apiInstance.ClientGetWithHttpInfo(username, password);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ClientGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | User&#39;s username |  |
| **password** | **string** | User&#39;s password |  |

### Return type

[**ClientGet200Response**](ClientGet200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client ID and client secret retrieved successfully |  -  |
| **401** | Unauthorized (invalid credentials) |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="loginclientpost"></a>
# **LoginClientPost**
> LoginClientPost200Response LoginClientPost (string clientId, string clientSecret)

Logs in a user using client ID and secret

Authenticates a user with the provided client ID and secret. Returns a JWT token, token type (Bearer), and expiry time in seconds.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using authservice.Api;
using authservice.Client;
using authservice.Model;

namespace Example
{
    public class LoginClientPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3000/auth";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var clientId = abc123-xyz456;  // string | User's client ID
            var clientSecret = def789-ghi012;  // string | User's client secret

            try
            {
                // Logs in a user using client ID and secret
                LoginClientPost200Response result = apiInstance.LoginClientPost(clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.LoginClientPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoginClientPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Logs in a user using client ID and secret
    ApiResponse<LoginClientPost200Response> response = apiInstance.LoginClientPostWithHttpInfo(clientId, clientSecret);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.LoginClientPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | User&#39;s client ID |  |
| **clientSecret** | **string** | User&#39;s client secret |  |

### Return type

[**LoginClientPost200Response**](LoginClientPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Login successful |  -  |
| **401** | Unauthorized (invalid client credentials) |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="regenerateclientcredentialspost"></a>
# **RegenerateClientCredentialsPost**
> RegenerateClientCredentialsPost200Response RegenerateClientCredentialsPost (string username, string password)

Regenerate client credentials

Regenerates the client ID and client secret of the user associated with the provided username and password. Returns the new client ID and client secret in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using authservice.Api;
using authservice.Client;
using authservice.Model;

namespace Example
{
    public class RegenerateClientCredentialsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3000/auth";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var username = johndoe;  // string | User's username
            var password = password123;  // string | User's password

            try
            {
                // Regenerate client credentials
                RegenerateClientCredentialsPost200Response result = apiInstance.RegenerateClientCredentialsPost(username, password);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.RegenerateClientCredentialsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegenerateClientCredentialsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Regenerate client credentials
    ApiResponse<RegenerateClientCredentialsPost200Response> response = apiInstance.RegenerateClientCredentialsPostWithHttpInfo(username, password);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.RegenerateClientCredentialsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | User&#39;s username |  |
| **password** | **string** | User&#39;s password |  |

### Return type

[**RegenerateClientCredentialsPost200Response**](RegenerateClientCredentialsPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Client credentials regenerated successfully |  -  |
| **401** | Unauthorized (invalid credentials) |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="registerpost"></a>
# **RegisterPost**
> RegisterPost201Response RegisterPost (string username, string password, string role)

Registers a new user

Creates a new user with the provided username, password, and role. Returns the generated client ID and client secret in the response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using authservice.Api;
using authservice.Client;
using authservice.Model;

namespace Example
{
    public class RegisterPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3000/auth";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var username = johndoe;  // string | Unique username for the user
            var password = password123;  // string | User's password
            var role = user;  // string |  (default to user)

            try
            {
                // Registers a new user
                RegisterPost201Response result = apiInstance.RegisterPost(username, password, role);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.RegisterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RegisterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Registers a new user
    ApiResponse<RegisterPost201Response> response = apiInstance.RegisterPostWithHttpInfo(username, password, role);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.RegisterPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | Unique username for the user |  |
| **password** | **string** | User&#39;s password |  |
| **role** | **string** |  | [default to user] |

### Return type

[**RegisterPost201Response**](RegisterPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | User registered successfully |  -  |
| **400** | Bad request (e.g., username already taken) |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

