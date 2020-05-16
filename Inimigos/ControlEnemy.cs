using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemy : MonoBehaviour
{
    public int HP;
    public int HPMax;
    public int ATK;
    public int DEF;
    public float DEFBonus;
    public int VEL;
    public int velocidadeAtk;
    public float raioAtaque;
    public float raioTorre;
    public float velocidadeMov;
    public bool morreu = false;

    int estabilidadeTempo = 0;

    public Animator anim;
    public Rigidbody cr;
    public GameObject torreInimiga;

    void Start()
    {
        anim = GetComponent<Animator>();
        cr = GetComponent<Rigidbody>();
        torreInimiga = GameObject.FindGameObjectWithTag("Torre");
        DEFBonus = 1.0f;
    }

    void Update()
    {
        if (!morreu)
        {
            float distanciaTorre = Vector3.Distance(torreInimiga.transform.position, transform.position);

            // Atacando a torre
            if (distanciaTorre < raioTorre)
            {
                anim.SetBool("Atacar", true);
                Torre torre = torreInimiga.GetComponent<Torre>();
                Atacar(torre, ATK, VEL);

            }
            else
            {
                // Atacar inimigo próximo
                GameObject atacarInimigo = inimigoProximo();

                float distancia = raioAtaque;

                if (atacarInimigo != null)
                {
                    distancia = Vector3.Distance(atacarInimigo.transform.position, transform.position);
                }

                if (distancia < raioAtaque)
                {
                    anim.SetBool("Atacar", true);
                    ControlPlayer inimigo = atacarInimigo.GetComponent<ControlPlayer>();
                    Atacar(inimigo, ATK, VEL);
                }

                // Mover até o inimigo próximo

                if (atacarInimigo != null && distancia > raioAtaque)
                {
                    anim.SetBool("Atacar", false);
                    anim.SetBool("Mover", true);
                    transform.position = transform.position + velocidadeMov * (atacarInimigo.transform.position - transform.position).normalized;
                    transform.forward = (atacarInimigo.transform.position - transform.position).normalized;
                }


                // Mover para a torre caso não tenha inimigo próximo
                if (atacarInimigo == null)
                {
                    anim.SetBool("Atacar", false);
                    anim.SetBool("Mover", true);
                    transform.position = transform.position + velocidadeMov * (torreInimiga.transform.position - transform.position).normalized;
                    transform.forward = (torreInimiga.transform.position - transform.position).normalized;
                }
            }
        }
        else
        {
            anim.SetBool("Morrer", true);
            tag = "Untagged";
            Destroy(gameObject, 5.0f);
        }
    }

    GameObject inimigoProximo()
    {
        int alvo = -1;
        float distancia;
        float raio = 6.0f;
        float menordistancia = raio;

        GameObject[] inimigos = GameObject.FindGameObjectsWithTag("Player");

        if (inimigos.Length == 0)
        {
            return null;
        }

        for (int i = 0; i < inimigos.Length; i++)
        {
            distancia = Vector3.Distance(inimigos[i].transform.position, transform.position);
            if (distancia < raio && distancia < menordistancia)
            {
                menordistancia = distancia;
                alvo = i;
            }
        }

        if (alvo == -1)
        {
            return null;
        }

        return inimigos[alvo];
    }

    void Atacar(ControlPlayer inimigo, int ATK, int VEL)
    {
        if (Time.frameCount % velocidadeAtk == 0 && Time.frameCount != estabilidadeTempo)
            inimigo.receberDano(4 * ATK);

        estabilidadeTempo = Time.frameCount;
    }

    void Atacar(Torre torre, int ATK, int VEL)
    {
        if (Time.frameCount % velocidadeAtk == 0 && Time.frameCount != estabilidadeTempo)
            torre.receberDano(4 * ATK);

        estabilidadeTempo = Time.frameCount;
    }

    public void receberDano(int dano)
    {
        HP = HP - (int)((dano - DEF) * DEFBonus);
        if (HP <= 0)
        {
            morreu = true;
        }
    }
}

