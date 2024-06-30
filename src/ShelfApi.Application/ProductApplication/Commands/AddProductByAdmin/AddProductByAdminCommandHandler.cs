using Mapster;
using MediatR;
using ShelfApi.Domain.ProductAggregate;

namespace ShelfApi.Application.ProductApplication;

public class AddProductByAdminCommandHandler(IIdManager idManager, IShelfApiDbContext dbContext)
    : IRequestHandler<AddProductByAdminCommand, ResultDto<ProductDto>>
{
    private IIdManager _idManager = idManager;
    private IShelfApiDbContext _dbContext = dbContext;

    public async Task<ResultDto<ProductDto>> Handle(AddProductByAdminCommand request, CancellationToken cancellationToken)
    {
        ulong id = _idManager.GenerateNextUlong();
        Product product = new(id, request.Name, request.Price, request.Quantity);

        _dbContext.Products.Add(product);

        await _dbContext.SaveChangesAsync();

        return product.Adapt<ProductDto>();
    }
}