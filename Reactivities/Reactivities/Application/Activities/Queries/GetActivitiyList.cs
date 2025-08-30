using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Activities.Queries
{
    public class GetActivitiyList
    {
        public class Query: IRequest<List<Activity>>
        { }

        public class Handler(AppDbContext context, ILogger<GetActivitiyList> logger) : IRequestHandler<Query, List<Activity>>
        {
            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                logger.LogInformation("Call GetActivityList");

                return await context.Activities.ToListAsync(cancellationToken);
            }
        }
    }
}
