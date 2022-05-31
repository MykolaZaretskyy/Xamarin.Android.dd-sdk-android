using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Plugin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='Feature']"
	[global::Android.Runtime.Register ("com/datadog/android/plugin/Feature", DoNotGenerateAcw=true)]
	public sealed partial class Feature : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='Feature']/field[@name='CRASH']"
		[Register ("CRASH")]
		public static global::Com.Datadog.Android.Plugin.Feature Crash {
			get {
				const string __id = "CRASH.Lcom/datadog/android/plugin/Feature;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.Feature> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='Feature']/field[@name='LOG']"
		[Register ("LOG")]
		public static global::Com.Datadog.Android.Plugin.Feature Log {
			get {
				const string __id = "LOG.Lcom/datadog/android/plugin/Feature;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.Feature> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='Feature']/field[@name='RUM']"
		[Register ("RUM")]
		public static global::Com.Datadog.Android.Plugin.Feature Rum {
			get {
				const string __id = "RUM.Lcom/datadog/android/plugin/Feature;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.Feature> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='Feature']/field[@name='TRACE']"
		[Register ("TRACE")]
		public static global::Com.Datadog.Android.Plugin.Feature Trace {
			get {
				const string __id = "TRACE.Lcom/datadog/android/plugin/Feature;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.Feature> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/plugin/Feature", typeof (Feature));

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

		internal Feature (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string FeatureName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='Feature']/method[@name='getFeatureName' and count(parameter)=0]"
			[Register ("getFeatureName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getFeatureName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='Feature']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/plugin/Feature;", "")]
		public static unsafe global::Com.Datadog.Android.Plugin.Feature ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/plugin/Feature;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.Feature> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='Feature']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/datadog/android/plugin/Feature;", "")]
		public static unsafe global::Com.Datadog.Android.Plugin.Feature[] Values ()
		{
			const string __id = "values.()[Lcom/datadog/android/plugin/Feature;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Datadog.Android.Plugin.Feature[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Plugin.Feature));
			} finally {
			}
		}

	}
}
