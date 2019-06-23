using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitch : MonoBehaviour
{
    public int amoutReduce = 2;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<TankMovement>().m_Speed *= amoutReduce;
            other.gameObject.GetComponent<TankMovement>().m_TurnSpeed *= amoutReduce;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<TankMovement>().m_Speed /= amoutReduce;
            other.gameObject.GetComponent<TankMovement>().m_TurnSpeed /= amoutReduce;


        }
    }

}
