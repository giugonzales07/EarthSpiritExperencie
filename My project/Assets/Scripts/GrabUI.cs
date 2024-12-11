//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class GrabUI : MonoBehaviour
{
    [Tooltip("Sprite that will always be active")]
    public Sprite DefaultAim;  //normal state
    [Tooltip("Sprite that activates when it can pick up an object")]
    public Sprite passiveAim;  //normal state
    [Tooltip("Sprite that activates when holding an object")]
    public Sprite grabAim;  //grab state

    private Image img;
    private GrabObjects grabSys;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        img.sprite = null;
        grabSys = Camera.main.GetComponent<GrabObjects>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (grabSys.grabedObj != null)
            img.sprite = grabAim;
        else{
            if (grabSys.possibleGrab)
                img.sprite = passiveAim;
            else
                img.sprite = DefaultAim;
        }
    }
}
