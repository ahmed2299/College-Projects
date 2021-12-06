package com.example.myapplication;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.myapplication.football_data_org_api.Table;

import java.util.ArrayList;

public class CompetitionTableAdapter extends RecyclerView.Adapter<CompetitionTableAdapter.TableHolder> {

    private Context context;
    private ArrayList<Table> tableArrayList;

    public CompetitionTableAdapter(Context context, ArrayList<Table> tableArrayList) {
        this.context = context;
        this.tableArrayList = tableArrayList;
    }

    @NonNull
    @Override
    public TableHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(context).inflate(R.layout.recycler_standing_table,parent,false);
        return new CompetitionTableAdapter.TableHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull TableHolder holder, int position) {
        Table table = tableArrayList.get(position);
        holder.teamName.setText(table.getTeam().getTeamName());
        holder.gamePlayed.setText(String.valueOf(table.getPlayedGames()));
        holder.won.setText(String.valueOf(table.getWon()));
        holder.draw.setText(String.valueOf(table.getDraw()));
        holder.lost.setText(String.valueOf(table.getLost()));
        holder.points.setText(String.valueOf(table.getPoints()));
        holder.goalsFor.setText(String.valueOf(table.getGoalsFor()));
        holder.goalsAgainst.setText(String.valueOf(table.getGoalsAgainst()));
        holder.goalsDifferent.setText(String.valueOf(table.getGoalDifference()));

    }

    @Override
    public int getItemCount() {
        return tableArrayList.size();
    }

    public static class TableHolder extends RecyclerView.ViewHolder{

        TextView teamName, gamePlayed, won, draw, lost, points, goalsFor, goalsAgainst, goalsDifferent;

        public TableHolder(@NonNull View itemView) {
            super(itemView);
            teamName = (TextView) itemView.findViewById(R.id.team_name_api);
            gamePlayed = (TextView) itemView.findViewById(R.id.played_games_api);
            won = (TextView) itemView.findViewById(R.id.won_api);
            draw = (TextView) itemView.findViewById(R.id.draw_api);
            lost = (TextView) itemView.findViewById(R.id.lost_api);
            points = (TextView) itemView.findViewById(R.id.points_api);
            goalsFor = (TextView) itemView.findViewById(R.id.goals_for_api);
            goalsAgainst = (TextView) itemView.findViewById(R.id.goals_against_api);
            goalsDifferent = (TextView) itemView.findViewById(R.id.goal_difference_api);

        }
    }
}
