using UnityEngine;

public class EnemyLich : MonoBehaviour
{
    public int HP = 2500; // Publico para teste
    int ATK = 80;
    int DEF = 60;
    int VEL = 60;
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
