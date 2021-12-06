package com.example.myapplication;

public class Temperature {
    private float temperature;

    public float getTemperature() {
        return temperature;
    }

    public void setTemperature(float temperature) {
        this.temperature = temperature;
    }

    public float convertFahrenhitToCelsius(){
        return ((temperature-32)*5/9);
    }

    public float convertCelsiusToFahrenhit(){
        return ((temperature*9)/5)+32;
    }

}
