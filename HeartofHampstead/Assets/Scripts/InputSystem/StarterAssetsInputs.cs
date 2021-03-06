using System.Collections;
using UnityEngine;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
#endif


namespace StarterAssets
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		public float radius = 1.5f;
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;
		public bool interact;
		public bool button;
		public bool pause;

		[Header("Movement Settings")]
		public bool analogMovement;

		[Header("Sound Settings")]
		[SerializeField]
		public AudioSource walkSound;
		private bool playsteps = false;
		[SerializeField]
		public AudioSource pageSound;

		[SerializeField]
		private GameObject pauseMenu;

#if !UNITY_IOS || !UNITY_ANDROID
		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;

		public Animator _animator;
#endif

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
		public void OnMove(InputValue value)
		{
			MoveInput(value.Get<Vector2>());
		}

		public void OnLook(InputValue value)
		{
			if(cursorInputForLook)
			{
				LookInput(value.Get<Vector2>());
			}
		}

		public void OnJump(InputValue value)
		{
			JumpInput(value.isPressed);
		}

		
		public void OnSprint(InputValue value)
		{
			SprintInput(value.isPressed);
		}
		
		public void OnInteract(InputValue value)
		{
			InteractInput(value.isPressed);
		}

		public void OnButton(InputValue value)
		{
			ButtonInput(value.isPressed);
		}

		public void OnPause(InputValue value)
		{
			PauseInput(value.isPressed);
		}
#else
		// old input sys if we do decide to have it (most likely wont)...
#endif


		public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;

			if (move == Vector2.zero && walkSound.isPlaying && playsteps)
            {
				walkSound.Stop();
				playsteps = false;
			}
			else if (!walkSound.isPlaying && !playsteps)
			{
				playsteps = true;
				walkSound.Play();
			}
		} 

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}

		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}

		public void InteractInput(bool newInteractState)
		{
			Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
			foreach (Collider hitCollider in hitColliders)
			{
				if (hitCollider.gameObject.layer == 6 || hitCollider.gameObject.layer == 8)
                {
					_animator.SetTrigger("Grab");
					pageSound.Play();
					hitCollider.SendMessage("Operate", SendMessageOptions.DontRequireReceiver);
				}
				else if (hitCollider.gameObject.layer == 7)
                {
					_animator.SetTrigger("Talk");
					hitCollider.SendMessage("Operate", SendMessageOptions.DontRequireReceiver);
				}

			}
		}

		public void ButtonInput(bool newButtonState)
		{
			Scene scene = SceneManager.GetActiveScene();
			if (scene.name == "World")
            {
				GameObject popUp = GameObject.Find("PopUp");
				popUp.gameObject.SetActive(false);
			}

		}

        [System.Obsolete]
        public void PauseInput(bool newPauseState)
		{
			Scene scene = SceneManager.GetActiveScene();
			if (scene.name == "World")
			{
				if (!pauseMenu.active)
				{
					Cursor.visible = true;
					Cursor.lockState = CursorLockMode.None;
					pauseMenu.gameObject.SetActive(true);
				}
				else
				{
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Locked;
					pauseMenu.gameObject.SetActive(false);
				}
            }
		}

#if !UNITY_IOS || !UNITY_ANDROID

		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}

#endif

	}
}
