using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour
{
    public float enemyMaxHealth;
    public float damageModifier;
    // public GameObject damageParticle;
    public bool drops;
    public GameObject drop;
    public AudioClip deathSound;    

    float currentHealth;

    public Slider enemyHeathIndicator;
    AudioSource enemyAS;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = enemyMaxHealth;
        enemyHeathIndicator.maxValue = enemyMaxHealth;
        enemyHeathIndicator.value= currentHealth;
        enemyAS = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addDamage(float damage){
        enemyHeathIndicator.gameObject.SetActive(true);
        damage = damage * damageModifier;
        if(damage <= 0) return;
        currentHealth -= damage;
        enemyHeathIndicator.value = currentHealth;
        enemyAS.Play();
        if(currentHealth <= 0){
            makeDead();
        }
    }

    // public void damageFX(Vector3 point, Vector3 rotation){
    //     Instantiate(damageParticle, point, Quaternion.Euler(rotation));
    // }


    void makeDead(){
        // turn off moviment and create ragdoll

        AudioSource.PlayClipAtPoint(deathSound, transform.position, 0.15f);

        Destroy(gameObject.transform.root.gameObject);
        if(drops) Instantiate(drop, transform.position, transform.rotation);
    }
}
