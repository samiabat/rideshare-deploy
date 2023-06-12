using AutoMapper;
using Rideshare.Application.Common.Dtos.Feedbacks;
using Rideshare.Application.Common.Dtos.Tests;
using Rideshare.Domain.Entities;

namespace Rideshare.Application.Profiles;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
            #region TestEntity Mappings

            CreateMap<TestEntity, TestEntityDto>().ReverseMap();

        #endregion TestEntity
        #region
        CreateMap<CreateFeedbackDto, Feedback>().ReverseMap();
        CreateMap<UpdateFeedbackDto, Feedback>().ReverseMap();
        CreateMap<FeedbackDto, Feedback>().ReverseMap();
        #endregion
    }
}
