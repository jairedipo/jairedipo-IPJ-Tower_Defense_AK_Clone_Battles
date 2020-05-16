using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
    public int HP = 10000;
    public bool destruiu = false;

    void Start()
    {
        
    }

    public void receberDano(int dano)
    {
        HP -= dano;
        if (HP <= 0)
        {
            destruiu = true;
        }
    }
}
