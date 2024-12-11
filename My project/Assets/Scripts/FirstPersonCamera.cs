using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform playerBody;
    public Transform playerHead;

    float sensitivityX = 1.2f;
    float sensitivityY = 2f;

    float rotatioX = 0;
    float rotatioY = 0;

    float angleYmin = -90;
    float angleYMax = 90;

    float smoothRotx = 0;
    float smoothRoty = 0;

    float smoothCoefx = 0.005f;
    float smoothCoefy = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    private void LateUpdate(){
        transform.position = playerHead.position;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalDelta = Input.GetAxisRaw("Mouse Y") * sensitivityY;
        float horizontalDelta = Input.GetAxisRaw("Mouse X") * sensitivityX;

        smoothRotx = Mathf.Lerp(smoothRotx, horizontalDelta, smoothCoefx);
        smoothRoty = Mathf.Lerp(smoothRoty, verticalDelta, smoothCoefy);
        
        rotatioY += smoothRoty;
        rotatioX += smoothRotx;

        rotatioY = Mathf.Clamp(rotatioY, angleYmin, angleYMax);

        playerBody.eulerAngles = new Vector3(0, rotatioX, 0);

        transform.eulerAngles = new Vector3(-rotatioY, rotatioX, 0);
    }
}
