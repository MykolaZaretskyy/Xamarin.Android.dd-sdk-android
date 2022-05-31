using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Plugin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogPluginConfig']"
	[global::Android.Runtime.Register ("com/datadog/android/plugin/DatadogPluginConfig", DoNotGenerateAcw=true)]
	public sealed partial class DatadogPluginConfig : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/plugin/DatadogPluginConfig", typeof (DatadogPluginConfig));

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

		internal DatadogPluginConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogPluginConfig']/constructor[@name='DatadogPluginConfig' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.datadog.android.privacy.TrackingConsent']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/datadog/android/privacy/TrackingConsent;)V", "")]
		public unsafe DatadogPluginConfig (global::Android.Content.Context context, string envName, string serviceName, string featurePersistenceDirName, global::Com.Datadog.Android.Privacy.TrackingConsent trackingConsent) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/datadog/android/privacy/TrackingConsent;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_envName = JNIEnv.NewString (envName);
			IntPtr native_serviceName = JNIEnv.NewString (serviceName);
			IntPtr native_featurePersistenceDirName = JNIEnv.NewString (featurePersistenceDirName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_envName);
				__args [2] = new JniArgumentValue (native_serviceName);
				__args [3] = new JniArgumentValue (native_featurePersistenceDirName);
				__args [4] = new JniArgumentValue ((trackingConsent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackingConsent).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_envName);
				JNIEnv.DeleteLocalRef (native_serviceName);
				JNIEnv.DeleteLocalRef (native_featurePersistenceDirName);
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (trackingConsent);
			}
		}

		public unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogPluginConfig']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string EnvName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogPluginConfig']/method[@name='getEnvName' and count(parameter)=0]"
			[Register ("getEnvName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getEnvName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string FeaturePersistenceDirName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogPluginConfig']/method[@name='getFeaturePersistenceDirName' and count(parameter)=0]"
			[Register ("getFeaturePersistenceDirName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getFeaturePersistenceDirName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ServiceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogPluginConfig']/method[@name='getServiceName' and count(parameter)=0]"
			[Register ("getServiceName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getServiceName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Datadog.Android.Privacy.TrackingConsent TrackingConsent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogPluginConfig']/method[@name='getTrackingConsent' and count(parameter)=0]"
			[Register ("getTrackingConsent", "()Lcom/datadog/android/privacy/TrackingConsent;", "")]
			get {
				const string __id = "getTrackingConsent.()Lcom/datadog/android/privacy/TrackingConsent;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Privacy.TrackingConsent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
