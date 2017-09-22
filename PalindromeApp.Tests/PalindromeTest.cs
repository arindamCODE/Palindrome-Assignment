using System;
using Xunit;
using PalindromeApp;

namespace PalindromeApp.Tests
{
    public class PalindromeTest
    {
        [Fact]
        public void TestPalindrome()
        {  
            //Arrange
            Palindrome objPalindrome = new Palindrome(); 

            //Act
            bool result = objPalindrome.IsAPalindrome("redivider");
            bool resultNegative = objPalindrome.IsAPalindrome("Test");


            //Assert
            Assert.IsType<bool>(result);
            Assert.True(result);

            Assert.IsType<bool>(resultNegative);
            Assert.False(resultNegative);
        }
    }
}