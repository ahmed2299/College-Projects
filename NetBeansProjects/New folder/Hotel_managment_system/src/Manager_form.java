/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Hossam eldien moham
 */
import java.util.*;
import javafx.util.*;



public class Manager_form extends javax.swing.JFrame {

    /**
     * Creates new form Manager_form
     */
    public Manager_form() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        txt_addEmployee = new javax.swing.JButton();
        txt_deleteEmploye = new javax.swing.JButton();
        txt_editEmployeeData = new javax.swing.JButton();
        txt_viewEmployeeData = new javax.swing.JButton();
        txt_viewResidentsData = new javax.swing.JButton();
        jButton6 = new javax.swing.JButton();
        btn_back = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());
        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(5, 12, -1, -1));
        getContentPane().add(jPanel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 12, -1, -1));

        txt_addEmployee.setText("Add employee");
        txt_addEmployee.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txt_addEmployeeActionPerformed(evt);
            }
        });
        getContentPane().add(txt_addEmployee, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 80, -1, -1));

        txt_deleteEmploye.setText("Delete emp");
        txt_deleteEmploye.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txt_deleteEmployeActionPerformed(evt);
            }
        });
        getContentPane().add(txt_deleteEmploye, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 130, -1, -1));

        txt_editEmployeeData.setText("Edit employee data");
        txt_editEmployeeData.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txt_editEmployeeDataActionPerformed(evt);
            }
        });
        getContentPane().add(txt_editEmployeeData, new org.netbeans.lib.awtextra.AbsoluteConstraints(330, 80, -1, -1));

        txt_viewEmployeeData.setText("View employee data");
        txt_viewEmployeeData.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txt_viewEmployeeDataActionPerformed(evt);
            }
        });
        getContentPane().add(txt_viewEmployeeData, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 130, -1, -1));

        txt_viewResidentsData.setText("View residents data");
        txt_viewResidentsData.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txt_viewResidentsDataActionPerformed(evt);
            }
        });
        getContentPane().add(txt_viewResidentsData, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 80, -1, -1));

        jButton6.setText("Get income money");
        getContentPane().add(jButton6, new org.netbeans.lib.awtextra.AbsoluteConstraints(340, 130, -1, -1));

        btn_back.setText("Back");
        btn_back.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_backActionPerformed(evt);
            }
        });
        getContentPane().add(btn_back, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 380, -1, -1));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    ArrayList<Manager>man=new ArrayList<>();
    
    
    
    private void txt_addEmployeeActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txt_addEmployeeActionPerformed
        // TODO add your handling code here:
        add_employee add=new add_employee();
        add.show();
        dispose();
        
    }//GEN-LAST:event_txt_addEmployeeActionPerformed

    private void txt_editEmployeeDataActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txt_editEmployeeDataActionPerformed
        // TODO add your handling code here:
        edit_employees_data edit=new edit_employees_data();
        edit.show();
        dispose();
    }//GEN-LAST:event_txt_editEmployeeDataActionPerformed

    private void txt_deleteEmployeActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txt_deleteEmployeActionPerformed
        // TODO add your handling code here:
        delete_employee delete=new delete_employee();
        delete.show();
        dispose();
    }//GEN-LAST:event_txt_deleteEmployeActionPerformed

    private void txt_viewResidentsDataActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txt_viewResidentsDataActionPerformed
        // TODO add your handling code here:
        view_resident_data view=new view_resident_data();
        view.show();
        dispose();
    }//GEN-LAST:event_txt_viewResidentsDataActionPerformed

    private void txt_viewEmployeeDataActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txt_viewEmployeeDataActionPerformed
        // TODO add your handling code here:
        view_employee_data view=new view_employee_data();
        view.show();
        dispose();
    }//GEN-LAST:event_txt_viewEmployeeDataActionPerformed

    private void btn_backActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_backActionPerformed
        // TODO add your handling code here:
        manager_login man=new manager_login();
        man.show();
        dispose();
    }//GEN-LAST:event_btn_backActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Manager_form.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Manager_form.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Manager_form.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Manager_form.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Manager_form().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btn_back;
    private javax.swing.JButton jButton6;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JButton txt_addEmployee;
    private javax.swing.JButton txt_deleteEmploye;
    private javax.swing.JButton txt_editEmployeeData;
    private javax.swing.JButton txt_viewEmployeeData;
    private javax.swing.JButton txt_viewResidentsData;
    // End of variables declaration//GEN-END:variables
}
