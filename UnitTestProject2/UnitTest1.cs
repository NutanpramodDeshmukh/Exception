using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using MoodAnalyaser;

namespace UnitTestProject2
{
    
    public class Tests
    {

        [SetUp]

        public void Setup()
        {

        }

        [Test]

        public void EmptyMessageShouldThrowCustomException_EmptyMeaasage()
        {
            string expecxted = "Empty Mood message not valid";
            try
            {
                MoodAnalyaser analyaser = new MoodAnalyaser("");
                string mood = analyaser.AnalyseMood();
            }
            catch (CustomException e)
            {
                Assert.AreEqual(expecxted, e.Message);
            }

        }

        [Test]

        public void NullMessageShouldThrowCustomException_NullMeaasage()
        {
            string expecxted = "Null message not valid";
            try
            {
                MoodAnalyaser analyaser = new MoodAnalyaser(null);
                string mood = analyaser.AnalyseMood();
            }
            catch (CustomException e)
            {
                Assert.AreEqual(expecxted, e.Message);
            }
        }

    }
}
