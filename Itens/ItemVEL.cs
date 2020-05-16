using UnityEngine;

public class ItemVEL : MonoBehaviour
{
    int vel;
    int VELOriginal;
    ControlPlayer player;
    ControlEnemy inimigo;

    private void Start()
    {
        vel = getVEL();
    }

    int getVEL()
    {
        int rand = Random.Range(1, 100);

        if (rand <= 60)
            return 10;
        if (rand <= 90)
            return 12;

        return 15;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.transform.GetComponent<ControlPlayer>();
            aplicarItem(player);

            ParticleSystem[] part = other.gameObject.GetComponentsInChildren<ParticleSystem>();
            part[3].Play();

            Destroy(gameObject, 15.0f);
        }
        if (other.gameObject.CompareTag("Inimigo"))
        {
            inimigo = other.transform.GetComponent<ControlEnemy>();
            aplicarItem(inimigo);

            ParticleSystem[] part = other.gameObject.GetComponentsInChildren<ParticleSystem>();
            part[3].Play();

            Destroy(gameObject, 15.0f);
        }
    }


    #region Apilicar Efeito

    void aplicarItem(ControlPlayer personagem)
    {
        VELOriginal = personagem.VEL;
        personagem.velocidadeMov = 0.0005f * (VELOriginal + vel);
        personagem.velocidadeAtk = 2500 / (VELOriginal + vel);
        gameObject.SetActive(false);
    }

    void aplicarItem(ControlEnemy personagem)
    {
        VELOriginal = personagem.VEL;
        personagem.velocidadeMov = 0.0005f * (VELOriginal + vel);
        personagem.velocidadeAtk = 2500 / (VELOriginal + vel);
        gameObject.SetActive(false);
    }

    #endregion


    #region Remover Efeito

    private void OnDestroy()
    {
        if (player != null)
            desfazerItem(player);
        if (inimigo != null)
            desfazerItem(inimigo);
    }

    void desfazerItem(ControlPlayer personagem)
    {
        personagem.velocidadeMov = 0.0005f * VELOriginal;
        personagem.velocidadeAtk = 2500 / VELOriginal;
        gameObject.SetActive(false);
    }

    void desfazerItem(ControlEnemy personagem)
    {
        personagem.velocidadeMov = 0.0005f * VELOriginal;
        personagem.velocidadeAtk = 2500 / VELOriginal;
        gameObject.SetActive(false);
    }

    #endregion Remover Efeito
}
