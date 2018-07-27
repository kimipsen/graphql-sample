using CurriculumVitaeAPI.Models;
using CurriculumVitaeData;
using CurriculumVitaeData.Repositories;
using CurriculumVitaeModel.Data;
using GraphQL;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CurriculumVitaeAPI.Extensions
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// Registers repositories with DI container.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            var connString = configuration["ConnectionStrings:CV"];
            services.AddDbContext<CVContext>(options => options.UseSqlServer(connString));
            services.AddSingleton<ICompanyRepository, CompanyRepository>();
            services.AddSingleton<IProjectRepository, ProjectRepository>();
            services.AddSingleton<IEducationRepository, EducationRepository>();
            services.AddSingleton<ILinkRepository, LinkRepository>();
            services.AddSingleton<ICVRepository, CVRepository>();
            return services.AddSingleton<ISkillRepository, SkillRepository>();
        }

        /// <summary>
        /// Registers GraphQL classes and configuration wiht DI container.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterGraphQL(this IServiceCollection services)
        {
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<CVQuery>();
            services.AddSingleton<CVType>();
            services.AddSingleton<CompanyType>();
            services.AddSingleton<ProjectType>();
            services.AddSingleton<EducationType>();
            services.AddSingleton<LinkType>();
            services.AddSingleton<ExperienceEnum>();
            services.AddSingleton<SkillType>();
            var serviceProvider = services.BuildServiceProvider();
            return services.AddSingleton<ISchema>(new CVSchema(new FuncDependencyResolver(type => serviceProvider.GetService(type))));
        }
    }
}
