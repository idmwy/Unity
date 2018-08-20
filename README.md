# Unity

Texture Saving 
---------------------

If reading pixel data from material.mainTexture returns grey color, and it seems not to be possible to directly convert from Texture to Texture2D. You can solve the problem by first converting the Texture into RenderTexture using Graphics.Blit() and then save it as Texture2D.
