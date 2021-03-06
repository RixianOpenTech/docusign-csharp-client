/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;
using DocuSign.eSign.Client;
using System.Reflection;

namespace DocuSign.eSign.Test
{
    /// <summary>
    ///  Class for testing InPersonSigner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class InPersonSignerTests
    {
        // TODO uncomment below to declare an instance variable for InPersonSigner
        //private InPersonSigner instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InPersonSigner
            //instance = new InPersonSigner();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InPersonSigner
        /// </summary>
        [Test]
        public void InPersonSignerInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InPersonSigner
            //Assert.IsInstanceOfType<InPersonSigner> (instance, "variable 'instance' is a InPersonSigner");
        }

        /// <summary>
        /// Test the property 'AccessCode'
        /// </summary>
        [Test]
        public void AccessCodeTest()
        {
            // TODO unit test for the property 'AccessCode'
        }
        /// <summary>
        /// Test the property 'AddAccessCodeToEmail'
        /// </summary>
        [Test]
        public void AddAccessCodeToEmailTest()
        {
            // TODO unit test for the property 'AddAccessCodeToEmail'
        }
        /// <summary>
        /// Test the property 'AutoNavigation'
        /// </summary>
        [Test]
        public void AutoNavigationTest()
        {
            // TODO unit test for the property 'AutoNavigation'
        }
        /// <summary>
        /// Test the property 'CanSignOffline'
        /// </summary>
        [Test]
        public void CanSignOfflineTest()
        {
            // TODO unit test for the property 'CanSignOffline'
        }
        /// <summary>
        /// Test the property 'ClientUserId'
        /// </summary>
        [Test]
        public void ClientUserIdTest()
        {
            // TODO unit test for the property 'ClientUserId'
        }
        /// <summary>
        /// Test the property 'CustomFields'
        /// </summary>
        [Test]
        public void CustomFieldsTest()
        {
            // TODO unit test for the property 'CustomFields'
        }
        /// <summary>
        /// Test the property 'DeclinedDateTime'
        /// </summary>
        [Test]
        public void DeclinedDateTimeTest()
        {
            // TODO unit test for the property 'DeclinedDateTime'
        }
        /// <summary>
        /// Test the property 'DeclinedReason'
        /// </summary>
        [Test]
        public void DeclinedReasonTest()
        {
            // TODO unit test for the property 'DeclinedReason'
        }
        /// <summary>
        /// Test the property 'DefaultRecipient'
        /// </summary>
        [Test]
        public void DefaultRecipientTest()
        {
            // TODO unit test for the property 'DefaultRecipient'
        }
        /// <summary>
        /// Test the property 'DeliveredDateTime'
        /// </summary>
        [Test]
        public void DeliveredDateTimeTest()
        {
            // TODO unit test for the property 'DeliveredDateTime'
        }
        /// <summary>
        /// Test the property 'DeliveryMethod'
        /// </summary>
        [Test]
        public void DeliveryMethodTest()
        {
            // TODO unit test for the property 'DeliveryMethod'
        }
        /// <summary>
        /// Test the property 'DocumentVisibility'
        /// </summary>
        [Test]
        public void DocumentVisibilityTest()
        {
            // TODO unit test for the property 'DocumentVisibility'
        }
        /// <summary>
        /// Test the property 'EmailNotification'
        /// </summary>
        [Test]
        public void EmailNotificationTest()
        {
            // TODO unit test for the property 'EmailNotification'
        }
        /// <summary>
        /// Test the property 'EmbeddedRecipientStartURL'
        /// </summary>
        [Test]
        public void EmbeddedRecipientStartURLTest()
        {
            // TODO unit test for the property 'EmbeddedRecipientStartURL'
        }
        /// <summary>
        /// Test the property 'ErrorDetails'
        /// </summary>
        [Test]
        public void ErrorDetailsTest()
        {
            // TODO unit test for the property 'ErrorDetails'
        }
        /// <summary>
        /// Test the property 'FaxNumber'
        /// </summary>
        [Test]
        public void FaxNumberTest()
        {
            // TODO unit test for the property 'FaxNumber'
        }
        /// <summary>
        /// Test the property 'HostEmail'
        /// </summary>
        [Test]
        public void HostEmailTest()
        {
            // TODO unit test for the property 'HostEmail'
        }
        /// <summary>
        /// Test the property 'HostName'
        /// </summary>
        [Test]
        public void HostNameTest()
        {
            // TODO unit test for the property 'HostName'
        }
        /// <summary>
        /// Test the property 'IdCheckConfigurationName'
        /// </summary>
        [Test]
        public void IdCheckConfigurationNameTest()
        {
            // TODO unit test for the property 'IdCheckConfigurationName'
        }
        /// <summary>
        /// Test the property 'IdCheckInformationInput'
        /// </summary>
        [Test]
        public void IdCheckInformationInputTest()
        {
            // TODO unit test for the property 'IdCheckInformationInput'
        }
        /// <summary>
        /// Test the property 'InheritEmailNotificationConfiguration'
        /// </summary>
        [Test]
        public void InheritEmailNotificationConfigurationTest()
        {
            // TODO unit test for the property 'InheritEmailNotificationConfiguration'
        }
        /// <summary>
        /// Test the property 'InPersonSigningType'
        /// </summary>
        [Test]
        public void InPersonSigningTypeTest()
        {
            // TODO unit test for the property 'InPersonSigningType'
        }
        /// <summary>
        /// Test the property 'NotaryHost'
        /// </summary>
        [Test]
        public void NotaryHostTest()
        {
            // TODO unit test for the property 'NotaryHost'
        }
        /// <summary>
        /// Test the property 'Note'
        /// </summary>
        [Test]
        public void NoteTest()
        {
            // TODO unit test for the property 'Note'
        }
        /// <summary>
        /// Test the property 'OfflineAttributes'
        /// </summary>
        [Test]
        public void OfflineAttributesTest()
        {
            // TODO unit test for the property 'OfflineAttributes'
        }
        /// <summary>
        /// Test the property 'PhoneAuthentication'
        /// </summary>
        [Test]
        public void PhoneAuthenticationTest()
        {
            // TODO unit test for the property 'PhoneAuthentication'
        }
        /// <summary>
        /// Test the property 'RecipientAttachments'
        /// </summary>
        [Test]
        public void RecipientAttachmentsTest()
        {
            // TODO unit test for the property 'RecipientAttachments'
        }
        /// <summary>
        /// Test the property 'RecipientAuthenticationStatus'
        /// </summary>
        [Test]
        public void RecipientAuthenticationStatusTest()
        {
            // TODO unit test for the property 'RecipientAuthenticationStatus'
        }
        /// <summary>
        /// Test the property 'RecipientId'
        /// </summary>
        [Test]
        public void RecipientIdTest()
        {
            // TODO unit test for the property 'RecipientId'
        }
        /// <summary>
        /// Test the property 'RecipientIdGuid'
        /// </summary>
        [Test]
        public void RecipientIdGuidTest()
        {
            // TODO unit test for the property 'RecipientIdGuid'
        }
        /// <summary>
        /// Test the property 'RecipientSignatureProviders'
        /// </summary>
        [Test]
        public void RecipientSignatureProvidersTest()
        {
            // TODO unit test for the property 'RecipientSignatureProviders'
        }
        /// <summary>
        /// Test the property 'RecipientSuppliesTabs'
        /// </summary>
        [Test]
        public void RecipientSuppliesTabsTest()
        {
            // TODO unit test for the property 'RecipientSuppliesTabs'
        }
        /// <summary>
        /// Test the property 'RequireIdLookup'
        /// </summary>
        [Test]
        public void RequireIdLookupTest()
        {
            // TODO unit test for the property 'RequireIdLookup'
        }
        /// <summary>
        /// Test the property 'RequireSignerCertificate'
        /// </summary>
        [Test]
        public void RequireSignerCertificateTest()
        {
            // TODO unit test for the property 'RequireSignerCertificate'
        }
        /// <summary>
        /// Test the property 'RequireSignOnPaper'
        /// </summary>
        [Test]
        public void RequireSignOnPaperTest()
        {
            // TODO unit test for the property 'RequireSignOnPaper'
        }
        /// <summary>
        /// Test the property 'RoleName'
        /// </summary>
        [Test]
        public void RoleNameTest()
        {
            // TODO unit test for the property 'RoleName'
        }
        /// <summary>
        /// Test the property 'RoutingOrder'
        /// </summary>
        [Test]
        public void RoutingOrderTest()
        {
            // TODO unit test for the property 'RoutingOrder'
        }
        /// <summary>
        /// Test the property 'SamlAuthentication'
        /// </summary>
        [Test]
        public void SamlAuthenticationTest()
        {
            // TODO unit test for the property 'SamlAuthentication'
        }
        /// <summary>
        /// Test the property 'SentDateTime'
        /// </summary>
        [Test]
        public void SentDateTimeTest()
        {
            // TODO unit test for the property 'SentDateTime'
        }
        /// <summary>
        /// Test the property 'SignatureInfo'
        /// </summary>
        [Test]
        public void SignatureInfoTest()
        {
            // TODO unit test for the property 'SignatureInfo'
        }
        /// <summary>
        /// Test the property 'SignedDateTime'
        /// </summary>
        [Test]
        public void SignedDateTimeTest()
        {
            // TODO unit test for the property 'SignedDateTime'
        }
        /// <summary>
        /// Test the property 'SignerEmail'
        /// </summary>
        [Test]
        public void SignerEmailTest()
        {
            // TODO unit test for the property 'SignerEmail'
        }
        /// <summary>
        /// Test the property 'SignerName'
        /// </summary>
        [Test]
        public void SignerNameTest()
        {
            // TODO unit test for the property 'SignerName'
        }
        /// <summary>
        /// Test the property 'SignInEachLocation'
        /// </summary>
        [Test]
        public void SignInEachLocationTest()
        {
            // TODO unit test for the property 'SignInEachLocation'
        }
        /// <summary>
        /// Test the property 'SigningGroupId'
        /// </summary>
        [Test]
        public void SigningGroupIdTest()
        {
            // TODO unit test for the property 'SigningGroupId'
        }
        /// <summary>
        /// Test the property 'SigningGroupName'
        /// </summary>
        [Test]
        public void SigningGroupNameTest()
        {
            // TODO unit test for the property 'SigningGroupName'
        }
        /// <summary>
        /// Test the property 'SigningGroupUsers'
        /// </summary>
        [Test]
        public void SigningGroupUsersTest()
        {
            // TODO unit test for the property 'SigningGroupUsers'
        }
        /// <summary>
        /// Test the property 'SmsAuthentication'
        /// </summary>
        [Test]
        public void SmsAuthenticationTest()
        {
            // TODO unit test for the property 'SmsAuthentication'
        }
        /// <summary>
        /// Test the property 'SocialAuthentications'
        /// </summary>
        [Test]
        public void SocialAuthenticationsTest()
        {
            // TODO unit test for the property 'SocialAuthentications'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'Tabs'
        /// </summary>
        [Test]
        public void TabsTest()
        {
            // TODO unit test for the property 'Tabs'
        }
        /// <summary>
        /// Test the property 'TemplateLocked'
        /// </summary>
        [Test]
        public void TemplateLockedTest()
        {
            // TODO unit test for the property 'TemplateLocked'
        }
        /// <summary>
        /// Test the property 'TemplateRequired'
        /// </summary>
        [Test]
        public void TemplateRequiredTest()
        {
            // TODO unit test for the property 'TemplateRequired'
        }
        /// <summary>
        /// Test the property 'TotalTabCount'
        /// </summary>
        [Test]
        public void TotalTabCountTest()
        {
            // TODO unit test for the property 'TotalTabCount'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }

    }

}
