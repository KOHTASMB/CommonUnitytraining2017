using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIcontrollervol3 : MonoBehaviour 
{
	public Button RestartButton;
	private void Start ()
	{
		RestartButton.gameObject.SetActive (false);
		RestartButton.onClick.AddListener (Restart);
	}
	void Restart ()
	{
		SceneManager.LoadScene (0);
	}
	public void ShowRestartButton()
	{
		RestartButton.gameObject.SetActive (true);

	}
}
