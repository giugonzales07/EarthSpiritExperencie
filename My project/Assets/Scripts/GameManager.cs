using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Texture DefaultCursor;
    private Texture m_CurrentCursor;
    private bool m_Navigating;
    public Color m_MouseOverColor = Color.green;
    private Color m_CurrentCursorColor;

    // Start is called before the first frame update
    void Start(){
        m_CurrentCursor = DefaultCursor;
        m_CurrentCursorColor = Color.white;
    }

    // Update is called once per frame
    void Update() {
        m_Navigating = Input.GetButton ("Horizontal") || Input.GetButton ("Vertical");
    }

    public void CursorColorChange (bool colorize) {
        m_CurrentCursorColor = colorize ? m_MouseOverColor : Color.white;
    }

    void OnGUI(){
        if(!m_Navigating){
            Cursor.lockState = CursorLockMode.None;
            var pos = Input.mousePosition;
            Color guiColor = GUI.color;
            GUI.color = m_CurrentCursorColor;
            GUI.DrawTexture(
                new Rect(pos.x, Screen.height - pos.y, 64f, 64f), m_CurrentCursor
            );
            GUI.color = guiColor;
        }
    }
}
