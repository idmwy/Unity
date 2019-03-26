# Unity

Texture Saving 
---------------------

If reading pixel data from material.mainTexture returns grey color, that means it cannot get color information from a texture like that. the texture is stored in GPU side. and all SetPixels() EncodeToPng() is in CPU side.
It seems not to be possible to directly convert from Texture to Texture2D. You can solve the problem by first converting the Texture into RenderTexture using Graphics.Blit() and then save it as Texture2D.

Note: render the texture on a RenderTexture and then use Texture2D.ReadPixels() to read it to a Texture2D (this step is quite slow).



RenderCamera
-----------------
This is a script for the capture the screen content. (You may need to add this code to the camera object in Unity. 


PPM saving
----------------
This is a script function to save the RGB color to .ppm file format. (Android device)


