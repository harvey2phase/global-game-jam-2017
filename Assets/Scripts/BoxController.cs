using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (BoxCollider2D))]

public class BoxController : MonoBehaviour 
{

	public int NUMBER_OF_ITERATIONS = 12;

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
		grounded = false;

		Vector2 candidateMoveVector = moveVector;
		int iterations = 0;

		candidateMoveVector = moveVector;

		//SidesCollision
		while (true) 
		{
			int numberOfCollisions = 0;

			float rayCastDistance;
			Vector2 candidatePosition = (Vector2)(this.transform.position) + candidateMoveVector;
			RaycastHit2D hit;

			rayCastDistance = Vector2.Distance(topLeft, bottomLeft);

			// Push Down from Left
			hit = Physics2D.Linecast(candidatePosition + topLeft, candidatePosition + bottomLeft);
			if (hit.transform != null && hit.distance > 0)  
			{
				numberOfCollisions++;
				if ((Vector2.Angle (hit.normal, Vector2.up) < steepThreshold) && (rayCastDistance - hit.distance) < stepThreshold)
				{
					candidateMoveVector += Vector2.up * 1.02f * (rayCastDistance - hit.distance);
					candidatePosition = (Vector2)(this.transform.position) + candidateMoveVector;
					grounded = true;

				}
			}

			// Push Down from Right
			hit = Physics2D.Linecast(candidatePosition + topRight, candidatePosition + bottomRight);
			if (hit.transform != null && hit.distance > 0)  
			{
				numberOfCollisions++;
				if ((Vector2.Angle (hit.normal, Vector2.up) < steepThreshold) && (rayCastDistance - hit.distance) < stepThreshold)
				{
					candidateMoveVector += Vector2.up * 1.02f * (rayCastDistance - hit.distance);
					candidatePosition = (Vector2)(this.transform.position) + candidateMoveVector;
					grounded = true;
				}
			}

			// Push Up from Left
			hit = Physics2D.Linecast(candidatePosition + bottomLeft, candidatePosition + topLeft);
			if (hit.transform != null && hit.distance > 0)  
			{
				numberOfCollisions++;
				candidateMoveVector -= Vector2.up * 1.02f * (rayCastDistance - hit.distance);
				candidatePosition = (Vector2)(this.transform.position) + candidateMoveVector;
			}

			// Push Up from Right
			hit = Physics2D.Linecast(candidatePosition + bottomRight, candidatePosition + topRight);
			if (hit.transform != null && hit.distance > 0)  
			{
				numberOfCollisions++;
				candidateMoveVector -= Vector2.up * 1.02f * (rayCastDistance - hit.distance);
				candidatePosition = (Vector2)(this.transform.position) + candidateMoveVector;
			}

			if (numberOfCollisions == 0)
			{
				moveVector = candidateMoveVector;
				break;
			}

			iterations++;
			if (iterations > NUMBER_OF_ITERATIONS) 
			{
				return;
			}
		}

		iterations = 0;
		//Top and BottomCollision
		while (true) 
		{
			int numberOfCollisions = 0;
			float rayCastDistance;
			Vector2 candidatePosition = (Vector2)(this.transform.position) + candidateMoveVector;
			Vector2 raycastUsed;
			RaycastHit2D hit;

			rayCastDistance = Vector2.Distance(topLeft, topRight);

			// Push Right From Top
			hit = Physics2D.Linecast(candidatePosition + topLeft, candidatePosition + topRight);
			if (hit.transform != null && hit.distance > 0)  
			{
				numberOfCollisions++;
				candidateMoveVector -= Vector2.right * 1.02f * (rayCastDistance - hit.distance);
				candidatePosition = (Vector2)(this.transform.position) + candidateMoveVector;
			}

			// Push Right From Bottom
			hit = Physics2D.Linecast(candidatePosition + bottomLeft, candidatePosition + bottomRight);
			if (hit.transform != null && hit.distance > 0) 
			{
				numberOfCollisions++;
				if (Vector2.Angle (hit.normal, Vector3.up) < steepThreshold) 
				{
					candidateMoveVector += Vector2.up * .05f;
					candidatePosition = (Vector2)(this.transform.position) + candidateMoveVector;
				} else 
				{
					candidateMoveVector += Vector2.left * 1.02f * (rayCastDistance - hit.distance);
					candidatePosition = (Vector2)(this.transform.position) + candidateMoveVector;
				}
			}

			// Push Left From Top
			hit = Physics2D.Linecast(candidatePosition + topRight, candidatePosition + topLeft);
			if (hit.transform != null && hit.distance > 0)  
			{
				numberOfCollisions++;
				candidateMoveVector += Vector2.right * 1.02f * (rayCastDistance - hit.distance);
				candidatePosition = (Vector2)(this.transform.position) + candidateMoveVector;
			}

			// Push Left from Bottom
			hit = Physics2D.Linecast(candidatePosition + bottomRight, candidatePosition + bottomLeft);
			if (hit.transform != null && hit.distance > 0)  
			{
				numberOfCollisions++;
				if (Vector2.Angle (hit.normal, Vector3.up) < steepThreshold) 
				{
					candidateMoveVector += Vector2.up * .05f;
					candidatePosition = (Vector2)(this.transform.position) + candidateMoveVector;
				} 
				else 
				{
					candidateMoveVector += Vector2.right * 1.02f * (rayCastDistance - hit.distance);
					candidatePosition = (Vector2)(this.transform.position) + candidateMoveVector;
				}
			}

			if (numberOfCollisions == 0)
			{
				moveVector = candidateMoveVector;
				break;
			}

			iterations++;
			if (iterations > NUMBER_OF_ITERATIONS) 
			{
				return;
			}
		}
		//		if (checkAllEdges((Vector2)transform.position + moveVector))
		transform.position += (Vector3)moveVector;
	}

	bool checkAllEdges(Vector2 center)
	{
		return true;
	}

	void Update()
	{

		if (Input.GetKey(KeyCode.RightArrow))
			Move(Time.deltaTime * 10 * Vector2.right);

		if (Input.GetKey(KeyCode.LeftArrow))
			Move(Time.deltaTime * 10 * Vector2.left);

		if (Input.GetKey(KeyCode.UpArrow))
			Move(Time.deltaTime * 10 * Vector2.up);

		if (Input.GetKey(KeyCode.DownArrow))
			Move(Time.deltaTime * 10 * Vector2.down);
	}

}
