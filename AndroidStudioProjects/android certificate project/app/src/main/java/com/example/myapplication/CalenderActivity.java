package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.nfc.Tag;
import android.os.Bundle;
import android.util.Log;
import android.widget.CalendarView;

import com.google.android.material.tabs.TabLayout;

public class CalenderActivity extends AppCompatActivity {

    private CalendarView calendar;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calender);
        calendar = (CalendarView) findViewById(R.id.calendarView);
    }

    @Override
    protected void onStart() {
    calendar.setOnDateChangeListener(new CalendarView.OnDateChangeListener() {
        @Override
        public void onSelectedDayChange(CalendarView calendarView, int i, int i1, int i2) {
            String date = String.valueOf(i);
            if(i1+1 <10)
                date += "-0"+(i1+1);
            else
                date += "-"+(i1+1);
            if (i2 < 10)
                date += "-0"+i2;
            else
                date += "-"+i2;
            Intent intent = new Intent(CalenderActivity.this,MainActivity.class);
            intent.putExtra("e", date);
            setResult(RESULT_OK, intent);
            finish();

        }
    });
        super.onStart();
    }
}
