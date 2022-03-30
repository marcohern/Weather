using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Weather.Entities;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Globalization;

namespace Weather.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public WeatherController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpPost]
    public async Task<List<ForecastPeriod>> Index(AddressInput input) {
        var location = await GetLocationAsync(input);
        var forecast = await GetPointWeatherAsync(location);
        return forecast.properties.periods;
    }

    private async Task<LatLng> GetLocationAsync(AddressInput input)
    {
        var httpRequestMessage = new HttpRequestMessage(
            HttpMethod.Get,
            $"https://geocoding.geo.census.gov/geocoder/locations/address?{GetQueryStrings(input)}");
        this.SetHeaders(httpRequestMessage);

        var httpClient = _httpClientFactory.CreateClient();
        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

        var json = await httpResponseMessage.Content.ReadAsStringAsync();
        var matches = JsonConvert.DeserializeObject<AddressOutput>(json);

        var coordinates = matches.result.addressMatches[0].coordinates;
        return new LatLng {
            Lat = coordinates.y,
            Lng = coordinates.x
        };
    }

    private async Task<Forecast?> GetPointWeatherAsync(LatLng latLng)
    {
        var culture = CultureInfo.CreateSpecificCulture("en-US");
        var url = $"https://api.weather.gov/points/{latLng.Lat.ToString("G",culture)},{latLng.Lng.ToString("G",culture)}";
        var httpRequestMessage = new HttpRequestMessage( HttpMethod.Get, url);
        this.SetHeaders(httpRequestMessage);
        var httpClient = _httpClientFactory.CreateClient();
        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        var json = await httpResponseMessage.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<WeatherPoints>(json);

        httpRequestMessage = new HttpRequestMessage( HttpMethod.Get, result.properties.forecast);
        this.SetHeaders(httpRequestMessage);
        httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        json = await httpResponseMessage.Content.ReadAsStringAsync();
        var forecast = JsonConvert.DeserializeObject<Forecast>(json);

        return forecast;
    }

    private void SetHeaders(HttpRequestMessage httpRequestMessage)
    {
        if (httpRequestMessage == null) return;
        httpRequestMessage.Headers.Add(HeaderNames.Accept,  "application/json" );
        httpRequestMessage.Headers.Add(HeaderNames.UserAgent,  "Weather App" );
    }

    private string GetQueryStrings(AddressInput input)
    {
        string queryString = "benchmark=Public_AR_Current&vintage=Current_Current";
        queryString += (input.Address == "") ? "" : $"&street={input.Address}";
        queryString += (input.City == "") ? "" : $"&city={input.City}";
        queryString += (input.State == "") ? "" : $"&state={input.State}";
        queryString += (input.Zip == "") ? "" : $"&zip={input.Zip}";
        return queryString;
    }
}