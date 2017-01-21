using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (BoxCollider2D))]


public class BruteForceController : MonoBehaviour 
{

		public int NUMBER_OF_ITERATIONS = 4;

		public float stepThreshold = .25f;
		public float steepThreshold = 45f;
		public LayerMask collisionMask;
		public bool grounded = false;

		BoxCollider2D box;

		Vector2 topLeft;
		Vector2 topRight;
		Vector2 bottomLeft;
		Vector2 bottomRight;

	public void OnEnable()
	{
		box = this.GetComponent<BoxCollider2D>();

		topLeft = new Vector2(-box.bounds.extents.x , box.bounds.extents.y);
		topRight = new Vector2(box.bounds.extents.x , box.bounds.extents.y);
		bottomLeft = new Vector2(-box.bounds.extents.x , -box.bounds.extents.y);
		bottomRight = new Vector2(box.bounds.extents.x , -box.bounds.extents.y);
	}

	public void Move(Vector2 moveVector)
	{
		
	}
}
