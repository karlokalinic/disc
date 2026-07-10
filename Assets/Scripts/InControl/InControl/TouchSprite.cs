using System;
using UnityEngine;

namespace InControl
{
	[Serializable]
	public class TouchSprite
	{
		[SerializeField]
		private Sprite idleSprite;

		[SerializeField]
		private Sprite busySprite;

		[SerializeField]
		private Color idleColor;

		[SerializeField]
		private Color busyColor;

		[SerializeField]
		private TouchSpriteShape shape;

		[SerializeField]
		private TouchUnitType sizeUnitType;

		[SerializeField]
		private Vector2 size;

		[SerializeField]
		private bool lockAspectRatio;

		[SerializeField]
		[HideInInspector]
		private Vector2 worldSize;

		private GameObject spriteGameObject;

		private SpriteRenderer spriteRenderer;

		private bool state;

		public bool Dirty { get; set; }

		public bool Ready { get; set; }

		public bool State
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Sprite BusySprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite IdleSprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite Sprite
		{
			set
			{
			}
		}

		public Color BusyColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color IdleColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public TouchSpriteShape Shape
		{
			get
			{
				return default(TouchSpriteShape);
			}
			set
			{
			}
		}

		public TouchUnitType SizeUnitType
		{
			get
			{
				return default(TouchUnitType);
			}
			set
			{
			}
		}

		public Vector2 Size
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 WorldSize => default(Vector2);

		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public TouchSprite()
		{
		}

		public TouchSprite(float size)
		{
		}

		public void Create(string gameObjectName, Transform parentTransform, int sortingOrder)
		{
		}

		public void Delete()
		{
		}

		public void Update()
		{
		}

		public void Update(bool forceUpdate)
		{
		}

		private GameObject CreateSpriteGameObject(string name, Transform parentTransform)
		{
			return null;
		}

		private SpriteRenderer CreateSpriteRenderer(GameObject spriteGameObject, Sprite sprite, int sortingOrder)
		{
			return null;
		}

		private void ScaleSpriteInPixels(GameObject spriteGameObject, SpriteRenderer spriteRenderer, Vector2 size)
		{
		}

		private void ScaleSpriteInPercent(GameObject spriteGameObject, SpriteRenderer spriteRenderer, Vector2 size)
		{
		}

		public bool Contains(Vector2 testWorldPoint)
		{
			return false;
		}

		public bool Contains(Touch touch)
		{
			return false;
		}

		public void DrawGizmos(Vector3 position, Color color)
		{
		}
	}
}
