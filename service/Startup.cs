using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace service
{
	public class Startup
	{
		public Startup(IConfiguration configuration) => Configuration = configuration;
		public IConfiguration Configuration { get; }
		public void ConfigureServices(IServiceCollection services) => services.AddControllers();
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			app.UseRouting();
			app.UseCors(builder => builder.WithOrigins("http://localhost:3000").WithMethods("GET"));
			app.UseEndpoints(endpoints => endpoints.MapControllers());
		}
	}
}
