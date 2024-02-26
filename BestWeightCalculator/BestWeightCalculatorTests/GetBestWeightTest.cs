using BestWeightCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BestWeightCalculatorTests
{
    [TestClass]
    public class GetBestWeightTest
    {
        [TestMethod]
        public void GetBestWeight_forPerson_Return63()
        {
            //Arrange
            WeightCalculator Weight = new WeightCalculator {Gender='m',Height=176 };

            //ACT
            double actualWeight = Weight.GetBestWeight();
            double expectedWeight = 63;

            //Assest
            Assert.AreEqual(expectedWeight, actualWeight);


        }
        [TestMethod]
        public void GetBestWeight_forPerson_Return65()
        {
            //Arrange
            WeightCalculator Weight = new WeightCalculator { Gender = 'm', Height = 170 };

            //ACT
            double actualWeight = Weight.GetBestWeight();
            double expectedWeight = 65;

            //Assest
            Assert.AreEqual(expectedWeight, actualWeight);

        }

        [TestMethod]
        public void GetBestWeight_forPersonGenderNotCorrect_ReturnError()
        {
            //Arrange
            WeightCalculator Weight = new WeightCalculator { Gender = 'f', Height = 170 };

            //ACT
            double actualWeight = Weight.GetBestWeight();
            double expectedWeight = 65;

            //Assest
            Assert.AreEqual(expectedWeight, actualWeight);

        }



        //test value
        //h=176 , w   => 63
        //h=170 , m   => 65
        //any char =>   0


    }
}
