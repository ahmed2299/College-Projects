package com.example.myapplication;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;
import com.example.myapplication.football_data_org_api.MatchX;

import java.util.ArrayList;

public class SubMatchView extends RecyclerView.Adapter<SubMatchView.SubMatchHolder> {

    private ArrayList<MatchX> matchXList;

    public SubMatchView(ArrayList<MatchX> matchXList){
        this.matchXList = matchXList;
    }

    @NonNull
    @Override
    public SubMatchHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.recycler_sub_match,parent,false);
        return new SubMatchView.SubMatchHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull SubMatchHolder holder, int position) {

        MatchX match = matchXList.get(position);
        match.setChecked(true);
        int index = match.getMatchDate().indexOf("T");
        index++;
        holder.date.setText(match.getMatchDate().substring(index,index+5));

        holder.homeTeam.setText(match.getHomeTeam().getTeamName());

        if (match.getHomeTeam().getTeamName().length() > 12)
            holder.homeTeam.setTextSize(8);
       // holder.status.setText(String.valueOf(match.getMatchScore().getFullTime().getAwayTeamScore()) + ":" + String.valueOf(match.getMatchScore().getFullTime().getHomeTeamScore()));
        holder.awayTeam.setText(match.getAwayTeam().getTeamName());

        if (match.getAwayTeam().getTeamName().length() > 12)
            holder.awayTeam.setTextSize(8);
    }

    @Override
    public int getItemCount() {
        return matchXList.size();
    }

    public static class SubMatchHolder extends RecyclerView.ViewHolder{

        Button date, homeTeam, status, awayTeam;
        public SubMatchHolder(@NonNull View itemView) {
            super(itemView);

            date = (Button) itemView.findViewById(R.id.buttonDate);
            homeTeam = (Button) itemView.findViewById(R.id.buttonHomeTeamName);
            status = (Button) itemView.findViewById(R.id.buttonStatus);
            awayTeam = (Button) itemView.findViewById(R.id.buttonAwayTeamName);
        }
    }
}
