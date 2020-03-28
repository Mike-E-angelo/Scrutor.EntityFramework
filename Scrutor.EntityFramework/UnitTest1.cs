using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Xunit;

namespace Scrutor.EntityFramework
{
	public sealed class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			Host.CreateDefaultBuilder()
			    .ConfigureServices(Configure)
			    .Build()
			    .Services.GetService<ApplicationStorage>();
		}

		static void Configure(IServiceCollection services)
		{
			services.AddScoped<ApplicationStorage, ApplicationStorage>()
			        .Decorate<ApplicationStorage>(storage => storage);
		}
	}

	public class ApplicationStorage {}

}