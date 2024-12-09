using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;

public class PlayerRotation : MonoBehaviour{
    public float RotationSpeed = 20.0f;
    public Transform playerBody; // Referência ao corpo do player

    // Update is called once per frame
    void Update(){
        if(KickStarter.playerInput){
            // Obter inputs usando o sistema do Adventure Creator
            float turn = KickStarter.playerInput.InputGetAxis("Turn");
            // Obter os ângulos atuais do transform em Euler
            Vector3 currentRotation = playerBody.eulerAngles;
            // Atualizar o ângulo de rotação no eixo Y (giro horizontal do player)
            currentRotation.y += turn * RotationSpeed * Time.deltaTime;
            // Aplicar os novos ângulos ao transform usando Euler
            playerBody.eulerAngles = currentRotation;
        }
    }
}
