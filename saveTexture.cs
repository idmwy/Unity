

        Texture mainTexture = meshrenderer.material.mainTexture;
        Texture2D texture2D = new Texture2D(mainTexture.width, mainTexture.height, TextureFormat.RGBA32, false);

        RenderTexture currentRT = RenderTexture.active;

        RenderTexture renderTexture = new RenderTexture(mainTexture.width, mainTexture.height, 32);
        Graphics.Blit(mainTexture, renderTexture);

        RenderTexture.active = renderTexture;
        texture2D.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        texture2D.Apply();

        //Color[] pixels = texture2D.GetPixels();

        RenderTexture.active = currentRT;

        //ball.GetComponent<MeshRenderer>().material.mainTexture = texture2D;

        var bytes = texture2D.EncodeToPNG();
  
        if (bytes != null && bytes.Length > 0)
        {
            File.WriteAllBytes(Application.persistentDataPath + "/../saved.png", bytes);
            Destroy(texture2D);  // if only for save file, it's better destory,otherwise no texture on the ball.
        }
         else
         {
             Debug.Log("Failure to save the PNG" );
         }
                
    
