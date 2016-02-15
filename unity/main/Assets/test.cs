using UnityEngine;
using System.Collections;
using Files2Textures;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var png = Convert.FromPDF(@"C:\Users\masaeedu\Desktop\course-override.pdf");
        var tex = new Texture2D(png.Width, png.Height);
        tex.LoadImage(png.Data);

        Debug.Log(png.Height);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
