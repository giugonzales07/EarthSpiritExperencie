using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBinGeneral : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){
        switch (collision.gameObject.tag)
        {
            case "bag_comercial":
                FindObjectOfType<GameManager>().score += -1;
                break;
            case "bag_recy":
                FindObjectOfType<GameManager>().score += -1;
                break;
            case "bag_general":
                FindObjectOfType<GameManager>().score += 2;
                break;
        }
        Destroy(collision.gameObject);
    }
}
