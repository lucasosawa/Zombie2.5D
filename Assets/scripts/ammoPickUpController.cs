using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoPickUpController : MonoBehaviour
{
    public AudioClip ammoPickUpSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            other.GetComponentInChildren<fireBullet>().reload();
            Destroy(transform.root.gameObject);
            AudioSource.PlayClipAtPoint(ammoPickUpSound, transform.position, 10f);
        }
    }
}
