package com.example.myapplication.football_data_org_api;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class TeamX {

    @SerializedName("id")
    @Expose
    private int teamId;
    @SerializedName("name")
    @Expose
    private String teamName;
    @SerializedName("crestUrl")
    @Expose
    private String imgUrl;

    public void setImgUrl(String imgUrl) {
        this.imgUrl = imgUrl;
    }

    public String getImgUrl() {
        return imgUrl;
    }

    public int getTeamId() {
        return teamId;
    }

    public String getTeamName() {
        return teamName;
    }
}
