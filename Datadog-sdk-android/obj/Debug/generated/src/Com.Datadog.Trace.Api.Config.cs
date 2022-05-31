using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Trace.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']"
	[global::Android.Runtime.Register ("com/datadog/trace/api/Config", DoNotGenerateAcw=true)]
	public partial class Config : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='AGENT_PORT_LEGACY']"
		[Register ("AGENT_PORT_LEGACY")]
		public const string AgentPortLegacy = (string) "agent.port";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='API_KEY']"
		[Register ("API_KEY")]
		public const string ApiKey = (string) "api-key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='API_KEY_FILE']"
		[Register ("API_KEY_FILE")]
		public const string ApiKeyFile = (string) "api-key-file";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='CONFIGURATION_FILE']"
		[Register ("CONFIGURATION_FILE")]
		public const string ConfigurationFile = (string) "trace.config";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DB_CLIENT_HOST_SPLIT_BY_INSTANCE']"
		[Register ("DB_CLIENT_HOST_SPLIT_BY_INSTANCE")]
		public const string DbClientHostSplitByInstance = (string) "trace.db.client.split-by-instance";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DD_AGENT_WRITER_TYPE']"
		[Register ("DD_AGENT_WRITER_TYPE")]
		public const string DdAgentWriterType = (string) "DDAgentWriter";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_AGENT_HOST']"
		[Register ("DEFAULT_AGENT_HOST")]
		public const string DefaultAgentHost = (string) "localhost";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_AGENT_UNIX_DOMAIN_SOCKET']"
		[Register ("DEFAULT_AGENT_UNIX_DOMAIN_SOCKET")]
		public static string DefaultAgentUnixDomainSocket {
			get {
				const string __id = "DEFAULT_AGENT_UNIX_DOMAIN_SOCKET.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_ANALYTICS_SAMPLE_RATE']"
		[Register ("DEFAULT_ANALYTICS_SAMPLE_RATE")]
		public const float DefaultAnalyticsSampleRate = (float) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_INTEGRATIONS_ENABLED']"
		[Register ("DEFAULT_INTEGRATIONS_ENABLED")]
		public const bool DefaultIntegrationsEnabled = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_JMX_FETCH_STATSD_PORT']"
		[Register ("DEFAULT_JMX_FETCH_STATSD_PORT")]
		public const int DefaultJmxFetchStatsdPort = (int) 8125;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_LOGS_INJECTION_ENABLED']"
		[Register ("DEFAULT_LOGS_INJECTION_ENABLED")]
		public const bool DefaultLogsInjectionEnabled = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_METRICS_ENABLED']"
		[Register ("DEFAULT_METRICS_ENABLED")]
		public const bool DefaultMetricsEnabled = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_PROFILING_ENABLED']"
		[Register ("DEFAULT_PROFILING_ENABLED")]
		public const bool DefaultProfilingEnabled = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_PROFILING_EXCEPTION_HISTOGRAM_MAX_COLLECTION_SIZE']"
		[Register ("DEFAULT_PROFILING_EXCEPTION_HISTOGRAM_MAX_COLLECTION_SIZE")]
		public const int DefaultProfilingExceptionHistogramMaxCollectionSize = (int) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_PROFILING_EXCEPTION_HISTOGRAM_TOP_ITEMS']"
		[Register ("DEFAULT_PROFILING_EXCEPTION_HISTOGRAM_TOP_ITEMS")]
		public const int DefaultProfilingExceptionHistogramTopItems = (int) 50;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_PROFILING_EXCEPTION_SAMPLE_LIMIT']"
		[Register ("DEFAULT_PROFILING_EXCEPTION_SAMPLE_LIMIT")]
		public const int DefaultProfilingExceptionSampleLimit = (int) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_PROFILING_PROXY_PORT']"
		[Register ("DEFAULT_PROFILING_PROXY_PORT")]
		public const int DefaultProfilingProxyPort = (int) 8080;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_PROFILING_START_DELAY']"
		[Register ("DEFAULT_PROFILING_START_DELAY")]
		public const int DefaultProfilingStartDelay = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_PROFILING_START_FORCE_FIRST']"
		[Register ("DEFAULT_PROFILING_START_FORCE_FIRST")]
		public const bool DefaultProfilingStartForceFirst = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_PROFILING_UPLOAD_COMPRESSION']"
		[Register ("DEFAULT_PROFILING_UPLOAD_COMPRESSION")]
		public const string DefaultProfilingUploadCompression = (string) "on";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_PROFILING_UPLOAD_PERIOD']"
		[Register ("DEFAULT_PROFILING_UPLOAD_PERIOD")]
		public const int DefaultProfilingUploadPeriod = (int) 60;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_PROFILING_UPLOAD_TIMEOUT']"
		[Register ("DEFAULT_PROFILING_UPLOAD_TIMEOUT")]
		public const int DefaultProfilingUploadTimeout = (int) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_SERVICE_NAME']"
		[Register ("DEFAULT_SERVICE_NAME")]
		public const string DefaultServiceName = (string) "unnamed-java-app";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_SITE']"
		[Register ("DEFAULT_SITE")]
		public const string DefaultSite = (string) "datadoghq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_TRACE_AGENT_PORT']"
		[Register ("DEFAULT_TRACE_AGENT_PORT")]
		public const int DefaultTraceAgentPort = (int) 8126;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_TRACE_ANALYTICS_ENABLED']"
		[Register ("DEFAULT_TRACE_ANALYTICS_ENABLED")]
		public const bool DefaultTraceAnalyticsEnabled = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='DEFAULT_TRACE_RATE_LIMIT']"
		[Register ("DEFAULT_TRACE_RATE_LIMIT")]
		public const double DefaultTraceRateLimit = (double) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='GLOBAL_TAGS']"
		[Register ("GLOBAL_TAGS")]
		[Obsolete ("deprecated")]
		public const string GlobalTags = (string) "trace.global.tags";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='HEALTH_METRICS_ENABLED']"
		[Register ("HEALTH_METRICS_ENABLED")]
		public const string HealthMetricsEnabled = (string) "trace.health.metrics.enabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='HOST_TAG']"
		[Register ("HOST_TAG")]
		public const string HostTag = (string) "host";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='HTTP_CLIENT_HOST_SPLIT_BY_DOMAIN']"
		[Register ("HTTP_CLIENT_HOST_SPLIT_BY_DOMAIN")]
		public const string HttpClientHostSplitByDomain = (string) "trace.http.client.split-by-domain";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='HTTP_CLIENT_TAG_QUERY_STRING']"
		[Register ("HTTP_CLIENT_TAG_QUERY_STRING")]
		public const string HttpClientTagQueryString = (string) "http.client.tag.query-string";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='HTTP_SERVER_TAG_QUERY_STRING']"
		[Register ("HTTP_SERVER_TAG_QUERY_STRING")]
		public const string HttpServerTagQueryString = (string) "http.server.tag.query-string";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='INTEGRATIONS_ENABLED']"
		[Register ("INTEGRATIONS_ENABLED")]
		public const string IntegrationsEnabled = (string) "integrations.enabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='JMX_FETCH_CONFIG']"
		[Register ("JMX_FETCH_CONFIG")]
		public const string JmxFetchConfig = (string) "jmxfetch.config";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='JMX_FETCH_ENABLED']"
		[Register ("JMX_FETCH_ENABLED")]
		public const string JmxFetchEnabled = (string) "jmxfetch.enabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='JMX_TAGS']"
		[Register ("JMX_TAGS")]
		public const string JmxTags = (string) "trace.jmx.tags";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='LANGUAGE_TAG_KEY']"
		[Register ("LANGUAGE_TAG_KEY")]
		public const string LanguageTagKey = (string) "language";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='LANGUAGE_TAG_VALUE']"
		[Register ("LANGUAGE_TAG_VALUE")]
		public const string LanguageTagValue = (string) "jvm";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='LOGGING_WRITER_TYPE']"
		[Register ("LOGGING_WRITER_TYPE")]
		public const string LoggingWriterType = (string) "LoggingWriter";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='LOGS_INJECTION_ENABLED']"
		[Register ("LOGS_INJECTION_ENABLED")]
		public const string LogsInjectionEnabled = (string) "logs.injection";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='PRIORITY_SAMPLING']"
		[Register ("PRIORITY_SAMPLING")]
		public const string PrioritySampling = (string) "priority.sampling";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='PROFILING_API_KEY_FILE_OLD']"
		[Register ("PROFILING_API_KEY_FILE_OLD")]
		[Obsolete ("deprecated")]
		public const string ProfilingApiKeyFileOld = (string) "profiling.api-key-file";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='PROFILING_API_KEY_FILE_VERY_OLD']"
		[Register ("PROFILING_API_KEY_FILE_VERY_OLD")]
		[Obsolete ("deprecated")]
		public const string ProfilingApiKeyFileVeryOld = (string) "profiling.apikey.file";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='PROFILING_API_KEY_OLD']"
		[Register ("PROFILING_API_KEY_OLD")]
		[Obsolete ("deprecated")]
		public const string ProfilingApiKeyOld = (string) "profiling.api-key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='PROFILING_API_KEY_VERY_OLD']"
		[Register ("PROFILING_API_KEY_VERY_OLD")]
		[Obsolete ("deprecated")]
		public const string ProfilingApiKeyVeryOld = (string) "profiling.apikey";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='PROFILING_ENABLED']"
		[Register ("PROFILING_ENABLED")]
		public const string ProfilingEnabled = (string) "profiling.enabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='PROFILING_START_FORCE_FIRST']"
		[Register ("PROFILING_START_FORCE_FIRST")]
		public const string ProfilingStartForceFirst = (string) "profiling.experimental.start-force-first";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='PROFILING_TAGS']"
		[Register ("PROFILING_TAGS")]
		public const string ProfilingTags = (string) "profiling.tags";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='PROFILING_URL']"
		[Register ("PROFILING_URL")]
		[Obsolete ("deprecated")]
		public const string ProfilingUrl = (string) "profiling.url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='PROFILING_URL_TEMPLATE']"
		[Register ("PROFILING_URL_TEMPLATE")]
		public const string ProfilingUrlTemplate = (string) "https://intake.profile.%s/v1/input";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='PROPAGATION_STYLE_EXTRACT']"
		[Register ("PROPAGATION_STYLE_EXTRACT")]
		public const string PropagationStyleExtract = (string) "propagation.style.extract";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='PROPAGATION_STYLE_INJECT']"
		[Register ("PROPAGATION_STYLE_INJECT")]
		public const string PropagationStyleInject = (string) "propagation.style.inject";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='RUNTIME_CONTEXT_FIELD_INJECTION']"
		[Register ("RUNTIME_CONTEXT_FIELD_INJECTION")]
		public const string RuntimeContextFieldInjection = (string) "trace.runtime.context.field.injection";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='RUNTIME_ID_TAG']"
		[Register ("RUNTIME_ID_TAG")]
		public const string RuntimeIdTag = (string) "runtime-id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='SERVICE']"
		[Register ("SERVICE")]
		public const string Service = (string) "service";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='SERVICE_TAG']"
		[Register ("SERVICE_TAG")]
		public const string ServiceTag = (string) "service";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='SPAN_TAGS']"
		[Register ("SPAN_TAGS")]
		public const string SpanTags = (string) "trace.span.tags";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='TAGS']"
		[Register ("TAGS")]
		public const string Tags = (string) "tags";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='TRACE_AGENT_PORT']"
		[Register ("TRACE_AGENT_PORT")]
		public const string TraceAgentPort = (string) "trace.agent.port";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='TRACE_ANALYTICS_ENABLED']"
		[Register ("TRACE_ANALYTICS_ENABLED")]
		public const string TraceAnalyticsEnabled = (string) "trace.analytics.enabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='TRACE_CLASSES_EXCLUDE']"
		[Register ("TRACE_CLASSES_EXCLUDE")]
		public const string TraceClassesExclude = (string) "trace.classes.exclude";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='TRACE_ENABLED']"
		[Register ("TRACE_ENABLED")]
		public const string TraceEnabled = (string) "trace.enabled";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='TRACE_EXECUTORS_ALL']"
		[Register ("TRACE_EXECUTORS_ALL")]
		public const string TraceExecutorsAll = (string) "trace.executors.all";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='TRACE_REPORT_HOSTNAME']"
		[Register ("TRACE_REPORT_HOSTNAME")]
		public const string TraceReportHostname = (string) "trace.report-hostname";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/field[@name='TRACE_RESOLVER_ENABLED']"
		[Register ("TRACE_RESOLVER_ENABLED")]
		public const string TraceResolverEnabled = (string) "trace.resolver.enabled";

		// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config.PropagationStyle']"
		[global::Android.Runtime.Register ("com/datadog/trace/api/Config$PropagationStyle", DoNotGenerateAcw=true)]
		public sealed partial class PropagationStyle : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config.PropagationStyle']/field[@name='B3']"
			[Register ("B3")]
			public static global::Com.Datadog.Trace.Api.Config.PropagationStyle B3 {
				get {
					const string __id = "B3.Lcom/datadog/trace/api/Config$PropagationStyle;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config.PropagationStyle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config.PropagationStyle']/field[@name='DATADOG']"
			[Register ("DATADOG")]
			public static global::Com.Datadog.Trace.Api.Config.PropagationStyle Datadog {
				get {
					const string __id = "DATADOG.Lcom/datadog/trace/api/Config$PropagationStyle;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config.PropagationStyle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config.PropagationStyle']/field[@name='HAYSTACK']"
			[Register ("HAYSTACK")]
			public static global::Com.Datadog.Trace.Api.Config.PropagationStyle Haystack {
				get {
					const string __id = "HAYSTACK.Lcom/datadog/trace/api/Config$PropagationStyle;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config.PropagationStyle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/api/Config$PropagationStyle", typeof (PropagationStyle));

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

			internal PropagationStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config.PropagationStyle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/datadog/trace/api/Config$PropagationStyle;", "")]
			public static unsafe global::Com.Datadog.Trace.Api.Config.PropagationStyle ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/datadog/trace/api/Config$PropagationStyle;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config.PropagationStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config.PropagationStyle']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/datadog/trace/api/Config$PropagationStyle;", "")]
			public static unsafe global::Com.Datadog.Trace.Api.Config.PropagationStyle[] Values ()
			{
				const string __id = "values.()[Lcom/datadog/trace/api/Config$PropagationStyle;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Datadog.Trace.Api.Config.PropagationStyle[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Datadog.Trace.Api.Config.PropagationStyle));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/trace/api/Config", typeof (Config));

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

		protected Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getAgentHost;
#pragma warning disable 0169
		static Delegate GetGetAgentHostHandler ()
		{
			if (cb_getAgentHost == null)
				cb_getAgentHost = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAgentHost);
			return cb_getAgentHost;
		}

		static IntPtr n_GetAgentHost (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AgentHost);
		}
#pragma warning restore 0169

		public virtual unsafe string AgentHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getAgentHost' and count(parameter)=0]"
			[Register ("getAgentHost", "()Ljava/lang/String;", "GetGetAgentHostHandler")]
			get {
				const string __id = "getAgentHost.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAgentPort;
#pragma warning disable 0169
		static Delegate GetGetAgentPortHandler ()
		{
			if (cb_getAgentPort == null)
				cb_getAgentPort = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAgentPort);
			return cb_getAgentPort;
		}

		static int n_GetAgentPort (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AgentPort;
		}
#pragma warning restore 0169

		public virtual unsafe int AgentPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getAgentPort' and count(parameter)=0]"
			[Register ("getAgentPort", "()I", "GetGetAgentPortHandler")]
			get {
				const string __id = "getAgentPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getAgentUnixDomainSocket;
#pragma warning disable 0169
		static Delegate GetGetAgentUnixDomainSocketHandler ()
		{
			if (cb_getAgentUnixDomainSocket == null)
				cb_getAgentUnixDomainSocket = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAgentUnixDomainSocket);
			return cb_getAgentUnixDomainSocket;
		}

		static IntPtr n_GetAgentUnixDomainSocket (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AgentUnixDomainSocket);
		}
#pragma warning restore 0169

		public virtual unsafe string AgentUnixDomainSocket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getAgentUnixDomainSocket' and count(parameter)=0]"
			[Register ("getAgentUnixDomainSocket", "()Ljava/lang/String;", "GetGetAgentUnixDomainSocketHandler")]
			get {
				const string __id = "getAgentUnixDomainSocket.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExcludedClasses;
#pragma warning disable 0169
		static Delegate GetGetExcludedClassesHandler ()
		{
			if (cb_getExcludedClasses == null)
				cb_getExcludedClasses = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExcludedClasses);
			return cb_getExcludedClasses;
		}

		static IntPtr n_GetExcludedClasses (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ExcludedClasses);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ExcludedClasses {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getExcludedClasses' and count(parameter)=0]"
			[Register ("getExcludedClasses", "()Ljava/util/List;", "GetGetExcludedClassesHandler")]
			get {
				const string __id = "getExcludedClasses.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFinalProfilingUrl;
#pragma warning disable 0169
		static Delegate GetGetFinalProfilingUrlHandler ()
		{
			if (cb_getFinalProfilingUrl == null)
				cb_getFinalProfilingUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFinalProfilingUrl);
			return cb_getFinalProfilingUrl;
		}

		static IntPtr n_GetFinalProfilingUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FinalProfilingUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string FinalProfilingUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getFinalProfilingUrl' and count(parameter)=0]"
			[Register ("getFinalProfilingUrl", "()Ljava/lang/String;", "GetGetFinalProfilingUrlHandler")]
			get {
				const string __id = "getFinalProfilingUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderTags;
#pragma warning disable 0169
		static Delegate GetGetHeaderTagsHandler ()
		{
			if (cb_getHeaderTags == null)
				cb_getHeaderTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHeaderTags);
			return cb_getHeaderTags;
		}

		static IntPtr n_GetHeaderTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.HeaderTags);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> HeaderTags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getHeaderTags' and count(parameter)=0]"
			[Register ("getHeaderTags", "()Ljava/util/Map;", "GetGetHeaderTagsHandler")]
			get {
				const string __id = "getHeaderTags.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHealthMetricsStatsdHost;
#pragma warning disable 0169
		static Delegate GetGetHealthMetricsStatsdHostHandler ()
		{
			if (cb_getHealthMetricsStatsdHost == null)
				cb_getHealthMetricsStatsdHost = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHealthMetricsStatsdHost);
			return cb_getHealthMetricsStatsdHost;
		}

		static IntPtr n_GetHealthMetricsStatsdHost (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HealthMetricsStatsdHost);
		}
#pragma warning restore 0169

		public virtual unsafe string HealthMetricsStatsdHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getHealthMetricsStatsdHost' and count(parameter)=0]"
			[Register ("getHealthMetricsStatsdHost", "()Ljava/lang/String;", "GetGetHealthMetricsStatsdHostHandler")]
			get {
				const string __id = "getHealthMetricsStatsdHost.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHealthMetricsStatsdPort;
#pragma warning disable 0169
		static Delegate GetGetHealthMetricsStatsdPortHandler ()
		{
			if (cb_getHealthMetricsStatsdPort == null)
				cb_getHealthMetricsStatsdPort = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHealthMetricsStatsdPort);
			return cb_getHealthMetricsStatsdPort;
		}

		static IntPtr n_GetHealthMetricsStatsdPort (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HealthMetricsStatsdPort);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer HealthMetricsStatsdPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getHealthMetricsStatsdPort' and count(parameter)=0]"
			[Register ("getHealthMetricsStatsdPort", "()Ljava/lang/Integer;", "GetGetHealthMetricsStatsdPortHandler")]
			get {
				const string __id = "getHealthMetricsStatsdPort.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHttpClientErrorStatuses;
#pragma warning disable 0169
		static Delegate GetGetHttpClientErrorStatusesHandler ()
		{
			if (cb_getHttpClientErrorStatuses == null)
				cb_getHttpClientErrorStatuses = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHttpClientErrorStatuses);
			return cb_getHttpClientErrorStatuses;
		}

		static IntPtr n_GetHttpClientErrorStatuses (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.HttpClientErrorStatuses);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> HttpClientErrorStatuses {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getHttpClientErrorStatuses' and count(parameter)=0]"
			[Register ("getHttpClientErrorStatuses", "()Ljava/util/Set;", "GetGetHttpClientErrorStatusesHandler")]
			get {
				const string __id = "getHttpClientErrorStatuses.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHttpServerErrorStatuses;
#pragma warning disable 0169
		static Delegate GetGetHttpServerErrorStatusesHandler ()
		{
			if (cb_getHttpServerErrorStatuses == null)
				cb_getHttpServerErrorStatuses = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHttpServerErrorStatuses);
			return cb_getHttpServerErrorStatuses;
		}

		static IntPtr n_GetHttpServerErrorStatuses (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.HttpServerErrorStatuses);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> HttpServerErrorStatuses {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getHttpServerErrorStatuses' and count(parameter)=0]"
			[Register ("getHttpServerErrorStatuses", "()Ljava/util/Set;", "GetGetHttpServerErrorStatusesHandler")]
			get {
				const string __id = "getHttpServerErrorStatuses.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDbClientSplitByInstance;
#pragma warning disable 0169
		static Delegate GetIsDbClientSplitByInstanceHandler ()
		{
			if (cb_isDbClientSplitByInstance == null)
				cb_isDbClientSplitByInstance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDbClientSplitByInstance);
			return cb_isDbClientSplitByInstance;
		}

		static bool n_IsDbClientSplitByInstance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDbClientSplitByInstance;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDbClientSplitByInstance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isDbClientSplitByInstance' and count(parameter)=0]"
			[Register ("isDbClientSplitByInstance", "()Z", "GetIsDbClientSplitByInstanceHandler")]
			get {
				const string __id = "isDbClientSplitByInstance.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isHealthMetricsEnabled;
#pragma warning disable 0169
		static Delegate GetIsHealthMetricsEnabledHandler ()
		{
			if (cb_isHealthMetricsEnabled == null)
				cb_isHealthMetricsEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHealthMetricsEnabled);
			return cb_isHealthMetricsEnabled;
		}

		static bool n_IsHealthMetricsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHealthMetricsEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsHealthMetricsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isHealthMetricsEnabled' and count(parameter)=0]"
			[Register ("isHealthMetricsEnabled", "()Z", "GetIsHealthMetricsEnabledHandler")]
			get {
				const string __id = "isHealthMetricsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isHttpClientSplitByDomain;
#pragma warning disable 0169
		static Delegate GetIsHttpClientSplitByDomainHandler ()
		{
			if (cb_isHttpClientSplitByDomain == null)
				cb_isHttpClientSplitByDomain = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHttpClientSplitByDomain);
			return cb_isHttpClientSplitByDomain;
		}

		static bool n_IsHttpClientSplitByDomain (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHttpClientSplitByDomain;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsHttpClientSplitByDomain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isHttpClientSplitByDomain' and count(parameter)=0]"
			[Register ("isHttpClientSplitByDomain", "()Z", "GetIsHttpClientSplitByDomainHandler")]
			get {
				const string __id = "isHttpClientSplitByDomain.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isHttpClientTagQueryString;
#pragma warning disable 0169
		static Delegate GetIsHttpClientTagQueryStringHandler ()
		{
			if (cb_isHttpClientTagQueryString == null)
				cb_isHttpClientTagQueryString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHttpClientTagQueryString);
			return cb_isHttpClientTagQueryString;
		}

		static bool n_IsHttpClientTagQueryString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHttpClientTagQueryString;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsHttpClientTagQueryString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isHttpClientTagQueryString' and count(parameter)=0]"
			[Register ("isHttpClientTagQueryString", "()Z", "GetIsHttpClientTagQueryStringHandler")]
			get {
				const string __id = "isHttpClientTagQueryString.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isHttpServerTagQueryString;
#pragma warning disable 0169
		static Delegate GetIsHttpServerTagQueryStringHandler ()
		{
			if (cb_isHttpServerTagQueryString == null)
				cb_isHttpServerTagQueryString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHttpServerTagQueryString);
			return cb_isHttpServerTagQueryString;
		}

		static bool n_IsHttpServerTagQueryString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHttpServerTagQueryString;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsHttpServerTagQueryString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isHttpServerTagQueryString' and count(parameter)=0]"
			[Register ("isHttpServerTagQueryString", "()Z", "GetIsHttpServerTagQueryStringHandler")]
			get {
				const string __id = "isHttpServerTagQueryString.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isIntegrationsEnabled;
#pragma warning disable 0169
		static Delegate GetIsIntegrationsEnabledHandler ()
		{
			if (cb_isIntegrationsEnabled == null)
				cb_isIntegrationsEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsIntegrationsEnabled);
			return cb_isIntegrationsEnabled;
		}

		static bool n_IsIntegrationsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIntegrationsEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsIntegrationsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isIntegrationsEnabled' and count(parameter)=0]"
			[Register ("isIntegrationsEnabled", "()Z", "GetIsIntegrationsEnabledHandler")]
			get {
				const string __id = "isIntegrationsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isJmxFetchEnabled;
#pragma warning disable 0169
		static Delegate GetIsJmxFetchEnabledHandler ()
		{
			if (cb_isJmxFetchEnabled == null)
				cb_isJmxFetchEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsJmxFetchEnabled);
			return cb_isJmxFetchEnabled;
		}

		static bool n_IsJmxFetchEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsJmxFetchEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsJmxFetchEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isJmxFetchEnabled' and count(parameter)=0]"
			[Register ("isJmxFetchEnabled", "()Z", "GetIsJmxFetchEnabledHandler")]
			get {
				const string __id = "isJmxFetchEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isLogsInjectionEnabled;
#pragma warning disable 0169
		static Delegate GetIsLogsInjectionEnabledHandler ()
		{
			if (cb_isLogsInjectionEnabled == null)
				cb_isLogsInjectionEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLogsInjectionEnabled);
			return cb_isLogsInjectionEnabled;
		}

		static bool n_IsLogsInjectionEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLogsInjectionEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLogsInjectionEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isLogsInjectionEnabled' and count(parameter)=0]"
			[Register ("isLogsInjectionEnabled", "()Z", "GetIsLogsInjectionEnabledHandler")]
			get {
				const string __id = "isLogsInjectionEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPrioritySamplingEnabled;
#pragma warning disable 0169
		static Delegate GetIsPrioritySamplingEnabledHandler ()
		{
			if (cb_isPrioritySamplingEnabled == null)
				cb_isPrioritySamplingEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPrioritySamplingEnabled);
			return cb_isPrioritySamplingEnabled;
		}

		static bool n_IsPrioritySamplingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrioritySamplingEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPrioritySamplingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isPrioritySamplingEnabled' and count(parameter)=0]"
			[Register ("isPrioritySamplingEnabled", "()Z", "GetIsPrioritySamplingEnabledHandler")]
			get {
				const string __id = "isPrioritySamplingEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isProfilingEnabled;
#pragma warning disable 0169
		static Delegate GetIsProfilingEnabledHandler ()
		{
			if (cb_isProfilingEnabled == null)
				cb_isProfilingEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsProfilingEnabled);
			return cb_isProfilingEnabled;
		}

		static bool n_IsProfilingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsProfilingEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsProfilingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isProfilingEnabled' and count(parameter)=0]"
			[Register ("isProfilingEnabled", "()Z", "GetIsProfilingEnabledHandler")]
			get {
				const string __id = "isProfilingEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isProfilingStartForceFirst;
#pragma warning disable 0169
		static Delegate GetIsProfilingStartForceFirstHandler ()
		{
			if (cb_isProfilingStartForceFirst == null)
				cb_isProfilingStartForceFirst = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsProfilingStartForceFirst);
			return cb_isProfilingStartForceFirst;
		}

		static bool n_IsProfilingStartForceFirst (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsProfilingStartForceFirst;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsProfilingStartForceFirst {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isProfilingStartForceFirst' and count(parameter)=0]"
			[Register ("isProfilingStartForceFirst", "()Z", "GetIsProfilingStartForceFirstHandler")]
			get {
				const string __id = "isProfilingStartForceFirst.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isReportHostName;
#pragma warning disable 0169
		static Delegate GetIsReportHostNameHandler ()
		{
			if (cb_isReportHostName == null)
				cb_isReportHostName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsReportHostName);
			return cb_isReportHostName;
		}

		static bool n_IsReportHostName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReportHostName;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsReportHostName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isReportHostName' and count(parameter)=0]"
			[Register ("isReportHostName", "()Z", "GetIsReportHostNameHandler")]
			get {
				const string __id = "isReportHostName.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRuntimeContextFieldInjection;
#pragma warning disable 0169
		static Delegate GetIsRuntimeContextFieldInjectionHandler ()
		{
			if (cb_isRuntimeContextFieldInjection == null)
				cb_isRuntimeContextFieldInjection = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRuntimeContextFieldInjection);
			return cb_isRuntimeContextFieldInjection;
		}

		static bool n_IsRuntimeContextFieldInjection (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRuntimeContextFieldInjection;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRuntimeContextFieldInjection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isRuntimeContextFieldInjection' and count(parameter)=0]"
			[Register ("isRuntimeContextFieldInjection", "()Z", "GetIsRuntimeContextFieldInjectionHandler")]
			get {
				const string __id = "isRuntimeContextFieldInjection.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isTraceAnalyticsEnabled;
#pragma warning disable 0169
		static Delegate GetIsTraceAnalyticsEnabledHandler ()
		{
			if (cb_isTraceAnalyticsEnabled == null)
				cb_isTraceAnalyticsEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTraceAnalyticsEnabled);
			return cb_isTraceAnalyticsEnabled;
		}

		static bool n_IsTraceAnalyticsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTraceAnalyticsEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsTraceAnalyticsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isTraceAnalyticsEnabled' and count(parameter)=0]"
			[Register ("isTraceAnalyticsEnabled", "()Z", "GetIsTraceAnalyticsEnabledHandler")]
			get {
				const string __id = "isTraceAnalyticsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isTraceEnabled;
#pragma warning disable 0169
		static Delegate GetIsTraceEnabledHandler ()
		{
			if (cb_isTraceEnabled == null)
				cb_isTraceEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTraceEnabled);
			return cb_isTraceEnabled;
		}

		static bool n_IsTraceEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTraceEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsTraceEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isTraceEnabled' and count(parameter)=0]"
			[Register ("isTraceEnabled", "()Z", "GetIsTraceEnabledHandler")]
			get {
				const string __id = "isTraceEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isTraceExecutorsAll;
#pragma warning disable 0169
		static Delegate GetIsTraceExecutorsAllHandler ()
		{
			if (cb_isTraceExecutorsAll == null)
				cb_isTraceExecutorsAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTraceExecutorsAll);
			return cb_isTraceExecutorsAll;
		}

		static bool n_IsTraceExecutorsAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTraceExecutorsAll;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsTraceExecutorsAll {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isTraceExecutorsAll' and count(parameter)=0]"
			[Register ("isTraceExecutorsAll", "()Z", "GetIsTraceExecutorsAllHandler")]
			get {
				const string __id = "isTraceExecutorsAll.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isTraceResolverEnabled;
#pragma warning disable 0169
		static Delegate GetIsTraceResolverEnabledHandler ()
		{
			if (cb_isTraceResolverEnabled == null)
				cb_isTraceResolverEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTraceResolverEnabled);
			return cb_isTraceResolverEnabled;
		}

		static bool n_IsTraceResolverEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTraceResolverEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsTraceResolverEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isTraceResolverEnabled' and count(parameter)=0]"
			[Register ("isTraceResolverEnabled", "()Z", "GetIsTraceResolverEnabledHandler")]
			get {
				const string __id = "isTraceResolverEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getJmxFetchCheckPeriod;
#pragma warning disable 0169
		static Delegate GetGetJmxFetchCheckPeriodHandler ()
		{
			if (cb_getJmxFetchCheckPeriod == null)
				cb_getJmxFetchCheckPeriod = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJmxFetchCheckPeriod);
			return cb_getJmxFetchCheckPeriod;
		}

		static IntPtr n_GetJmxFetchCheckPeriod (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JmxFetchCheckPeriod);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer JmxFetchCheckPeriod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getJmxFetchCheckPeriod' and count(parameter)=0]"
			[Register ("getJmxFetchCheckPeriod", "()Ljava/lang/Integer;", "GetGetJmxFetchCheckPeriodHandler")]
			get {
				const string __id = "getJmxFetchCheckPeriod.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getJmxFetchConfigDir;
#pragma warning disable 0169
		static Delegate GetGetJmxFetchConfigDirHandler ()
		{
			if (cb_getJmxFetchConfigDir == null)
				cb_getJmxFetchConfigDir = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJmxFetchConfigDir);
			return cb_getJmxFetchConfigDir;
		}

		static IntPtr n_GetJmxFetchConfigDir (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.JmxFetchConfigDir);
		}
#pragma warning restore 0169

		public virtual unsafe string JmxFetchConfigDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getJmxFetchConfigDir' and count(parameter)=0]"
			[Register ("getJmxFetchConfigDir", "()Ljava/lang/String;", "GetGetJmxFetchConfigDirHandler")]
			get {
				const string __id = "getJmxFetchConfigDir.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getJmxFetchConfigs;
#pragma warning disable 0169
		static Delegate GetGetJmxFetchConfigsHandler ()
		{
			if (cb_getJmxFetchConfigs == null)
				cb_getJmxFetchConfigs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJmxFetchConfigs);
			return cb_getJmxFetchConfigs;
		}

		static IntPtr n_GetJmxFetchConfigs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.JmxFetchConfigs);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> JmxFetchConfigs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getJmxFetchConfigs' and count(parameter)=0]"
			[Register ("getJmxFetchConfigs", "()Ljava/util/List;", "GetGetJmxFetchConfigsHandler")]
			get {
				const string __id = "getJmxFetchConfigs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getJmxFetchMetricsConfigs;
#pragma warning disable 0169
		static Delegate GetGetJmxFetchMetricsConfigsHandler ()
		{
			if (cb_getJmxFetchMetricsConfigs == null)
				cb_getJmxFetchMetricsConfigs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJmxFetchMetricsConfigs);
			return cb_getJmxFetchMetricsConfigs;
		}

		static IntPtr n_GetJmxFetchMetricsConfigs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.JmxFetchMetricsConfigs);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> JmxFetchMetricsConfigs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getJmxFetchMetricsConfigs' and count(parameter)=0]"
			[Register ("getJmxFetchMetricsConfigs", "()Ljava/util/List;", "GetGetJmxFetchMetricsConfigsHandler")]
			get {
				const string __id = "getJmxFetchMetricsConfigs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getJmxFetchRefreshBeansPeriod;
#pragma warning disable 0169
		static Delegate GetGetJmxFetchRefreshBeansPeriodHandler ()
		{
			if (cb_getJmxFetchRefreshBeansPeriod == null)
				cb_getJmxFetchRefreshBeansPeriod = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJmxFetchRefreshBeansPeriod);
			return cb_getJmxFetchRefreshBeansPeriod;
		}

		static IntPtr n_GetJmxFetchRefreshBeansPeriod (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JmxFetchRefreshBeansPeriod);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer JmxFetchRefreshBeansPeriod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getJmxFetchRefreshBeansPeriod' and count(parameter)=0]"
			[Register ("getJmxFetchRefreshBeansPeriod", "()Ljava/lang/Integer;", "GetGetJmxFetchRefreshBeansPeriodHandler")]
			get {
				const string __id = "getJmxFetchRefreshBeansPeriod.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getJmxFetchStatsdHost;
#pragma warning disable 0169
		static Delegate GetGetJmxFetchStatsdHostHandler ()
		{
			if (cb_getJmxFetchStatsdHost == null)
				cb_getJmxFetchStatsdHost = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJmxFetchStatsdHost);
			return cb_getJmxFetchStatsdHost;
		}

		static IntPtr n_GetJmxFetchStatsdHost (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.JmxFetchStatsdHost);
		}
#pragma warning restore 0169

		public virtual unsafe string JmxFetchStatsdHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getJmxFetchStatsdHost' and count(parameter)=0]"
			[Register ("getJmxFetchStatsdHost", "()Ljava/lang/String;", "GetGetJmxFetchStatsdHostHandler")]
			get {
				const string __id = "getJmxFetchStatsdHost.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getJmxFetchStatsdPort;
#pragma warning disable 0169
		static Delegate GetGetJmxFetchStatsdPortHandler ()
		{
			if (cb_getJmxFetchStatsdPort == null)
				cb_getJmxFetchStatsdPort = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJmxFetchStatsdPort);
			return cb_getJmxFetchStatsdPort;
		}

		static IntPtr n_GetJmxFetchStatsdPort (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JmxFetchStatsdPort);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer JmxFetchStatsdPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getJmxFetchStatsdPort' and count(parameter)=0]"
			[Register ("getJmxFetchStatsdPort", "()Ljava/lang/Integer;", "GetGetJmxFetchStatsdPortHandler")]
			get {
				const string __id = "getJmxFetchStatsdPort.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocalRootSpanTags;
#pragma warning disable 0169
		static Delegate GetGetLocalRootSpanTagsHandler ()
		{
			if (cb_getLocalRootSpanTags == null)
				cb_getLocalRootSpanTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalRootSpanTags);
			return cb_getLocalRootSpanTags;
		}

		static IntPtr n_GetLocalRootSpanTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.LocalRootSpanTags);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> LocalRootSpanTags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getLocalRootSpanTags' and count(parameter)=0]"
			[Register ("getLocalRootSpanTags", "()Ljava/util/Map;", "GetGetLocalRootSpanTagsHandler")]
			get {
				const string __id = "getLocalRootSpanTags.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMergedJmxTags;
#pragma warning disable 0169
		static Delegate GetGetMergedJmxTagsHandler ()
		{
			if (cb_getMergedJmxTags == null)
				cb_getMergedJmxTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMergedJmxTags);
			return cb_getMergedJmxTags;
		}

		static IntPtr n_GetMergedJmxTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.MergedJmxTags);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> MergedJmxTags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getMergedJmxTags' and count(parameter)=0]"
			[Register ("getMergedJmxTags", "()Ljava/util/Map;", "GetGetMergedJmxTagsHandler")]
			get {
				const string __id = "getMergedJmxTags.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMergedProfilingTags;
#pragma warning disable 0169
		static Delegate GetGetMergedProfilingTagsHandler ()
		{
			if (cb_getMergedProfilingTags == null)
				cb_getMergedProfilingTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMergedProfilingTags);
			return cb_getMergedProfilingTags;
		}

		static IntPtr n_GetMergedProfilingTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.MergedProfilingTags);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> MergedProfilingTags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getMergedProfilingTags' and count(parameter)=0]"
			[Register ("getMergedProfilingTags", "()Ljava/util/Map;", "GetGetMergedProfilingTagsHandler")]
			get {
				const string __id = "getMergedProfilingTags.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMergedSpanTags;
#pragma warning disable 0169
		static Delegate GetGetMergedSpanTagsHandler ()
		{
			if (cb_getMergedSpanTags == null)
				cb_getMergedSpanTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMergedSpanTags);
			return cb_getMergedSpanTags;
		}

		static IntPtr n_GetMergedSpanTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.MergedSpanTags);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> MergedSpanTags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getMergedSpanTags' and count(parameter)=0]"
			[Register ("getMergedSpanTags", "()Ljava/util/Map;", "GetGetMergedSpanTagsHandler")]
			get {
				const string __id = "getMergedSpanTags.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPartialFlushMinSpans;
#pragma warning disable 0169
		static Delegate GetGetPartialFlushMinSpansHandler ()
		{
			if (cb_getPartialFlushMinSpans == null)
				cb_getPartialFlushMinSpans = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPartialFlushMinSpans);
			return cb_getPartialFlushMinSpans;
		}

		static IntPtr n_GetPartialFlushMinSpans (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PartialFlushMinSpans);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer PartialFlushMinSpans {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getPartialFlushMinSpans' and count(parameter)=0]"
			[Register ("getPartialFlushMinSpans", "()Ljava/lang/Integer;", "GetGetPartialFlushMinSpansHandler")]
			get {
				const string __id = "getPartialFlushMinSpans.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProfilingExceptionHistogramMaxCollectionSize;
#pragma warning disable 0169
		static Delegate GetGetProfilingExceptionHistogramMaxCollectionSizeHandler ()
		{
			if (cb_getProfilingExceptionHistogramMaxCollectionSize == null)
				cb_getProfilingExceptionHistogramMaxCollectionSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetProfilingExceptionHistogramMaxCollectionSize);
			return cb_getProfilingExceptionHistogramMaxCollectionSize;
		}

		static int n_GetProfilingExceptionHistogramMaxCollectionSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProfilingExceptionHistogramMaxCollectionSize;
		}
