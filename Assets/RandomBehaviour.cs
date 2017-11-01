using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBehaviour : StateMachineBehaviour
{
	[SerializeField]int range;

	private static int hashRandom = Animator.StringToHash ("Random");

	public override void OnStateMachineEnter (Animator animator, int stateMachinePathHash)
	{
		animator.SetInteger (hashRandom, UnityEngine.Random.Range (0, range));
	}
}