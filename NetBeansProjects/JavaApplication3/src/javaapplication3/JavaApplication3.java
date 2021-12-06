/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication3;

/**
 *
 * @author Hossam eldien moham
 */
import java.util.*;
public class JavaApplication3 {

    public abstract class Animal{
         String species;
         int count;
         int [] ages;

        public Animal(String species, int count ) {
            this.species = species;
            this.count = count;
            ages=new int[count];
        }
        public void set_ages(){
            Scanner in=new Scanner(System.in);
            System.out.print("Enter the number of animals you want there age : ");
            count=in.nextInt();
            for(int i=0;i<count;i++){
                System.out.print("the "+(i+1)+" animal : ");
                int age=in.nextInt();
                ages[i]=age;
            }
            
        }
        public abstract void display_animal();
            
        
    }
    public static class Cage{
        private Animal animal;
        private static int cage_count;
        
        public Cage(Animal animal){
            this.animal=animal;
        }
        
        public  void display_cage_info (){
            Scanner in=new Scanner(System.in);
            System.out.print("The species are : "+animal.species);
            
            for(int i=0;i<animal.count;i++){
                System.out.println("the "+(i+1)+" animal : "+animal.ages[i]);
                
            }
            
        }
        public void display_no_of_cages(){
            
            System.out.println("The number of cages are "+cage_count);
            
        }
        
    }
    
     static class Lion extends Animal{
        String colour;
        public Lion(String species,int count,String colour){
            super(species,count);
            this.colour=colour;
            
        }
        public void display_animal(){
            System.out.print(species+count+colour);
            
        }
        
    }
    static class Elephant extends Animal{
        private float weight;
        public Elephant(String species,int count,float weight){
            super(species,count);
            this.weight=weight;
    }
        public void display_animal(){
            System.out.print(species+count+weight);
        }
        
    }
    public static void main(String[] args) {
         Scanner in=new Scanner(System.in);
        Animal a1=new Lion("cat species", 4, "Brown");
        Animal a2=new Elephant("Elephants", 3, 6000f);
        Animal a3=new Elephant(null, 2, 2700f);
        Cage c1=new Cage(a1);
        Cage c2=new Cage(a2);
        Cage c3=new Cage(a3);
        c1.display_no_of_cages();
        c2.display_no_of_cages();
        c3.display_no_of_cages();
        
        c1.display_cage_info();
        c2.display_cage_info();
        c3.display_cage_info();
        /*
        private String species;
        private int count;
        private  int [] ages;
        */
        
    }
    
}
