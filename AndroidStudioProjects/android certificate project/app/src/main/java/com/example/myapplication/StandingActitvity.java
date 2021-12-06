package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.util.Log;
import android.widget.Toast;

import com.example.myapplication.football_data_org_api.ApiX;
import com.example.myapplication.football_data_org_api.Standing;
import com.example.myapplication.football_data_org_api.Table;

import java.util.ArrayList;

import okhttp3.OkHttpClient;
import okhttp3.logging.HttpLoggingInterceptor;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class StandingActitvity extends AppCompatActivity {

    private static final String TAG = "StandingActivity";
    private JsonPlaceHolderApo Json;
    RecyclerView recyclerView;
    CompetitionTableAdapter holder;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_standing_actitvity);
        HttpLoggingInterceptor loggingInterceptor = new HttpLoggingInterceptor();
        loggingInterceptor.setLevel(HttpLoggingInterceptor.Level.BODY);

        OkHttpClient okHttpClient = new OkHttpClient.Builder()
                .addInterceptor(loggingInterceptor).build();

        Retrofit retrofit = new Retrofit.Builder().baseUrl("http://api.football-data.org/v2/")
                .addConverterFactory(GsonConverterFactory.create())
                .client(okHttpClient)
                .build();

        Json = retrofit.create(JsonPlaceHolderApo.class);


        getStanding();
    }





    private void getStanding() {
        Call<ApiX> call = Json.getStanding(getIntent().getStringExtra("id"));

        call.enqueue(new Callback<ApiX>() {
            @Override
            public void onResponse(Call<ApiX> call, Response<ApiX> response) {
                if (!response.isSuccessful()) {
                    Log.d(TAG, "Code: " + response.code());
                    return;
                }

                if (response.body().getStandingArrayList().size() > 0 ) {
                    fillRecycler(response.body().getStandingArrayList());
                } else {
                    Toast.makeText(StandingActitvity.this, "Competition has no Table", Toast.LENGTH_SHORT).show();
                }

            }

            @Override
            public void onFailure(Call<ApiX> call, Throwable t) {
                Toast.makeText(StandingActitvity.this, getString(R.string.connection_failed), Toast.LENGTH_SHORT).show();
            }
        });

    }




    private void fillRecycler(ArrayList<Standing> standingArrayList) {
        ArrayList<Table> x = standingArrayList.get(0).getTables();
        holder = new CompetitionTableAdapter(StandingActitvity.this, x);
        recyclerView = (RecyclerView) findViewById(R.id.recycler_table);
        recyclerView.setLayoutManager(new LinearLayoutManager(StandingActitvity.this));
        recyclerView.setAdapter(holder);
    }
}
