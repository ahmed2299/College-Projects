package com.example.myapplication;

import com.google.gson.annotations.SerializedName;

public class Post {

    private int id;
    private String userId;
    private String title;

    @SerializedName("body")
    private String Text;

    public String getUserId() {
        return userId;
    }

    public int getId() {
        return id;
    }

    public String getTitle() {
        return title;
    }

    public String getText() {
        return Text;
    }
}
