using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
		public AudioClip cowSound;

		// Use this for initialization
		void Start ()
		{
				//renderer.enabled = false; /* Makes object invisible */
				GetComponent<Renderer> ().enabled = false;
		}
    
		// Update is called once per frame
		void Update ()
		{
				/* Get main Input */
				//if (Input.GetButton ("Fire1"))
				if (Input.GetKey ("1")) {
						GetComponent<Renderer> ().enabled = true; /* Makes object visible */
						/* Play the ray sound */
						GetComponent<AudioSource> ().Play ();
				}
        
				if (GetComponent<Renderer> ().enabled == true) {
						transform.position += Vector3.down * (Time.deltaTime * 2);
				}

				/* Check for out of bounds */

				if (this.transform.position.y < -1.5) {
						transform.position = new Vector2 (0.08658695f, 0.1924166f); /* Return bullet to original position */
						GetComponent<Renderer> ().enabled = false;
				}
		}

		void OnTriggerEnter2D (Collider2D other)
		{
				if (other.gameObject.name == "cow(Clone)") {
						AudioSource.PlayClipAtPoint (cowSound, transform.position);
						/* Destroy the cow */
						Destroy (other.gameObject);
						transform.position = new Vector2 (0.08658695f, 0.1924166f); /* Return bullet to original position */
						GetComponent<Renderer> ().enabled = false;
				}
		}
}
