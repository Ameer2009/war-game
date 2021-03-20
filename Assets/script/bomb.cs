using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
public ParticleSystem explosion;
    


    void Start()
    {
        
    }

    void Update()
    {
        
    }

private void OnCollisionEnter(Collision collision) {
ParticleSystem new_explosion = Instantiate(explosion);
new_explosion.transform.position = transform.position;
new_explosion.Play();
}

}