#pragma warning restore 0169

		public virtual unsafe int ProfilingExceptionHistogramMaxCollectionSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getProfilingExceptionHistogramMaxCollectionSize' and count(parameter)=0]"
			[Register ("getProfilingExceptionHistogramMaxCollectionSize", "()I", "GetGetProfilingExceptionHistogramMaxCollectionSizeHandler")]
			get {
				const string __id = "getProfilingExceptionHistogramMaxCollectionSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getProfilingExceptionHistogramTopItems;
#pragma warning disable 0169
		static Delegate GetGetProfilingExceptionHistogramTopItemsHandler ()
		{
			if (cb_getProfilingExceptionHistogramTopItems == null)
				cb_getProfilingExceptionHistogramTopItems = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetProfilingExceptionHistogramTopItems);
			return cb_getProfilingExceptionHistogramTopItems;
		}

		static int n_GetProfilingExceptionHistogramTopItems (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProfilingExceptionHistogramTopItems;
		}
#pragma warning restore 0169

		public virtual unsafe int ProfilingExceptionHistogramTopItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getProfilingExceptionHistogramTopItems' and count(parameter)=0]"
			[Register ("getProfilingExceptionHistogramTopItems", "()I", "GetGetProfilingExceptionHistogramTopItemsHandler")]
			get {
				const string __id = "getProfilingExceptionHistogramTopItems.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getProfilingExceptionSampleLimit;
#pragma warning disable 0169
		static Delegate GetGetProfilingExceptionSampleLimitHandler ()
		{
			if (cb_getProfilingExceptionSampleLimit == null)
				cb_getProfilingExceptionSampleLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetProfilingExceptionSampleLimit);
			return cb_getProfilingExceptionSampleLimit;
		}

		static int n_GetProfilingExceptionSampleLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProfilingExceptionSampleLimit;
		}
