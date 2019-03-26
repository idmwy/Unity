private String filenameLocal;
private int lRed, lGreen, lBlue;
private String strLocal;



bytesLocal = frame.Buffer;
Debug.Log("Local copy length " + bytesLocal.Length);
indexLocal = 0;

filenameLocal = Application.persistentDataPath + "/../AndroidLocal.ppm";

if (File.Exists(filenameLocal))
    File.Delete(filenameLocal);

using (StreamWriter file = new StreamWriter(filenameLocal,true))
{
	file.WriteLine("P3\r\n320 480\r\n255\n");
  for (int y = 0 ; y < 480 ; y++)
  {
		for(int x = 0; x < 320; x++)
    {
    	lRed = bytesLocal[indexLocal * 4];
      lGreen = bytesLocal[indexLocal * 4 + 1];
      lBlue = bytesLocal[indexLocal * 4 + 2];

      strLocal = " " + lRed + " " + lGreen + " " + lBlue + " ";
      file.Write(strLocal);
      indexLocal++;
     }
     file.WriteLine();
  }
  file.Close();
}
