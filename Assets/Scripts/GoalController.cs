using System.Collections;
using UnityEngine;

public class GoalController : MonoBehaviour 
{
	public UIController UIController;
	public UIcontrollervol3 UIcontrollervol3;
	private void OnTriggerEnter (Collider hit)
	{
		if (hit.CompareTag ("Player")) 
		{
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			UIController.ShowGameClearLabel();

			UIcontrollervol3.ShowRestartButton();
		}
	}
}
