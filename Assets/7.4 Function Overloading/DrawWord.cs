using UnityEngine;
using System.Collections;

public class DrawWord : MonoBehaviour 
{
    // Update is called once per frame
    void Update()
    {
	Vector3 position = Vector3.zero;
		drawWord("Word are begin draw",2f,position,Color.blue);
    }
	 
    public static void drawWord(string word , float iscale, Vector3 position ,Color icolor)
    {
      // convert to uppercase first
		string uletters = word.ToUpper();
		char[] letters = uletters.ToCharArray();

		if (letters.Length > 0)
        {
			for (int i = 0; i < letters.Length; i++)
            {
                float offset = i * iscale;
				Vector3 offsetPositon = new Vector3(offset + position.x,  position.y,position.z);

				Debug.Log(letters[i]);
				drawWord(letters[i], iscale, offsetPositon, icolor);
            }
 
        }
    }
	public static void drawWord(char c, float iscale, Vector3 position, Color icolor)
    {
		Vector3[] lines = Letters.ToVecotorArray(c);

		for (int i = 1; i < lines.Length; i++)
        {
			Vector3 start = (lines[i - 1] * iscale);
			Vector3 end = (lines[i] * iscale);
            Debug.DrawLine(start + position, end + position, icolor);
        }
    }
}


public class Letters
{
	public static Vector3[] A = new[]
    {
        new Vector3(-1,-1,0),
        new Vector3(-1,0,0),
        new Vector3(0,1,0),
        new Vector3(1,0,0),
        new Vector3(-1,0,0),
        new Vector3(1,0,0),
        new Vector3(-1,-1,0)
        
    };
    public static Vector3[] B = new[]
    {
        new Vector3(-1,-1,0),
        new Vector3(-1,1,0),
        new Vector3(0,1,0),
        new Vector3(1,0,0),
        new Vector3(-1,0,0),
        new Vector3(1,-1,0),
        new Vector3(-1,-1,0)
        
    };

    public static Vector3[] ToVecotorArray(char c)
    {
		Vector3[] letter = new[] {Vector3.zero};
		switch(c)
        {
            case 'A':
			return letter = A;
              //  break;
            case 'B':
			return letter = B;
             //   break;
		default:
			return letter;
//			break;
        }


    }
}
