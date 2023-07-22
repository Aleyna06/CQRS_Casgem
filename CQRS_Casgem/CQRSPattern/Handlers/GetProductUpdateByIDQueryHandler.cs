using CQRS_Casgem.CQRSPattern.Queries;
using CQRS_Casgem.CQRSPattern.Result;
using CQRS_Casgem.DAL;

namespace CQRS_Casgem.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductUpdateByIDQueryResult Handle(GetProductUpdateBtIDQuery query)
        {
            var value = _context.Products.Find(query.Id);
            return new GetProductUpdateByIDQueryResult
            {
                Brand = value.Brand,
                Category = value.Category,
                Name = value.Name,
                Price = value.Price,
                ProductID = value.ProductID,
                Stock = value.Stock,
            };
        }
    }
}
