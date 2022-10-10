using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoEnemy : MonoBehaviour
{
    public Animator ani;
    public Enemy enemigo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            ani.SetBool("walk", false);
            ani.SetBool("run", false);
            ani.SetBool("attack", true);
            enemigo.atacando = true;
            GetComponent<CapsuleCollider>().enabled = false;
        }
    }
}
