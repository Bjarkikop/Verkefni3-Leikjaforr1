using UnityEngine;

public class Target : MonoBehaviour
{
    //bý til health fyrir box og kalla á cracked crate
    public float health = 50f;
    public GameObject destroyedVersion;

    public void TakeDamage(float amount)
    {
        //box tekur damage og kallar á die fallið ef það fer lægra em 0
        health -= amount;
        if(health <= 0f)
        {
            Die();
        }
    }
    //Fallið replace-ar crate med cracked crate og eyðir crate
    void Die()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
