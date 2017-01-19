using UnityEngine;
using System.Collections;

public class OnCollision : MonoBehaviour
{
		void OnTriggerEnter2D (Collider2D other)
		{
				if (other.gameObject.name == "cow(Clone)") {
						/* Play the save cow sound */
						//audio.Play();
						GetComponent<AudioSource> ().Play ();
						/* Destroy the cow */
						Destroy (other.gameObject);
				}
		}
}