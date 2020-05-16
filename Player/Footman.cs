using UnityEngine;

public class Footman : MonoBehaviour
{
    public int HP = 1250; // Publico para teste
    int ATK = 100;
    int DEF = 80;
    int VEL = 70;
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
}

