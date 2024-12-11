using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBinComercial : MonoBehaviour
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
                FindObjectOfType<GameManager>().WinPoints();
                //FindObjectOfType<GameManager>().score += 2;
                break;
            case "bag_recy":
                FindObjectOfType<GameManager>().LosePoints();
                break;
            case "bag_general":
                FindObjectOfType<GameManager>().LosePoints();
                break;
        }
        // Destruir o objeto de colisão após um quadro
        StartCoroutine(DestroyAfterFrame(collision.gameObject));
    }

    private IEnumerator DestroyAfterFrame(GameObject obj){
        yield return null; // Espera um quadro
        DestroyImmediate(obj);
    }
    
}
