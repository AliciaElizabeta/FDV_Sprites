using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackOnCollision : MonoBehaviour
{
    private Animator zombieAnimator;
    private Animator goblinAnimator;


    // Start is called before the first frame update
    void Start()
    {
        //zombieAnimator = GetComponent<Animator>();
        goblinAnimator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            zombieAnimator = collision.gameObject.GetComponent<Animator>();
            zombieAnimator.SetBool("Dead", true); // Iniciar la animación "Dead" del zombie
            goblinAnimator.SetBool("Collision", true); // Iniciar la animación "Attack" del goblin
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        goblinAnimator.SetBool("Collision", false); // Iniciar la animación "Attack" del goblin
    }

    /*void OnCollisionEnter(Collision collision)
    {
        myAnimator.SetBool("Collision", true);
        collision.GetComponent<Animator>().SetBool("Dead", true);
    }

    void OnCollisionExit(Collision collision)
    {
        myAnimator.SetBool("Collision", false);

    }*/
}
