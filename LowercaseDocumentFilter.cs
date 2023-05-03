using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace GlitchSimulator;

public class LowerCaseDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        foreach (var path in swaggerDoc.Paths.ToList())
        {
            var newPath = path.Key.ToLower();
            swaggerDoc.Paths.Remove(path.Key);
            swaggerDoc.Paths.Add(newPath, path.Value);
        }
    }
}