using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Core.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']"
	[global::Android.Runtime.Register ("com/datadog/android/core/configuration/Credentials", DoNotGenerateAcw=true)]
	public sealed partial class Credentials : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/core/configuration/Credentials", typeof (Credentials));

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

		internal Credentials (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']/constructor[@name='Credentials' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Credentials (string clientToken, string envName, string variant, string rumApplicationId, string serviceName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_clientToken = JNIEnv.NewString (clientToken);
			IntPtr native_envName = JNIEnv.NewString (envName);
			IntPtr native_variant = JNIEnv.NewString (variant);
			IntPtr native_rumApplicationId = JNIEnv.NewString (rumApplicationId);
			IntPtr native_serviceName = JNIEnv.NewString (serviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_clientToken);
				__args [1] = new JniArgumentValue (native_envName);
				__args [2] = new JniArgumentValue (native_variant);
				__args [3] = new JniArgumentValue (native_rumApplicationId);
				__args [4] = new JniArgumentValue (native_serviceName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientToken);
				JNIEnv.DeleteLocalRef (native_envName);
				JNIEnv.DeleteLocalRef (native_variant);
				JNIEnv.DeleteLocalRef (native_rumApplicationId);
				JNIEnv.DeleteLocalRef (native_serviceName);
			}
		}

		public unsafe string ClientToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']/method[@name='getClientToken' and count(parameter)=0]"
			[Register ("getClientToken", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getClientToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string EnvName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']/method[@name='getEnvName' and count(parameter)=0]"
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

		public unsafe string RumApplicationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']/method[@name='getRumApplicationId' and count(parameter)=0]"
			[Register ("getRumApplicationId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getRumApplicationId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ServiceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']/method[@name='getServiceName' and count(parameter)=0]"
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

		public unsafe string Variant {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']/method[@name='getVariant' and count(parameter)=0]"
			[Register ("getVariant", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getVariant.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']/method[@name='component1' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']/method[@name='component2' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']/method[@name='component3' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Ljava/lang/String;", "")]
		public unsafe string Component4 ()
		{
			const string __id = "component4.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()Ljava/lang/String;", "")]
		public unsafe string Component5 ()
		{
			const string __id = "component5.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Credentials']/method[@name='copy' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/core/configuration/Credentials;", "")]
		public unsafe global::Com.Datadog.Android.Core.Configuration.Credentials Copy (string clientToken, string envName, string variant, string rumApplicationId, string serviceName)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/datadog/android/core/configuration/Credentials;";
			IntPtr native_clientToken = JNIEnv.NewString (clientToken);
			IntPtr native_envName = JNIEnv.NewString (envName);
			IntPtr native_variant = JNIEnv.NewString (variant);
			IntPtr native_rumApplicationId = JNIEnv.NewString (rumApplicationId);
			IntPtr native_serviceName = JNIEnv.NewString (serviceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_clientToken);
				__args [1] = new JniArgumentValue (native_envName);
				__args [2] = new JniArgumentValue (native_variant);
				__args [3] = new JniArgumentValue (native_rumApplicationId);
				__args [4] = new JniArgumentValue (native_serviceName);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Credentials> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientToken);
				JNIEnv.DeleteLocalRef (native_envName);
				JNIEnv.DeleteLocalRef (native_variant);
				JNIEnv.DeleteLocalRef (native_rumApplicationId);
				JNIEnv.DeleteLocalRef (native_serviceName);
			}
		}

	}
}
