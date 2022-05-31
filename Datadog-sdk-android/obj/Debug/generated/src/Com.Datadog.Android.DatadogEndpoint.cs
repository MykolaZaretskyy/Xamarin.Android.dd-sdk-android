using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']"
	[global::Android.Runtime.Register ("com/datadog/android/DatadogEndpoint", DoNotGenerateAcw=true)]
	public sealed partial class DatadogEndpoint : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Datadog.Android.DatadogEndpoint Instance {
			get {
				const string __id = "INSTANCE.Lcom/datadog/android/DatadogEndpoint;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.DatadogEndpoint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='LOGS_EU']"
		[Register ("LOGS_EU")]
		public const string LogsEu = (string) "https://mobile-http-intake.logs.datadoghq.eu";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='LOGS_GOV']"
		[Register ("LOGS_GOV")]
		public const string LogsGov = (string) "https://mobile-http-intake.logs.ddog-gov.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='LOGS_US']"
		[Register ("LOGS_US")]
		public const string LogsUs = (string) "https://mobile-http-intake.logs.datadoghq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='NTP_0']"
		[Register ("NTP_0")]
		public const string Ntp0 = (string) "0.datadog.pool.ntp.org";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='NTP_1']"
		[Register ("NTP_1")]
		public const string Ntp1 = (string) "1.datadog.pool.ntp.org";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='NTP_2']"
		[Register ("NTP_2")]
		public const string Ntp2 = (string) "2.datadog.pool.ntp.org";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='NTP_3']"
		[Register ("NTP_3")]
		public const string Ntp3 = (string) "3.datadog.pool.ntp.org";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='RUM_EU']"
		[Register ("RUM_EU")]
		public const string RumEu = (string) "https://rum-http-intake.logs.datadoghq.eu";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='RUM_GOV']"
		[Register ("RUM_GOV")]
		public const string RumGov = (string) "https://rum-http-intake.logs.ddog-gov.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='RUM_US']"
		[Register ("RUM_US")]
		public const string RumUs = (string) "https://rum-http-intake.logs.datadoghq.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='TRACES_EU']"
		[Register ("TRACES_EU")]
		public const string TracesEu = (string) "https://public-trace-http-intake.logs.datadoghq.eu";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='TRACES_GOV']"
		[Register ("TRACES_GOV")]
		public const string TracesGov = (string) "https://public-trace-http-intake.logs.ddog-gov.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android']/class[@name='DatadogEndpoint']/field[@name='TRACES_US']"
		[Register ("TRACES_US")]
		public const string TracesUs = (string) "https://public-trace-http-intake.logs.datadoghq.com";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/DatadogEndpoint", typeof (DatadogEndpoint));

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

		internal DatadogEndpoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
