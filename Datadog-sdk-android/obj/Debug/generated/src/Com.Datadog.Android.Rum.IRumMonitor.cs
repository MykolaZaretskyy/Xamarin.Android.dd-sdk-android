using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumMonitor.Builder']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/RumMonitor$Builder", DoNotGenerateAcw=true)]
	public sealed partial class RumMonitorBuilder : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumMonitor.Builder']/field[@name='RUM_NOT_ENABLED_ERROR_MESSAGE']"
		[Register ("RUM_NOT_ENABLED_ERROR_MESSAGE")]
		public const string RumNotEnabledErrorMessage = (string) "You're trying to create a RumMonitor instance, but the RUM feature was disabled in your DatadogConfig. No RUM data will be sent.";

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumMonitor.Builder.Companion']"
		[global::Android.Runtime.Register ("com/datadog/android/rum/RumMonitor$Builder$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/RumMonitor$Builder$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumMonitor.Builder.Companion']/constructor[@name='RumMonitor.Builder.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
			[Register (".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe Companion (global::Kotlin.Jvm.Internal.DefaultConstructorMarker _constructor_marker) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((_constructor_marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _constructor_marker).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (_constructor_marker);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/RumMonitor$Builder", typeof (RumMonitorBuilder));

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

		internal RumMonitorBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumMonitor.Builder']/constructor[@name='RumMonitor.Builder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RumMonitorBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumMonitor.Builder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/datadog/android/rum/RumMonitor;", "")]
		public unsafe global::Com.Datadog.Android.Rum.IRumMonitor Build ()
		{
			const string __id = "build.()Lcom/datadog/android/rum/RumMonitor;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumMonitor.Builder']/method[@name='sampleRumSessions' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("sampleRumSessions", "(F)Lcom/datadog/android/rum/RumMonitor$Builder;", "")]
		public unsafe global::Com.Datadog.Android.Rum.RumMonitorBuilder SampleRumSessions (float samplingRate)
		{
			const string __id = "sampleRumSessions.(F)Lcom/datadog/android/rum/RumMonitor$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (samplingRate);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumMonitorBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumMonitor.DefaultImpls']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/RumMonitor$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class RumMonitorDefaultImpls : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/RumMonitor$DefaultImpls", typeof (RumMonitorDefaultImpls));

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

		internal RumMonitorDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']"
	[Register ("com/datadog/android/rum/RumMonitor", "", "Com.Datadog.Android.Rum.IRumMonitorInvoker")]
	public partial interface IRumMonitor : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']/method[@name='addError' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.RumErrorSource'] and parameter[3][@type='java.lang.Throwable'] and parameter[4][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("addError", "(Ljava/lang/String;Lcom/datadog/android/rum/RumErrorSource;Ljava/lang/Throwable;Ljava/util/Map;)V", "GetAddError_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Ljava_util_Map_Handler:Com.Datadog.Android.Rum.IRumMonitorInvoker, Datadog_sdk_android")]
		void AddError (string message, global::Com.Datadog.Android.Rum.RumErrorSource source, global::Java.Lang.Throwable throwable, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']/method[@name='addErrorWithStacktrace' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.datadog.android.rum.RumErrorSource'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("addErrorWithStacktrace", "(Ljava/lang/String;Lcom/datadog/android/rum/RumErrorSource;Ljava/lang/String;Ljava/util/Map;)V", "GetAddErrorWithStacktrace_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_String_Ljava_util_Map_Handler:Com.Datadog.Android.Rum.IRumMonitorInvoker, Datadog_sdk_android")]
		void AddErrorWithStacktrace (string message, global::Com.Datadog.Android.Rum.RumErrorSource source, string stacktrace, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']/method[@name='addTiming' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addTiming", "(Ljava/lang/String;)V", "GetAddTiming_Ljava_lang_String_Handler:Com.Datadog.Android.Rum.IRumMonitorInvoker, Datadog_sdk_android")]
		void AddTiming (string name);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']/method[@name='addUserAction' and count(parameter)=3 and parameter[1][@type='com.datadog.android.rum.RumActionType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("addUserAction", "(Lcom/datadog/android/rum/RumActionType;Ljava/lang/String;Ljava/util/Map;)V", "GetAddUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_Handler:Com.Datadog.Android.Rum.IRumMonitorInvoker, Datadog_sdk_android")]
		void AddUserAction (global::Com.Datadog.Android.Rum.RumActionType type, string name, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']/method[@name='startResource' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("startResource", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetStartResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler:Com.Datadog.Android.Rum.IRumMonitorInvoker, Datadog_sdk_android")]
		void StartResource (string key, string method, string url, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']/method[@name='startUserAction' and count(parameter)=3 and parameter[1][@type='com.datadog.android.rum.RumActionType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("startUserAction", "(Lcom/datadog/android/rum/RumActionType;Ljava/lang/String;Ljava/util/Map;)V", "GetStartUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_Handler:Com.Datadog.Android.Rum.IRumMonitorInvoker, Datadog_sdk_android")]
		void StartUserAction (global::Com.Datadog.Android.Rum.RumActionType type, string name, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']/method[@name='startView' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("startView", "(Ljava/lang/Object;Ljava/lang/String;Ljava/util/Map;)V", "GetStartView_Ljava_lang_Object_Ljava_lang_String_Ljava_util_Map_Handler:Com.Datadog.Android.Rum.IRumMonitorInvoker, Datadog_sdk_android")]
		void StartView (global::Java.Lang.Object key, string name, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']/method[@name='stopResource' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='com.datadog.android.rum.RumResourceKind'] and parameter[5][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("stopResource", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Long;Lcom/datadog/android/rum/RumResourceKind;Ljava/util/Map;)V", "GetStopResource_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Lcom_datadog_android_rum_RumResourceKind_Ljava_util_Map_Handler:Com.Datadog.Android.Rum.IRumMonitorInvoker, Datadog_sdk_android")]
		void StopResource (string p0, global::Java.Lang.Integer p1, global::Java.Lang.Long p2, global::Com.Datadog.Android.Rum.RumResourceKind p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']/method[@name='stopResourceWithError' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.datadog.android.rum.RumErrorSource'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("stopResourceWithError", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Lcom/datadog/android/rum/RumErrorSource;Ljava/lang/Throwable;)V", "GetStopResourceWithError_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Handler:Com.Datadog.Android.Rum.IRumMonitorInvoker, Datadog_sdk_android")]
		void StopResourceWithError (string p0, global::Java.Lang.Integer p1, string p2, global::Com.Datadog.Android.Rum.RumErrorSource p3, global::Java.Lang.Throwable p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']/method[@name='stopUserAction' and count(parameter)=3 and parameter[1][@type='com.datadog.android.rum.RumActionType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("stopUserAction", "(Lcom/datadog/android/rum/RumActionType;Ljava/lang/String;Ljava/util/Map;)V", "GetStopUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_Handler:Com.Datadog.Android.Rum.IRumMonitorInvoker, Datadog_sdk_android")]
		void StopUserAction (global::Com.Datadog.Android.Rum.RumActionType type, string name, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']/method[@name='stopUserAction' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("stopUserAction", "(Ljava/util/Map;)V", "GetStopUserAction_Ljava_util_Map_Handler:Com.Datadog.Android.Rum.IRumMonitorInvoker, Datadog_sdk_android")]
		void StopUserAction (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.rum']/interface[@name='RumMonitor']/method[@name='stopView' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("stopView", "(Ljava/lang/Object;Ljava/util/Map;)V", "GetStopView_Ljava_lang_Object_Ljava_util_Map_Handler:Com.Datadog.Android.Rum.IRumMonitorInvoker, Datadog_sdk_android")]
		void StopView (global::Java.Lang.Object key, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes);

	}

	[global::Android.Runtime.Register ("com/datadog/android/rum/RumMonitor", DoNotGenerateAcw=true)]
	internal partial class IRumMonitorInvoker : global::Java.Lang.Object, IRumMonitor {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/RumMonitor", typeof (IRumMonitorInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IRumMonitor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRumMonitor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.datadog.android.rum.RumMonitor'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRumMonitorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addError_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAddError_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Ljava_util_Map_Handler ()
		{
			if (cb_addError_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Ljava_util_Map_ == null)
				cb_addError_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_AddError_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Ljava_util_Map_);
			return cb_addError_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Ljava_util_Map_;
		}

		static void n_AddError_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_source, IntPtr native_throwable, IntPtr native_attributes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumErrorSource> (native_source, JniHandleOwnership.DoNotTransfer);
			var throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			__this.AddError (message, source, throwable, attributes);
		}
#pragma warning restore 0169

		IntPtr id_addError_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Ljava_util_Map_;
		public unsafe void AddError (string message, global::Com.Datadog.Android.Rum.RumErrorSource source, global::Java.Lang.Throwable throwable, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			if (id_addError_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Ljava_util_Map_ == IntPtr.Zero)
				id_addError_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "addError", "(Ljava/lang/String;Lcom/datadog/android/rum/RumErrorSource;Ljava/lang/Throwable;Ljava/util/Map;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_message);
			__args [1] = new JValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
			__args [2] = new JValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
			__args [3] = new JValue (native_attributes);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addError_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_message);
			JNIEnv.DeleteLocalRef (native_attributes);
		}

		static Delegate cb_addErrorWithStacktrace_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAddErrorWithStacktrace_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_addErrorWithStacktrace_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_addErrorWithStacktrace_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_AddErrorWithStacktrace_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_String_Ljava_util_Map_);
			return cb_addErrorWithStacktrace_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_AddErrorWithStacktrace_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_source, IntPtr native_stacktrace, IntPtr native_attributes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			var source = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumErrorSource> (native_source, JniHandleOwnership.DoNotTransfer);
			var stacktrace = JNIEnv.GetString (native_stacktrace, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			__this.AddErrorWithStacktrace (message, source, stacktrace, attributes);
		}
#pragma warning restore 0169

		IntPtr id_addErrorWithStacktrace_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void AddErrorWithStacktrace (string message, global::Com.Datadog.Android.Rum.RumErrorSource source, string stacktrace, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			if (id_addErrorWithStacktrace_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_addErrorWithStacktrace_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "addErrorWithStacktrace", "(Ljava/lang/String;Lcom/datadog/android/rum/RumErrorSource;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_stacktrace = JNIEnv.NewString (stacktrace);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_message);
			__args [1] = new JValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
			__args [2] = new JValue (native_stacktrace);
			__args [3] = new JValue (native_attributes);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addErrorWithStacktrace_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_message);
			JNIEnv.DeleteLocalRef (native_stacktrace);
			JNIEnv.DeleteLocalRef (native_attributes);
		}

		static Delegate cb_addTiming_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddTiming_Ljava_lang_String_Handler ()
		{
			if (cb_addTiming_Ljava_lang_String_ == null)
				cb_addTiming_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddTiming_Ljava_lang_String_);
			return cb_addTiming_Ljava_lang_String_;
		}

		static void n_AddTiming_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.AddTiming (name);
		}
#pragma warning restore 0169

		IntPtr id_addTiming_Ljava_lang_String_;
		public unsafe void AddTiming (string name)
		{
			if (id_addTiming_Ljava_lang_String_ == IntPtr.Zero)
				id_addTiming_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addTiming", "(Ljava/lang/String;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_name);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTiming_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_name);
		}

		static Delegate cb_addUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAddUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_addUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_addUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AddUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_);
			return cb_addUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_AddUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_name, IntPtr native_attributes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumActionType> (native_type, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			__this.AddUserAction (type, name, attributes);
		}
#pragma warning restore 0169

		IntPtr id_addUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void AddUserAction (global::Com.Datadog.Android.Rum.RumActionType type, string name, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			if (id_addUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_addUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "addUserAction", "(Lcom/datadog/android/rum/RumActionType;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
			__args [1] = new JValue (native_name);
			__args [2] = new JValue (native_attributes);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_name);
			JNIEnv.DeleteLocalRef (native_attributes);
		}

		static Delegate cb_startResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStartResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_startResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_startResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_StartResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_startResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_StartResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_method, IntPtr native_url, IntPtr native_attributes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var method = JNIEnv.GetString (native_method, JniHandleOwnership.DoNotTransfer);
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			__this.StartResource (key, method, url, attributes);
		}
