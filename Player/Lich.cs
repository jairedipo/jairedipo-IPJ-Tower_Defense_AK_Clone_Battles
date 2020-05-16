using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lich : MonoBehaviour
{
    public int HP = 2500; // Publico para teste
    int ATK = 80;
    int DEF = 60;
    int VEL = 60;
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

