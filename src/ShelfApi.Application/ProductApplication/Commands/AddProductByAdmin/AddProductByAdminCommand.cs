using MediatR;

namespace ShelfApi.Application.ProductApplication;

public class AddProductByAdminCommand : IRequest<ResultDto<ProductDto>>
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}