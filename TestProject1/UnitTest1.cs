using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;


namespace MoodAnalyser
{
    [TestClass]
    public class MoodAnalyser
    {
        //uc1 given  happy or sad return happy or sad
        [TestMethod]
        public void GivenhappyShouldbereturnHappy()
        {

            //AAA metodology
            //Arrange
            string Expected = "happy";
            MoodAnalysertest obj = new MoodAnalysertest("Happy");

            //Act
            string actuall = obj.AnalyseMood();

            //Assert
            Assert.AreEqual(Expected, actuall);
        }
        [TestMethod]
        public void GivensadShouldbereturnsad()
        {

            //AAA metodology
            //Arrange
            string Expected = "sad";
            MoodAnalysertest obj = new MoodAnalysertest("sad");

            //Act
            string actuall = obj.AnalyseMood();

            //Assert
            Assert.AreEqual(Expected, actuall);
        }
        //uc2 user invalid mood 
        [TestMethod]
            [TestCategory("negativeSenario")]
        public void GivenNullShouldbeReturnHappy()
        {
            ///AAA methodology
            // Arrange
            string Expected = "happy";
            MoodAnalysertest obj = new MoodAnalysertest(null);

            //Act
            string actuall = obj.AnalyseMood();

            //Assert 
            Assert.AreEqual(Expected, actuall);
        }

    }
}
