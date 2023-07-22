namespace CQRS_Casgem.CQRSPattern.Queries
{
    public class GetProductUpdateBtIDQuery
    {
        public GetProductUpdateBtIDQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