#pragma warning restore 0169

		public virtual unsafe int ProfilingExceptionSampleLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getProfilingExceptionSampleLimit' and count(parameter)=0]"
			[Register ("getProfilingExceptionSampleLimit", "()I", "GetGetProfilingExceptionSampleLimitHandler")]
			get {
				const string __id = "getProfilingExceptionSampleLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getProfilingProxyHost;
#pragma warning disable 0169
		static Delegate GetGetProfilingProxyHostHandler ()
		{
			if (cb_getProfilingProxyHost == null)
				cb_getProfilingProxyHost = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProfilingProxyHost);
			return cb_getProfilingProxyHost;
		}

		static IntPtr n_GetProfilingProxyHost (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProfilingProxyHost);
		}
#pragma warning restore 0169

		public virtual unsafe string ProfilingProxyHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getProfilingProxyHost' and count(parameter)=0]"
			[Register ("getProfilingProxyHost", "()Ljava/lang/String;", "GetGetProfilingProxyHostHandler")]
			get {
				const string __id = "getProfilingProxyHost.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProfilingProxyPassword;
#pragma warning disable 0169
		static Delegate GetGetProfilingProxyPasswordHandler ()
		{
			if (cb_getProfilingProxyPassword == null)
				cb_getProfilingProxyPassword = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProfilingProxyPassword);
			return cb_getProfilingProxyPassword;
		}

		static IntPtr n_GetProfilingProxyPassword (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProfilingProxyPassword);
		}
