using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

	void Update () {
        var pos = new Vector3(target.position.x, target.position.y, target.position.z + (-10f));
        transform.position = Vector3.Lerp(transform.position, pos, 5 * Time.deltaTime);
	}
}
