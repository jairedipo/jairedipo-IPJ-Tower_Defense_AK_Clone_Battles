using UnityEngine;

public class EnemyGolem : MonoBehaviour
{
    public int HP = 2250; // Publico para teste
    int ATK = 90;
    int DEF = 100;
    int VEL = 50;
    float raioAtaqueTorre = 4.0f;
    float raioAtaqueInimigo = 4.0f;

    public Animator anim;
    ControlEnemy enemy;

    void Start()
    {
        anim = GetComponent<Animator>();
        enemy = GetComponent<ControlEnemy>();
        
        enemy.HP = HP;
        enemy.HPMax = HP;
        enemy.ATK = ATK;
        enemy.DEF = DEF;
        enemy.VEL = VEL;
        enemy.raioTorre = raioAtaqueTorre;
        enemy.raioAtaque = raioAtaqueInimigo;
        enemy.velocidadeMov = 0.0005f * VEL;
        enemy.velocidadeAtk = 2500 / VEL;
    }

    // Habilidade Imutável: Não é afetado por alteração de status.
    private void Update()
    {
        enemy.ATK = ATK;
        enemy.DEFBonus = 1.0f;
        enemy.velocidadeMov = 0.0005f * VEL;
        enemy.velocidadeAtk = 2500 / VEL;
    }
}