#pragma warning restore 0169

		public virtual unsafe string ProfilingProxyPassword {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getProfilingProxyPassword' and count(parameter)=0]"
			[Register ("getProfilingProxyPassword", "()Ljava/lang/String;", "GetGetProfilingProxyPasswordHandler")]
			get {
				const string __id = "getProfilingProxyPassword.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProfilingProxyPort;
#pragma warning disable 0169
		static Delegate GetGetProfilingProxyPortHandler ()
		{
			if (cb_getProfilingProxyPort == null)
				cb_getProfilingProxyPort = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetProfilingProxyPort);
			return cb_getProfilingProxyPort;
		}

		static int n_GetProfilingProxyPort (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProfilingProxyPort;
		}
#pragma warning restore 0169

		public virtual unsafe int ProfilingProxyPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getProfilingProxyPort' and count(parameter)=0]"
			[Register ("getProfilingProxyPort", "()I", "GetGetProfilingProxyPortHandler")]
			get {
				const string __id = "getProfilingProxyPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getProfilingProxyUsername;
#pragma warning disable 0169
		static Delegate GetGetProfilingProxyUsernameHandler ()
		{
			if (cb_getProfilingProxyUsername == null)
				cb_getProfilingProxyUsername = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProfilingProxyUsername);
			return cb_getProfilingProxyUsername;
		}

		static IntPtr n_GetProfilingProxyUsername (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProfilingProxyUsername);
		}
