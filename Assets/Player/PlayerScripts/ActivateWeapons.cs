using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWeapons : MonoBehaviour
{
    public TakeWeapons tomarWeapons;
    public int numeroWeapon;
    // Start is called before the first frame update
    void Start()
    {
        tomarWeapons = GameObject.FindGameObjectWithTag("Player").GetComponent<TakeWeapons>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            tomarWeapons.ActivarArmar(numeroWeapon);
            Destroy(gameObject);
        }
    }
}
