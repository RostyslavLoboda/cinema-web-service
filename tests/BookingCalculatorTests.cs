using CinemaServer.Services;
using Xunit;

namespace CinemaServer.Tests;

public class BookingCalculatorTests
{
    [Fact]
    public void CalculateTotalPrice_ValidStudentBooking_ReturnsDiscountedPrice()
    {
        var calculator = new BookingCalculator();
        decimal result = calculator.CalculateTotalPrice(200m, 2, isStudent: true);
        Assert.Equal(999m, result);
    }

    [Fact]
    public void CalculateTotalPrice_ZeroTickets_ThrowsArgumentException()
    {
        var calculator = new BookingCalculator();
        Assert.Throws<ArgumentException>(() => calculator.CalculateTotalPrice(200m, 0, isStudent: false));
    }
}