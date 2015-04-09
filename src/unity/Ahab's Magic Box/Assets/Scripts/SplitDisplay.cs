using UnityEngine;
using System.Collections;

public class SplitDisplay : MonoBehaviour {

	private const float CAM_Y = 1.0f;
	private const float CAM_Z_INC = 30.0f;
	private const float CAM_CLIP_OVERLAP = 0.1f;


	public RenderTexture camTexture1;
	public RenderTexture camTexture2;
	public RenderTexture camTexture3;
	public Camera cam1;
	public Camera cam2;
	public Camera cam3;
	public bool flipOrder = true;


	// Use this for initialization
	void Start () {
		cam1.transform.position = new Vector3 (0, CAM_Y, 0);
		cam2.transform.position = new Vector3 (0, CAM_Y, 0);
		cam3.transform.position = new Vector3 (0, CAM_Y, 0);

		cam1.nearClipPlane = 0.1f;
		cam1.farClipPlane = CAM_Z_INC + CAM_CLIP_OVERLAP;

		cam2.nearClipPlane = CAM_Z_INC;
		cam2.farClipPlane = (CAM_Z_INC * 2) + CAM_CLIP_OVERLAP;

		cam1.nearClipPlane = (CAM_Z_INC * 2);
		cam1.farClipPlane = (CAM_Z_INC * 3) + CAM_CLIP_OVERLAP;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (Event.current.type.Equals (EventType.Repaint)) {
			float thirdScreenHieght = Screen.height / 3;
			if (flipOrder) {
				GUI.DrawTexture (new Rect (0, thirdScreenHieght * 2, Screen.width, thirdScreenHieght), camTexture1, ScaleMode.ScaleAndCrop, true, 0);
				GUI.DrawTexture (new Rect (0, thirdScreenHieght, Screen.width, thirdScreenHieght), camTexture2, ScaleMode.ScaleAndCrop, true, 0);
				GUI.DrawTexture (new Rect (0, 0, Screen.width, thirdScreenHieght), camTexture3, ScaleMode.ScaleAndCrop, true, 0);
			} else {
				GUI.DrawTexture (new Rect (0, 0, Screen.width, thirdScreenHieght), camTexture1, ScaleMode.ScaleAndCrop, true, 0);
				GUI.DrawTexture (new Rect (0, thirdScreenHieght, Screen.width, thirdScreenHieght), camTexture2, ScaleMode.ScaleAndCrop, true, 0);
				GUI.DrawTexture (new Rect (0, thirdScreenHieght * 2, Screen.width, thirdScreenHieght), camTexture3, ScaleMode.ScaleAndCrop, true, 0);
			}
		}
	}
}
