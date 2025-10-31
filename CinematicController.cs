using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CinematicController : MonoBehaviour
{
    public VideoPlayer videoPlayer;  // Referencia al VideoPlayer

    void Start()
    {
        // Especifica la ruta del video en la carpeta StreamingAssets
        string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, "cinematic.mp4");
        
        // Asigna la URL del video
        videoPlayer.url = videoPath;

        // Reproduce el video al inicio
        videoPlayer.Play();
    }
}

