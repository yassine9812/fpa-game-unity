using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayacastscript : MonoBehaviour
{

    public GameObject door;
    Animation anim;
    public float raylength = 20;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;


        if (Physics.Raycast(ray, out hit, raylength))
        {
            if (hit.collider.gameObject.tag == ("door"))
            {
                door.GetComponent<Animation>().Play("opendoor");
            }


        }
    }
}