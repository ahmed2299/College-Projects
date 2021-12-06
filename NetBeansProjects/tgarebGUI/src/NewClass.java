
import java.sql.DriverManager;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Hossam eldien moham
 */
public class NewClass {
    
    public static void main(String[] args) {
        NewJFrame f=new NewJFrame();
        f.setVisible(true);
        con=DriverManager.getConnection("root", "root","" );
    }
}