#pragma warning restore 0169

		public virtual unsafe string ProfilingProxyUsername {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getProfilingProxyUsername' and count(parameter)=0]"
			[Register ("getProfilingProxyUsername", "()Ljava/lang/String;", "GetGetProfilingProxyUsernameHandler")]
			get {
				const string __id = "getProfilingProxyUsername.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProfilingStartDelay;
#pragma warning disable 0169
		static Delegate GetGetProfilingStartDelayHandler ()
		{
			if (cb_getProfilingStartDelay == null)
				cb_getProfilingStartDelay = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetProfilingStartDelay);
			return cb_getProfilingStartDelay;
		}

		static int n_GetProfilingStartDelay (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProfilingStartDelay;
		}
#pragma warning restore 0169

		public virtual unsafe int ProfilingStartDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getProfilingStartDelay' and count(parameter)=0]"
			[Register ("getProfilingStartDelay", "()I", "GetGetProfilingStartDelayHandler")]
			get {
				const string __id = "getProfilingStartDelay.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getProfilingTemplateOverrideFile;
#pragma warning disable 0169
		static Delegate GetGetProfilingTemplateOverrideFileHandler ()
		{
			if (cb_getProfilingTemplateOverrideFile == null)
				cb_getProfilingTemplateOverrideFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProfilingTemplateOverrideFile);
			return cb_getProfilingTemplateOverrideFile;
		}

		static IntPtr n_GetProfilingTemplateOverrideFile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProfilingTemplateOverrideFile);
		}
