package GUI;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;
import java.util.Observable;
import java.util.Observer;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

import Codigo.Maquina;

public class Painel extends JFrame implements Runnable, Observer {

    private Thread t = null;
    private JPanel jpmain;
    private JButton jclick;
    private JButton jfim;
    private JButton jcompleto;
    private JLabel estado;
    private Maquina maquina;

    public Painel() {
        super("Maquina de Café");
        setDefaultCloseOperation(DO_NOTHING_ON_CLOSE);
        WindowListener l = new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
                int res = saiOuNao();
                if (res == JOptionPane.YES_OPTION) {
                    System.exit(0);
                }
            }
        };

        addWindowListener(l);
        jpmain = new JPanel();
        add(jpmain);
        jpmain.setLayout(new GridLayout(0, 5));
        
        
        estado = new JLabel("estado");
        estado.setForeground(Color.black);
        jclick = getBotao("  Botão  ");
        jclick.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
            	maquina.click();
            	if (t != null && t.isAlive()) {
            		t.interrupt();
            	}
            }
        });
        jcompleto = getBotao(" Completo ");
        jcompleto.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
            	maquina.complete();
            }
        });
        jfim = getBotao("  Sair  ");
        jfim.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                int res = saiOuNao();
                if (res == JOptionPane.YES_OPTION) {
                    System.exit(0);
                }
            }
        });

        jpmain.add(new JPanel());
        jpmain.add(new JPanel());
        jpmain.add(new JPanel());
        jpmain.add(new JPanel());
        jpmain.add(new JPanel());

        jpmain.add(new JPanel());
        jpmain.add(new JPanel());
        jpmain.add(jclick);
        jpmain.add(new JPanel());

        jpmain.add(new JPanel());
        jpmain.add(estado);
        jpmain.add(new JPanel());
        jpmain.add(new JPanel());
        jpmain.add(new JPanel());

        jpmain.add(new JPanel());
        jpmain.add(jcompleto);
        jpmain.add(new JPanel());
        jpmain.add(jfim);
        jpmain.add(new JPanel());

        jpmain.add(new JPanel());
        jpmain.add(new JPanel());
        jpmain.add(new JPanel());
        jpmain.add(new JPanel());
        jpmain.add(new JPanel());
        
        maquina = new Maquina();
        maquina.addObserver(this);
    	estado.setText(maquina.status());
    }

    public void update( Observable obs, Object obj) {
    	Maquina maquina = (Maquina)obs;
    	estado.setText(maquina.status());
    	if (maquina.status().equals("MaquinaOpen")) {
    		t = new Thread(this);
    		t.start();
    	}
    }
    
    public void run() {
    	try {
    		Thread.sleep( 2000);
    	} catch (Exception ex) {
    	}
    	maquina.timeout();
    }
    
    protected int saiOuNao() {
        return JOptionPane.showConfirmDialog(this,
                " Sair? ",
                " Maquian de  Café ", JOptionPane.OK_CANCEL_OPTION,
                JOptionPane.WARNING_MESSAGE);
    }
    
    private JButton getBotao(String texto) {
    	JButton bot = new JButton( texto);
    	bot.setPreferredSize(new Dimension(120,40));
    	bot.setBackground(new Color(208,232,255));
    	return bot;
    }
    
    public static void main( String[] args) {
    	Painel p = new Painel();
        p.pack();
        p.setVisible(true);
    }
}