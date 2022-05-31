using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Datadog.Android.Rum {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']"
	[global::Android.Runtime.Register ("com/datadog/android/rum/RumAttributes", DoNotGenerateAcw=true)]
	public sealed partial class RumAttributes : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ACTION_GESTURE_DIRECTION']"
		[Register ("ACTION_GESTURE_DIRECTION")]
		public const string ActionGestureDirection = (string) "action.gesture.direction";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ACTION_TARGET_CLASS_NAME']"
		[Register ("ACTION_TARGET_CLASS_NAME")]
		public const string ActionTargetClassName = (string) "action.target.classname";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ACTION_TARGET_PARENT_CLASSNAME']"
		[Register ("ACTION_TARGET_PARENT_CLASSNAME")]
		public const string ActionTargetParentClassname = (string) "action.target.parent.classname";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ACTION_TARGET_PARENT_INDEX']"
		[Register ("ACTION_TARGET_PARENT_INDEX")]
		public const string ActionTargetParentIndex = (string) "action.target.parent.index";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ACTION_TARGET_PARENT_RESOURCE_ID']"
		[Register ("ACTION_TARGET_PARENT_RESOURCE_ID")]
		public const string ActionTargetParentResourceId = (string) "action.target.parent.resource_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ACTION_TARGET_RESOURCE_ID']"
		[Register ("ACTION_TARGET_RESOURCE_ID")]
		public const string ActionTargetResourceId = (string) "action.target.resource_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ACTION_TARGET_TITLE']"
		[Register ("ACTION_TARGET_TITLE")]
		public const string ActionTargetTitle = (string) "action.target.title";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='APPLICATION_VERSION']"
		[Register ("APPLICATION_VERSION")]
		public const string ApplicationVersion = (string) "version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ENV']"
		[Register ("ENV")]
		public const string Env = (string) "env";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ERROR_DATABASE_PATH']"
		[Register ("ERROR_DATABASE_PATH")]
		public const string ErrorDatabasePath = (string) "error.database.path";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ERROR_DATABASE_VERSION']"
		[Register ("ERROR_DATABASE_VERSION")]
		public const string ErrorDatabaseVersion = (string) "error.database.version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ERROR_RESOURCE_METHOD']"
		[Register ("ERROR_RESOURCE_METHOD")]
		public const string ErrorResourceMethod = (string) "error.resource.method";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ERROR_RESOURCE_STATUS_CODE']"
		[Register ("ERROR_RESOURCE_STATUS_CODE")]
		public const string ErrorResourceStatusCode = (string) "error.resource.status_code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='ERROR_RESOURCE_URL']"
		[Register ("ERROR_RESOURCE_URL")]
		public const string ErrorResourceUrl = (string) "error.resource.url";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Datadog.Android.Rum.RumAttributes Instance {
			get {
				const string __id = "INSTANCE.Lcom/datadog/android/rum/RumAttributes;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Datadog.Android.Rum.RumAttributes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='INTERNAL_ERROR_TYPE']"
		[Register ("INTERNAL_ERROR_TYPE")]
		public const string InternalErrorType = (string) "_dd.error_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='INTERNAL_TIMESTAMP']"
		[Register ("INTERNAL_TIMESTAMP")]
		public const string InternalTimestamp = (string) "_dd.timestamp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='NETWORK_BYTES_READ']"
		[Register ("NETWORK_BYTES_READ")]
		public const string NetworkBytesRead = (string) "network.bytes_read";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='NETWORK_CARRIER_ID']"
		[Register ("NETWORK_CARRIER_ID")]
		public const string NetworkCarrierId = (string) "network.client.sim_carrier.id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='NETWORK_CARRIER_NAME']"
		[Register ("NETWORK_CARRIER_NAME")]
		public const string NetworkCarrierName = (string) "network.client.sim_carrier.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='NETWORK_CONNECTIVITY']"
		[Register ("NETWORK_CONNECTIVITY")]
		public const string NetworkConnectivity = (string) "network.client.connectivity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='NETWORK_DOWN_KBPS']"
		[Register ("NETWORK_DOWN_KBPS")]
		public const string NetworkDownKbps = (string) "network.client.downlink_kbps";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='NETWORK_SIGNAL_STRENGTH']"
		[Register ("NETWORK_SIGNAL_STRENGTH")]
		public const string NetworkSignalStrength = (string) "network.client.signal_strength";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='NETWORK_UP_KBPS']"
		[Register ("NETWORK_UP_KBPS")]
		public const string NetworkUpKbps = (string) "network.client.uplink_kbps";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "sdk_version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='SERVICE_NAME']"
		[Register ("SERVICE_NAME")]
		public const string ServiceName = (string) "service";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='SOURCE']"
		[Register ("SOURCE")]
		public const string Source = (string) "source";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='SPAN_ID']"
		[Register ("SPAN_ID")]
		public const string SpanId = (string) "_dd.span_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='TRACE_ID']"
		[Register ("TRACE_ID")]
		public const string TraceId = (string) "_dd.trace_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.datadog.android.rum']/class[@name='RumAttributes']/field[@name='VARIANT']"
		[Register ("VARIANT")]
		public const string Variant = (string) "variant";

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/datadog/android/rum/RumAttributes", typeof (RumAttributes));

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

		internal RumAttributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

	}
}
