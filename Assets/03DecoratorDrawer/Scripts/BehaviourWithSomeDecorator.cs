using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourWithSomeDecorator : MonoBehaviour
{
	[Header("I am title")]

	[SerializeField]
	private string myName;

	[Space(20)]
	[SerializeField]
	private int iAmAnIntNotRelatedToMyName;
}
