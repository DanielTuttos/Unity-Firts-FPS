using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player")){
            Destroy(gameObject);
        }
    }

}
