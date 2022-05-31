using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/datadog/android/DatadogConfig", DoNotGenerateAcw=true)]
	public sealed partial class DatadogConfig : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[global::Android.Runtime.Register ("com/datadog/android/DatadogConfig$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder.Companion']"
			[global::Android.Runtime.Register ("com/datadog/android/DatadogConfig$Builder$Companion", DoNotGenerateAcw=true)]
			public sealed partial class Companion : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/DatadogConfig$Builder$Companion", typeof (Companion));

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

				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder.Companion']/constructor[@name='DatadogConfig.Builder.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder.WhenMappings']"
			[global::Android.Runtime.Register ("com/datadog/android/DatadogConfig$Builder$WhenMappings", DoNotGenerateAcw=true)]
			public sealed partial class WhenMappings : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/DatadogConfig$Builder$WhenMappings", typeof (WhenMappings));

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

				internal WhenMappings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
				{
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/DatadogConfig$Builder", typeof (Builder));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/constructor[@name='DatadogConfig.Builder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Builder (string clientToken, string envName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_clientToken = JNIEnv.NewString (clientToken);
				IntPtr native_envName = JNIEnv.NewString (envName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_clientToken);
					__args [1] = new JniArgumentValue (native_envName);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientToken);
					JNIEnv.DeleteLocalRef (native_envName);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/constructor[@name='DatadogConfig.Builder' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Builder (string clientToken, string envName, string applicationId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_clientToken = JNIEnv.NewString (clientToken);
				IntPtr native_envName = JNIEnv.NewString (envName);
				IntPtr native_applicationId = JNIEnv.NewString (applicationId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_clientToken);
					__args [1] = new JniArgumentValue (native_envName);
					__args [2] = new JniArgumentValue (native_applicationId);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientToken);
					JNIEnv.DeleteLocalRef (native_envName);
					JNIEnv.DeleteLocalRef (native_applicationId);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/constructor[@name='DatadogConfig.Builder' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.UUID']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/UUID;)V", "")]
			public unsafe Builder (string clientToken, string envName, global::Java.Util.UUID applicationId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/UUID;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_clientToken = JNIEnv.NewString (clientToken);
				IntPtr native_envName = JNIEnv.NewString (envName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_clientToken);
					__args [1] = new JniArgumentValue (native_envName);
					__args [2] = new JniArgumentValue ((applicationId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) applicationId).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_clientToken);
					JNIEnv.DeleteLocalRef (native_envName);
					global::System.GC.KeepAlive (applicationId);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='addPlugin' and count(parameter)=2 and parameter[1][@type='com.datadog.android.plugin.DatadogPlugin'] and parameter[2][@type='com.datadog.android.plugin.Feature']]"
			[Register ("addPlugin", "(Lcom/datadog/android/plugin/DatadogPlugin;Lcom/datadog/android/plugin/Feature;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder AddPlugin (global::Com.Datadog.Android.Plugin.IDatadogPlugin plugin, global::Com.Datadog.Android.Plugin.Feature feature)
			{
				const string __id = "addPlugin.(Lcom/datadog/android/plugin/DatadogPlugin;Lcom/datadog/android/plugin/Feature;)Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((plugin == null) ? IntPtr.Zero : ((global::Java.Lang.Object) plugin).Handle);
					__args [1] = new JniArgumentValue ((feature == null) ? IntPtr.Zero : ((global::Java.Lang.Object) feature).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (plugin);
					global::System.GC.KeepAlive (feature);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/datadog/android/DatadogConfig;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig Build ()
			{
				const string __id = "build.()Lcom/datadog/android/DatadogConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='sampleRumSessions' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("sampleRumSessions", "(F)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder SampleRumSessions (float samplingRate)
			{
				const string __id = "sampleRumSessions.(F)Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (samplingRate);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='setCrashReportsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCrashReportsEnabled", "(Z)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder SetCrashReportsEnabled (bool enabled)
			{
				const string __id = "setCrashReportsEnabled.(Z)Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='setEnvironmentName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Obsolete (@"deprecated")]
			[Register ("setEnvironmentName", "(Ljava/lang/String;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder SetEnvironmentName (string envName)
			{
				const string __id = "setEnvironmentName.(Ljava/lang/String;)Lcom/datadog/android/DatadogConfig$Builder;";
				IntPtr native_envName = JNIEnv.NewString (envName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_envName);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_envName);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='setFirstPartyHosts' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setFirstPartyHosts", "(Ljava/util/List;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder SetFirstPartyHosts (global::System.Collections.Generic.IList<string> hosts)
			{
				const string __id = "setFirstPartyHosts.(Ljava/util/List;)Lcom/datadog/android/DatadogConfig$Builder;";
				IntPtr native_hosts = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (hosts);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_hosts);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_hosts);
					global::System.GC.KeepAlive (hosts);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='setLogsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLogsEnabled", "(Z)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder SetLogsEnabled (bool enabled)
			{
				const string __id = "setLogsEnabled.(Z)Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='setRumActionEventMapper' and count(parameter)=1 and parameter[1][@type='com.datadog.android.event.EventMapper&lt;com.datadog.android.rum.model.ActionEvent&gt;']]"
			[Register ("setRumActionEventMapper", "(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder SetRumActionEventMapper (global::Com.Datadog.Android.Event.IEventMapper eventMapper)
			{
				const string __id = "setRumActionEventMapper.(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((eventMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventMapper).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (eventMapper);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='setRumEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRumEnabled", "(Z)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder SetRumEnabled (bool enabled)
			{
				const string __id = "setRumEnabled.(Z)Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='setRumErrorEventMapper' and count(parameter)=1 and parameter[1][@type='com.datadog.android.event.EventMapper&lt;com.datadog.android.rum.model.ErrorEvent&gt;']]"
			[Register ("setRumErrorEventMapper", "(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder SetRumErrorEventMapper (global::Com.Datadog.Android.Event.IEventMapper eventMapper)
			{
				const string __id = "setRumErrorEventMapper.(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((eventMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventMapper).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (eventMapper);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='setRumResourceEventMapper' and count(parameter)=1 and parameter[1][@type='com.datadog.android.event.EventMapper&lt;com.datadog.android.rum.model.ResourceEvent&gt;']]"
			[Register ("setRumResourceEventMapper", "(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder SetRumResourceEventMapper (global::Com.Datadog.Android.Event.IEventMapper eventMapper)
			{
				const string __id = "setRumResourceEventMapper.(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((eventMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventMapper).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (eventMapper);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='setRumViewEventMapper' and count(parameter)=1 and parameter[1][@type='com.datadog.android.event.EventMapper&lt;com.datadog.android.rum.model.ViewEvent&gt;']]"
			[Register ("setRumViewEventMapper", "(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder SetRumViewEventMapper (global::Com.Datadog.Android.Event.IEventMapper eventMapper)
			{
				const string __id = "setRumViewEventMapper.(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((eventMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventMapper).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (eventMapper);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='setServiceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServiceName", "(Ljava/lang/String;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder SetServiceName (string serviceName)
			{
				const string __id = "setServiceName.(Ljava/lang/String;)Lcom/datadog/android/DatadogConfig$Builder;";
				IntPtr native_serviceName = JNIEnv.NewString (serviceName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_serviceName);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_serviceName);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='setTracesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTracesEnabled", "(Z)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder SetTracesEnabled (bool enabled)
			{
				const string __id = "setTracesEnabled.(Z)Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (enabled);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='trackInteractions' and count(parameter)=0]"
			[Register ("trackInteractions", "()Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder TrackInteractions ()
			{
				const string __id = "trackInteractions.()Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='trackInteractions' and count(parameter)=1 and parameter[1][@type='com.datadog.android.rum.tracking.ViewAttributesProvider[]']]"
			[Register ("trackInteractions", "([Lcom/datadog/android/rum/tracking/ViewAttributesProvider;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder TrackInteractions (global::Com.Datadog.Android.Rum.Tracking.IViewAttributesProvider[] touchTargetExtraAttributesProviders)
			{
				const string __id = "trackInteractions.([Lcom/datadog/android/rum/tracking/ViewAttributesProvider;)Lcom/datadog/android/DatadogConfig$Builder;";
				IntPtr native_touchTargetExtraAttributesProviders = JNIEnv.NewArray (touchTargetExtraAttributesProviders);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_touchTargetExtraAttributesProviders);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (touchTargetExtraAttributesProviders != null) {
						JNIEnv.CopyArray (native_touchTargetExtraAttributesProviders, touchTargetExtraAttributesProviders);
						JNIEnv.DeleteLocalRef (native_touchTargetExtraAttributesProviders);
					}
					global::System.GC.KeepAlive (touchTargetExtraAttributesProviders);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='useCustomCrashReportsEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("useCustomCrashReportsEndpoint", "(Ljava/lang/String;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder UseCustomCrashReportsEndpoint (string endpoint)
			{
				const string __id = "useCustomCrashReportsEndpoint.(Ljava/lang/String;)Lcom/datadog/android/DatadogConfig$Builder;";
				IntPtr native_endpoint = JNIEnv.NewString (endpoint);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_endpoint);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_endpoint);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='useCustomLogsEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("useCustomLogsEndpoint", "(Ljava/lang/String;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder UseCustomLogsEndpoint (string endpoint)
			{
				const string __id = "useCustomLogsEndpoint.(Ljava/lang/String;)Lcom/datadog/android/DatadogConfig$Builder;";
				IntPtr native_endpoint = JNIEnv.NewString (endpoint);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_endpoint);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_endpoint);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='useCustomRumEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("useCustomRumEndpoint", "(Ljava/lang/String;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder UseCustomRumEndpoint (string endpoint)
			{
				const string __id = "useCustomRumEndpoint.(Ljava/lang/String;)Lcom/datadog/android/DatadogConfig$Builder;";
				IntPtr native_endpoint = JNIEnv.NewString (endpoint);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_endpoint);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_endpoint);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='useCustomTracesEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("useCustomTracesEndpoint", "(Ljava/lang/String;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder UseCustomTracesEndpoint (string endpoint)
			{
				const string __id = "useCustomTracesEndpoint.(Ljava/lang/String;)Lcom/datadog/android/DatadogConfig$Builder;";
				IntPtr native_endpoint = JNIEnv.NewString (endpoint);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_endpoint);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_endpoint);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='useEUEndpoints' and count(parameter)=0]"
			[Register ("useEUEndpoints", "()Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder UseEUEndpoints ()
			{
				const string __id = "useEUEndpoints.()Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='useGovEndpoints' and count(parameter)=0]"
			[Register ("useGovEndpoints", "()Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder UseGovEndpoints ()
			{
				const string __id = "useGovEndpoints.()Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='useUSEndpoints' and count(parameter)=0]"
			[Register ("useUSEndpoints", "()Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder UseUSEndpoints ()
			{
				const string __id = "useUSEndpoints.()Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig.Builder']/method[@name='useViewTrackingStrategy' and count(parameter)=1 and parameter[1][@type='com.datadog.android.rum.tracking.ViewTrackingStrategy']]"
			[Register ("useViewTrackingStrategy", "(Lcom/datadog/android/rum/tracking/ViewTrackingStrategy;)Lcom/datadog/android/DatadogConfig$Builder;", "")]
			public unsafe global::Com.Datadog.Android.DatadogConfig.Builder UseViewTrackingStrategy (global::Com.Datadog.Android.Rum.Tracking.IViewTrackingStrategy strategy)
			{
				const string __id = "useViewTrackingStrategy.(Lcom/datadog/android/rum/tracking/ViewTrackingStrategy;)Lcom/datadog/android/DatadogConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (strategy);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/DatadogConfig", typeof (DatadogConfig));

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

		internal DatadogConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogConfig']/constructor[@name='DatadogConfig' and count(parameter)=6 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
		public unsafe DatadogConfig (global::Java.Lang.Object logsConfig, global::Java.Lang.Object tracesConfig, global::Java.Lang.Object crashReportConfig, global::Java.Lang.Object rumConfig, global::Java.Lang.Object coreConfig, global::Kotlin.Jvm.Internal.DefaultConstructorMarker _constructor_marker) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;Lkotlin/jvm/internal/DefaultConstructorMarker;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((logsConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logsConfig).Handle);
				__args [1] = new JniArgumentValue ((tracesConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tracesConfig).Handle);
				__args [2] = new JniArgumentValue ((crashReportConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) crashReportConfig).Handle);
				__args [3] = new JniArgumentValue ((rumConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rumConfig).Handle);
				__args [4] = new JniArgumentValue ((coreConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coreConfig).Handle);
				__args [5] = new JniArgumentValue ((_constructor_marker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _constructor_marker).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (logsConfig);
				global::System.GC.KeepAlive (tracesConfig);
				global::System.GC.KeepAlive (crashReportConfig);
				global::System.GC.KeepAlive (rumConfig);
				global::System.GC.KeepAlive (coreConfig);
				global::System.GC.KeepAlive (_constructor_marker);
			}
		}

	}
}
