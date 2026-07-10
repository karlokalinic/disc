using System;
using FortressOccident;
using UnityEngine;
using Voidforge;

public abstract class PartyMember<T> : SingletonComponent<T> where T : MonoBehaviour
{
	[GetComponent]
	protected ComponentRef<Character> character;

	public Action OnPartyStatusChange;

	private bool _isLeftOutside;

	public Character Character => null;

	public bool IsInParty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsLeftOutside
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual void Join()
	{
	}

	public virtual void Remove()
	{
	}
}
