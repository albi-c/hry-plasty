package cz.woodrixel.pexesogui;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

@SuppressWarnings("serial")
public class MainWindow extends Frame {
	
	Frame f=new Frame();
	Player p1;
	Player p2;
	
	public MainWindow() {
		f.setSize(1024,720);
		Button b = new Button("Hrát");  
		b.setBounds(f.getWidth()/2-40,680,80,30);
		b.addActionListener(new ActionListener(){  
		    public void actionPerformed(ActionEvent e){  
		            StartGame();
		    }  
		});  
		f.addWindowListener(new WindowAdapter() {
	        public void windowClosing(WindowEvent e) {
	            System.exit(0);
	        }
	    });
		f.add(b);
		f.setLayout(null);
		f.setVisible(true);
	}
	public static void StartGame()
	{
		
	}
	
	public static void main(String args[]){  
		@SuppressWarnings("unused")
		MainWindow window = new MainWindow();  
	}
}
