using ShelfApi.Domain.Common.Extensions;
using ShelfApi.Domain.ErrorAggregate;

namespace ShelfApi.Domain.FinancialAggregate;

public record Price
{
    public decimal Value { get; private set; }

    public static Price Zero => new(0);

    public static Price Create(decimal value)
    {
        ErrorCode? errorCode = TryCreate(value, out Price price);
        if (errorCode.HasValue)
            throw new Ex
    }

    public static ErrorCode? TryCreate(decimal value, out Price price)
    {
        price = new()
        {
            Value = value
        };

        if (value < 0)
            return ErrorCode.InvalidPrice;

        return null;
    }

    public Price GetTax(decimal taxPercentage)
        => new(Value.GetPercentage(taxPercentage));

    public static Price operator +(Price p1, Price p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        Price price = new(p1.Value + p2.Value);
        return price;
    }

    public static Price operator -(Price p1, Price p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        Price price = new(p1.Value - p2.Value);
        return price;
    }

    public static Price operator *(Price p1, Price p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        Price price = new(p1.Value * p2.Value);
        return price;
    }

    public static Price operator /(Price p1, Price p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);
        ArgumentOutOfRangeException.ThrowIfEqual(p2, Zero);

        Price price = new(Math.Round(p1.Value / p2.Value));
        return price;
    }

    public static implicit operator decimal(Price x) => x.Value;
    public static implicit operator Price(decimal x)
    {
        ErrorCode? price = TryParse(x);
    };
}