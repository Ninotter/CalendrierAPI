using CalendrierApi.Core;
using System.ComponentModel;

namespace CalendarTest
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}
        #region Invalid Inputs
        [Test]
        public void GetDaysInMonth_ShouldThrowException_InvalidMonthInput()
        {
            //Arrange
            int year = 2000;
            int month = 0; //Invalid input
            //Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Calendar.GetDaysInMonth(year, month));
        }

        [Test]
        public void GetDaysInMonth_ShouldThrowException_InvalidYearInput()
        {
            //Arrange
            int year = -1; //Invalid input
            int month = 0; 
            //Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Calendar.GetDaysInMonth(year, month));
        }
        #endregion

        #region Valid Inputs
        [Test]
        public void GetDaysInMonth_ShouldReturn29Size_LeapYearTest()
        {
            //Arrange
            int year = 2000; //Leap year
            int month = 2; 
            //Act & Assert
            Assert.That(29 == Calendar.GetDaysInMonth(year, month).Count());
        }

        [Test]
        public void GetDaysInMonth_ShouldReturn31Size_RandomTest()
        {
            //Arrange
            int year = 2023; //Leap year
            int month = 10;
            //Act & Assert
            Assert.That(31 == Calendar.GetDaysInMonth(year, month).Count());
        }
        #endregion
    }
}