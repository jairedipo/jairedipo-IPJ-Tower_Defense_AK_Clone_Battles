using UnityEngine;

public class EnemyGrunt : MonoBehaviour
{
    public int HP = 1000; // Publico para teste
    int ATK = 100;
    int DEF = 70;
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
}
