using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{

    public float delay = 3f;
    float countDown;

    public float radius = 5;
    public float explosionForce = 70;

    bool exploded = false;

    public GameObject explosionEffect;


    // Start is called before the first frame update
    void Start()
    {
        countDown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0 && !exploded)
        {
            Explode();
            exploded = true;
        }
    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (var rangeObjects in colliders)
        {
            Rigidbody rb = rangeObjects.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce * 10, transform.position, radius);
            }
        }
        Destroy(gameObject);
    }
}
