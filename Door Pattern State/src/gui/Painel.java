package gui;

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

import codigo.Door;

public class Painel extends JFrame implements Runnable, Observer {

    private Thread t = null;
    private JPanel jpmain;
    private PainelPorta jpi;
    private JButton jclick;
    private JButton jfim;
    private JButton jcompleto;
    private JLabel estado;
    private Door porta;

    public Painel() {
        super("UP - ES - Padrão State");
        setDefaultCloseOperation(DO_NOTHING_ON_CLOSE);
        WindowListener l = new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
                int res = saiOuNao();
                if (res == JOptionPane.YES_OPTION) { // confirmado ?
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
        jpi = new PainelPorta();
        jclick = getBotao("  Botão  ");
        jclick.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
            	porta.click();
            	if (t != null && t.isAlive()) {
            		t.interrupt();
            	}
            }
        });
        jcompleto = getBotao(" Completo ");
        jcompleto.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
            	porta.complete();
            }
        });
        jfim = getBotao("  Sair  ");
        jfim.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                int res = saiOuNao();
                if (res == JOptionPane.YES_OPTION) { // confirmado ?
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
        jpmain.add(jpi);
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
        
        porta = new Door();
        porta.addObserver(this);
    	estado.setText(porta.status());
    	jpi.setImagem(porta.getImagem());
    	jpi.repaint();
    }

    public void update( Observable obs, Object obj) {
    	Door porta = (Door)obs;
    	estado.setText(porta.status());
    	jpi.setImagem(porta.getImagem());
    	jpi.repaint();
    	if (porta.status().equals("DoorOpen")) {
    		t = new Thread(this);
    		t.start();
    	}
    }
    
    public void run() {
    	try {
    		Thread.sleep( 2000);
    	} catch (Exception ex) {
    	}
    	porta.timeout();
    }
    
    protected int saiOuNao() {
        return JOptionPane.showConfirmDialog(this,
                " Confirma o fim do programa ? ",
                " UP - ES - Padrão State ", JOptionPane.OK_CANCEL_OPTION,
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
