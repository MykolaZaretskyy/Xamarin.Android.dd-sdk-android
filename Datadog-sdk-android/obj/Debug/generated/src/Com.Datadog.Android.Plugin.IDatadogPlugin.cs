using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Plugin {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.android.plugin']/interface[@name='DatadogPlugin']"
	[Register ("com/datadog/android/plugin/DatadogPlugin", "", "Com.Datadog.Android.Plugin.IDatadogPluginInvoker")]
	public partial interface IDatadogPlugin : global::Com.Datadog.Android.Privacy.ITrackingConsentProviderCallback {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/interface[@name='DatadogPlugin']/method[@name='onContextChanged' and count(parameter)=1 and parameter[1][@type='com.datadog.android.plugin.DatadogContext']]"
		[Register ("onContextChanged", "(Lcom/datadog/android/plugin/DatadogContext;)V", "GetOnContextChanged_Lcom_datadog_android_plugin_DatadogContext_Handler:Com.Datadog.Android.Plugin.IDatadogPluginInvoker, Datadog_sdk_android")]
		void OnContextChanged (global::Com.Datadog.Android.Plugin.DatadogContext context);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/interface[@name='DatadogPlugin']/method[@name='register' and count(parameter)=1 and parameter[1][@type='com.datadog.android.plugin.DatadogPluginConfig']]"
		[Register ("register", "(Lcom/datadog/android/plugin/DatadogPluginConfig;)V", "GetRegister_Lcom_datadog_android_plugin_DatadogPluginConfig_Handler:Com.Datadog.Android.Plugin.IDatadogPluginInvoker, Datadog_sdk_android")]
		void Register (global::Com.Datadog.Android.Plugin.DatadogPluginConfig config);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/interface[@name='DatadogPlugin']/method[@name='unregister' and count(parameter)=0]"
		[Register ("unregister", "()V", "GetUnregisterHandler:Com.Datadog.Android.Plugin.IDatadogPluginInvoker, Datadog_sdk_android")]
		void Unregister ();

	}

	[global::Android.Runtime.Register ("com/datadog/android/plugin/DatadogPlugin", DoNotGenerateAcw=true)]
	internal partial class IDatadogPluginInvoker : global::Java.Lang.Object, IDatadogPlugin {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/plugin/DatadogPlugin", typeof (IDatadogPluginInvoker));

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

		public static IDatadogPlugin GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDatadogPlugin> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.android.plugin.DatadogPlugin'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDatadogPluginInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onContextChanged_Lcom_datadog_android_plugin_DatadogContext_;
#pragma warning disable 0169
		static Delegate GetOnContextChanged_Lcom_datadog_android_plugin_DatadogContext_Handler ()
		{
			if (cb_onContextChanged_Lcom_datadog_android_plugin_DatadogContext_ == null)
				cb_onContextChanged_Lcom_datadog_android_plugin_DatadogContext_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnContextChanged_Lcom_datadog_android_plugin_DatadogContext_);
			return cb_onContextChanged_Lcom_datadog_android_plugin_DatadogContext_;
		}

		static void n_OnContextChanged_Lcom_datadog_android_plugin_DatadogContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.IDatadogPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.DatadogContext> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.OnContextChanged (context);
		}
#pragma warning restore 0169

		IntPtr id_onContextChanged_Lcom_datadog_android_plugin_DatadogContext_;
		public unsafe void OnContextChanged (global::Com.Datadog.Android.Plugin.DatadogContext context)
		{
			if (id_onContextChanged_Lcom_datadog_android_plugin_DatadogContext_ == IntPtr.Zero)
				id_onContextChanged_Lcom_datadog_android_plugin_DatadogContext_ = JNIEnv.GetMethodID (class_ref, "onContextChanged", "(Lcom/datadog/android/plugin/DatadogContext;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onContextChanged_Lcom_datadog_android_plugin_DatadogContext_, __args);
		}

		static Delegate cb_register_Lcom_datadog_android_plugin_DatadogPluginConfig_;
#pragma warning disable 0169
		static Delegate GetRegister_Lcom_datadog_android_plugin_DatadogPluginConfig_Handler ()
		{
			if (cb_register_Lcom_datadog_android_plugin_DatadogPluginConfig_ == null)
				cb_register_Lcom_datadog_android_plugin_DatadogPluginConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Register_Lcom_datadog_android_plugin_DatadogPluginConfig_);
			return cb_register_Lcom_datadog_android_plugin_DatadogPluginConfig_;
		}

		static void n_Register_Lcom_datadog_android_plugin_DatadogPluginConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.IDatadogPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.DatadogPluginConfig> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.Register (config);
		}
#pragma warning restore 0169

		IntPtr id_register_Lcom_datadog_android_plugin_DatadogPluginConfig_;
		public unsafe void Register (global::Com.Datadog.Android.Plugin.DatadogPluginConfig config)
		{
			if (id_register_Lcom_datadog_android_plugin_DatadogPluginConfig_ == IntPtr.Zero)
				id_register_Lcom_datadog_android_plugin_DatadogPluginConfig_ = JNIEnv.GetMethodID (class_ref, "register", "(Lcom/datadog/android/plugin/DatadogPluginConfig;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Lcom_datadog_android_plugin_DatadogPluginConfig_, __args);
		}

		static Delegate cb_unregister;
#pragma warning disable 0169
		static Delegate GetUnregisterHandler ()
		{
			if (cb_unregister == null)
				cb_unregister = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Unregister);
			return cb_unregister;
		}

		static void n_Unregister (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.IDatadogPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unregister ();
		}
#pragma warning restore 0169

		IntPtr id_unregister;
		public unsafe void Unregister ()
		{
			if (id_unregister == IntPtr.Zero)
				id_unregister = JNIEnv.GetMethodID (class_ref, "unregister", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregister);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.IDatadogPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
