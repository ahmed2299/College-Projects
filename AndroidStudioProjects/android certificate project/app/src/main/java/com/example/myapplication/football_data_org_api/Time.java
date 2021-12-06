package com.example.myapplication.football_data_org_api;

import com.google.gson.annotations.SerializedName;

public class Time {

    @SerializedName("homeTeam")
    private int homeTeamScore;
    @SerializedName("awayTeam")
    private int awayTeamScore;

    public int getHomeTeamScore() {
        return homeTeamScore;
    }

    public int getAwayTeamScore() {
        return awayTeamScore;
    }
}
