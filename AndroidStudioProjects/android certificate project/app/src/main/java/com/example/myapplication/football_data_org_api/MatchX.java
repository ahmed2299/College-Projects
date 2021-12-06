package com.example.myapplication.football_data_org_api;

import com.google.gson.annotations.SerializedName;

public class MatchX implements Comparable<MatchX>{

    @SerializedName("id")
    private int matchId;
    @SerializedName("competition")
    private CompetitionX competitionX;
    @SerializedName("status")
    private String status;
    @SerializedName("homeTeam")
    private TeamX homeTeam;
    @SerializedName("awayTeam")
    private TeamX awayTeam;
    @SerializedName("utcDate")
    private String matchDate;
    @SerializedName("score")
    private Score matchScore;
    private boolean checked = false;

    public boolean isChecked() {
        return checked;
    }

    public void setChecked(boolean checked) {
        this.checked = checked;
    }

    public int getMatchId() {
        return matchId;
    }

    public CompetitionX getCompetitionX() {
        return competitionX;
    }

    public String getStatus() {
        return status;
    }

    public TeamX getHomeTeam() {
        return homeTeam;
    }

    public TeamX getAwayTeam() {
        return awayTeam;
    }

    public String getMatchDate() {
        return matchDate;
    }

    @Override
    public int compareTo(MatchX matchX) {
        int index = matchX.getMatchDate().indexOf("T");
        index++;
        String hour1 = matchDate.substring(index,index+2);
        String min1 = matchDate.substring(index+3,index+5);
        String hour2 = matchX.matchDate.substring(index,index+2);
        String min2 = matchX.matchDate.substring(index+3,index+5);

        String x = hour1+":"+min1+"\t"+hour2+":"+min2;


        if (Integer.valueOf(hour1) < Integer.valueOf(hour2))
            return -1;
        else if (Integer.valueOf(hour1) > Integer.valueOf(hour2))
            return 1;
        else {
            if (Integer.valueOf(min1) < Integer.valueOf(min2))
                return -1;
            else if (Integer.valueOf(min1) > Integer.valueOf(min2))
                return 1;
        }
        return 0;
    }
}
