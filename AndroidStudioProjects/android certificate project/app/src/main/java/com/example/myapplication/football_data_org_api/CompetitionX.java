package com.example.myapplication.football_data_org_api;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class CompetitionX {
    @SerializedName("id")
    @Expose
    private int competitionId;
    @SerializedName("name")
    @Expose
    private String competitionName;

    public int getCompetitionId() {
        return competitionId;
    }

    public String getCompetitionName() {
        return competitionName;
    }
}
