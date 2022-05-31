using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']"
	[global::Android.Runtime.Register ("com/datadog/android/Datadog", DoNotGenerateAcw=true)]
	public sealed partial class Datadog : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/field[@name='ENV_NAME_VALIDATION_REG_EX']"
		[Register ("ENV_NAME_VALIDATION_REG_EX")]
		public const string EnvNameValidationRegEx = (string) "[a-zA-Z0-9_:./-]{0,195}[a-zA-Z0-9_./-]";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Datadog.Android.Datadog Instance {
			get {
				const string __id = "INSTANCE.Lcom/datadog/android/Datadog;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Datadog> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/field[@name='MESSAGE_ALREADY_INITIALIZED']"
		[Register ("MESSAGE_ALREADY_INITIALIZED")]
		public const string MessageAlreadyInitialized = (string) "The Datadog library has already been initialized.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/field[@name='MESSAGE_DEPRECATED']"
		[Register ("MESSAGE_DEPRECATED")]
		public const string MessageDeprecated = (string) "%s has been deprecated. If you need it, submit an issue at https://github.com/DataDog/dd-sdk-android/issues/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/field[@name='MESSAGE_ENV_NAME_NOT_VALID']"
		[Register ("MESSAGE_ENV_NAME_NOT_VALID")]
		public const string MessageEnvNameNotValid = (string) "The environment name should contain maximum 196 of the following allowed characters [a-zA-Z0-9_:./-] and should never finish with a semicolon.In this case the Datadog SDK will not be initialised.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/field[@name='MESSAGE_NOT_INITIALIZED']"
		[Register ("MESSAGE_NOT_INITIALIZED")]
		public const string MessageNotInitialized = (string) "Datadog has not been initialized.\u000aPlease add the following code in your application's onCreate() method:\u000aval credentials = Credentials(\"<CLIENT_TOKEN>\", \"<ENVIRONMENT>\", \"<VARIANT>\", \"<APPLICATION_ID>\")\u000aDatadog.initialize(context, credentials, configuration, trackingConsent);";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/field[@name='SHUTDOWN_THREAD']"
		[Register ("SHUTDOWN_THREAD")]
		public const string ShutdownThread = (string) "datadog_shutdown";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/field[@name='WARNING_MESSAGE_APPLICATION_ID_IS_NULL']"
		[Register ("WARNING_MESSAGE_APPLICATION_ID_IS_NULL")]
		public const string WarningMessageApplicationIdIsNull = (string) "You're trying to enable RUM but no Application Id was provided. Please pass this value into the Datadog Credentials:\u000aval credentials = Credentials(\"<CLIENT_TOKEN>\", \"<ENVIRONMENT>\", \"<VARIANT>\", \"<APPLICATION_ID>\")\u000aDatadog.initialize(context, credentials, configuration, trackingConsent);";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/Datadog", typeof (Datadog));

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

		internal Datadog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "")]
			get {
				const string __id = "isInitialized.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/method[@name='clearAllData' and count(parameter)=0]"
		[Register ("clearAllData", "()V", "")]
		public unsafe void ClearAllData ()
		{
			const string __id = "clearAllData.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/method[@name='initialize' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.datadog.android.core.configuration.Credentials'] and parameter[3][@type='com.datadog.android.core.configuration.Configuration'] and parameter[4][@type='com.datadog.android.privacy.TrackingConsent']]"
		[Register ("initialize", "(Landroid/content/Context;Lcom/datadog/android/core/configuration/Credentials;Lcom/datadog/android/core/configuration/Configuration;Lcom/datadog/android/privacy/TrackingConsent;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context context, global::Com.Datadog.Android.Core.Configuration.Credentials credentials, global::Com.Datadog.Android.Core.Configuration.Configuration configuration, global::Com.Datadog.Android.Privacy.TrackingConsent trackingConsent)
		{
			const string __id = "initialize.(Landroid/content/Context;Lcom/datadog/android/core/configuration/Credentials;Lcom/datadog/android/core/configuration/Configuration;Lcom/datadog/android/privacy/TrackingConsent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((credentials == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentials).Handle);
				__args [2] = new JniArgumentValue ((configuration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configuration).Handle);
				__args [3] = new JniArgumentValue ((trackingConsent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackingConsent).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (credentials);
				global::System.GC.KeepAlive (configuration);
				global::System.GC.KeepAlive (trackingConsent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.datadog.android.DatadogConfig']]"
		[Obsolete (@"deprecated")]
		[Register ("initialize", "(Landroid/content/Context;Lcom/datadog/android/DatadogConfig;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context context, global::Com.Datadog.Android.DatadogConfig config)
		{
			const string __id = "initialize.(Landroid/content/Context;Lcom/datadog/android/DatadogConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (config);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.datadog.android.privacy.TrackingConsent'] and parameter[3][@type='com.datadog.android.DatadogConfig']]"
		[Obsolete (@"deprecated")]
		[Register ("initialize", "(Landroid/content/Context;Lcom/datadog/android/privacy/TrackingConsent;Lcom/datadog/android/DatadogConfig;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context context, global::Com.Datadog.Android.Privacy.TrackingConsent trackingConsent, global::Com.Datadog.Android.DatadogConfig config)
		{
			const string __id = "initialize.(Landroid/content/Context;Lcom/datadog/android/privacy/TrackingConsent;Lcom/datadog/android/DatadogConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((trackingConsent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackingConsent).Handle);
				__args [2] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (trackingConsent);
				global::System.GC.KeepAlive (config);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/method[@name='setTrackingConsent' and count(parameter)=1 and parameter[1][@type='com.datadog.android.privacy.TrackingConsent']]"
		[Register ("setTrackingConsent", "(Lcom/datadog/android/privacy/TrackingConsent;)V", "")]
		public unsafe void SetTrackingConsent (global::Com.Datadog.Android.Privacy.TrackingConsent consent)
		{
			const string __id = "setTrackingConsent.(Lcom/datadog/android/privacy/TrackingConsent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consent).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (consent);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/method[@name='setUserInfo' and count(parameter)=0]"
		[Register ("setUserInfo", "()V", "")]
		public static unsafe void SetUserInfo ()
		{
			const string __id = "setUserInfo.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/method[@name='setUserInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUserInfo", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetUserInfo (string id)
		{
			const string __id = "setUserInfo.(Ljava/lang/String;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/method[@name='setUserInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setUserInfo", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetUserInfo (string id, string name)
		{
			const string __id = "setUserInfo.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_name);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/method[@name='setUserInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setUserInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetUserInfo (string id, string name, string email)
		{
			const string __id = "setUserInfo.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_email = JNIEnv.NewString (email);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (native_email);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_email);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/method[@name='setUserInfo' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("setUserInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static unsafe void SetUserInfo (string id, string name, string email, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> extraInfo)
		{
			const string __id = "setUserInfo.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_email = JNIEnv.NewString (email);
			IntPtr native_extraInfo = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (extraInfo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (native_email);
				__args [3] = new JniArgumentValue (native_extraInfo);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_email);
				JNIEnv.DeleteLocalRef (native_extraInfo);
				global::System.GC.KeepAlive (extraInfo);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='Datadog']/method[@name='setVerbosity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setVerbosity", "(I)V", "")]
		public static unsafe void SetVerbosity (int level)
		{
			const string __id = "setVerbosity.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (level);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
