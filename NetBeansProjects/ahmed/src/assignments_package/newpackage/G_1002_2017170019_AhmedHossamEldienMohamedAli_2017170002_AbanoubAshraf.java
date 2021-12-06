/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package assignments_package.newpackage;
   import java.util.*;
 abstract class Person{
        
        protected String name;
        protected int age;
        
        public abstract void print(); 
        
    }
class Teacher extends Person{
        
        private int noOfCourses;
        private String [] course_name;
        private double salary;
        
        public Teacher(String name,int age,int noOfCourses){
            this.name=name;
            this.age=age;
            this.noOfCourses=noOfCourses;
        }
        
        public Teacher(String name,int age,int noOfCourses,double salary){
            this(name,age,noOfCourses);
            this.salary=salary;
        }
        
        @Override
        public void print(){
            System.out.println("The teacher's name : "+name);
            System.out.println("The teacher's age : "+age);
            System.out.println("The teacher's salary : "+salary);
            for(int i=0;i<noOfCourses;i++){
                System.out.print("The teacher's "+(i+1) +" courses : ");
                System.out.println(course_name[i]);
            }
            
        }        
        
        public void setCourse_name(String[] course_name) {
            this.course_name = course_name;
        }     
        
    }   
public class G_1002_2017170019_AhmedHossamEldienMohamedAli_2017170002_AbanoubAshraf {

    
    
    public static void main(String[] args) {
        Scanner in=new Scanner(System.in);
        
        System.out.print("Enter the name of teacher : ");
        String name=in.next();
        
        System.out.print("Enter the age of teacher : ");
        int age=in.nextInt();
        
        System.out.print("Enter the noOfCourses : ");
        int noOfCourses=in.nextInt();
        
        System.out.print("Enter the teacher's salary : ");
        double salary=in.nextDouble();
        
        Teacher t=new Teacher(name, age, noOfCourses,salary);
        
        String[] course_name=new String[noOfCourses];
        for(int i=0;i<noOfCourses;i++){
            System.out.print("Enter the "+(i+1)+" course : ");
            course_name[i]=in.next();
            //course_name[i]=course_name[i].toCharArray();
            t.setCourse_name(course_name);
        }
            
        
        Person p=new Teacher(name, age, noOfCourses, salary);
        t.print();
        
         /**/
    }
}