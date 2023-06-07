using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireinthehole : MonoBehaviour
{
    public Rigidbody cartouch;
    private AudioSource audios;
    public float force = 1000.0f;
    private ParticleSystem flash;


    // Start is called before the first frame update
    void Start()
    {
        audios = GetComponent<AudioSource>();
        flash= GetComponent<ParticleSystem>();
        audios.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody cartinst;
            cartinst = Instantiate(cartouch,transform.position,transform.rotation) as Rigidbody;
            cartinst.AddForce(transform.forward * force);
            audios.PlayOneShot(audios.clip);
            flash.Play();
        }
    }
}
