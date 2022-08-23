using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeWeapons : MonoBehaviour
{
    public GameObject[] armas;
    public PlayerMovement logicaPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarArmar(int numero)
    {
        for(int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
        }

        armas[numero].SetActive(true);
        logicaPlayer.conArma = true;
    }
}
