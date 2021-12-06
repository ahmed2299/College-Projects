package com.example.myapplication;

import com.example.myapplication.football_data_org_api.ApiX;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.Path;
import retrofit2.http.Query;

public interface JsonPlaceHolderApo {

    @GET("posts")
    Call<List<Post>> getPost();

    @Headers("X-Auth-Token: b543c82bf9214722b854f3496284bf5d")
    @GET("competitions/{id}/teams/")
    Call<ApiX> getTeamX(@Path("id") String id);

    @Headers("X-Auth-Token: b543c82bf9214722b854f3496284bf5d")
    @GET("competitions/{id}")
    Call<ApiX> getCompetitionsX(@Path("id") String id);

    @Headers("X-Auth-Token: b543c82bf9214722b854f3496284bf5d")
    @GET("matches")
    Call<ApiX> getMatchesX(@Query("competitions") Integer competitionId,
                           @Query("dateFrom") String dateFrom,
                           @Query("dateTo") String dateTo);

    @Headers("X-Auth-Token: b543c82bf9214722b854f3496284bf5d")
    @GET("competitions/{id}/standings")
    Call<ApiX> getStanding(@Path("id") String id);
}
//baseURl ----