#pragma warning restore 0169

		public virtual unsafe string ProfilingTemplateOverrideFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getProfilingTemplateOverrideFile' and count(parameter)=0]"
			[Register ("getProfilingTemplateOverrideFile", "()Ljava/lang/String;", "GetGetProfilingTemplateOverrideFileHandler")]
			get {
				const string __id = "getProfilingTemplateOverrideFile.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProfilingUploadCompression;
#pragma warning disable 0169
		static Delegate GetGetProfilingUploadCompressionHandler ()
		{
			if (cb_getProfilingUploadCompression == null)
				cb_getProfilingUploadCompression = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProfilingUploadCompression);
			return cb_getProfilingUploadCompression;
		}

		static IntPtr n_GetProfilingUploadCompression (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProfilingUploadCompression);
		}
#pragma warning restore 0169

		public virtual unsafe string ProfilingUploadCompression {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getProfilingUploadCompression' and count(parameter)=0]"
			[Register ("getProfilingUploadCompression", "()Ljava/lang/String;", "GetGetProfilingUploadCompressionHandler")]
			get {
				const string __id = "getProfilingUploadCompression.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProfilingUploadPeriod;
#pragma warning disable 0169
		static Delegate GetGetProfilingUploadPeriodHandler ()
		{
			if (cb_getProfilingUploadPeriod == null)
				cb_getProfilingUploadPeriod = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetProfilingUploadPeriod);
			return cb_getProfilingUploadPeriod;
		}

		static int n_GetProfilingUploadPeriod (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProfilingUploadPeriod;
		}
#pragma warning restore 0169

		public virtual unsafe int ProfilingUploadPeriod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getProfilingUploadPeriod' and count(parameter)=0]"
			[Register ("getProfilingUploadPeriod", "()I", "GetGetProfilingUploadPeriodHandler")]
			get {
				const string __id = "getProfilingUploadPeriod.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getProfilingUploadTimeout;
#pragma warning disable 0169
		static Delegate GetGetProfilingUploadTimeoutHandler ()
		{
			if (cb_getProfilingUploadTimeout == null)
				cb_getProfilingUploadTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetProfilingUploadTimeout);
			return cb_getProfilingUploadTimeout;
		}

		static int n_GetProfilingUploadTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProfilingUploadTimeout;
		}
#pragma warning restore 0169

		public virtual unsafe int ProfilingUploadTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getProfilingUploadTimeout' and count(parameter)=0]"
			[Register ("getProfilingUploadTimeout", "()I", "GetGetProfilingUploadTimeoutHandler")]
			get {
				const string __id = "getProfilingUploadTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPropagationStylesToExtract;
#pragma warning disable 0169
		static Delegate GetGetPropagationStylesToExtractHandler ()
		{
			if (cb_getPropagationStylesToExtract == null)
				cb_getPropagationStylesToExtract = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPropagationStylesToExtract);
			return cb_getPropagationStylesToExtract;
		}

		static IntPtr n_GetPropagationStylesToExtract (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Datadog.Trace.Api.Config.PropagationStyle>.ToLocalJniHandle (__this.PropagationStylesToExtract);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Datadog.Trace.Api.Config.PropagationStyle> PropagationStylesToExtract {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getPropagationStylesToExtract' and count(parameter)=0]"
			[Register ("getPropagationStylesToExtract", "()Ljava/util/Set;", "GetGetPropagationStylesToExtractHandler")]
			get {
				const string __id = "getPropagationStylesToExtract.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Com.Datadog.Trace.Api.Config.PropagationStyle>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPropagationStylesToInject;
#pragma warning disable 0169
		static Delegate GetGetPropagationStylesToInjectHandler ()
		{
			if (cb_getPropagationStylesToInject == null)
				cb_getPropagationStylesToInject = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPropagationStylesToInject);
			return cb_getPropagationStylesToInject;
		}

		static IntPtr n_GetPropagationStylesToInject (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Datadog.Trace.Api.Config.PropagationStyle>.ToLocalJniHandle (__this.PropagationStylesToInject);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Datadog.Trace.Api.Config.PropagationStyle> PropagationStylesToInject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getPropagationStylesToInject' and count(parameter)=0]"
			[Register ("getPropagationStylesToInject", "()Ljava/util/Set;", "GetGetPropagationStylesToInjectHandler")]
			get {
				const string __id = "getPropagationStylesToInject.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<global::Com.Datadog.Trace.Api.Config.PropagationStyle>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRuntimeId;
#pragma warning disable 0169
		static Delegate GetGetRuntimeIdHandler ()
		{
			if (cb_getRuntimeId == null)
				cb_getRuntimeId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRuntimeId);
			return cb_getRuntimeId;
		}

		static IntPtr n_GetRuntimeId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RuntimeId);
		}
#pragma warning restore 0169

		public virtual unsafe string RuntimeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getRuntimeId' and count(parameter)=0]"
			[Register ("getRuntimeId", "()Ljava/lang/String;", "GetGetRuntimeIdHandler")]
			get {
				const string __id = "getRuntimeId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScopeDepthLimit;
#pragma warning disable 0169
		static Delegate GetGetScopeDepthLimitHandler ()
		{
			if (cb_getScopeDepthLimit == null)
				cb_getScopeDepthLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScopeDepthLimit);
			return cb_getScopeDepthLimit;
		}

		static IntPtr n_GetScopeDepthLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScopeDepthLimit);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer ScopeDepthLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getScopeDepthLimit' and count(parameter)=0]"
			[Register ("getScopeDepthLimit", "()Ljava/lang/Integer;", "GetGetScopeDepthLimitHandler")]
			get {
				const string __id = "getScopeDepthLimit.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServiceMapping;
#pragma warning disable 0169
		static Delegate GetGetServiceMappingHandler ()
		{
			if (cb_getServiceMapping == null)
				cb_getServiceMapping = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceMapping);
			return cb_getServiceMapping;
		}

		static IntPtr n_GetServiceMapping (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ServiceMapping);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ServiceMapping {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getServiceMapping' and count(parameter)=0]"
			[Register ("getServiceMapping", "()Ljava/util/Map;", "GetGetServiceMappingHandler")]
			get {
				const string __id = "getServiceMapping.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServiceName;
#pragma warning disable 0169
		static Delegate GetGetServiceNameHandler ()
		{
			if (cb_getServiceName == null)
				cb_getServiceName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceName);
			return cb_getServiceName;
		}

		static IntPtr n_GetServiceName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceName);
		}
