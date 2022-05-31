using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum.Tracking {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.android.rum.tracking']/interface[@name='TrackingStrategy']"
	[Register ("com/datadog/android/rum/tracking/TrackingStrategy", "", "Com.Datadog.Android.Rum.Tracking.ITrackingStrategyInvoker")]
	public partial interface ITrackingStrategy : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.tracking']/interface[@name='TrackingStrategy']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("register", "(Landroid/content/Context;)V", "GetRegister_Landroid_content_Context_Handler:Com.Datadog.Android.Rum.Tracking.ITrackingStrategyInvoker, Datadog_sdk_android")]
		void Register (global::Android.Content.Context context);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum.tracking']/interface[@name='TrackingStrategy']/method[@name='unregister' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("unregister", "(Landroid/content/Context;)V", "GetUnregister_Landroid_content_Context_Handler:Com.Datadog.Android.Rum.Tracking.ITrackingStrategyInvoker, Datadog_sdk_android")]
		void Unregister (global::Android.Content.Context context);

	}

	[global::Android.Runtime.Register ("com/datadog/android/rum/tracking/TrackingStrategy", DoNotGenerateAcw=true)]
	internal partial class ITrackingStrategyInvoker : global::Java.Lang.Object, ITrackingStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/tracking/TrackingStrategy", typeof (ITrackingStrategyInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITrackingStrategy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrackingStrategy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.android.rum.tracking.TrackingStrategy'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrackingStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_register_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetRegister_Landroid_content_Context_Handler ()
		{
			if (cb_register_Landroid_content_Context_ == null)
				cb_register_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Register_Landroid_content_Context_);
			return cb_register_Landroid_content_Context_;
		}

		static void n_Register_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Tracking.ITrackingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Register (context);
		}
#pragma warning restore 0169

		IntPtr id_register_Landroid_content_Context_;
		public unsafe void Register (global::Android.Content.Context context)
		{
			if (id_register_Landroid_content_Context_ == IntPtr.Zero)
				id_register_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "register", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Landroid_content_Context_, __args);
		}

		static Delegate cb_unregister_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetUnregister_Landroid_content_Context_Handler ()
		{
			if (cb_unregister_Landroid_content_Context_ == null)
				cb_unregister_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Unregister_Landroid_content_Context_);
			return cb_unregister_Landroid_content_Context_;
		}

		static void n_Unregister_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.Tracking.ITrackingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Unregister (context);
		}
#pragma warning restore 0169

		IntPtr id_unregister_Landroid_content_Context_;
		public unsafe void Unregister (global::Android.Content.Context context)
		{
			if (id_unregister_Landroid_content_Context_ == IntPtr.Zero)
				id_unregister_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "unregister", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregister_Landroid_content_Context_, __args);
		}

	}
}
