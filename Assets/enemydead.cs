using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydead : MonoBehaviour
{
    public int health = 3;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cart"))
        {
            health--;
            if (health <= 0)
            {
                //Destroy(gameObject);
                anim.SetBool("isDeath", true);
            }

        }
    }

}