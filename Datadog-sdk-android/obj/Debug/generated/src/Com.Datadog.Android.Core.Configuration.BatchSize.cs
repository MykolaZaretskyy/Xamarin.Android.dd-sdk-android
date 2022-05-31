using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Core.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='BatchSize']"
	[global::Android.Runtime.Register ("com/datadog/android/core/configuration/BatchSize", DoNotGenerateAcw=true)]
	public sealed partial class BatchSize : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='BatchSize']/field[@name='LARGE']"
		[Register ("LARGE")]
		public static global::Com.Datadog.Android.Core.Configuration.BatchSize Large {
			get {
				const string __id = "LARGE.Lcom/datadog/android/core/configuration/BatchSize;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.BatchSize> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='BatchSize']/field[@name='MEDIUM']"
		[Register ("MEDIUM")]
		public static global::Com.Datadog.Android.Core.Configuration.BatchSize Medium {
			get {
				const string __id = "MEDIUM.Lcom/datadog/android/core/configuration/BatchSize;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.BatchSize> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='BatchSize']/field[@name='SMALL']"
		[Register ("SMALL")]
		public static global::Com.Datadog.Android.Core.Configuration.BatchSize Small {
			get {
				const string __id = "SMALL.Lcom/datadog/android/core/configuration/BatchSize;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.BatchSize> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/core/configuration/BatchSize", typeof (BatchSize));

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

		internal BatchSize (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='BatchSize']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/android/core/configuration/BatchSize;", "")]
		public static unsafe global::Com.Datadog.Android.Core.Configuration.BatchSize ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/android/core/configuration/BatchSize;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.BatchSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='BatchSize']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/datadog/android/core/configuration/BatchSize;", "")]
		public static unsafe global::Com.Datadog.Android.Core.Configuration.BatchSize[] Values ()
		{
			const string __id = "values.()[Lcom/datadog/android/core/configuration/BatchSize;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Datadog.Android.Core.Configuration.BatchSize[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Android.Core.Configuration.BatchSize));
			} finally {
			}
		}

	}
}
