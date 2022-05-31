using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/datadog/android/log/Logger", DoNotGenerateAcw=true)]
	public sealed partial class Logger : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger.Builder']"
		[global::Android.Runtime.Register ("com/datadog/android/log/Logger$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/log/Logger$Builder", typeof (Builder));

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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger.Builder']/constructor[@name='Logger.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/datadog/android/log/Logger;", "")]
			public unsafe global::Com.Datadog.Android.Log.Logger Build ()
			{
				const string __id = "build.()Lcom/datadog/android/log/Logger;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Log.Logger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger.Builder']/method[@name='setBundleWithRumEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBundleWithRumEnabled", "(Z)Lcom/datadog/android/log/Logger$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Log.Logger.Builder SetBundleWithRumEnabled (bool enabled)
			{
				const string __id = "setBundleWithRumEnabled.(Z)Lcom/datadog/android/log/Logger$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Log.Logger.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger.Builder']/method[@name='setBundleWithTraceEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBundleWithTraceEnabled", "(Z)Lcom/datadog/android/log/Logger$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Log.Logger.Builder SetBundleWithTraceEnabled (bool enabled)
			{
				const string __id = "setBundleWithTraceEnabled.(Z)Lcom/datadog/android/log/Logger$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Log.Logger.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger.Builder']/method[@name='setDatadogLogsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDatadogLogsEnabled", "(Z)Lcom/datadog/android/log/Logger$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Log.Logger.Builder SetDatadogLogsEnabled (bool enabled)
			{
				const string __id = "setDatadogLogsEnabled.(Z)Lcom/datadog/android/log/Logger$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Log.Logger.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger.Builder']/method[@name='setLogcatLogsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLogcatLogsEnabled", "(Z)Lcom/datadog/android/log/Logger$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Log.Logger.Builder SetLogcatLogsEnabled (bool enabled)
			{
				const string __id = "setLogcatLogsEnabled.(Z)Lcom/datadog/android/log/Logger$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Log.Logger.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger.Builder']/method[@name='setLoggerName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLoggerName", "(Ljava/lang/String;)Lcom/datadog/android/log/Logger$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Log.Logger.Builder SetLoggerName (string name)
			{
				const string __id = "setLoggerName.(Ljava/lang/String;)Lcom/datadog/android/log/Logger$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Log.Logger.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger.Builder']/method[@name='setNetworkInfoEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNetworkInfoEnabled", "(Z)Lcom/datadog/android/log/Logger$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Log.Logger.Builder SetNetworkInfoEnabled (bool enabled)
			{
				const string __id = "setNetworkInfoEnabled.(Z)Lcom/datadog/android/log/Logger$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Log.Logger.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger.Builder']/method[@name='setSampleRate' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSampleRate", "(F)Lcom/datadog/android/log/Logger$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Log.Logger.Builder SetSampleRate (float rate)
			{
				const string __id = "setSampleRate.(F)Lcom/datadog/android/log/Logger$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (rate);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Log.Logger.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger.Builder']/method[@name='setServiceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServiceName", "(Ljava/lang/String;)Lcom/datadog/android/log/Logger$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Log.Logger.Builder SetServiceName (string serviceName)
			{
				const string __id = "setServiceName.(Ljava/lang/String;)Lcom/datadog/android/log/Logger$Builder;";
				IntPtr native_serviceName = JNIEnv.NewString (serviceName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serviceName);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Log.Logger.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serviceName);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/log/Logger", typeof (Logger));

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

		internal Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='addAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("addAttribute", "(Ljava/lang/String;Z)V", "")]
		public unsafe void AddAttribute (string key, bool value)
		{
			const string __id = "addAttribute.(Ljava/lang/String;Z)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='addAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("addAttribute", "(Ljava/lang/String;D)V", "")]
		public unsafe void AddAttribute (string key, double value)
		{
			const string __id = "addAttribute.(Ljava/lang/String;D)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='addAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("addAttribute", "(Ljava/lang/String;F)V", "")]
		public unsafe void AddAttribute (string key, float value)
		{
			const string __id = "addAttribute.(Ljava/lang/String;F)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='addAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("addAttribute", "(Ljava/lang/String;I)V", "")]
		public unsafe void AddAttribute (string key, int value)
		{
			const string __id = "addAttribute.(Ljava/lang/String;I)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='addAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void AddAttribute (string key, string value)
		{
			const string __id = "addAttribute.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='addAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date']]"
		[Register ("addAttribute", "(Ljava/lang/String;Ljava/util/Date;)V", "")]
		public unsafe void AddAttribute (string key, global::Java.Util.Date value)
		{
			const string __id = "addAttribute.(Ljava/lang/String;Ljava/util/Date;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				global::System.GC.KeepAlive (value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='addAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("addAttribute", "(Ljava/lang/String;J)V", "")]
		public unsafe void AddAttribute (string key, long value)
		{
			const string __id = "addAttribute.(Ljava/lang/String;J)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='addTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addTag", "(Ljava/lang/String;)V", "")]
		public unsafe void AddTag (string tag)
		{
			const string __id = "addTag.(Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tag);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='addTag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addTag", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void AddTag (string key, string value)
		{
			const string __id = "addTag.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)V", "")]
		public unsafe void D (string message)
		{
			const string __id = "d.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe void D (string message, global::Java.Lang.Throwable throwable)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V", "")]
		public unsafe void D (string message, global::Java.Lang.Throwable throwable, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [2] = new JniArgumentValue (native_attributes);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_attributes);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (attributes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)V", "")]
		public unsafe void E (string message)
		{
			const string __id = "e.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe void E (string message, global::Java.Lang.Throwable throwable)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V", "")]
		public unsafe void E (string message, global::Java.Lang.Throwable throwable, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [2] = new JniArgumentValue (native_attributes);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_attributes);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (attributes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;)V", "")]
		public unsafe void I (string message)
		{
			const string __id = "i.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe void I (string message, global::Java.Lang.Throwable throwable)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V", "")]
		public unsafe void I (string message, global::Java.Lang.Throwable throwable, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [2] = new JniArgumentValue (native_attributes);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_attributes);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (attributes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("log", "(ILjava/lang/String;)V", "")]
		public unsafe void Log (int priority, string message)
		{
			const string __id = "log.(ILjava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (priority);
				__args [1] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='log' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("log", "(ILjava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe void Log (int priority, string message, global::Java.Lang.Throwable throwable)
		{
			const string __id = "log.(ILjava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (priority);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='log' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable'] and parameter[4][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("log", "(ILjava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V", "")]
		public unsafe void Log (int priority, string message, global::Java.Lang.Throwable throwable, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			const string __id = "log.(ILjava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (priority);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [3] = new JniArgumentValue (native_attributes);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_attributes);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (attributes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='removeAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeAttribute", "(Ljava/lang/String;)V", "")]
		public unsafe void RemoveAttribute (string key)
		{
			const string __id = "removeAttribute.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='removeTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeTag", "(Ljava/lang/String;)V", "")]
		public unsafe void RemoveTag (string tag)
		{
			const string __id = "removeTag.(Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tag);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='removeTagsWithKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeTagsWithKey", "(Ljava/lang/String;)V", "")]
		public unsafe void RemoveTagsWithKey (string key)
		{
			const string __id = "removeTagsWithKey.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;)V", "")]
		public unsafe void V (string message)
		{
			const string __id = "v.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe void V (string message, global::Java.Lang.Throwable throwable)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V", "")]
		public unsafe void V (string message, global::Java.Lang.Throwable throwable, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [2] = new JniArgumentValue (native_attributes);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_attributes);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (attributes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;)V", "")]
		public unsafe void W (string message)
		{
			const string __id = "w.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe void W (string message, global::Java.Lang.Throwable throwable)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V", "")]
		public unsafe void W (string message, global::Java.Lang.Throwable throwable, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [2] = new JniArgumentValue (native_attributes);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_attributes);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (attributes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='wtf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("wtf", "(Ljava/lang/String;)V", "")]
		public unsafe void Wtf (string message)
		{
			const string __id = "wtf.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='wtf' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("wtf", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe void Wtf (string message, global::Java.Lang.Throwable throwable)
		{
			const string __id = "wtf.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (throwable);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.log']/class[@name='Logger']/method[@name='wtf' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("wtf", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V", "")]
		public unsafe void Wtf (string message, global::Java.Lang.Throwable throwable, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			const string __id = "wtf.(Ljava/lang/String;Ljava/lang/Throwable;Ljava/util/Map;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [2] = new JniArgumentValue (native_attributes);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_attributes);
				global::System.GC.KeepAlive (throwable);
				global::System.GC.KeepAlive (attributes);
			}
		}

	}
}
