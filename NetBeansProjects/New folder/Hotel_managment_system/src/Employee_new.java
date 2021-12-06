/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author ahmed
 */
public class Employee_new {
     int id;
     String name;
     int salary;
     String job_title;

    public Employee_new(int id, String name, int salary, String job_title) {
        this.id = id;
        this.name = name;
        this.salary = salary;
        this.job_title = job_title;
    }

    public Employee_new(int id, String job_title) {
        this.id = id;
        this.job_title = job_title;
    }
     
     
}
