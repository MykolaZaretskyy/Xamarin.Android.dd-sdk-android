using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Core.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration']"
	[global::Android.Runtime.Register ("com/datadog/android/core/configuration/Configuration", DoNotGenerateAcw=true)]
	public sealed partial class Configuration : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration']/field[@name='DEFAULT_SAMPLING_RATE']"
		[Register ("DEFAULT_SAMPLING_RATE")]
		public const float DefaultSamplingRate = (float) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration']/field[@name='ERROR_MALFORMED_HOST_IP_ADDRESS']"
		[Register ("ERROR_MALFORMED_HOST_IP_ADDRESS")]
		public const string ErrorMalformedHostIpAddress = (string) "The host name or ip address used for first party hosts: %s was malformed. It will be dropped.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration']/field[@name='ERROR_MALFORMED_URL']"
		[Register ("ERROR_MALFORMED_URL")]
		public const string ErrorMalformedUrl = (string) "The url: %s is malformed. It will be dropped";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration']/field[@name='WARNING_USING_URL_FOR_HOST']"
		[Register ("WARNING_USING_URL_FOR_HOST")]
		public const string WarningUsingUrlForHost = (string) "You are using an url: %s for declaring the first party hosts. You should use instead a valid host name: %s.";

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']"
		[global::Android.Runtime.Register ("com/datadog/android/core/configuration/Configuration$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder.WhenMappings']"
			[global::Android.Runtime.Register ("com/datadog/android/core/configuration/Configuration$Builder$WhenMappings", DoNotGenerateAcw=true)]
			public sealed partial class WhenMappings : global::Java.Lang.Object {
				static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/core/configuration/Configuration$Builder$WhenMappings", typeof (WhenMappings));

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

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/core/configuration/Configuration$Builder", typeof (Builder));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/constructor[@name='Configuration.Builder' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
			[Register (".ctor", "(ZZZZ)V", "")]
			public unsafe Builder (bool logsEnabled, bool tracesEnabled, bool crashReportsEnabled, bool rumEnabled) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(ZZZZ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (logsEnabled);
					__args [1] = new JniArgumentValue (tracesEnabled);
					__args [2] = new JniArgumentValue (crashReportsEnabled);
					__args [3] = new JniArgumentValue (rumEnabled);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe bool CrashReportsEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='getCrashReportsEnabled' and count(parameter)=0]"
				[Register ("getCrashReportsEnabled", "()Z", "")]
				get {
					const string __id = "getCrashReportsEnabled.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe bool LogsEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='getLogsEnabled' and count(parameter)=0]"
				[Register ("getLogsEnabled", "()Z", "")]
				get {
					const string __id = "getLogsEnabled.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe bool RumEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='getRumEnabled' and count(parameter)=0]"
				[Register ("getRumEnabled", "()Z", "")]
				get {
					const string __id = "getRumEnabled.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe bool TracesEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='getTracesEnabled' and count(parameter)=0]"
				[Register ("getTracesEnabled", "()Z", "")]
				get {
					const string __id = "getTracesEnabled.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='addPlugin' and count(parameter)=2 and parameter[1][@type='com.datadog.android.plugin.DatadogPlugin'] and parameter[2][@type='com.datadog.android.plugin.Feature']]"
			[Register ("addPlugin", "(Lcom/datadog/android/plugin/DatadogPlugin;Lcom/datadog/android/plugin/Feature;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder AddPlugin (global::Com.Datadog.Android.Plugin.IDatadogPlugin plugin, global::Com.Datadog.Android.Plugin.Feature feature)
			{
				const string __id = "addPlugin.(Lcom/datadog/android/plugin/DatadogPlugin;Lcom/datadog/android/plugin/Feature;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((plugin == null) ? IntPtr.Zero : ((global::Java.Lang.Object) plugin).Handle);
					__args [1] = new JniArgumentValue ((feature == null) ? IntPtr.Zero : ((global::Java.Lang.Object) feature).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (plugin);
					global::System.GC.KeepAlive (feature);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/datadog/android/core/configuration/Configuration;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration Build ()
			{
				const string __id = "build.()Lcom/datadog/android/core/configuration/Configuration;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='sampleRumSessions' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("sampleRumSessions", "(F)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder SampleRumSessions (float samplingRate)
			{
				const string __id = "sampleRumSessions.(F)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (samplingRate);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='setBatchSize' and count(parameter)=1 and parameter[1][@type='com.datadog.android.core.configuration.BatchSize']]"
			[Register ("setBatchSize", "(Lcom/datadog/android/core/configuration/BatchSize;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder SetBatchSize (global::Com.Datadog.Android.Core.Configuration.BatchSize batchSize)
			{
				const string __id = "setBatchSize.(Lcom/datadog/android/core/configuration/BatchSize;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((batchSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) batchSize).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (batchSize);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='setFirstPartyHosts' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setFirstPartyHosts", "(Ljava/util/List;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder SetFirstPartyHosts (global::System.Collections.Generic.IList<string> hosts)
			{
				const string __id = "setFirstPartyHosts.(Ljava/util/List;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				IntPtr native_hosts = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (hosts);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_hosts);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_hosts);
					global::System.GC.KeepAlive (hosts);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='setRumActionEventMapper' and count(parameter)=1 and parameter[1][@type='com.datadog.android.event.EventMapper&lt;com.datadog.android.rum.model.ActionEvent&gt;']]"
			[Register ("setRumActionEventMapper", "(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder SetRumActionEventMapper (global::Com.Datadog.Android.Event.IEventMapper eventMapper)
			{
				const string __id = "setRumActionEventMapper.(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((eventMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventMapper).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (eventMapper);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='setRumErrorEventMapper' and count(parameter)=1 and parameter[1][@type='com.datadog.android.event.EventMapper&lt;com.datadog.android.rum.model.ErrorEvent&gt;']]"
			[Register ("setRumErrorEventMapper", "(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder SetRumErrorEventMapper (global::Com.Datadog.Android.Event.IEventMapper eventMapper)
			{
				const string __id = "setRumErrorEventMapper.(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((eventMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventMapper).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (eventMapper);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='setRumResourceEventMapper' and count(parameter)=1 and parameter[1][@type='com.datadog.android.event.EventMapper&lt;com.datadog.android.rum.model.ResourceEvent&gt;']]"
			[Register ("setRumResourceEventMapper", "(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder SetRumResourceEventMapper (global::Com.Datadog.Android.Event.IEventMapper eventMapper)
			{
				const string __id = "setRumResourceEventMapper.(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((eventMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventMapper).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (eventMapper);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='setRumViewEventMapper' and count(parameter)=1 and parameter[1][@type='com.datadog.android.event.EventMapper&lt;com.datadog.android.rum.model.ViewEvent&gt;']]"
			[Register ("setRumViewEventMapper", "(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder SetRumViewEventMapper (global::Com.Datadog.Android.Event.IEventMapper eventMapper)
			{
				const string __id = "setRumViewEventMapper.(Lcom/datadog/android/event/EventMapper;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((eventMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventMapper).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (eventMapper);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='setUploadFrequency' and count(parameter)=1 and parameter[1][@type='com.datadog.android.core.configuration.UploadFrequency']]"
			[Register ("setUploadFrequency", "(Lcom/datadog/android/core/configuration/UploadFrequency;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder SetUploadFrequency (global::Com.Datadog.Android.Core.Configuration.UploadFrequency uploadFrequency)
			{
				const string __id = "setUploadFrequency.(Lcom/datadog/android/core/configuration/UploadFrequency;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((uploadFrequency == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uploadFrequency).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (uploadFrequency);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='trackInteractions' and count(parameter)=0]"
			[Register ("trackInteractions", "()Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder TrackInteractions ()
			{
				const string __id = "trackInteractions.()Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='trackInteractions' and count(parameter)=1 and parameter[1][@type='com.datadog.android.rum.tracking.ViewAttributesProvider[]']]"
			[Register ("trackInteractions", "([Lcom/datadog/android/rum/tracking/ViewAttributesProvider;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder TrackInteractions (global::Com.Datadog.Android.Rum.Tracking.IViewAttributesProvider[] touchTargetExtraAttributesProviders)
			{
				const string __id = "trackInteractions.([Lcom/datadog/android/rum/tracking/ViewAttributesProvider;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				IntPtr native_touchTargetExtraAttributesProviders = JNIEnv.NewArray (touchTargetExtraAttributesProviders);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_touchTargetExtraAttributesProviders);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (touchTargetExtraAttributesProviders != null) {
						JNIEnv.CopyArray (native_touchTargetExtraAttributesProviders, touchTargetExtraAttributesProviders);
						JNIEnv.DeleteLocalRef (native_touchTargetExtraAttributesProviders);
					}
					global::System.GC.KeepAlive (touchTargetExtraAttributesProviders);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='useCustomCrashReportsEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("useCustomCrashReportsEndpoint", "(Ljava/lang/String;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder UseCustomCrashReportsEndpoint (string endpoint)
			{
				const string __id = "useCustomCrashReportsEndpoint.(Ljava/lang/String;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				IntPtr native_endpoint = JNIEnv.NewString (endpoint);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_endpoint);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_endpoint);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='useCustomLogsEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("useCustomLogsEndpoint", "(Ljava/lang/String;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder UseCustomLogsEndpoint (string endpoint)
			{
				const string __id = "useCustomLogsEndpoint.(Ljava/lang/String;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				IntPtr native_endpoint = JNIEnv.NewString (endpoint);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_endpoint);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_endpoint);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='useCustomRumEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("useCustomRumEndpoint", "(Ljava/lang/String;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder UseCustomRumEndpoint (string endpoint)
			{
				const string __id = "useCustomRumEndpoint.(Ljava/lang/String;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				IntPtr native_endpoint = JNIEnv.NewString (endpoint);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_endpoint);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_endpoint);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='useCustomTracesEndpoint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("useCustomTracesEndpoint", "(Ljava/lang/String;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder UseCustomTracesEndpoint (string endpoint)
			{
				const string __id = "useCustomTracesEndpoint.(Ljava/lang/String;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				IntPtr native_endpoint = JNIEnv.NewString (endpoint);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_endpoint);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_endpoint);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='useEUEndpoints' and count(parameter)=0]"
			[Register ("useEUEndpoints", "()Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder UseEUEndpoints ()
			{
				const string __id = "useEUEndpoints.()Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='useGovEndpoints' and count(parameter)=0]"
			[Register ("useGovEndpoints", "()Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder UseGovEndpoints ()
			{
				const string __id = "useGovEndpoints.()Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='useUSEndpoints' and count(parameter)=0]"
			[Register ("useUSEndpoints", "()Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder UseUSEndpoints ()
			{
				const string __id = "useUSEndpoints.()Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Builder']/method[@name='useViewTrackingStrategy' and count(parameter)=1 and parameter[1][@type='com.datadog.android.rum.tracking.ViewTrackingStrategy']]"
			[Register ("useViewTrackingStrategy", "(Lcom/datadog/android/rum/tracking/ViewTrackingStrategy;)Lcom/datadog/android/core/configuration/Configuration$Builder;", "")]
			public unsafe global::Com.Datadog.Android.Core.Configuration.Configuration.Builder UseViewTrackingStrategy (global::Com.Datadog.Android.Rum.Tracking.IViewTrackingStrategy strategy)
			{
				const string __id = "useViewTrackingStrategy.(Lcom/datadog/android/rum/tracking/ViewTrackingStrategy;)Lcom/datadog/android/core/configuration/Configuration$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((strategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategy).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Core.Configuration.Configuration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (strategy);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Companion']"
		[global::Android.Runtime.Register ("com/datadog/android/core/configuration/Configuration$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/core/configuration/Configuration$Companion", typeof (Companion));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.datadog.android.core.configuration']/class[@name='Configuration.Companion']/constructor[@name='Configuration.Companion' and count(parameter)=1 and parameter[1][@type='kotlin.jvm.internal.DefaultConstructorMarker']]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/core/configuration/Configuration", typeof (Configuration));

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

		internal Configuration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