#pragma warning restore 0169

		public virtual unsafe string ServiceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getServiceName' and count(parameter)=0]"
			[Register ("getServiceName", "()Ljava/lang/String;", "GetGetServiceNameHandler")]
			get {
				const string __id = "getServiceName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSite;
#pragma warning disable 0169
		static Delegate GetGetSiteHandler ()
		{
			if (cb_getSite == null)
				cb_getSite = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSite);
			return cb_getSite;
		}

		static IntPtr n_GetSite (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Site);
		}
#pragma warning restore 0169

		public virtual unsafe string Site {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getSite' and count(parameter)=0]"
			[Register ("getSite", "()Ljava/lang/String;", "GetGetSiteHandler")]
			get {
				const string __id = "getSite.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSplitByTags;
#pragma warning disable 0169
		static Delegate GetGetSplitByTagsHandler ()
		{
			if (cb_getSplitByTags == null)
				cb_getSplitByTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSplitByTags);
			return cb_getSplitByTags;
		}

		static IntPtr n_GetSplitByTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.SplitByTags);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.ICollection<string> SplitByTags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getSplitByTags' and count(parameter)=0]"
			[Register ("getSplitByTags", "()Ljava/util/Set;", "GetGetSplitByTagsHandler")]
			get {
				const string __id = "getSplitByTags.()Ljava/util/Set;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTraceAnnotations;
#pragma warning disable 0169
		static Delegate GetGetTraceAnnotationsHandler ()
		{
			if (cb_getTraceAnnotations == null)
				cb_getTraceAnnotations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTraceAnnotations);
			return cb_getTraceAnnotations;
		}

		static IntPtr n_GetTraceAnnotations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TraceAnnotations);
		}
#pragma warning restore 0169

		public virtual unsafe string TraceAnnotations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getTraceAnnotations' and count(parameter)=0]"
			[Register ("getTraceAnnotations", "()Ljava/lang/String;", "GetGetTraceAnnotationsHandler")]
			get {
				const string __id = "getTraceAnnotations.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTraceExecutors;
#pragma warning disable 0169
		static Delegate GetGetTraceExecutorsHandler ()
		{
			if (cb_getTraceExecutors == null)
				cb_getTraceExecutors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTraceExecutors);
			return cb_getTraceExecutors;
		}

		static IntPtr n_GetTraceExecutors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.TraceExecutors);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> TraceExecutors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getTraceExecutors' and count(parameter)=0]"
			[Register ("getTraceExecutors", "()Ljava/util/List;", "GetGetTraceExecutorsHandler")]
			get {
				const string __id = "getTraceExecutors.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTraceMethods;
#pragma warning disable 0169
		static Delegate GetGetTraceMethodsHandler ()
		{
			if (cb_getTraceMethods == null)
				cb_getTraceMethods = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTraceMethods);
			return cb_getTraceMethods;
		}

		static IntPtr n_GetTraceMethods (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TraceMethods);
		}
#pragma warning restore 0169

		public virtual unsafe string TraceMethods {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getTraceMethods' and count(parameter)=0]"
			[Register ("getTraceMethods", "()Ljava/lang/String;", "GetGetTraceMethodsHandler")]
			get {
				const string __id = "getTraceMethods.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTraceRateLimit;
#pragma warning disable 0169
		static Delegate GetGetTraceRateLimitHandler ()
		{
			if (cb_getTraceRateLimit == null)
				cb_getTraceRateLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTraceRateLimit);
			return cb_getTraceRateLimit;
		}

		static IntPtr n_GetTraceRateLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TraceRateLimit);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Double TraceRateLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getTraceRateLimit' and count(parameter)=0]"
			[Register ("getTraceRateLimit", "()Ljava/lang/Double;", "GetGetTraceRateLimitHandler")]
			get {
				const string __id = "getTraceRateLimit.()Ljava/lang/Double;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTraceSampleRate;
#pragma warning disable 0169
		static Delegate GetGetTraceSampleRateHandler ()
		{
			if (cb_getTraceSampleRate == null)
				cb_getTraceSampleRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTraceSampleRate);
			return cb_getTraceSampleRate;
		}

		static IntPtr n_GetTraceSampleRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TraceSampleRate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Double TraceSampleRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getTraceSampleRate' and count(parameter)=0]"
			[Register ("getTraceSampleRate", "()Ljava/lang/Double;", "GetGetTraceSampleRateHandler")]
			get {
				const string __id = "getTraceSampleRate.()Ljava/lang/Double;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTraceSamplingOperationRules;
#pragma warning disable 0169
		static Delegate GetGetTraceSamplingOperationRulesHandler ()
		{
			if (cb_getTraceSamplingOperationRules == null)
				cb_getTraceSamplingOperationRules = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTraceSamplingOperationRules);
			return cb_getTraceSamplingOperationRules;
		}

		static IntPtr n_GetTraceSamplingOperationRules (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.TraceSamplingOperationRules);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> TraceSamplingOperationRules {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getTraceSamplingOperationRules' and count(parameter)=0]"
			[Register ("getTraceSamplingOperationRules", "()Ljava/util/Map;", "GetGetTraceSamplingOperationRulesHandler")]
			get {
				const string __id = "getTraceSamplingOperationRules.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTraceSamplingServiceRules;
#pragma warning disable 0169
		static Delegate GetGetTraceSamplingServiceRulesHandler ()
		{
			if (cb_getTraceSamplingServiceRules == null)
				cb_getTraceSamplingServiceRules = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTraceSamplingServiceRules);
			return cb_getTraceSamplingServiceRules;
		}

		static IntPtr n_GetTraceSamplingServiceRules (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.TraceSamplingServiceRules);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> TraceSamplingServiceRules {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getTraceSamplingServiceRules' and count(parameter)=0]"
			[Register ("getTraceSamplingServiceRules", "()Ljava/util/Map;", "GetGetTraceSamplingServiceRulesHandler")]
			get {
				const string __id = "getTraceSamplingServiceRules.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWriterType;
#pragma warning disable 0169
		static Delegate GetGetWriterTypeHandler ()
		{
			if (cb_getWriterType == null)
				cb_getWriterType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWriterType);
			return cb_getWriterType;
		}

		static IntPtr n_GetWriterType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.WriterType);
		}
