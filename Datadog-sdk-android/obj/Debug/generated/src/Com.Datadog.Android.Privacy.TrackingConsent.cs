using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Privacy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.privacy']/class[@name='TrackingConsent']"
	[global::Android.Runtime.Register ("com/datadog/android/privacy/TrackingConsent", DoNotGenerateAcw=true)]
	public sealed partial class TrackingConsent : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.privacy']/class[@name='TrackingConsent']/field[@name='GRANTED']"
		[Register ("GRANTED")]
		public static global::Com.Datadog.Android.Privacy.TrackingConsent Granted {
			get {
				const string __id = "GRANTED.Lcom/datadog/android/privacy/TrackingConsent;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Privacy.TrackingConsent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.privacy']/class[@name='TrackingConsent']/field[@name='NOT_GRANTED']"
		[Register ("NOT_GRANTED")]
		public static global::Com.Datadog.Android.Privacy.TrackingConsent NotGranted {
			get {
				const string __id = "NOT_GRANTED.Lcom/datadog/android/privacy/TrackingConsent;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Privacy.TrackingConsent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.privacy']/class[@name='TrackingConsent']/field[@name='PENDING']"
		[Register ("PENDING")]
		public static global::Com.Datadog.Android.Privacy.TrackingConsent Pending {
			get {
				const string __id = "PENDING.Lcom/datadog/android/privacy/TrackingConsent;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Privacy.TrackingConsent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/privacy/TrackingConsent", typeof (TrackingConsent));

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

		internal TrackingConsent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.privacy']/class[@name='TrackingConsent']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/privacy/TrackingConsent;", "")]
		public static unsafe global::Com.Datadog.Android.Privacy.TrackingConsent ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/privacy/TrackingConsent;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Privacy.TrackingConsent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.privacy']/class[@name='TrackingConsent']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/datadog/android/privacy/TrackingConsent;", "")]
		public static unsafe global::Com.Datadog.Android.Privacy.TrackingConsent[] Values ()
		{
			const string __id = "values.()[Lcom/datadog/android/privacy/TrackingConsent;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Datadog.Android.Privacy.TrackingConsent[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Privacy.TrackingConsent));
			} finally {
			}
		}

	}
}
