using MediatR;

namespace ShelfApi.Application.ProductApplication;

public class ListProductsQuery : IRequest<ResultDto<List<ProductDto>>>
{
}