using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MovieController : MonoBehaviour
{

    [SerializeField]
    GameObject m_menuCanvas;

    [SerializeField]
    GameObject m_laserPointer;

    [SerializeField]
    VideoPlayer m_videoPlayer;

    private bool m_menuCanvasStatus;

    // Use this for initialization
    void Start()
    {
        m_menuCanvas.SetActive(false);
        m_laserPointer.SetActive(false);
        m_menuCanvasStatus = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.Back) && m_menuCanvasStatus == true)
        {
            m_videoPlayer.Play();
            m_menuCanvas.SetActive(false);
            m_laserPointer.SetActive(false);
            m_menuCanvasStatus = false;
        }
        else if (OVRInput.Get(OVRInput.RawButton.Back) && m_menuCanvasStatus == false)
        {
            m_videoPlayer.Pause();
            m_menuCanvas.SetActive(true);
            m_laserPointer.SetActive(true);
            m_menuCanvasStatus = true;
        }
    }
}
