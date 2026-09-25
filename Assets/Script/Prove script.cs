using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Provescript : MonoBehaviour
{
    const int LIMITE_VIDA = 100;
    private float velocidadeJogador = 15.0f;
    private int pontosVida = 50;
    private int escudo = 20;
    private int energia = 40;
    private int xp = 120;
    private string nomePersonagem = "Guerreiro";
    private int nivel = 1;
    private bool estaVivo = true;
    private bool temPocao = true;
    private bool emCombate = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int danoRecebido = 30;
        if (escudo >= danoRecebido)
        {
            escudo -= danoRecebido;
        }
        else
        {
            danoRecebido -= escudo;
            escudo = 0;
            pontosVida -= danoRecebido;
        }


        if (energia < 50 && temPocao || emCombate)
        {
            energia += 30;
            temPocao = false;
        }
        else
        {
            energia += 5;
        }

        if (xp > 50)
        {
            nivel++;
            xp -= 50;
        }

        if (xp > 50)
        {

            nivel++;
            xp -= 50;
        }

        if (xp > 50)
        {
            nivel++;
            xp -= 50;
        }

        string estado = "parado";
        bool estaAtordoado = false;

        if (estaAtordoado == true)
        {
            velocidadeJogador = 0.0f;
            estado = "atortoado";
        }
        else if (velocidadeJogador > 10.0f)
        {
            estado = "correndo";
            velocidadeJogador += 5.0f;
        }
        else if (velocidadeJogador > 0.0f)
        {
            estado = "andando";
        }
        else
        {
            estado = "parado";
        }

        nomePersonagem = "Guerreiro";
        pontosVida = 40;
        escudo = 0;
        estaVivo = true;
        energia = 70;
        temPocao = false;
        nivel = 3;
        xp = 20;
        estado = "correndo";
        velocidadeJogador = 20.0f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
