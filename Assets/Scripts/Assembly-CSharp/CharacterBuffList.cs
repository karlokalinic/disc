using System.Collections.Generic;
using Sunshine.Metric;
using UnityEngine;
using Voidforge;

[ExecuteInEditMode]
public class CharacterBuffList : SingletonComponent<CharacterBuffList>
{
	public CharacterBuffListComponent[] characterBuffs;

	protected Dictionary<string, CharacterBuff> string2buff;

	protected Dictionary<CharacterBuff, string> buff2string;

	protected override void Awake()
	{
	}

	protected void RefreshCache()
	{
	}

	public CharacterBuff GetBuff(string name)
	{
		return null;
	}

	public string GetName(CharacterBuff buff)
	{
		return null;
	}

	protected void TestCache()
	{
	}
}
