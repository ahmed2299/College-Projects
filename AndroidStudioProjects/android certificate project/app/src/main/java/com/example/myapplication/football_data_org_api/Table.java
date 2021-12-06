package com.example.myapplication.football_data_org_api;

import com.google.gson.annotations.SerializedName;

public class Table {

    @SerializedName("team")
    private TeamX team;
    @SerializedName("playedGames")
    private int playedGames;
    @SerializedName("won")
    private int won;
    @SerializedName("draw")
    private int draw;
    @SerializedName("lost")
    private int lost;
    @SerializedName("points")
    private int points;
    @SerializedName("goalsFor")
    private int goalsFor;
    @SerializedName("goalsAgainst")
    private int goalsAgainst;
    @SerializedName("goalDifference")
    private int goalDifference;

    public TeamX getTeam() {
        return team;
    }

    public int getPlayedGames() {
        return playedGames;
    }

    public int getWon() {
        return won;
    }

    public int getDraw() {
        return draw;
    }

    public int getLost() {
        return lost;
    }

    public int getPoints() {
        return points;
    }

    public int getGoalsFor() {
        return goalsFor;
    }

    public int getGoalsAgainst() {
        return goalsAgainst;
    }

    public int getGoalDifference() {
        return goalDifference;
    }
}
