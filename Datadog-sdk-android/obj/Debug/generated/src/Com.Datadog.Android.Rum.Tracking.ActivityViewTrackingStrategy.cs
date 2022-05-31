using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum.Tracking {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.tracking']/class[@name='ActivityViewTrackingStrategy']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/tracking/ActivityViewTrackingStrategy", DoNotGenerateAcw=true)]
	public sealed partial class ActivityViewTrackingStrategy : global::Com.Datadog.Android.Rum.Tracking.ActivityLifecycleTrackingStrategy, global::Com.Datadog.Android.Rum.Tracking.IViewTrackingStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/tracking/ActivityViewTrackingStrategy", typeof (ActivityViewTrackingStrategy));

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

		internal ActivityViewTrackingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.tracking']/class[@name='ActivityViewTrackingStrategy']/constructor[@name='ActivityViewTrackingStrategy' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe ActivityViewTrackingStrategy (bool trackExtras) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (trackExtras);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.tracking']/class[@name='ActivityViewTrackingStrategy']/constructor[@name='ActivityViewTrackingStrategy' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.datadog.android.rum.tracking.ComponentPredicate&lt;android.app.Activity&gt;']]"
		[Register (".ctor", "(ZLcom/datadog/android/rum/tracking/ComponentPredicate;)V", "")]
		public unsafe ActivityViewTrackingStrategy (bool trackExtras, global::Com.Datadog.Android.Rum.Tracking.IComponentPredicate componentPredicate) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZLcom/datadog/android/rum/tracking/ComponentPredicate;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (trackExtras);
				__args [1] = new JniArgumentValue ((componentPredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) componentPredicate).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (componentPredicate);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.tracking']/class[@name='ActivityViewTrackingStrategy']/method[@name='onActivityPostResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityPostResumed", "(Landroid/app/Activity;)V", "")]
		public override unsafe void OnActivityPostResumed (global::Android.App.Activity activity)
		{
			const string __id = "onActivityPostResumed.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

	}
}
