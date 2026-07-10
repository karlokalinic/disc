using System.Collections.Generic;
using UnityEngine;

namespace Voidforge
{
	public class OnScreenTrackingTag : PositionTrackingTag
	{
		[SerializeField]
		protected Camera viewCamera;

		[SerializeField]
		protected LayerMask layerMask;

		[SerializeField]
		protected bool perVertex;

		protected Bounds? _aggregatedBounds;

		protected Bounds? _screenBounds;

		protected Bounds? _selfBounds;

		protected CameraTrackingTag _cameraTag;

		protected List<OnScreenTrackingTag> _subTags;

		public bool IsVisible => false;

		public Bounds ScreenBounds => default(Bounds);

		public Bounds ViewportBounds => default(Bounds);

		protected Camera Camera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected Bounds SelfBounds => default(Bounds);

		protected Matrix4x4 ViewportMVPMatrix => default(Matrix4x4);

		public void Initialize(OnScreenTrackingTag sourceTag)
		{
		}

		protected void OnCameraTrackingEvent()
		{
		}

		protected void OnSubTrackingEvent()
		{
		}

		protected override void SendTrackingEvent()
		{
		}

		protected bool ShouldBeTagged(Transform t)
		{
			return false;
		}

		protected void TagChildren(Transform self)
		{
		}

		protected override void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected override void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
