/*
 * Auth Service
 *
 * This API provides token-based authentication for user registration, login, and client credential management. It ensures secure communication by utilizing tokens for authentication. Users can register with unique usernames and passwords, authenticate using client credentials, retrieve client IDs and secrets, and regenerate client credentials as needed. The API supports various user roles, including 'user', 'admin', 'moderator', 'guest', and 'superadmin'.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using authservice.Model;
using authservice.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace authservice.Test.Model
{
    /// <summary>
    ///  Class for testing ClientGet200Response
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientGet200ResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientGet200Response
        //private ClientGet200Response instance;

        public ClientGet200ResponseTests()
        {
            // TODO uncomment below to create an instance of ClientGet200Response
            //instance = new ClientGet200Response();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientGet200Response
        /// </summary>
        [Fact]
        public void ClientGet200ResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientGet200Response
            //Assert.IsType<ClientGet200Response>(instance);
        }

        /// <summary>
        /// Test the property 'ClientId'
        /// </summary>
        [Fact]
        public void ClientIdTest()
        {
            // TODO unit test for the property 'ClientId'
        }

        /// <summary>
        /// Test the property 'ClientSecret'
        /// </summary>
        [Fact]
        public void ClientSecretTest()
        {
            // TODO unit test for the property 'ClientSecret'
        }
    }
}
