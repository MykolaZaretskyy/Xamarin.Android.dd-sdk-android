using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Opentracing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='DDTraceOTInfo']"
	[global::Android.Runtime.Register ("com/datadog/opentracing/DDTraceOTInfo", DoNotGenerateAcw=true)]
	public partial class DDTraceOTInfo : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='DDTraceOTInfo']/field[@name='JAVA_VERSION']"
		[Register ("JAVA_VERSION")]
		public static string JavaVersion {
			get {
				const string __id = "JAVA_VERSION.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='DDTraceOTInfo']/field[@name='JAVA_VM_NAME']"
		[Register ("JAVA_VM_NAME")]
		public static string JavaVmName {
			get {
				const string __id = "JAVA_VM_NAME.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='DDTraceOTInfo']/field[@name='JAVA_VM_VENDOR']"
		[Register ("JAVA_VM_VENDOR")]
		public static string JavaVmVendor {
			get {
				const string __id = "JAVA_VM_VENDOR.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='DDTraceOTInfo']/field[@name='VERSION']"
		[Register ("VERSION")]
		public static string Version {
			get {
				const string __id = "VERSION.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/opentracing/DDTraceOTInfo", typeof (DDTraceOTInfo));

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

		protected DDTraceOTInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='DDTraceOTInfo']/constructor[@name='DDTraceOTInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DDTraceOTInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.opentracing']/class[@name='DDTraceOTInfo']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (params string[] args)
		{
			const string __id = "main.([Ljava/lang/String;)V";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_args);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (args);
			}
		}

	}
}
