using System;

public class MyRepository : IRepository
{
    private HelperResolverService helperResolverService;
    public MyRepository(HelperResolverService helperResolverService)
    {
        this.helperResolverService = helperResolverService;
        Console.WriteLine(helperResolverService.GetConnectionString());
    }
}