﻿using UnityEngine;
using System.Collections;
public class InputManager : MonoBehaviour
{
	private bool draggingItem = false;
	private GameObject draggedObject;
	private Rigidbody2D draggedObjectRigidbody;
	private Vector2 touchOffset;
	public float dragFollowSpeed;

	void Update ()
	{
		if (HasInput)
		{
			//print ("DRAGGING");
			DragOrPickUp();
		}
		else
		{
			if (draggingItem)
				DropItem();
		}
	}

	float rounded(float num, float multiple)
	{
		//return Mathf.Round (num / multiple) * multiple;
		return num;
	}
		
	Vector2 RawTouchPosition
	{
		get
		{
			Vector2 inputPos;
			inputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			return inputPos;
		}
	}

	Vector2 RoundedTouchPosition
	{
		get
		{
			Vector2 inputPos;
			inputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			inputPos.x = rounded (inputPos.x, snaptogrid.XSnap);
			inputPos.y = rounded (inputPos.y, snaptogrid.YSnap);
			return inputPos;
		}
	}

	private void DragOrPickUp()
	{
		var inputPosition = RoundedTouchPosition;
		var rawInputPosition = RawTouchPosition;
		if (draggingItem)
		{
			draggedObjectRigidbody.MovePosition (Vector3.Lerp (draggedObject.transform.position, inputPosition, Time.deltaTime * dragFollowSpeed));
			//draggedObject.transform.position = inputPosition;// + touchOffset;
		}
		else
		{
			RaycastHit2D[] touches = Physics2D.RaycastAll(rawInputPosition, rawInputPosition, 1.1f);
			if (touches.Length > 0)
			{
				var hit = touches[0];
				if (hit.transform != null)
				{
					if (hit.transform.gameObject.layer == LayerMask.NameToLayer("characters"))
						{
							draggingItem = true;
							draggedObject = hit.transform.gameObject;
							draggedObjectRigidbody = draggedObject.GetComponent<Rigidbody2D> ();
							touchOffset = (Vector2)hit.transform.position - rawInputPosition;
							draggedObject.transform.localScale = new Vector3(1.2f,1.2f,1.2f);

						}
				}
			}
		}
	}

	private bool HasInput
	{
		get
		{
			// returns true if either the mouse button is down or at least one touch is felt on the screen
			return Input.GetMouseButton(0);
		}
	}

	void DropItem()
	{
		draggingItem = false;
		draggedObject.transform.localScale = new Vector3(1.1f,1.1f,1.1f);
		draggedObjectRigidbody.velocity = Vector2.zero;
//        draggedObject.transform.position = new Vector3(Mathf.Round(draggedObject.transform.position.x), Mathf.Round(transform.position.y), (draggedObject.transform.position.z));
    }
}