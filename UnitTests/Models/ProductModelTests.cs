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
            Assert.AreEqual(result.Logistics, "");
        }

        // Test setting Logistics to a string value
        [TestMethod]
        public void ProductModel_Set_Logistics_Valid_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Logistics = "Transported";

            // Assert
            Assert.AreEqual(result.Logistics, "Transported");
        }

        // Test setting Logistics to a Null value (a string can be Null) 
        [TestMethod]
        public void ProductModel_Set_Logistics_Null_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Logistics = null; 

            // Assert
            Assert.AreEqual(result.Logistics, null);
        }

        // Test default get e-mail
        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(result.Email, "Unknown");
        }

        // Test set e-mail with valid string value
        [TestMethod]
        public void ProductModel_Set_Email_Valid_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Email = "js@ProductModel.com";

            // Assert
            Assert.AreEqual(result.Email, "js@ProductModel.com");
        }


        // Test default get ID (not set in constructor, should be null)
        [TestMethod]
        public void ProductModel_Get_ID_Devault_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(result.Id, null);
        }

        // Test set ID to valid string 
        [TestMethod]
        public void ProductModel_Set_ID_Valid_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Id = "Jason";

            // Assert
            Assert.AreEqual(result.Id, "Jason");
        }

        // Test default get ratings 
        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            int[] rating = new int[] { 5 };

            // Assert
            CollectionAssert.AreEqual(rating, result.Ratings);
        }

        // Test set ratings to valid int[]
        [TestMethod]
        public void ProductModel_Set_Ratings_Valid_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Ratings = new int[] { 1 };
            int[] rating = new int[] { 1 };

            // Assert
            CollectionAssert.AreEqual(result.Ratings, rating);
        }

        // Test get description default (should be null) 
        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(result.Description, null);
        }

        // Test set description to valid string 
        [TestMethod]
        public void ProductModel_Set_Description_Valid_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Description = "Desk Lamp";

            // Assert
            Assert.AreEqual(result.Description, "Desk Lamp");
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

            // Act
            var result = new ProductModel();
            DateTime thisDate = new DateTime(2008, 3, 15);
            result.Date = thisDate; 

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
            Assert.AreEqual(result.Image, null); 
        }

        // Test set image to valid string 
        [TestMethod]
        public void ProductModel_Set_Image_Valid_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            string image = "Img";
            result.Image = "Img";

            // Assert
            Assert.AreEqual(result.Image, image);
        }

        // Test get maker default (not set in constructor, should be null)
        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
   
            // Assert
            Assert.AreEqual(result.Maker, null);
        }

        // Test set maker to valid string 
        [TestMethod]
        public void ProductModel_Set_Maker_Valid_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            string maker = "Jessica Jones";
            result.Maker = "Jessica Jones";

            // Assert
            Assert.AreEqual(result.Maker, maker);
        }
    }
}
