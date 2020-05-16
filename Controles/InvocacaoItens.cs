using UnityEngine;

public class InvocacaoItens : MonoBehaviour
{
    public GameObject[] itens;
    public int intervalo = 500;
    int tempoAtual;
    bool novoItem = false;

    Quaternion rot = new Quaternion(0, 0, 0, 0);

    void Update()
    {
        if (!novoItem)
        {
            int rand = Random.Range(-100, 100);
            intervalo += rand;
            novoItem = true;
            tempoAtual = Time.frameCount + intervalo;
        }

        if (novoItem && tempoAtual == Time.frameCount)
        {
            int rand = Random.Range(0, itens.Length);
            Instantiate(itens[rand], getPosition(), rot);
            novoItem = false;
            intervalo = 500;
        }
    }


    private Vector3 getPosition()
    {
        float posx = Random.Range(-1.0f, 1.0f);
        float posz = Random.Range(-16.0f, -24.0f);

        return new Vector3(posx, 1.2f, posz);
    }
}
