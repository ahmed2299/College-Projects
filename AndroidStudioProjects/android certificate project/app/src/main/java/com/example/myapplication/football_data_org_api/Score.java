package com.example.myapplication.football_data_org_api;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class Score {

    @SerializedName("fullTime")
    private Time fullTime;

    public Time getFullTime() {
        return fullTime;
    }
}
