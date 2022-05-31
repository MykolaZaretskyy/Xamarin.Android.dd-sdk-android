using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum.Tracking {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum.tracking']/class[@name='AcceptAllDefaultFragment']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/tracking/AcceptAllDefaultFragment", DoNotGenerateAcw=true)]
	public partial class AcceptAllDefaultFragment : global::Java.Lang.Object, global::Com.Datadog.Android.Rum.Tracking.IComponentPredicate {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/tracking/AcceptAllDefaultFragment", typeof (AcceptAllDefaultFragment));

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

		protected AcceptAllDefaultFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum.tracking']/class[@name='AcceptAllDefaultFragment']/constructor[@name='AcceptAllDefaultFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AcceptAllDefaultFragment () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_accept_Landroid_app_Fragment_;
#pragma warning disable 0169
		static Delegate GetAccept_Landroid_app_Fragment_Handler ()
		{
			if (cb_accept_Landroid_app_Fragment_ == null)
				cb_accept_Landroid_app_Fragment_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Accept_Landroid_app_Fragment_);
			return cb_accept_Landroid_app_Fragment_;
		}

		static bool n_Accept_Landroid_app_Fragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_component)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Tracking.AcceptAllDefaultFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var component = global::Java.Lang.Object.GetObject<global::Android.App.Fragment> (native_component, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Accept (component);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.tracking']/class[@name='AcceptAllDefaultFragment']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='android.app.Fragment']]"
		[Register ("accept", "(Landroid/app/Fragment;)Z", "GetAccept_Landroid_app_Fragment_Handler")]
		public virtual unsafe bool Accept (global::Android.App.Fragment component)
		{
			const string __id = "accept.(Landroid/app/Fragment;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((component == null) ? IntPtr.Zero : ((global::Java.Lang.Object) component).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (component);
			}
		}

		static Delegate cb_getViewName_Landroid_app_Fragment_;
#pragma warning disable 0169
		static Delegate GetGetViewName_Landroid_app_Fragment_Handler ()
		{
			if (cb_getViewName_Landroid_app_Fragment_ == null)
				cb_getViewName_Landroid_app_Fragment_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetViewName_Landroid_app_Fragment_);
			return cb_getViewName_Landroid_app_Fragment_;
		}

		static IntPtr n_GetViewName_Landroid_app_Fragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_component)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Tracking.AcceptAllDefaultFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var component = global::Java.Lang.Object.GetObject<global::Android.App.Fragment> (native_component, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetViewName (component));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.tracking']/class[@name='AcceptAllDefaultFragment']/method[@name='getViewName' and count(parameter)=1 and parameter[1][@type='android.app.Fragment']]"
		[Register ("getViewName", "(Landroid/app/Fragment;)Ljava/lang/String;", "GetGetViewName_Landroid_app_Fragment_Handler")]
		public virtual unsafe string GetViewName (global::Android.App.Fragment component)
		{
			const string __id = "getViewName.(Landroid/app/Fragment;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((component == null) ? IntPtr.Zero : ((global::Java.Lang.Object) component).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (component);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Datadog.Android.Rum.Tracking.IComponentPredicate
		bool global::Com.Datadog.Android.Rum.Tracking.IComponentPredicate.Accept (global::Java.Lang.Object component)
		{
			return Accept (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Android.App.Fragment>(component));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Datadog.Android.Rum.Tracking.IComponentPredicate
		string global::Com.Datadog.Android.Rum.Tracking.IComponentPredicate.GetViewName (global::Java.Lang.Object component)
		{
			return GetViewName (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Android.App.Fragment>(component));
		}

	}
}
