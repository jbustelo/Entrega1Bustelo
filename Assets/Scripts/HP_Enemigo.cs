using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_Enemigo : MonoBehaviour
{
    public Objetivo obj;
    public int vidaMax;
    public float vidaActual;
    public Image ImagenBarraVida;
    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        RevisarVida();
        if (vidaActual <= 0)
        {
            gameObject.SetActive(false);
            obj.numDeEnemigos--;
            obj.texto_Objetivo.text = "Acaba con los enemigos en la base" + "\n Restantes: " + obj.numDeEnemigos;
        }

        if (vidaActual > vidaMax)
        {
            vidaActual = vidaMax;
        }
    }

    public void RevisarVida()
    {
        ImagenBarraVida.fillAmount = vidaActual / vidaMax;
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("ArmaPlayer"))
        {
            vidaActual = vidaActual - 3;
        }
    }
}
