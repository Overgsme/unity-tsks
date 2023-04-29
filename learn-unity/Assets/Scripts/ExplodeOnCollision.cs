using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ExplodeOnCollision : MonoBehaviour
{
    public List<GameObject> PushOnExplodeObjects;
    public float power = 1f;
    public ParticleSystem ParticleSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider coll)
    {
        Explode();
        Debug.Log("Bomb activated!");
    }

    private void Explode()
    {
        PushOnExplodeObjects.ForEach(e =>
        {
            Rigidbody rb = e.GetComponent<Rigidbody>();
            Vector3 dir = e.transform.position - transform.position;
            float distance = dir.magnitude;
            dir.Normalize();

            rb.velocity += dir*power/distance/rb.mass;
        });
        Instantiate(ParticleSystem, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
