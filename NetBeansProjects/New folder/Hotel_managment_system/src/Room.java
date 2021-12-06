
import java.util.ArrayList;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Hossam eldien moham
 */
public class Room {
    String type_room;
    int number_of_nights;
    String services;

   ArrayList<Room>room;

    public Room(String type_room, int number_of_nights, String services, ArrayList<Room> room) {
        this.type_room = type_room;
        this.number_of_nights = number_of_nights;
        this.services = services;
        this.room = room;
    }

    
    

    
    public void calculate(){
        
    }
    
}
