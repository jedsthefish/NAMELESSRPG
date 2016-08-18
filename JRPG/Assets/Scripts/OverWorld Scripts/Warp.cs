using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {


    public Transform warpTarget;
    

    IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        ScreenFaderScript sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFaderScript>();
        other.attachedRigidbody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;

        yield return StartCoroutine(sf.FadeToBlack());
        other.gameObject.transform.position = warpTarget.position;
        Camera.main.transform.position = warpTarget.position;
        yield return StartCoroutine(sf.FadeToClear());

        other.attachedRigidbody.constraints = RigidbodyConstraints2D.None;
        other.attachedRigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;

    }

}
