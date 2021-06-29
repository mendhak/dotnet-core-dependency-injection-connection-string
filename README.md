
```
dotnet run
```

Then, browse to 

https://localhost:5001/v1/WeatherForecast

and see the console output

Then browse to
 
https://localhost:5001/v2/BetterWeatherForecast

And see the console output

Go to [Startup.cs](Startup.cs#L41) to see how it's done. 

Look at the [Helper Resolver](Helper/HelperResolverService.cs), note the IHttpContextAccessor being injected. 

