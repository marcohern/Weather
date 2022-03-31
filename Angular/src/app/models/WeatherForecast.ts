
export class WeatherForecast {
    public number:number = 0;
    public startTime:Date = new Date;
    public endTime:Date = new Date;
    public isDaytime:boolean = false;
    public temperature:number = 0;
    public temperatureUnit:string = "";
    public temperatureTrend:string = "";
    public windSpeed:string = "";
    public windDirection:string = "";
    public icon:string = "";
    public shortForecast:string = "";
    public detailedForecast:string = "";
}