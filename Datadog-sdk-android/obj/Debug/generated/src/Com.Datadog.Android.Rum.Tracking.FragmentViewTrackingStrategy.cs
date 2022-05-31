using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum.Tracking {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.tracking']/class[@name='FragmentViewTrackingStrategy']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/tracking/FragmentViewTrackingStrategy", DoNotGenerateAcw=true)]
	public sealed partial class FragmentViewTrackingStrategy : global::Com.Datadog.Android.Rum.Tracking.ActivityLifecycleTrackingStrategy, global::Com.Datadog.Android.Rum.Tracking.IViewTrackingStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/tracking/FragmentViewTrackingStrategy", typeof (FragmentViewTrackingStrategy));

		internal static new IntPtr class_ref {
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

		internal FragmentViewTrackingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.tracking']/class[@name='FragmentViewTrackingStrategy']/constructor[@name='FragmentViewTrackingStrategy' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe FragmentViewTrackingStrategy (bool trackArguments) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (trackArguments);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
