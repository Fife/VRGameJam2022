using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scissor_trigger : MonoBehaviour
{
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (!flag)
        {

            GameObject obj = GameObject.Find("/scissor blades/Blade");

            Animation anim = obj.GetComponent<Animation>();
            Behaviour bhvr = (Behaviour)anim;

            bhvr.enabled = true;

            anim.Play("scissor");

            obj = GameObject.Find("/Bowling ball/Sphere");
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.None;
            rb.mass = 5;
            flag = true;


            obj = GameObject.Find("/hammer");

            anim = obj.GetComponent<Animation>();
            anim.Play("hammer");


            obj = GameObject.Find("/Spring");

            anim = obj.GetComponent<Animation>();
            anim.Play("spring");

        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
