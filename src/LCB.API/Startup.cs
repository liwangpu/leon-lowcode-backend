using FluentValidation.AspNetCore;
using LCB.API.Application.Validations.Books;
using LCB.API.Infrastructure.Datastores;
using LCB.Domain.AggregateModels.BookAggregate;
using LCB.Infrastructure.Datastores;
using LCB.Infrastructure.Repositories;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace LCB.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<BookStoreSettings>(Configuration.GetSection(nameof(BookStoreSettings)));
            services.AddSingleton<IBookStoreSettings>(sp => sp.GetRequiredService<IOptions<BookStoreSettings>>().Value);
            services.AddSingleton<IBookRepository, BookRepository>();

            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddControllers().AddFluentValidation(fv=>fv.RegisterValidatorsFromAssemblyContaining<BookCreateValidator>());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
