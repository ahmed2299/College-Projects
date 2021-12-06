package com.example.myapplication.football_data_org_api;

import com.google.gson.annotations.SerializedName;

import java.util.ArrayList;
public class ApiX {

    @SerializedName("matches")
    private ArrayList<MatchX> matchXList;
    @SerializedName("standings")
    private ArrayList<Standing> standingArrayList;

    public ArrayList<Standing> getStandingArrayList() {
        return standingArrayList;
    }

    public ArrayList<MatchX> getMatchXList() {
        return matchXList;
    }
}
