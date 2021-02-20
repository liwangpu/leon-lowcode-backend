using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LCB.API.Application.Queries.Dynamic
{
    public class DynamicQueryHandler : IRequestHandler<DynamicQuery, DynamicQueryDTO>
    {
        public DynamicQueryHandler()
        {

        }

        public async Task<DynamicQueryDTO> Handle(DynamicQuery request, CancellationToken cancellationToken)
        {

            return new DynamicQueryDTO();
        }
    }
}
