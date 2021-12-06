package com.example.myapplication.football_data_org_api;

import com.google.gson.annotations.SerializedName;

import java.util.ArrayList;

public class Standing {

    @SerializedName("table")
    private ArrayList<Table> tables;

    public ArrayList<Table> getTables() {
        return tables;
    }
}
