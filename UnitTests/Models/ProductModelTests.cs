using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        // Test if default constructor is not Null 
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        // Test if default Logistics is an empty string
        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        // Test setting Logistics to a string value
        [TestMethod]
        public void ProductModel_Set_Logistics_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Logistics = "Transported";

            // Assert
            Assert.AreEqual("Transported", result.Logistics);
        }

        // Test default get e-mail
        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            string unknown = "Unknown";

            // Assert
            Assert.AreEqual(unknown, result.Email);
        }

        // Test set e-mail with valid string value
        [TestMethod]
        public void ProductModel_Set_Email_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Email = "js@ProductModel.com";

            // Assert
            Assert.AreEqual("js@ProductModel.com", result.Email);
        }


        // Test default get ID (not set in constructor, should be null)
        [TestMethod]
        public void ProductModel_Get_ID_Devault_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Id);
        }

        // Test set ID to valid string 
        [TestMethod]
        public void ProductModel_Set_ID_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "Jason";

            // Assert
            Assert.AreEqual("Jason", result.Id);
        }

        // Test default get ratings 
        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange
            int[] rating = new int[] { 5 };

            // Act
            var result = new ProductModel();

            // Assert
            CollectionAssert.AreEqual(rating, result.Ratings);
        }

        // Test set ratings to valid int[]
        [TestMethod]
        public void ProductModel_Set_Ratings_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            int[] rating = new int[] { 1 };

            // Act
            result.Ratings = new int[] { 1 };
            
            // Assert
            CollectionAssert.AreEqual(rating, result.Ratings);
        }

        // Test get description default (should be null) 
        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Description);
        }

        // Test set description to valid string 
        [TestMethod]
        public void ProductModel_Set_Description_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "Desk Lamp";

            // Assert
            Assert.AreEqual("Desk Lamp", result.Description);
        }

        // Test default get date 
        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        // Test set date to valid date
        [TestMethod]
        public void ProductModel_Set_Date_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            DateTime thisDate = new DateTime(2008, 3, 15);

            // Act
            result.Date = new DateTime(2008, 3, 15);

            // Assert
            Assert.AreEqual(thisDate.ToShortDateString(), result.Date.ToShortDateString());
        }

        // Test default get image (not set in constructor, should be null)
        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Image); 
        }

        // Test set image to valid string 
        [TestMethod]
        public void ProductModel_Set_Image_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string image = "Img";

            // Act
            result.Image = "Img";

            // Assert
            Assert.AreEqual(image, result.Image);
        }

        // Test get maker default (not set in constructor, should be null)
        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
   
            // Assert
            Assert.AreEqual(null, result.Maker);
        }

        // Test set maker to valid string 
        [TestMethod]
        public void ProductModel_Set_Maker_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string maker = "Jessica Jones";

            // Act
            result.Maker = "Jessica Jones";

            // Assert
            Assert.AreEqual(maker, result.Maker);
        }

        // Test get sequence default (not set in constructor, should be null)
        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Sequence);
        }

        // Test set sequence to valid string 
        [TestMethod]
        public void ProductModel_Set_Sequence_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string sequence = "Sequence";

            // Act
            result.Sequence = "Sequence";

            // Assert
            Assert.AreEqual(sequence, result.Sequence);
        }

        // Test get title default (not set in constructor, should be null)
        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Title);
        }

        // Test set title to valid string 
        [TestMethod]
        public void ProductModel_Set_Title_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string title = "A Good Title";

            // Act
            result.Title = "A Good Title";

            // Assert
            Assert.AreEqual(title, result.Title);
        }

        // Test get url default (not set in constructor, should be null)
        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Url);
        }

        // Test set url to valid string 
        [TestMethod]
        public void ProductModel_Set_Url_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string url = "https://www.seattleu.edu/mysu/";

            // Act
            result.Url = "https://www.seattleu.edu/mysu/";

            // Assert
            Assert.AreEqual(url, result.Url);
        }

        // Test object toString method (DateTime changes, so make sure date is same for each) 
        [TestMethod]
        public void ProductModel_Get_ToString_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            var result2 = new ProductModel();
            DateTime thisDate = new DateTime(2008, 3, 15);
            result.Date = thisDate;
            result2.Date = thisDate;
            string resultString2 = result2.ToString();

            // Act
            string resultString = result.ToString();

            // Assert
            Assert.AreEqual(resultString2, resultString);
        }

        // Test get average rating for null entry (should return 0) 
        [TestMethod]
        public void ProductModel_Get_AverageRating_DefaultNull_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Ratings = null;

            // Act
            int average = result.AverageRating(); 

            // Assert
            Assert.AreEqual(0, average);
        }

        // Test get average rating for Default entry (single object, default is 5)
        [TestMethod]
        public void ProductModel_Get_AverageRating_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            int average = result.AverageRating();

            // Assert
            Assert.AreEqual(5, average);
        }

        // Test get average rating for multiple entries (total = 12 , count = 6 items. 12/6 = 2) 
        [TestMethod]
        public void ProductModel_Get_AverageRating_Valid_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Ratings = new int[] { 2, 3, 4, 1, 1, 1};
           
            // Act
            int average = result.AverageRating();

            // Assert
            Assert.AreEqual(2, average);
        }

        // Test get average rating total (if total == 0, return 0)  
        [TestMethod]
        public void ProductModel_Get_AverageRating_DefaultTotal_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Ratings = new int[] {0};

            // Act
            int average = result.AverageRating();

            // Assert
            Assert.AreEqual(0, average);
        }

        // Test get average rating count (if count == 0, return 0)  
        [TestMethod]
        public void ProductModel_Get_AverageRating_DefaultCount_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            result.Ratings = new int[] { };

            // Act
            int average = result.AverageRating();

            // Assert
            Assert.AreEqual(0, average);
        }
    }
}
