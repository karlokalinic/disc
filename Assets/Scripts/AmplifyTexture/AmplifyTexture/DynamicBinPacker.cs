using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public sealed class DynamicBinPacker : RectanglePacker
	{
		[Serializable]
		public sealed class Node : Rectangle
		{
			[SerializeField]
			private int m_index;

			[SerializeField]
			private bool m_leaf;

			[SerializeField]
			private string m_key;

			[SerializeField]
			private int m_keyHash;

			[SerializeField]
			private List<int> m_children;

			internal int Index => 0;

			internal bool Leaf => false;

			internal string Key => null;

			internal int KeyHash => 0;

			internal List<int> Children => null;

			internal bool Assigned => false;

			public Node(int index)
			{
			}

			internal void MakeEmptyInner()
			{
			}

			internal void MakeEmptyLeaf()
			{
			}

			internal void AssignKey(int width, int height, string key)
			{
			}

			internal void ClearKey()
			{
			}
		}

		public enum SplitHeuristic
		{
			VerticalAxis = 0,
			LongestAxis = 1
		}

		[SerializeField]
		private SplitHeuristic m_splitHeuristic;

		[SerializeField]
		private List<Node> m_nodeList;

		[SerializeField]
		private Node m_root;

		internal Node Root => null;

		public DynamicBinPacker(int packingAreaWidth, int packingAreaHeight, SplitHeuristic splitHeuristic)
			: base(0, 0)
		{
		}

		private Node CreateNode()
		{
			return null;
		}

		private void DestroyNode(Node node)
		{
		}

		private void DestroyAllNodes()
		{
		}

		internal override void Clear()
		{
		}

		private Node Insert(Node node, int width, int height, string key)
		{
			return null;
		}

		internal override bool TryPack(int width, int height, string key, out Point location)
		{
			location = null;
			return false;
		}

		internal override void RemoveByKey(string key)
		{
		}

		internal int RecursivePruneTree(Node node)
		{
			return 0;
		}

		internal void PruneTree()
		{
		}

		private Node RecursiveFindByLocation(Node node, int x, int y)
		{
			return null;
		}

		internal Node FindByLocation(int x, int y)
		{
			return null;
		}

		private Node RecursiveFindByKey(Node node, string key, int keyHash)
		{
			return null;
		}

		internal Node FindByKey(string key)
		{
			return null;
		}

		public float RecursiveComputeUsedSpacePercentage(Node node)
		{
			return 0f;
		}

		public float ComputeUsedSpacePercentage()
		{
			return 0f;
		}

		private void RecursiveDebugTree(TextWriter writer, Node node, string spaces, int level, ref int counter)
		{
		}

		internal void DebugTree(TextWriter writer)
		{
		}
	}
}
