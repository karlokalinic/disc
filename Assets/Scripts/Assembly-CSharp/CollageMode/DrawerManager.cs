using System.Collections.Generic;
using UnityEngine;

namespace CollageMode
{
	public class DrawerManager : MonoBehaviour
	{
		private Stack<Drawer> drawersStack;

		public Drawer Current => null;

		public void PushDrawer(Drawer drawer, bool replaceLastOne = false)
		{
		}

		public void PopDrawer()
		{
		}

		public void Clear()
		{
		}
	}
}
