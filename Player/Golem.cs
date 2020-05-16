using UnityEngine;

public class Golem : MonoBehaviour
{
    public int HP = 2250; // Publico para teste
    int ATK = 90;
    int DEF = 100;
    int VEL = 50;
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

    // Habilidade Imutável: Não é afetado por alteração de status.
    private void Update()
    {
        player.ATK = ATK;
        player.DEFBonus = 1.0f;
        player.velocidadeMov = 0.0005f * VEL;
        player.velocidadeAtk = 2500 / VEL;
    }
}