#pragma warning restore 0169

		public virtual unsafe string WriterType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getWriterType' and count(parameter)=0]"
			[Register ("getWriterType", "()Ljava/lang/String;", "GetGetWriterTypeHandler")]
			get {
				const string __id = "getWriterType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/datadog/trace/api/Config;", "")]
		public static unsafe global::Com.Datadog.Trace.Api.Config Get ()
		{
			const string __id = "get.()Lcom/datadog/trace/api/Config;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.util.Properties']]"
		[Register ("get", "(Ljava/util/Properties;)Lcom/datadog/trace/api/Config;", "")]
		public static unsafe global::Com.Datadog.Trace.Api.Config Get (global::Java.Util.Properties properties)
		{
			const string __id = "get.(Ljava/util/Properties;)Lcom/datadog/trace/api/Config;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((properties == null) ? IntPtr.Zero : ((global::Java.Lang.Object) properties).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (properties);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getBooleanSettingFromEnvironment' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("getBooleanSettingFromEnvironment", "(Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;", "")]
		public static unsafe global::Java.Lang.Boolean GetBooleanSettingFromEnvironment (string name, global::Java.Lang.Boolean defaultValue)
		{
			const string __id = "getBooleanSettingFromEnvironment.(Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((defaultValue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultValue).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (defaultValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getFloatSettingFromEnvironment' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Float']]"
		[Obsolete (@"deprecated")]
		[Register ("getFloatSettingFromEnvironment", "(Ljava/lang/String;Ljava/lang/Float;)Ljava/lang/Float;", "")]
		public static unsafe global::Java.Lang.Float GetFloatSettingFromEnvironment (string name, global::Java.Lang.Float defaultValue)
		{
			const string __id = "getFloatSettingFromEnvironment.(Ljava/lang/String;Ljava/lang/Float;)Ljava/lang/Float;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((defaultValue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultValue).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (defaultValue);
			}
		}

		static Delegate cb_getInstrumentationAnalyticsSampleRate_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInstrumentationAnalyticsSampleRate_arrayLjava_lang_String_Handler ()
		{
			if (cb_getInstrumentationAnalyticsSampleRate_arrayLjava_lang_String_ == null)
				cb_getInstrumentationAnalyticsSampleRate_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_F) n_GetInstrumentationAnalyticsSampleRate_arrayLjava_lang_String_);
			return cb_getInstrumentationAnalyticsSampleRate_arrayLjava_lang_String_;
		}

		static float n_GetInstrumentationAnalyticsSampleRate_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aliases)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var aliases = (string[]) JNIEnv.GetArray (native_aliases, JniHandleOwnership.DoNotTransfer, typeof (string));
			float __ret = __this.GetInstrumentationAnalyticsSampleRate (aliases);
			if (aliases != null)
				JNIEnv.CopyArray (aliases, native_aliases);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getInstrumentationAnalyticsSampleRate' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("getInstrumentationAnalyticsSampleRate", "([Ljava/lang/String;)F", "GetGetInstrumentationAnalyticsSampleRate_arrayLjava_lang_String_Handler")]
		public virtual unsafe float GetInstrumentationAnalyticsSampleRate (params string[] aliases)
		{
			const string __id = "getInstrumentationAnalyticsSampleRate.([Ljava/lang/String;)F";
			IntPtr native_aliases = JNIEnv.NewArray (aliases);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_aliases);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				if (aliases != null) {
					JNIEnv.CopyArray (native_aliases, aliases);
					JNIEnv.DeleteLocalRef (native_aliases);
				}
				global::System.GC.KeepAlive (aliases);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='getSettingFromEnvironment' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("getSettingFromEnvironment", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetSettingFromEnvironment (string name, string defaultValue)
		{
			const string __id = "getSettingFromEnvironment.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = JNIEnv.NewString (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static Delegate cb_isIntegrationEnabled_Ljava_util_SortedSet_Z;
#pragma warning disable 0169
		static Delegate GetIsIntegrationEnabled_Ljava_util_SortedSet_ZHandler ()
		{
			if (cb_isIntegrationEnabled_Ljava_util_SortedSet_Z == null)
				cb_isIntegrationEnabled_Ljava_util_SortedSet_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_IsIntegrationEnabled_Ljava_util_SortedSet_Z);
			return cb_isIntegrationEnabled_Ljava_util_SortedSet_Z;
		}

		static bool n_IsIntegrationEnabled_Ljava_util_SortedSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_integrationNames, bool defaultEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var integrationNames = (global::Java.Util.ISortedSet)global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (native_integrationNames, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsIntegrationEnabled (integrationNames, defaultEnabled);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isIntegrationEnabled' and count(parameter)=2 and parameter[1][@type='java.util.SortedSet&lt;java.lang.String&gt;'] and parameter[2][@type='boolean']]"
		[Register ("isIntegrationEnabled", "(Ljava/util/SortedSet;Z)Z", "GetIsIntegrationEnabled_Ljava_util_SortedSet_ZHandler")]
		public virtual unsafe bool IsIntegrationEnabled (global::Java.Util.ISortedSet integrationNames, bool defaultEnabled)
		{
			const string __id = "isIntegrationEnabled.(Ljava/util/SortedSet;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((integrationNames == null) ? IntPtr.Zero : ((global::Java.Lang.Object) integrationNames).Handle);
				__args [1] = new JniArgumentValue (defaultEnabled);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (integrationNames);
			}
		}

		static Delegate cb_isJmxFetchIntegrationEnabled_Ljava_util_SortedSet_Z;
#pragma warning disable 0169
		static Delegate GetIsJmxFetchIntegrationEnabled_Ljava_util_SortedSet_ZHandler ()
		{
			if (cb_isJmxFetchIntegrationEnabled_Ljava_util_SortedSet_Z == null)
				cb_isJmxFetchIntegrationEnabled_Ljava_util_SortedSet_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_IsJmxFetchIntegrationEnabled_Ljava_util_SortedSet_Z);
			return cb_isJmxFetchIntegrationEnabled_Ljava_util_SortedSet_Z;
		}

		static bool n_IsJmxFetchIntegrationEnabled_Ljava_util_SortedSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_integrationNames, bool defaultEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var integrationNames = (global::Java.Util.ISortedSet)global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (native_integrationNames, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsJmxFetchIntegrationEnabled (integrationNames, defaultEnabled);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isJmxFetchIntegrationEnabled' and count(parameter)=2 and parameter[1][@type='java.util.SortedSet&lt;java.lang.String&gt;'] and parameter[2][@type='boolean']]"
		[Register ("isJmxFetchIntegrationEnabled", "(Ljava/util/SortedSet;Z)Z", "GetIsJmxFetchIntegrationEnabled_Ljava_util_SortedSet_ZHandler")]
		public virtual unsafe bool IsJmxFetchIntegrationEnabled (global::Java.Util.ISortedSet integrationNames, bool defaultEnabled)
		{
			const string __id = "isJmxFetchIntegrationEnabled.(Ljava/util/SortedSet;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((integrationNames == null) ? IntPtr.Zero : ((global::Java.Lang.Object) integrationNames).Handle);
				__args [1] = new JniArgumentValue (defaultEnabled);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (integrationNames);
			}
		}

		static Delegate cb_isRuleEnabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsRuleEnabled_Ljava_lang_String_Handler ()
		{
			if (cb_isRuleEnabled_Ljava_lang_String_ == null)
				cb_isRuleEnabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsRuleEnabled_Ljava_lang_String_);
			return cb_isRuleEnabled_Ljava_lang_String_;
		}

		static bool n_IsRuleEnabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsRuleEnabled (name);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isRuleEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isRuleEnabled", "(Ljava/lang/String;)Z", "GetIsRuleEnabled_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsRuleEnabled (string name)
		{
			const string __id = "isRuleEnabled.(Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_isTraceAnalyticsIntegrationEnabled_Ljava_util_SortedSet_Z;
#pragma warning disable 0169
		static Delegate GetIsTraceAnalyticsIntegrationEnabled_Ljava_util_SortedSet_ZHandler ()
		{
			if (cb_isTraceAnalyticsIntegrationEnabled_Ljava_util_SortedSet_Z == null)
				cb_isTraceAnalyticsIntegrationEnabled_Ljava_util_SortedSet_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_Z) n_IsTraceAnalyticsIntegrationEnabled_Ljava_util_SortedSet_Z);
			return cb_isTraceAnalyticsIntegrationEnabled_Ljava_util_SortedSet_Z;
		}

		static bool n_IsTraceAnalyticsIntegrationEnabled_Ljava_util_SortedSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_integrationNames, bool defaultEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Datadog.Trace.Api.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var integrationNames = (global::Java.Util.ISortedSet)global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (native_integrationNames, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsTraceAnalyticsIntegrationEnabled (integrationNames, defaultEnabled);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='isTraceAnalyticsIntegrationEnabled' and count(parameter)=2 and parameter[1][@type='java.util.SortedSet&lt;java.lang.String&gt;'] and parameter[2][@type='boolean']]"
		[Register ("isTraceAnalyticsIntegrationEnabled", "(Ljava/util/SortedSet;Z)Z", "GetIsTraceAnalyticsIntegrationEnabled_Ljava_util_SortedSet_ZHandler")]
		public virtual unsafe bool IsTraceAnalyticsIntegrationEnabled (global::Java.Util.ISortedSet integrationNames, bool defaultEnabled)
		{
			const string __id = "isTraceAnalyticsIntegrationEnabled.(Ljava/util/SortedSet;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((integrationNames == null) ? IntPtr.Zero : ((global::Java.Lang.Object) integrationNames).Handle);
				__args [1] = new JniArgumentValue (defaultEnabled);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (integrationNames);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='jmxFetchIntegrationEnabled' and count(parameter)=2 and parameter[1][@type='java.util.SortedSet&lt;java.lang.String&gt;'] and parameter[2][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("jmxFetchIntegrationEnabled", "(Ljava/util/SortedSet;Z)Z", "")]
		public static unsafe bool JmxFetchIntegrationEnabled (global::Java.Util.ISortedSet integrationNames, bool defaultEnabled)
		{
			const string __id = "jmxFetchIntegrationEnabled.(Ljava/util/SortedSet;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((integrationNames == null) ? IntPtr.Zero : ((global::Java.Lang.Object) integrationNames).Handle);
				__args [1] = new JniArgumentValue (defaultEnabled);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (integrationNames);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.datadog.trace.api']/class[@name='Config']/method[@name='traceAnalyticsIntegrationEnabled' and count(parameter)=2 and parameter[1][@type='java.util.SortedSet&lt;java.lang.String&gt;'] and parameter[2][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("traceAnalyticsIntegrationEnabled", "(Ljava/util/SortedSet;Z)Z", "")]
		public static unsafe bool TraceAnalyticsIntegrationEnabled (global::Java.Util.ISortedSet integrationNames, bool defaultEnabled)
		{
			const string __id = "traceAnalyticsIntegrationEnabled.(Ljava/util/SortedSet;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((integrationNames == null) ? IntPtr.Zero : ((global::Java.Lang.Object) integrationNames).Handle);
				__args [1] = new JniArgumentValue (defaultEnabled);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (integrationNames);
			}
		}

	}
}
