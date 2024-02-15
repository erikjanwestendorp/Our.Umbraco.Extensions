using Microsoft.AspNetCore.Builder;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Extensions;

namespace Our.Umbraco.Extensions;

public static class WebApplicationBuilderExtensions
{
	public static IUmbracoBuilder CreateUmbracoBuilder(this WebApplicationBuilder builder, Action<WebApplicationBuilder> configure)
	{
		configure(builder);

		return builder.CreateUmbracoBuilder();
	}
}