#pragma warning restore 0169

		IntPtr id_startResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void StartResource (string key, string method, string url, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			if (id_startResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_startResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "startResource", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_method = JNIEnv.NewString (method);
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_key);
			__args [1] = new JValue (native_method);
			__args [2] = new JValue (native_url);
			__args [3] = new JValue (native_attributes);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startResource_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_key);
			JNIEnv.DeleteLocalRef (native_method);
			JNIEnv.DeleteLocalRef (native_url);
			JNIEnv.DeleteLocalRef (native_attributes);
		}

		static Delegate cb_startUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStartUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_startUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_startUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_StartUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_);
			return cb_startUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_StartUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_name, IntPtr native_attributes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumActionType> (native_type, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			__this.StartUserAction (type, name, attributes);
		}
#pragma warning restore 0169

		IntPtr id_startUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void StartUserAction (global::Com.Datadog.Android.Rum.RumActionType type, string name, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			if (id_startUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_startUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "startUserAction", "(Lcom/datadog/android/rum/RumActionType;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
			__args [1] = new JValue (native_name);
			__args [2] = new JValue (native_attributes);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_name);
			JNIEnv.DeleteLocalRef (native_attributes);
		}

		static Delegate cb_startView_Ljava_lang_Object_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStartView_Ljava_lang_Object_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_startView_Ljava_lang_Object_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_startView_Ljava_lang_Object_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_StartView_Ljava_lang_Object_Ljava_lang_String_Ljava_util_Map_);
			return cb_startView_Ljava_lang_Object_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_StartView_Ljava_lang_Object_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_name, IntPtr native_attributes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			__this.StartView (key, name, attributes);
		}
