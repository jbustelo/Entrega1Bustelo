using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaObjeto : MonoBehaviour
{
    public bool destruirConCursor;
    public bool destruirAutomatico;
    public PlayerMovement logicaPlayer;
    public LogicaBarraHP Playerhealth;
    public int tipo;
    //1 = Aumenta vida
    //2 = Crece
    
    // Start is called before the first frame update
    void Start()
    {
        logicaPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        Playerhealth = GameObject.FindGameObjectWithTag("Player").GetComponent<LogicaBarraHP>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Efecto()
    {
        switch (tipo)
        {
            case 1:
            Playerhealth.vidaActual += 5;
            break;
            case 2:
            logicaPlayer.gameObject.transform.localScale = new Vector3(1, 1, 1);
            break;

            default:
            Debug.Log("sin efecto");
            break;
        }
    }
}
