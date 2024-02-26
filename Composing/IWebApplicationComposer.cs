using Microsoft.AspNetCore.Builder;

namespace Our.Umbraco.Extensions.Composing;

public interface IWebApplicationComposer
{
    void Compose(WebApplicationBuilder builder);
}