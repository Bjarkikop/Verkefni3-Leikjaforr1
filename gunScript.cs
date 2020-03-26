using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    //geri float fyrir damage, range og impact og fps camera sem er main camera og muzzleflash fyrir byssu
    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;

    public Camera fpsCam;
    public ParticleSystem muzzleflash;
    void Update()
    {
        //ef það er ýtt á mouse button 1
        if (Input.GetButtonDown("Fire1")){
            //kallar fallið shoot
            Shoot();
        }
    }
    void Shoot()
    {
        //spilar muzzleflash
        muzzleflash.Play();
        //target
        RaycastHit hit;
        //ef það er hitt eitthvað target
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //læt nafn í console
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            //læt impact á object og damage
            if(target != null)
            {
                target.TakeDamage(damage);
                    
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
}
