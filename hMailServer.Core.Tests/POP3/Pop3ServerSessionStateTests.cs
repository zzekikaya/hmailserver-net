﻿using hMailServer.Core.Protocols.POP3;
using hMailServer.Core.Protocols.SMTP;
using NUnit.Framework;

namespace hMailServer.Core.Tests.POP3
{
    [TestFixture]
    public class Pop3ServerSessionStateTests
    {
        [Test]
        public void UidlBeforeUserAndPasswordShouldFail()
        {
            var state = new Pop3ServerSessionState()
                {
                    HasUsername = true,
                    HasPassword = false
                };

            Assert.IsFalse(state.IsCommandValid(Pop3Command.Uidl));
        }

        [Test]
        public void UidlAfterUserAndPasswordShouldFail()
        {
            var state = new Pop3ServerSessionState()
            {
                HasUsername = true,
                HasPassword = true
            };

            Assert.IsTrue(state.IsCommandValid(Pop3Command.Uidl));
        }
    }
}
