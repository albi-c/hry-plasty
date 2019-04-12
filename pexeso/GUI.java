package cz.woodrixel.pexesogui;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class GUI extends Frame {
	
	Frame f=new Frame();  
	
	public GUI() {
		Button b = new Button("Exit");  
		b.setBounds(432,680,80,30);
		b.addActionListener(new ActionListener(){  
		    public void actionPerformed(ActionEvent e){  
		            System.exit(0); 
		    }  
		});  
		f.add(b);
		f.setSize(1024,720);
		f.setLayout(null);
		f.setVisible(true);
	}
	public static void main(String args[]){  
		GUI window = new GUI();  
	}
}
