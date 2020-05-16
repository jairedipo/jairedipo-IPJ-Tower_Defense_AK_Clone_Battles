using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shurtle : MonoBehaviour
{
    public int HP = 1750; // Publico para teste
    int ATK = 30;
    int DEF = 90;
    int VEL = 30;
    float raioAtaqueTorre = 4.0f;
    float raioAtaqueInimigo = 4.0f;

    public Animator anim;
    ControlPlayer player;


    void Start()
    {
        anim = GetComponent<Animator>();
        player = GetComponent<ControlPlayer>();

        player.HP = HP;
        player.HPMax = HP;
        player.ATK = ATK;
        player.DEF = DEF;
        player.VEL = VEL;
        player.raioTorre = raioAtaqueTorre;
        player.raioAtaque = raioAtaqueInimigo;
        player.velocidadeMov = 0.0005f * VEL;
        player.velocidadeAtk = 2500 / VEL;
    }

    void Update()
    {

    }
}

