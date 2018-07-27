using CurriculumVitaeModel.Models;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    public class EducationType : ObjectGraphType<Education>
    {
        public EducationType()
        {
            Field(x => x.Id);
            Field(x => x.School);
            Field<StringGraphType>("startDate", 
                resolve: context => 
                    context
                    .Source
                    .StartDate
                    .ToString(Constants.DateTimeFormatForPeriods));
            Field<StringGraphType>("endDate", 
                resolve: context => 
                    context
                    .Source
                    .EndDate
                    .ToString(Constants.DateTimeFormatForPeriods));
        }
    }
}
