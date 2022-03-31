import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { WeatherForecast } from '../models/WeatherForecast';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class WeatherService {

  constructor(private http: HttpClient) { }

  public getWeatherForecastByAddress(address:string, city:string, state:string, zip:string): Observable<WeatherForecast[]>
  {
    return this.http.post<WeatherForecast[]>(environment.weatherService + "/api/weather", {
      address: address, city: city, state: state, zip: zip
    });
  }
}
