using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Plugin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogRumContext']"
	[global::Android.Runtime.Register ("com/datadog/android/plugin/DatadogRumContext", DoNotGenerateAcw=true)]
	public sealed partial class DatadogRumContext : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/plugin/DatadogRumContext", typeof (DatadogRumContext));

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

		internal DatadogRumContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogRumContext']/constructor[@name='DatadogRumContext' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DatadogRumContext () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogRumContext']/constructor[@name='DatadogRumContext' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe DatadogRumContext (string applicationId, string sessionId, string viewId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_applicationId = JNIEnv.NewString (applicationId);
			IntPtr native_sessionId = JNIEnv.NewString (sessionId);
			IntPtr native_viewId = JNIEnv.NewString (viewId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_applicationId);
				__args [1] = new JniArgumentValue (native_sessionId);
				__args [2] = new JniArgumentValue (native_viewId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationId);
				JNIEnv.DeleteLocalRef (native_sessionId);
				JNIEnv.DeleteLocalRef (native_viewId);
			}
		}

		public unsafe string ApplicationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogRumContext']/method[@name='getApplicationId' and count(parameter)=0]"
			[Register ("getApplicationId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getApplicationId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogRumContext']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSessionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ViewId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogRumContext']/method[@name='getViewId' and count(parameter)=0]"
			[Register ("getViewId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getViewId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogRumContext']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/lang/String;", "")]
		public unsafe string Component1 ()
		{
			const string __id = "component1.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogRumContext']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/lang/String;", "")]
		public unsafe string Component2 ()
		{
			const string __id = "component2.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogRumContext']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/lang/String;", "")]
		public unsafe string Component3 ()
		{
			const string __id = "component3.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.plugin']/class[@name='DatadogRumContext']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/plugin/DatadogRumContext;", "")]
		public unsafe global::Com.Datadog.Android.Plugin.DatadogRumContext Copy (string applicationId, string sessionId, string viewId)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/plugin/DatadogRumContext;";
			IntPtr native_applicationId = JNIEnv.NewString (applicationId);
			IntPtr native_sessionId = JNIEnv.NewString (sessionId);
			IntPtr native_viewId = JNIEnv.NewString (viewId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_applicationId);
				__args [1] = new JniArgumentValue (native_sessionId);
				__args [2] = new JniArgumentValue (native_viewId);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Plugin.DatadogRumContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_applicationId);
				JNIEnv.DeleteLocalRef (native_sessionId);
				JNIEnv.DeleteLocalRef (native_viewId);
			}
		}

	}
}
