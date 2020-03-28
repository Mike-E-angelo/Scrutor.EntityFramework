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
			    .ConfigureServices(x => x.AddSingleton<ApplicationStorage, ApplicationStorage>()
			                             .Decorate<ApplicationStorage>(storage => storage))
			    .Build()
			    .Services.GetService<ApplicationStorage>();
		}
	}

	public class ApplicationStorage {}
}