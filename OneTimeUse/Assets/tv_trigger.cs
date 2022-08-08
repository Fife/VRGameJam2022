using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class tv_trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        //check if the collider is tagged as "Player" this time.
        if (other.tag == "Sockets")
        {
            GameObject obj = GameObject.Find("/Solution Sockets/VHS");
            XRSocketInteractor socket = obj.GetComponent<XRSocketInteractor>();

            IXRSelectInteractable inserted_obj = socket.GetOldestInteractableSelected();
            if (inserted_obj.transform.name == "VHS_low")
            {
                obj = GameObject.Find("/Environment/Interactable/VCRTVCombo/StylizedFire/RedFire");
                ParticleSystem ps = obj.GetComponent<ParticleSystem>();
                ps.Play();


                obj = GameObject.Find("/Environment/Interactable/VCRTVCombo/StylizedFire/OrangeFire");
                ps = obj.GetComponent<ParticleSystem>();
                ps.Play();

                obj = GameObject.Find("/Environment/Interactable/VCRTVCombo/StylizedFire/YellowFire");
                ps = obj.GetComponent<ParticleSystem>();
                ps.Play();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
