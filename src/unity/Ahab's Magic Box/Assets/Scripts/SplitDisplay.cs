using UnityEngine;
using System.Collections;

public class SplitDisplay : MonoBehaviour {

	private const float CAM_Y = 1.0f;
	private const float CAM_Z_INC = 30.0f;
	private const float CAM_CLIP_OVERLAP = 10.0f;

	public RenderTexture camTexture1;
	public RenderTexture camTexture2;
	public RenderTexture camTexture3;
	public Camera cam1;
	public Camera cam2;
	public Camera cam3;

	// Use this for initialization
	void Start () {
		cam1.transform.position = new Vector3(0, CAM_Y, 0);
		cam2.transform.position = new Vector3(0, CAM_Y, CAM_Z_INC);
		cam3.transform.position = new Vector3(0, CAM_Y, CAM_Z_INC * 2);
		cam1.farClipPlane = CAM_Z_INC + CAM_CLIP_OVERLAP;
		cam2.farClipPlane = CAM_Z_INC + CAM_CLIP_OVERLAP;
		cam3.farClipPlane = CAM_Z_INC + CAM_CLIP_OVERLAP;
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
