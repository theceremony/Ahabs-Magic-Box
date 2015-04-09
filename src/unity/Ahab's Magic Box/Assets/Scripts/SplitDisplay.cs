using UnityEngine;
using System.Collections;

public class SplitDisplay : MonoBehaviour {

	public RenderTexture camTexture1;
	public RenderTexture camTexture2;
	public RenderTexture camTexture3;
	public Camera cam1;
	public Camera cam2;
	public Camera cam3;

	// Use this for initialization
	void Start () {
		Debug.Log ("start");
		cam1.transform.position.Set (0, 0, 0);
		cam2.transform.position.Set (0, 0, -300);
		cam3.transform.position.Set (0, 0, -600);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		GUI.DrawTexture(new Rect(0, 0, 256, 256), camTexture1, ScaleMode.StretchToFill, true, 0);
		GUI.DrawTexture(new Rect(256, 0, 256, 256), camTexture2, ScaleMode.StretchToFill, true, 0);
		GUI.DrawTexture(new Rect(512, 0, 256, 256), camTexture3, ScaleMode.StretchToFill, true, 0);
	}
}
