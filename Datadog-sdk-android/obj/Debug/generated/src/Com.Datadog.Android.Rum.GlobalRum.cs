using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='GlobalRum']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/GlobalRum", DoNotGenerateAcw=true)]
	public sealed partial class GlobalRum : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='GlobalRum']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Datadog.Android.Rum.GlobalRum Instance {
			get {
				const string __id = "INSTANCE.Lcom/datadog/android/rum/GlobalRum;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.GlobalRum> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/GlobalRum", typeof (GlobalRum));

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

		internal GlobalRum (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe bool IsRegistered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='GlobalRum']/method[@name='isRegistered' and count(parameter)=0]"
			[Register ("isRegistered", "()Z", "")]
			get {
				const string __id = "isRegistered.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='GlobalRum']/method[@name='addAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("addAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void AddAttribute (string key, global::Java.Lang.Object value)
		{
			const string __id = "addAttribute.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='GlobalRum']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/datadog/android/rum/RumMonitor;", "")]
		public static unsafe global::Com.Datadog.Android.Rum.IRumMonitor Get ()
		{
			const string __id = "get.()Lcom/datadog/android/rum/RumMonitor;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='GlobalRum']/method[@name='registerIfAbsent' and count(parameter)=1 and parameter[1][@type='com.datadog.android.rum.RumMonitor']]"
		[Register ("registerIfAbsent", "(Lcom/datadog/android/rum/RumMonitor;)Z", "")]
		public static unsafe bool RegisterIfAbsent (global::Com.Datadog.Android.Rum.IRumMonitor monitor)
		{
			const string __id = "registerIfAbsent.(Lcom/datadog/android/rum/RumMonitor;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((monitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monitor).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (monitor);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='GlobalRum']/method[@name='registerIfAbsent' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Callable&lt;com.datadog.android.rum.RumMonitor&gt;']]"
		[Register ("registerIfAbsent", "(Ljava/util/concurrent/Callable;)Z", "")]
		public static unsafe bool RegisterIfAbsent (global::Java.Util.Concurrent.ICallable provider)
		{
			const string __id = "registerIfAbsent.(Ljava/util/concurrent/Callable;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((provider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) provider).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (provider);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='GlobalRum']/method[@name='removeAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeAttribute", "(Ljava/lang/String;)V", "")]
		public static unsafe void RemoveAttribute (string key)
		{
			const string __id = "removeAttribute.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

	}
}
