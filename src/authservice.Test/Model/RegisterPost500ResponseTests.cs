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
    ///  Class for testing RegisterPost500Response
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RegisterPost500ResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RegisterPost500Response
        //private RegisterPost500Response instance;

        public RegisterPost500ResponseTests()
        {
            // TODO uncomment below to create an instance of RegisterPost500Response
            //instance = new RegisterPost500Response();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RegisterPost500Response
        /// </summary>
        [Fact]
        public void RegisterPost500ResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" RegisterPost500Response
            //Assert.IsType<RegisterPost500Response>(instance);
        }

        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Fact]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }
    }
}