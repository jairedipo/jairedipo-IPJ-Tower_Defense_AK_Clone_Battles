using UnityEngine;

public class Dog : MonoBehaviour
{
    public int HP = 2000; // Publico para teste
    int ATK = 40;
    int DEF = 40;
    int VEL = 100;
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
