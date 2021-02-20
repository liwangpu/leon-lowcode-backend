using MediatR;

namespace LCB.API.Application.Queries.Dynamic
{
    public class DynamicQuery : IRequest<DynamicQueryDTO>
    {
        public dynamic Filter { get; set; }
        public dynamic Sort { get; set; }
    }

    public class DynamicQueryDTO
    {

    }
}
