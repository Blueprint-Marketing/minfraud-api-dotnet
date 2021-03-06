﻿using MaxMind.MinFraud.Response;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace MaxMind.MinFraud.UnitTest.Response
{
    public class CreditCardTest
    {
        [Test]
        public void TestCreditCard()
        {
            var cc = new JObject
            {
                {
                    "issuer",
                    new JObject
                    {
                        {"name", "Bank"}
                    }
                },
                {
                    "country",
                    "US"
                }
                ,
                {
                    "is_issued_in_billing_address_country",
                    true
                },
                {
                    "is_prepaid",
                    true
                }
            }.ToObject<CreditCard>();

            Assert.AreEqual("Bank", cc.Issuer.Name);
            Assert.AreEqual("US", cc.Country);
            Assert.AreEqual(true, cc.IsPrepaid);
            Assert.AreEqual(true, cc.IsIssuedInBillingAddressCountry);
        }
    }
}