using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popper_trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        GameObject obj = GameObject.Find("/Party popper");
        obj.GetComponent<PartyPopper>().Launch();

        ParticleSystem ps = obj.transform.GetChild(4).GetComponent<ParticleSystem>();
        ps.Play();
        ps = obj.transform.GetChild(5).GetComponent<ParticleSystem>();
        ps.Play();
        ps = obj.transform.GetChild(6).GetComponent<ParticleSystem>();
        ps.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
