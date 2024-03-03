/*
 * Auth Service
 *
 * This API provides token-based authentication for user registration, login, and client credential management. It ensures secure communication by utilizing tokens for authentication. Users can register with unique usernames and passwords, authenticate using client credentials, retrieve client IDs and secrets, and regenerate client credentials as needed. The API supports various user roles, including 'user', 'admin', 'moderator', 'guest', and 'superadmin'.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using authservice.Client;
using authservice.Api;
// uncomment below to import models
//using authservice.Model;

namespace authservice.Test.Api
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DefaultApiTests : IDisposable
    {
        private DefaultApi instance;

        public DefaultApiTests()
        {
            instance = new DefaultApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DefaultApi
            //Assert.IsType<DefaultApi>(instance);
        }

        /// <summary>
        /// Test ClientGet
        /// </summary>
        [Fact]
        public void ClientGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string password = null;
            //var response = instance.ClientGet(username, password);
            //Assert.IsType<ClientGet200Response>(response);
        }

        /// <summary>
        /// Test LoginClientPost
        /// </summary>
        [Fact]
        public void LoginClientPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string clientSecret = null;
            //var response = instance.LoginClientPost(clientId, clientSecret);
            //Assert.IsType<LoginClientPost200Response>(response);
        }

        /// <summary>
        /// Test RegenerateClientCredentialsPost
        /// </summary>
        [Fact]
        public void RegenerateClientCredentialsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string password = null;
            //var response = instance.RegenerateClientCredentialsPost(username, password);
            //Assert.IsType<RegenerateClientCredentialsPost200Response>(response);
        }

        /// <summary>
        /// Test RegisterPost
        /// </summary>
        [Fact]
        public void RegisterPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string password = null;
            //string role = null;
            //var response = instance.RegisterPost(username, password, role);
            //Assert.IsType<RegisterPost201Response>(response);
        }
    }
}
