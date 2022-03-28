using Reception_App.Models;
using System;
using Xunit;

namespace ReceptionAppTests
{
    public class UnitTest1
    {
        [Fact]
        public void ToString_AllRequireParams_PersonInfo()
        {
            Visitor person = new Visitor("Koel", "WTC", "Student", "karend@student.wethinkcode.co.za", "0849779380");
            String p = person.ToString();

            Assert.Equal(
                $"ID: 0\nName: Koel\nCompany: WTC\nRole: Student\nEmail: karend@student.wethinkcode.co.za\nContactNumber: 0849779380", p);
        }
    }
}
