using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool conArma;
    public float SpeedMovement = 5.0f;
    public float SpeedRotacion = 200.0f;
    private Animator anim;
    public float x, y;
    public Rigidbody rb;
    public float fuerzadeJump = 8f;
    public bool canJump;
    public bool ImAttacking;
    public bool avanzoSolo;
    public float impulsoDeGolpe = 10f;
    // Start is called before the first frame update
    void Start()
    {
        canJump = false;
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (ImAttacking == false)
        {
            transform.Rotate(0, x * Time.deltaTime * SpeedRotacion, 0);
            transform.Translate(0, 0, y * Time.deltaTime * SpeedMovement);
        }


        if (avanzoSolo)
        {
            rb.velocity = transform.forward * impulsoDeGolpe;
        }
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        if (Input.GetMouseButtonDown(0) && canJump && !ImAttacking)
        {
            if (conArma)
            {
                anim.SetTrigger("Punch2");
                ImAttacking = true;
            }
            else
            {
                anim.SetTrigger("Punch");
                ImAttacking = true;
            }

        }

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (canJump)
        {
            if (ImAttacking == false)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    anim.SetBool("Jump", true);
                    rb.AddForce(new Vector3(0, fuerzadeJump, 0), ForceMode.Impulse);
                }
            }

            anim.SetBool("tocoFloor", true);
        }
        else
        {
            ImFalling();
        }
    }

    public void ImFalling()
    {
        anim.SetBool("tocoFloor", false);
        anim.SetBool("Jump", false);
    }

    public void StopPunching()
    {
        ImAttacking = false;

    }

    /*public void AvanzoSolo()
    {
        avanzoSolo = true;
    }

    public void DejoDeAvanzar()
    {
        avanzoSolo = false;
    }*/


}