#pragma warning restore 0169

		IntPtr id_startView_Ljava_lang_Object_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void StartView (global::Java.Lang.Object key, string name, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			if (id_startView_Ljava_lang_Object_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_startView_Ljava_lang_Object_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "startView", "(Ljava/lang/Object;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
			__args [1] = new JValue (native_name);
			__args [2] = new JValue (native_attributes);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startView_Ljava_lang_Object_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_name);
			JNIEnv.DeleteLocalRef (native_attributes);
		}

		static Delegate cb_stopResource_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Lcom_datadog_android_rum_RumResourceKind_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStopResource_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Lcom_datadog_android_rum_RumResourceKind_Ljava_util_Map_Handler ()
		{
			if (cb_stopResource_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Lcom_datadog_android_rum_RumResourceKind_Ljava_util_Map_ == null)
				cb_stopResource_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Lcom_datadog_android_rum_RumResourceKind_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_V) n_StopResource_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Lcom_datadog_android_rum_RumResourceKind_Ljava_util_Map_);
			return cb_stopResource_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Lcom_datadog_android_rum_RumResourceKind_Ljava_util_Map_;
		}

		static void n_StopResource_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Lcom_datadog_android_rum_RumResourceKind_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumResourceKind> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.StopResource (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_stopResource_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Lcom_datadog_android_rum_RumResourceKind_Ljava_util_Map_;
		public unsafe void StopResource (string p0, global::Java.Lang.Integer p1, global::Java.Lang.Long p2, global::Com.Datadog.Android.Rum.RumResourceKind p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p4)
		{
			if (id_stopResource_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Lcom_datadog_android_rum_RumResourceKind_Ljava_util_Map_ == IntPtr.Zero)
				id_stopResource_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Lcom_datadog_android_rum_RumResourceKind_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stopResource", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Long;Lcom/datadog/android/rum/RumResourceKind;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopResource_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_Long_Lcom_datadog_android_rum_RumResourceKind_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_stopResourceWithError_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetStopResourceWithError_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_Handler ()
		{
			if (cb_stopResourceWithError_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_ == null)
				cb_stopResourceWithError_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_V) n_StopResourceWithError_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_);
			return cb_stopResourceWithError_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_;
		}

		static void n_StopResourceWithError_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumErrorSource> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.StopResourceWithError (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_stopResourceWithError_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_;
		public unsafe void StopResourceWithError (string p0, global::Java.Lang.Integer p1, string p2, global::Com.Datadog.Android.Rum.RumErrorSource p3, global::Java.Lang.Throwable p4)
		{
			if (id_stopResourceWithError_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_stopResourceWithError_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "stopResourceWithError", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;Lcom/datadog/android/rum/RumErrorSource;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopResourceWithError_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Lcom_datadog_android_rum_RumErrorSource_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_stopUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStopUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_stopUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_stopUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_StopUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_);
			return cb_stopUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_StopUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_name, IntPtr native_attributes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumActionType> (native_type, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			__this.StopUserAction (type, name, attributes);
		}
#pragma warning restore 0169

		IntPtr id_stopUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_;
		public unsafe void StopUserAction (global::Com.Datadog.Android.Rum.RumActionType type, string name, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			if (id_stopUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_stopUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stopUserAction", "(Lcom/datadog/android/rum/RumActionType;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
			__args [1] = new JValue (native_name);
			__args [2] = new JValue (native_attributes);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopUserAction_Lcom_datadog_android_rum_RumActionType_Ljava_lang_String_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_name);
			JNIEnv.DeleteLocalRef (native_attributes);
		}

		static Delegate cb_stopUserAction_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStopUserAction_Ljava_util_Map_Handler ()
		{
			if (cb_stopUserAction_Ljava_util_Map_ == null)
				cb_stopUserAction_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StopUserAction_Ljava_util_Map_);
			return cb_stopUserAction_Ljava_util_Map_;
		}

		static void n_StopUserAction_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attributes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			__this.StopUserAction (attributes);
		}
#pragma warning restore 0169

		IntPtr id_stopUserAction_Ljava_util_Map_;
		public unsafe void StopUserAction (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			if (id_stopUserAction_Ljava_util_Map_ == IntPtr.Zero)
				id_stopUserAction_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stopUserAction", "(Ljava/util/Map;)V");
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_attributes);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopUserAction_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_attributes);
		}

		static Delegate cb_stopView_Ljava_lang_Object_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStopView_Ljava_lang_Object_Ljava_util_Map_Handler ()
		{
			if (cb_stopView_Ljava_lang_Object_Ljava_util_Map_ == null)
				cb_stopView_Ljava_lang_Object_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_StopView_Ljava_lang_Object_Ljava_util_Map_);
			return cb_stopView_Ljava_lang_Object_Ljava_util_Map_;
		}

		static void n_StopView_Ljava_lang_Object_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_attributes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.IRumMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			var attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_attributes, JniHandleOwnership.DoNotTransfer);
			__this.StopView (key, attributes);
		}
#pragma warning restore 0169

		IntPtr id_stopView_Ljava_lang_Object_Ljava_util_Map_;
		public unsafe void StopView (global::Java.Lang.Object key, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> attributes)
		{
			if (id_stopView_Ljava_lang_Object_Ljava_util_Map_ == IntPtr.Zero)
				id_stopView_Ljava_lang_Object_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "stopView", "(Ljava/lang/Object;Ljava/util/Map;)V");
			IntPtr native_attributes = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (attributes);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
			__args [1] = new JValue (native_attributes);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopView_Ljava_lang_Object_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_attributes);
		}

	}
}
