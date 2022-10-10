using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Objetivo : MonoBehaviour
{
    public int numDeEnemigos;
    public TextMeshProUGUI texto_Objetivo;
    
    // Start is called before the first frame update
    void Start()
    {
        numDeEnemigos = GameObject.FindGameObjectsWithTag("Enemy").Length;
        texto_Objetivo.text = "Acaba con los enemigos en la base" + "\n Restantes: " + numDeEnemigos;
    }

    // Update is called once per frame
    void Update()
    {
        if (numDeEnemigos <= 0)
        {
            texto_Objetivo.text = "Completaste la misión";
        }
    }
}
