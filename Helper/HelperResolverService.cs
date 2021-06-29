using Microsoft.AspNetCore.Http;

public class HelperResolverService
{
    private readonly IHttpContextAccessor context;
    public HelperResolverService(IHttpContextAccessor context)
    {
        this.context = context;
    }

    public string GetConnectionString(){
        
        if(context.HttpContext.Request.Path.ToString().Contains("v1")){
            return "The old connection string";
        }
        
        return "The new connection string";
    }

}