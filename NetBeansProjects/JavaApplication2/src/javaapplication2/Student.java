/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication2;

import java.util.*;
import javafx.scene.Camera;

class sportive{
    
    public static int x=10;
    /*public sportive(){
        
        x+=10;
    }*/
     void start(){
    System.out.println("sportive"+(x+20));
    
}
     void snap(){
      System.out.println("Start snap machine");
}
     void snap(int i){
      System.out.println("Start snap machine");
}
    
}

class squashPlayer extends sportive{
    
    
     void start(){
    System.out.println("squash"+(x+20));
    
}
    
      void snap(){
    System.out.println("photo taken ");
}
}
class swimPlayer extends sportive{
    
    
     void start(){
    System.out.println("swim"+(x+20));
    
}
    
      void snap(){
    System.out.println("photo ,,,,,,,,,,,,, ");
}
}
public class Student {
    
    public static void main(String[] args) {
        
       sportive s=new sportive();
       sportive s1=new sportive();
       sportive s2=new sportive();
       s2.x=50;
       System.out.println(squashPlayer.x); 
}
}