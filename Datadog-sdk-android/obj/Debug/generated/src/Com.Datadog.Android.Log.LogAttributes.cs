using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']"
	[global::Android.Runtime.Register ("com/datadog/android/log/LogAttributes", DoNotGenerateAcw=true)]
	public sealed partial class LogAttributes : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='APPLICATION_PACKAGE']"
		[Register ("APPLICATION_PACKAGE")]
		public const string ApplicationPackage = (string) "application.package";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='APPLICATION_VERSION']"
		[Register ("APPLICATION_VERSION")]
		public const string ApplicationVersion = (string) "version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='DATE']"
		[Register ("DATE")]
		public const string Date = (string) "date";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='DB_INSTANCE']"
		[Register ("DB_INSTANCE")]
		public const string DbInstance = (string) "db.instance";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='DB_OPERATION']"
		[Register ("DB_OPERATION")]
		public const string DbOperation = (string) "db.operation";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='DB_STATEMENT']"
		[Register ("DB_STATEMENT")]
		public const string DbStatement = (string) "db.statement";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='DB_USER']"
		[Register ("DB_USER")]
		public const string DbUser = (string) "db.user";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='DD_SPAN_ID']"
		[Register ("DD_SPAN_ID")]
		public const string DdSpanId = (string) "dd.span_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='DD_TRACE_ID']"
		[Register ("DD_TRACE_ID")]
		public const string DdTraceId = (string) "dd.trace_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='DURATION']"
		[Register ("DURATION")]
		public const string Duration = (string) "duration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='ENV']"
		[Register ("ENV")]
		public const string Env = (string) "env";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='ERROR_KIND']"
		[Register ("ERROR_KIND")]
		public const string ErrorKind = (string) "error.kind";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='ERROR_MESSAGE']"
		[Register ("ERROR_MESSAGE")]
		public const string ErrorMessage = (string) "error.message";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='ERROR_STACK']"
		[Register ("ERROR_STACK")]
		public const string ErrorStack = (string) "error.stack";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='HOST']"
		[Register ("HOST")]
		public const string Host = (string) "host";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='HTTP_METHOD']"
		[Register ("HTTP_METHOD")]
		public const string HttpMethod = (string) "http.method";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='HTTP_REFERRER']"
		[Register ("HTTP_REFERRER")]
		public const string HttpReferrer = (string) "http.referrer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='HTTP_REQUEST_ID']"
		[Register ("HTTP_REQUEST_ID")]
		public const string HttpRequestId = (string) "http.request_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='HTTP_STATUS_CODE']"
		[Register ("HTTP_STATUS_CODE")]
		public const string HttpStatusCode = (string) "http.status_code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='HTTP_URL']"
		[Register ("HTTP_URL")]
		public const string HttpUrl = (string) "http.url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='HTTP_USERAGENT']"
		[Register ("HTTP_USERAGENT")]
		public const string HttpUseragent = (string) "http.useragent";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='HTTP_VERSION']"
		[Register ("HTTP_VERSION")]
		public const string HttpVersion = (string) "http.version";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Datadog.Android.Log.LogAttributes Instance {
			get {
				const string __id = "INSTANCE.Lcom/datadog/android/log/LogAttributes;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Log.LogAttributes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='LOGGER_METHOD_NAME']"
		[Register ("LOGGER_METHOD_NAME")]
		public const string LoggerMethodName = (string) "logger.method_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='LOGGER_NAME']"
		[Register ("LOGGER_NAME")]
		public const string LoggerName = (string) "logger.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='LOGGER_THREAD_NAME']"
		[Register ("LOGGER_THREAD_NAME")]
		public const string LoggerThreadName = (string) "logger.thread_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='LOGGER_VERSION']"
		[Register ("LOGGER_VERSION")]
		public const string LoggerVersion = (string) "logger.version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='MESSAGE']"
		[Register ("MESSAGE")]
		public const string Message = (string) "message";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='NETWORK_CARRIER_ID']"
		[Register ("NETWORK_CARRIER_ID")]
		public const string NetworkCarrierId = (string) "network.client.sim_carrier.id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='NETWORK_CARRIER_NAME']"
		[Register ("NETWORK_CARRIER_NAME")]
		public const string NetworkCarrierName = (string) "network.client.sim_carrier.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='NETWORK_CLIENT_IP']"
		[Register ("NETWORK_CLIENT_IP")]
		public const string NetworkClientIp = (string) "network.client.ip";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='NETWORK_CLIENT_PORT']"
		[Register ("NETWORK_CLIENT_PORT")]
		public const string NetworkClientPort = (string) "network.client.port";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='NETWORK_CONNECTIVITY']"
		[Register ("NETWORK_CONNECTIVITY")]
		public const string NetworkConnectivity = (string) "network.client.connectivity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='NETWORK_DOWN_KBPS']"
		[Register ("NETWORK_DOWN_KBPS")]
		public const string NetworkDownKbps = (string) "network.client.downlink_kbps";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='NETWORK_SIGNAL_STRENGTH']"
		[Register ("NETWORK_SIGNAL_STRENGTH")]
		public const string NetworkSignalStrength = (string) "network.client.signal_strength";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='NETWORK_UP_KBPS']"
		[Register ("NETWORK_UP_KBPS")]
		public const string NetworkUpKbps = (string) "network.client.uplink_kbps";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='RUM_APPLICATION_ID']"
		[Register ("RUM_APPLICATION_ID")]
		public const string RumApplicationId = (string) "application_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='RUM_SESSION_ID']"
		[Register ("RUM_SESSION_ID")]
		public const string RumSessionId = (string) "session_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='RUM_VIEW_ID']"
		[Register ("RUM_VIEW_ID")]
		public const string RumViewId = (string) "view.id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='SERVICE_NAME']"
		[Register ("SERVICE_NAME")]
		public const string ServiceName = (string) "service";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='SOURCE']"
		[Register ("SOURCE")]
		public const string Source = (string) "source";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='STATUS']"
		[Register ("STATUS")]
		public const string Status = (string) "status";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='USR_ATTRIBUTES_GROUP']"
		[Register ("USR_ATTRIBUTES_GROUP")]
		public const string UsrAttributesGroup = (string) "usr";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='USR_EMAIL']"
		[Register ("USR_EMAIL")]
		public const string UsrEmail = (string) "usr.email";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='USR_ID']"
		[Register ("USR_ID")]
		public const string UsrId = (string) "usr.id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.log']/class[@name='LogAttributes']/field[@name='USR_NAME']"
		[Register ("USR_NAME")]
		public const string UsrName = (string) "usr.name";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/log/LogAttributes", typeof (LogAttributes));

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

		internal LogAttributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
