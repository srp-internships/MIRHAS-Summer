using Moq;
using NUnit.Framework;
using System;
using TestNinja.Mocking;
using static TestNinja.Mocking.BookingHelper;
using System.Collections.Generic;
using System.Linq;


namespace Ninja_Test.Mocking
{
    [TestFixture]
    class HouseKeeperServiceTests
    {
        Mock<IUnitOfWork> _unitOfWork;
        Mock<IStatementGenerator> _statementGenerator;
        Mock<IEmailSender> _emailSender;
        Mock<IXtraMessageBox> _xtraMessageBox;
        HouseKeeperService service;

        [SetUp]
        public void SetUp()
        {
            _statementGenerator = new Mock<IStatementGenerator>();
            _unitOfWork = new Mock<IUnitOfWork>();
            _emailSender = new Mock<IEmailSender>();
            _xtraMessageBox = new Mock<IXtraMessageBox>();

            service = new HouseKeeperService(_unitOfWork.Object, _statementGenerator.Object, _emailSender.Object, _xtraMessageBox.Object);

            SetDatasUp();
        }
        private void SetDatasUp()
        {
            _unitOfWork.Setup(a => a.Query<Housekeeper>()).Returns(new List<Housekeeper>
            {
                new Housekeeper { Oid = 1, Email = "housekeeper1@gmail.com", FullName = "HouseKeeper1", StatementEmailBody = "Hello" },
                new Housekeeper { Oid = 2, Email = "housekeeper2@gmail.com", FullName = "HouseKeeper2", StatementEmailBody = "Hello" },
                new Housekeeper { Oid = 3, Email = "housekeeper3@gmail.com", FullName = "HouseKeeper3", StatementEmailBody = "Hello" },
                new Housekeeper { Oid = 4, Email = "housekeeper4@gmail.com", FullName = "HouseKeeper4", StatementEmailBody = "Hello" },
                new Housekeeper { Oid = 5, Email = "housekeeper5@gmail.com", FullName = "HouseKeeper5", StatementEmailBody = "Hello" },
                new Housekeeper { Oid = 6, Email = "housekeeper6@gmail.com", FullName = "HouseKeeper6", StatementEmailBody = "Hello" },
                new Housekeeper { Oid = 7, Email = "housekeeper7@gmail.com", FullName = "HouseKeeper7", StatementEmailBody = "Hello" }

            }.AsQueryable());

            _statementGenerator.Setup(a => a.SaveStatement(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<DateTime>())).Returns("a");
        }

        [Test]
        public void HouseKeeperServiceTest_VerifiyQueryMethod()
        {
            service.SendStatementEmails(DateTime.Today);
            _unitOfWork.Verify(e => e.Query<Housekeeper>());
        }
        [Test]
        public void HouseKeeperServiceTest_VerifySaveStatementMethod()
        {
            service.SendStatementEmails(DateTime.Today);
            _statementGenerator.Verify(a => a.SaveStatement(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<DateTime>()));
        }
        [Test]
        public void HouseKeeperServiceTest_VerifyEmailFileMethod()
        {
            service.SendStatementEmails(DateTime.Today);
            _emailSender.Verify(e => e.EmailFile(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()));
        }
    }
}
