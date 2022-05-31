using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumErrorSource']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/RumErrorSource", DoNotGenerateAcw=true)]
	public sealed partial class RumErrorSource : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumErrorSource']/field[@name='AGENT']"
		[Register ("AGENT")]
		public static global::Com.Datadog.Android.Rum.RumErrorSource Agent {
			get {
				const string __id = "AGENT.Lcom/datadog/android/rum/RumErrorSource;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumErrorSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumErrorSource']/field[@name='CONSOLE']"
		[Register ("CONSOLE")]
		public static global::Com.Datadog.Android.Rum.RumErrorSource Console {
			get {
				const string __id = "CONSOLE.Lcom/datadog/android/rum/RumErrorSource;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumErrorSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumErrorSource']/field[@name='LOGGER']"
		[Register ("LOGGER")]
		public static global::Com.Datadog.Android.Rum.RumErrorSource Logger {
			get {
				const string __id = "LOGGER.Lcom/datadog/android/rum/RumErrorSource;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumErrorSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumErrorSource']/field[@name='NETWORK']"
		[Register ("NETWORK")]
		public static global::Com.Datadog.Android.Rum.RumErrorSource Network {
			get {
				const string __id = "NETWORK.Lcom/datadog/android/rum/RumErrorSource;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumErrorSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumErrorSource']/field[@name='SOURCE']"
		[Register ("SOURCE")]
		public static global::Com.Datadog.Android.Rum.RumErrorSource Source {
			get {
				const string __id = "SOURCE.Lcom/datadog/android/rum/RumErrorSource;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumErrorSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumErrorSource']/field[@name='WEBVIEW']"
		[Register ("WEBVIEW")]
		public static global::Com.Datadog.Android.Rum.RumErrorSource Webview {
			get {
				const string __id = "WEBVIEW.Lcom/datadog/android/rum/RumErrorSource;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumErrorSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/RumErrorSource", typeof (RumErrorSource));

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

		internal RumErrorSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumErrorSource']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/rum/RumErrorSource;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.RumErrorSource ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/rum/RumErrorSource;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumErrorSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumErrorSource']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/datadog/android/rum/RumErrorSource;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.RumErrorSource[] Values ()
		{
			const string __id = "values.()[Lcom/datadog/android/rum/RumErrorSource;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Datadog.Android.Rum.RumErrorSource[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Rum.RumErrorSource));
			} finally {
			}
		}

	}
}
