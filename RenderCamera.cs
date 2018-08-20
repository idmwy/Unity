using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using WaveVR_Log;

public class SL_RenderCamera : MonoBehaviour {
    private const string LOG_TAG = "WaveVR_HelloVR";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Controller.isTriggered)
        {
            CamCapture();
        }
		
	}

    void CamCapture()
    {
        Camera Cam = GetComponent<Camera>();

        RenderTexture currentRT = RenderTexture.active;
        RenderTexture.active = Cam.targetTexture;

        Cam.Render();

        Texture2D Image = new Texture2D(Cam.targetTexture.width, Cam.targetTexture.height);
        Image.ReadPixels(new Rect(0, 0, Cam.targetTexture.width, Cam.targetTexture.height), 0, 0);
        Image.Apply();
        RenderTexture.active = currentRT;

        var bytes = Image.EncodeToPNG();
        Destroy(Image);

        File.WriteAllBytes(Application.persistentDataPath + "/../LeftEye.png", bytes);
        Log.d(LOG_TAG, "11111Trigger " + Application.persistentDataPath);

    }
}

