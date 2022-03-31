import { Component, OnInit } from '@angular/core';
import { WeatherForecast } from 'src/app/models/WeatherForecast';
import { WeatherService } from '../../services/weather.service';

@Component({
  selector: 'app-main',
  templateUrl: './main.page.html',
  styleUrls: ['./main.page.css']
})
export class MainPage implements OnInit {

  public address:string = '';
  public city:string = '';
  public state:string = '';
  public zip:string = '';

  constructor(private weatherService:WeatherService) {
  }

  ngOnInit(): void {
    
  }

  getWeather(): void {
    console.log("getWeather");
    this.weatherService.getWeatherForecastByAddress(this.address, this.city, this.state, this.zip)
      .subscribe((forecast:WeatherForecast[]) => {
        console.log(forecast);
      });
  }

}
