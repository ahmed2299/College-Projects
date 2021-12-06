package com.example.myapplication;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import com.example.myapplication.football_data_org_api.ApiX;
import com.example.myapplication.football_data_org_api.MatchX;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;
import java.util.HashMap;
import java.util.Locale;

import okhttp3.OkHttpClient;
import okhttp3.logging.HttpLoggingInterceptor;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class MainActivity extends AppCompatActivity {

    private static final String TAG = "MainActivity";
    private JsonPlaceHolderApo Json;
    private String date;
    RecyclerView recyclerView;
    MainMatchView holder;
    Button btnDate;
    boolean isSortedByDate;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        isSortedByDate = true;
        btnDate = (Button) findViewById(R.id.btn_date);

        recyclerView = (RecyclerView) findViewById(R.id.recyclerView);
        recyclerView.setLayoutManager(new LinearLayoutManager(MainActivity.this));

        date = new SimpleDateFormat("yyyy-MM-d", Locale.getDefault()).format(new Date());

        HttpLoggingInterceptor loggingInterceptor = new HttpLoggingInterceptor();
        loggingInterceptor.setLevel(HttpLoggingInterceptor.Level.BODY);

        OkHttpClient okHttpClient = new OkHttpClient.Builder()
                .addInterceptor(loggingInterceptor).build();

        Retrofit retrofit = new Retrofit.Builder().baseUrl(getString(R.string.api_address))
                .addConverterFactory(GsonConverterFactory.create())
                .client(okHttpClient)
                .build();

        Json = retrofit.create(JsonPlaceHolderApo.class);
    }

    @Override
    protected void onStart() {
        btnDate.setText(date);
        btnDate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i = new Intent(MainActivity.this, CalenderActivity.class);
                startActivityForResult(i, 12);
            }
        });
        super.onStart();
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_options, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        switch (item.getItemId()) {
            case R.id.sort_by_competition:
                isSortedByDate = false;
                getMatches(isSortedByDate, date);
                break;
            case R.id.sort_by_time:
                isSortedByDate = true;
                getMatches(isSortedByDate, date);
                break;
        }
        return super.onOptionsItemSelected(item);
    }

    private void getMatches(final boolean isSortByTime, String date) {
        String dd = "2019-06-01";
        Call<ApiX> call = Json.getMatchesX(null, date, date);
        call.enqueue(new Callback<ApiX>() {
            @Override
            public void onResponse(Call<ApiX> call, Response<ApiX> response) {
                if (!response.isSuccessful()) {
                    return;
                }

                ArrayList<MatchX> f = response.body().getMatchXList();
                if (f.size() != 0) {
                    if ((isSortByTime)) {
                        fillRecycleByTime(f);
                    } else {
                        fillRecycleByCompetition(f);
                    }
                } else {
                    Toast.makeText(MainActivity.this, "No Match Today", Toast.LENGTH_SHORT).show();
                    fillRecycleByCompetition(new ArrayList<MatchX>());
                }
            }

            @Override
            public void onFailure(Call<ApiX> call, Throwable t) {
                Log.d(TAG, "onFailure: in Failure" + t.getMessage());
                Toast.makeText(MainActivity.this, getString(R.string.connection_failed), Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void fillRecycleByCompetition(ArrayList<MatchX> matchList) {
        HashMap<String, ArrayList<MatchX>> matchMap = new HashMap<>();

        for (MatchX match : matchList) {
            String competitionName = match.getCompetitionX().getCompetitionName();
            if (matchMap.containsKey(competitionName)) {
                matchMap.get(competitionName).add(match);
            }
            else {
                ArrayList<MatchX> matchXArrayList = new ArrayList<>();
                matchXArrayList.add(match);
                matchMap.put(competitionName, matchXArrayList);
            }
        }

        holder = new MainMatchView(MainActivity.this, matchMap);
        recyclerView.setAdapter(holder);
    }

    private void fillRecycleByTime(ArrayList<MatchX> matchList) {
        Collections.sort(matchList);
        holder = new MainMatchView(MainActivity.this, matchList);
        recyclerView.setAdapter(holder);

    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        if (requestCode == 12) {
            if (resultCode == RESULT_OK) {
                date = data.getStringExtra("e");
                getMatches(isSortedByDate, date);
            }
        }
    }
}


