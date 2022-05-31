using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Privacy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.android.privacy']/interface[@name='TrackingConsentProviderCallback']"
	[Register ("com/datadog/android/privacy/TrackingConsentProviderCallback", "", "Com.Datadog.Android.Privacy.ITrackingConsentProviderCallbackInvoker")]
	public partial interface ITrackingConsentProviderCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.privacy']/interface[@name='TrackingConsentProviderCallback']/method[@name='onConsentUpdated' and count(parameter)=2 and parameter[1][@type='com.datadog.android.privacy.TrackingConsent'] and parameter[2][@type='com.datadog.android.privacy.TrackingConsent']]"
		[Register ("onConsentUpdated", "(Lcom/datadog/android/privacy/TrackingConsent;Lcom/datadog/android/privacy/TrackingConsent;)V", "GetOnConsentUpdated_Lcom_datadog_android_privacy_TrackingConsent_Lcom_datadog_android_privacy_TrackingConsent_Handler:Com.Datadog.Android.Privacy.ITrackingConsentProviderCallbackInvoker, Datadog_sdk_android")]
		void OnConsentUpdated (global::Com.Datadog.Android.Privacy.TrackingConsent previousConsent, global::Com.Datadog.Android.Privacy.TrackingConsent newConsent);

	}

	[global::Android.Runtime.Register ("com/datadog/android/privacy/TrackingConsentProviderCallback", DoNotGenerateAcw=true)]
	internal partial class ITrackingConsentProviderCallbackInvoker : global::Java.Lang.Object, ITrackingConsentProviderCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/privacy/TrackingConsentProviderCallback", typeof (ITrackingConsentProviderCallbackInvoker));

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

		public static ITrackingConsentProviderCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrackingConsentProviderCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.android.privacy.TrackingConsentProviderCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrackingConsentProviderCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConsentUpdated_Lcom_datadog_android_privacy_TrackingConsent_Lcom_datadog_android_privacy_TrackingConsent_;
#pragma warning disable 0169
		static Delegate GetOnConsentUpdated_Lcom_datadog_android_privacy_TrackingConsent_Lcom_datadog_android_privacy_TrackingConsent_Handler ()
		{
			if (cb_onConsentUpdated_Lcom_datadog_android_privacy_TrackingConsent_Lcom_datadog_android_privacy_TrackingConsent_ == null)
				cb_onConsentUpdated_Lcom_datadog_android_privacy_TrackingConsent_Lcom_datadog_android_privacy_TrackingConsent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnConsentUpdated_Lcom_datadog_android_privacy_TrackingConsent_Lcom_datadog_android_privacy_TrackingConsent_);
			return cb_onConsentUpdated_Lcom_datadog_android_privacy_TrackingConsent_Lcom_datadog_android_privacy_TrackingConsent_;
		}

		static void n_OnConsentUpdated_Lcom_datadog_android_privacy_TrackingConsent_Lcom_datadog_android_privacy_TrackingConsent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_previousConsent, IntPtr native_newConsent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Privacy.ITrackingConsentProviderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var previousConsent = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Privacy.TrackingConsent> (native_previousConsent, JniHandleOwnership.DoNotTransfer);
			var newConsent = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Privacy.TrackingConsent> (native_newConsent, JniHandleOwnership.DoNotTransfer);
			__this.OnConsentUpdated (previousConsent, newConsent);
		}
#pragma warning restore 0169

		IntPtr id_onConsentUpdated_Lcom_datadog_android_privacy_TrackingConsent_Lcom_datadog_android_privacy_TrackingConsent_;
		public unsafe void OnConsentUpdated (global::Com.Datadog.Android.Privacy.TrackingConsent previousConsent, global::Com.Datadog.Android.Privacy.TrackingConsent newConsent)
		{
			if (id_onConsentUpdated_Lcom_datadog_android_privacy_TrackingConsent_Lcom_datadog_android_privacy_TrackingConsent_ == IntPtr.Zero)
				id_onConsentUpdated_Lcom_datadog_android_privacy_TrackingConsent_Lcom_datadog_android_privacy_TrackingConsent_ = JNIEnv.GetMethodID (class_ref, "onConsentUpdated", "(Lcom/datadog/android/privacy/TrackingConsent;Lcom/datadog/android/privacy/TrackingConsent;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((previousConsent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) previousConsent).Handle);
			__args [1] = new JValue ((newConsent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newConsent).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConsentUpdated_Lcom_datadog_android_privacy_TrackingConsent_Lcom_datadog_android_privacy_TrackingConsent_, __args);
		}

	}
}
