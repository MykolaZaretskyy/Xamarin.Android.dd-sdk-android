using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Core.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.core.internal.utils']/class[@name='ComponentPredicateExtKt']"
	[global::Android.Runtime.Register ("com/datadog/android/core/internal/utils/ComponentPredicateExtKt", DoNotGenerateAcw=true)]
	public sealed partial class ComponentPredicateExtKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/core/internal/utils/ComponentPredicateExtKt", typeof (ComponentPredicateExtKt));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal ComponentPredicateExtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
