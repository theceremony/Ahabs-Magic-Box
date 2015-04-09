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
		cam3.farClipPlane = CAM_Z_INC + CAM_CLIP_OVERLAP + 600;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		float thirdScreenHieght = Screen.height / 3;
		GUI.DrawTexture(new Rect(0, thirdScreenHieght *2, Screen.width, thirdScreenHieght), camTexture1, ScaleMode.ScaleAndCrop, true, 0);
		GUI.DrawTexture(new Rect(0, thirdScreenHieght, Screen.width, thirdScreenHieght), camTexture2, ScaleMode.ScaleAndCrop, true, 0);
		GUI.DrawTexture(new Rect(0, 0, Screen.width, thirdScreenHieght), camTexture3, ScaleMode.ScaleAndCrop, true, 0);
	}
}
