package com.example.myapplication;

import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import androidx.cardview.widget.CardView;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import com.example.myapplication.football_data_org_api.MatchX;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map.Entry;

public class MainMatchView extends RecyclerView.Adapter<MainMatchView.MainMatchViewHolder> {

    private Context context;
    private HashMap<String, ArrayList<MatchX>> matchMap;
    private Iterator<Entry<String, ArrayList<MatchX>>> iter;
    private ArrayList<MatchX> matchArrayList;
    private boolean isSortByTime;

    public MainMatchView(Context context, HashMap<String, ArrayList<MatchX>> matchMap) {
        this.context = context;
        this.matchMap = matchMap;
        iter = matchMap.entrySet().iterator();
        isSortByTime = false;
    }

    public MainMatchView(Context context, ArrayList<MatchX> matchArrayList) {
        this.context = context;
        this.matchArrayList = matchArrayList;
        isSortByTime = true;
    }

    @Override
    public MainMatchViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(context).inflate(R.layout.recycler_list, parent, false);
        return new MainMatchViewHolder(view);
    }




    @Override
    public void onBindViewHolder(MainMatchViewHolder holder, int position) {
        if (!isSortByTime) {
            Entry<String, ArrayList<MatchX>> entry = iter.next();
            holder.competitionName.setText(entry.getKey());
            holder.competitionId.setText(String.valueOf(entry.getValue().get(0).getCompetitionX().getCompetitionId()));
            holder.rvChild.setLayoutManager(new LinearLayoutManager(context));
            SubMatchView subMatchHolder = new SubMatchView(entry.getValue());
            holder.rvChild.setAdapter(subMatchHolder);
        } else {
            holder.competitionName.setText(matchArrayList.get(position).getCompetitionX().getCompetitionName());
            holder.competitionId.setText(String.valueOf(matchArrayList.get(position).getCompetitionX().getCompetitionId()));
            holder.rvChild.setLayoutManager(new LinearLayoutManager(context));
            ArrayList<MatchX> x = new ArrayList<>();
            x.add(matchArrayList.get(position));
            SubMatchView subMatchHolder = new SubMatchView(x);
            holder.rvChild.setAdapter(subMatchHolder);
        }
        holder.competitionCard.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                TextView text = (TextView) view.findViewById(R.id.competition_id);
                Intent i = new Intent(context, StandingActitvity.class).putExtra("id", text.getText());
                context.startActivity(i);
            }
        });
    }


    @Override
    public int getItemCount() {
        if (isSortByTime)
            return matchArrayList.size();
        else
            return matchMap.size();
    }


    public static class MainMatchViewHolder extends RecyclerView.ViewHolder {

        TextView competitionName, competitionId;
        RecyclerView rvChild;
        CardView competitionCard;

        public MainMatchViewHolder(View itemView) {
            super(itemView);
            rvChild = (RecyclerView) itemView.findViewById(R.id.match_recycler_view);
            competitionName = (TextView) itemView.findViewById(R.id.competition_name);
            competitionCard = (CardView) itemView.findViewById(R.id.competition_card);
            competitionId = (TextView) itemView.findViewById(R.id.competition_id);
        }
    }
}
