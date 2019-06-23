using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class castle_code : destroiable
{
    public Mesh salem;
    public Mesh halfDestried;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<MeshFilter>().mesh = salem;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Healthset(float amount)
    {
        base.Healthset(amount);
        if (health <= 50)
        {
            this.GetComponent<MeshFilter>().mesh = halfDestried;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectile")
        {
            // health -= collision.gameObject.GetComponent<ShellExplosion>().m_MaxDamage/3;
            Healthset(other.GetComponent<ShellExplosion>().m_MaxDamage / 5);
        }
    }

}
