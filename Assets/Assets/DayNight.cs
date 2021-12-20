using UnityEngine;
using System.Collections;

public class DayNight : MonoBehaviour {

	[Tooltip ("# of minutes per second for cycle")]
	public float minutesPerSecond = 60f;
	public float xrot;
    private Light l;
    // Update is called once per frame
    private void Start()
    {
        l = GetComponent<Light>();
    }
    void Update () {
		float angleThisFrame = Time.deltaTime / 360 * minutesPerSecond;
		transform.RotateAround (transform.position, Vector3.forward, angleThisFrame);
        xrot = this.transform.rotation.eulerAngles.x;
        //if (xrot > 180)
       // {
        //    l.intensity = 0;
       // }
      //  if (xrot == 360)
       // {
      //      xrot = 0;
      //  }

    }
}
