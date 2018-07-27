using CurriculumVitaeModel.Models;
using GraphQL.Types;

namespace CurriculumVitaeAPI.Models
{
    /// <summary>
    /// Map Education to a graphql object
    /// </summary>
    public class EducationType : ObjectGraphType<Education>
    {
        /// <summary>
        /// Maps dates as "yyyy-MM".
        /// </summary>
        public EducationType()
        {
            Field(x => x.Id);
            Field(x => x.Title);
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
