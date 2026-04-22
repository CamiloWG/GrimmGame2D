using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    public Transform player1;
    public Transform player2;

    private bool usandoPlayer1 = true;

    public void SwitchCamera()
    {
        usandoPlayer1 = !usandoPlayer1;

        vcam.Follow = usandoPlayer1 ? player1 : player2;
    }
}
