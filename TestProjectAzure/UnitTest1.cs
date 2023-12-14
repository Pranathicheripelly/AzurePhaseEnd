using AzurePhaseEnd.Pages;
using AzurePhaseEnd;
using Microsoft.AspNetCore.Mvc;

namespace TestProjectAzure
{
    [TestFixture]
    public class PizzaOrderTests
    {
        [Test]
        public void PizzaSelectionPage_ShouldReturnPageResult()
        {
            // Arrange
            var pizzaPageModel = new PizzaModel();

            // Act
            var result = pizzaPageModel.OnPostAddToCart();

            // Assert
            Assert.IsInstanceOf<RedirectToPageResult>(result);
            var redirectResult = (RedirectToPageResult)result;
            Assert.AreEqual("OrderCheckout", redirectResult.PageName);
        }

        [Test]
        public void OrderCheckOutPage_ShouldReturnPageResult()
        {
            // Arrange
            var orderCheckoutModel = new OrderCheckoutModel
            {
                SelectedPizza = "Pepperoni",
                Quantity = 2
            };

            // Act
            var result = orderCheckoutModel.OnPostPlaceOrder();

            // Assert
            Assert.IsInstanceOf<RedirectToPageResult>(result);
            var redirectResult = (RedirectToPageResult)result;
            Assert.AreEqual("OrderConformation", redirectResult.PageName);
        }

        // Add more test methods as needed to cover different scenarios
    }
}
