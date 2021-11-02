namespace WebEid.Security.Tests.Validator
{
    using Exceptions;
    using NUnit.Framework;
    using Security.Validator;
    using TestUtils;

    [TestFixture]
    public class AuthTokenValidatorWithDisallowedEsteidPolicyTests : AbstractTestWithMockedDateAndCorrectNonce
    {
        private IAuthTokenValidator validator;

        [SetUp]
        protected override void SetUp()
        {
            base.SetUp();
            this.validator = AuthTokenValidators.GetAuthTokenValidatorWithDisallowedEsteidPolicy(this.Cache);
        }

        [Test]
        public void TestX5CDisallowedPolicyCertificate()
        {
            this.PutCorrectNonceToCache();
            Assert.ThrowsAsync<UserCertificateDisallowedPolicyException>(async () => await this.validator.Validate(Tokens.SignedTest));
        }
    }
}