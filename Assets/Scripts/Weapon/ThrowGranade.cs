using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGranade : MonoBehaviour
{
    public float throwForce = 500;
    public GameObject granadePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Throw();
        }
    }

    public void Throw()
    {
        GameObject newGranade = Instantiate(granadePrefab, transform.position, transform.rotation);
        newGranade.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce);
    }
}
