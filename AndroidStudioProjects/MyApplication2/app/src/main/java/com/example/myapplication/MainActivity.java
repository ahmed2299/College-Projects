package com.example.myapplication;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.GridView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        String[] myArr=getResources().getStringArray(R.array.grid);

        ArrayAdapter<String>adapter=new ArrayAdapter<String>(this,android.R.layout.simple_list_item_1,myArr);

        GridView myGrid=(GridView)findViewById(R.id.grid_letters);
        myGrid.setAdapter(adapter);

        myGrid.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                TextView view1=(TextView) view;
                String value=view1.getText().toString();

                if(Character.isLowerCase(value.charAt(0))){
                    view1.setText(value.toUpperCase());
                }

                else if(Character.isUpperCase(value.charAt(0))){
                    view1.setText(value.toLowerCase());
                }
            }
        });


    }

}
