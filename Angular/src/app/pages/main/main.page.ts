import { Component, OnInit } from '@angular/core';

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

  constructor() {
  }

  ngOnInit(): void {
    
  }

  getWeather(): void {
    console.log("getWeather");
  }

}
