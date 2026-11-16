namespace CinemaServer.Services;

public class BookingCalculator
{
    public decimal CalculateTotalPrice(decimal basePrice, int ticketsCount, bool isStudent)
    {
        if (ticketsCount <= 0)
            throw new ArgumentException("Кількість квитків має бути більшою за нуль.", nameof(ticketsCount));

        if (basePrice < 0)
            throw new ArgumentException("Ціна квитка не може бути від'ємною.", nameof(basePrice));

        decimal total = basePrice * ticketsCount;
        return isStudent ? total * 0.8m : total; // 20% студентська знижка
    }
}