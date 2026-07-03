using Microsoft.Extensions.Configuration;

namespace EntityFrameworkExample.Settings
{
	public class ConnectionStringBuilder
	(
		IConfiguration configuration
	) : IConnectionStringBuilder
	{
		public string Build()
		{
			var connectionString = configuration
				.GetSection("ConnectionString")
				.Get<string>()
				?? string.Empty;

			return connectionString;
		}
	}
}
